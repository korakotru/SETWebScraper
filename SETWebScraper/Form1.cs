using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Text;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETWebScraper
{
    public partial class Form1 : Form
    {
        SETDataSet.stock_2022FEB09DataTable dtStockList = new SETDataSet.stock_2022FEB09DataTable();
        SETDataSetTableAdapters.stock_2022FEB09TableAdapter adapter = new SETDataSetTableAdapters.stock_2022FEB09TableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        //private string Title { get; set; }
        //private string Url { get; set; } 
        //public string[] QueryTerms { get; } = { "Ocean", "Nature", "Pollution" }; 
        //public List<string> StockList = new List<string>();
        private string url = "https://classic.set.or.th/set/factsheet.do?symbol={symbol}&ssoPageId=3&language=th&country=TH"; //"https://www.set.or.th/set/factsheet.do?symbol={symbol}&ssoPageId=3&language=th&country=TH";//"https://www.oceannetworks.ca/news/stories";
        private string stockQuoteUrl = "https://www.set.or.th/th/market/product/stock/quote/{symbol}/price";
        private string tradingViewUrl = "https://th.tradingview.com/chart/ha6EVyUm/?symbol=SET%3A{symbol}";
        static readonly CancellationTokenSource s_cts = new CancellationTokenSource();
        private async Task ScrapeWebsiteAsync()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            decimal toalStock = dtStockList.Rows.Count;
            decimal countUpdated = 0;
            progressBar1.Maximum = (int)toalStock;
            if (dtStockList.Rows.Count > 0)
            {
                foreach (DataRow stock in dtStockList.Rows) //APEX
                {
                    var doc = await Task.Run(() => DownloadWebPage(url.Replace("{symbol}", stock["stock_symbol"].ToString().Replace("&", "%26"))));

                    // Using LINQ to parse HTML table smartly 
                    var HTMLTableTRList = from table in doc.DocumentNode.SelectNodes("//table").Cast<HtmlNode>()
                                          from row in table.SelectNodes("tr").Cast<HtmlNode>()
                                          from cell in row.SelectNodes("th|td").Cast<HtmlNode>()
                                          select new { Cell_Text = cell.InnerText };

                    // now showing output of parsed HTML table 
                    var castHtmlTable = HTMLTableTRList.Select((r, i) => new { Cell_Text = r.Cell_Text, Index = i }).ToArray();

                    for (int i = 0; i < castHtmlTable.Count(); i++)
                    {
                        if (castHtmlTable[i].Cell_Text.Equals("ลักษณะธุรกิจ"))
                        {
                            stock["business_details"] = castHtmlTable[i + 1].Cell_Text;
                            dataGridView1.Refresh();
                            adapter.UpdateBusinessDetails(stock["business_details"].ToString(), stock["stock_symbol"].ToString());
                            break;
                        }
                    }
                    countUpdated++;
                    progressBar1.Value = (int)countUpdated;
                    lblPercentDownload.Text = $"Updated {stock["stock_symbol"].ToString()} - {countUpdated}/{toalStock} ({(countUpdated / (toalStock / 100)).ToString("##0.00") + " %"})";
                    lblPercentDownload.Refresh();
                    await Task.Run(() => System.Threading.Thread.Sleep(1000));
                }
            }

            progressBar1.Value = 0;
        }

        private HtmlAgilityPack.HtmlDocument DownloadWebPage(string url)
        {
            var web = new HtmlWeb();
            return web.Load(url);
        }

        private async void ScrapeWebsite()
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var objSource = new List<ObjSource>();

            //// From File
            //var doc = new HtmlDocument();
            //doc.Load(filePath);

            //// From String
            //var doc = new HtmlDocument();
            //doc.LoadHtml(html);

            //// From Web
            //var url = "http://html-agility-pack.net/";
            //var web = new HtmlWeb();
            //var doc = web.Load(url);



            // From Web
            //var url = txtUrl.Text;
            int toalStock = dtStockList.Rows.Count;
            int countUpdated = 0;
            progressBar1.Maximum = toalStock;
            if (dtStockList.Rows.Count > 0)
            {
                foreach (DataRow stock in dtStockList.Rows) //APEX
                {
                    var web = new HtmlWeb();
                    var doc = web.Load(url.Replace("{symbol}", stock["stock_symbol"].ToString().Replace("&", "%26")));

                    // Using LINQ to parse HTML table smartly 
                    var HTMLTableTRList = from table in doc.DocumentNode.SelectNodes("//table").Cast<HtmlNode>()
                                          from row in table.SelectNodes("tr").Cast<HtmlNode>()
                                          from cell in row.SelectNodes("th|td").Cast<HtmlNode>()
                                          select new { Cell_Text = cell.InnerText };

                    // now showing output of parsed HTML table

                    var castHtmlTable = HTMLTableTRList.Select((r, i) => new { Cell_Text = r.Cell_Text, Index = i }).ToArray();

                    for (int i = 0; i < castHtmlTable.Count(); i++)
                    {
                        if (castHtmlTable[i].Cell_Text.Equals("ลักษณะธุรกิจ"))
                        {
                            //txtResult.Text = castHtmlTable[i + 1].Cell_Text;
                            //objSource.Add(new ObjSource() { Stock = stock, Cell_Text = castHtmlTable[i + 1].Cell_Text, Index = castHtmlTable[i + 1].Index });
                            stock["business_details"] = castHtmlTable[i + 1].Cell_Text;
                            dataGridView1.Refresh();
                            adapter.UpdateBusinessDetails(stock["business_details"].ToString(), stock["stock_symbol"].ToString());
                            break;
                        }
                    }
                    countUpdated++;
                    progressBar1.Value = countUpdated;
                    System.Threading.Thread.Sleep(1000);
                }
            }

            progressBar1.Value = 0;
            //dataGridView1.DataSource = dtStockList;

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await BindDatagridAsync();
        }

        private async Task BindDatagridAsync()
        {
            await Task.Run(() => adapter.Fill(dtStockList));
            //await Task.Run(() => dataGridView1.DataSource = dtStockList);
            //await Task.Run(() => dataGridView2.DataSource = dtStockList); 

            dataGridView1.DataSource = dtStockList;
            dataGridView2.DataSource = dtStockList;
        }


        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            FilterStockAsync();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterStockAsync();
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterStockAsync();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterStockAsync();
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            FilterStockAsync();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            FilterStockAsync();
        }
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            FilterStockAsync();
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            FilterStockAsync();
        }
        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            FilterStockAsync();
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            FilterStockAsync();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            FilterStockAsync();
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            FilterStockAsync();
        }



        private void FilterStockAsync()
        {
            string symbol = textBox1.Text;
            string market = comboBox1.Text;
            string industry = comboBox2.Text;
            string sector = comboBox3.Text;
            string compName = textBox3.Text;
            string businessDetails = textBox2.Text;
            string businessDetails2 = textBox4.Text;
            string businessDetails3 = textBox5.Text;

            StringBuilder filterString = new StringBuilder();
            filterString.Append($"  ( stock_symbol like '%{symbol}%' or {symbol.Equals("")} ) ");
            filterString.Append($"  and ( market like '%{market}%' or  {market.Equals("")} ) ");
            filterString.Append($"  and ( industry like '%{industry}%' or  {industry.Equals("")} ) ");
            filterString.Append($"  and ( sector like '%{sector}%' or  {sector.Equals("")} ) ");
            filterString.Append($"  and ( company_name like '%{compName}%' or  {compName.Equals("")} ) ");
            filterString.Append($"  and ( (business_details like '%{businessDetails}%' or  {businessDetails.Equals("")}) and (business_details like '%{businessDetails2}%' or  {businessDetails2.Equals("")}) and (business_details like '%{businessDetails3}%' or  {businessDetails3.Equals("")}) ) ");

            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = filterString.ToString();
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {

            textBox1.Text =
            comboBox1.Text =
            comboBox2.Text =
            comboBox3.Text =
            textBox3.Text =
            textBox2.Text =
            textBox4.Text =
            textBox5.Text = string.Empty;
            FilterStockAsync();
        }
        private async void btnScrape_Click(object sender, EventArgs e)
        {
            await ScrapeWebsiteAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            s_cts.Cancel();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // here you can have column reference by using e.ColumnIndex
            if (e.ColumnIndex == 9)
            {
                DataGridViewLinkCell cell = (DataGridViewLinkCell)  dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
                try
                { 
                    Process.Start("chrome.exe", cell.Value + " --incognito");
                    Process.Start("chrome.exe", stockQuoteUrl.Replace("{symbol}", ((DataGridViewTextBoxCell)dataGridView2.Rows[e.RowIndex].Cells["stock_symbol"]).Value.ToString().Replace("&", "%26")) + " --incognito");
                    Process.Start("chrome.exe", tradingViewUrl.Replace("{symbol}", ((DataGridViewTextBoxCell)dataGridView2.Rows[e.RowIndex].Cells["stock_symbol"]).Value.ToString().Replace("&", "%26")) + " --incognito");
                }
                catch (System.ComponentModel.Win32Exception ex)
                {
                    MessageBox.Show("Unable to find Google Chrome...",
                        "chrome.exe not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
            // ... do something ... 
        }
    }
}
