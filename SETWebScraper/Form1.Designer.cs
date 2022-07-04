namespace SETWebScraper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.stock_symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.market = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.industry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website = new System.Windows.Forms.DataGridViewLinkColumn();
            this.company_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnScrape = new System.Windows.Forms.Button();
            this.lblPercentDownload = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.sETDataSet = new SETWebScraper.SETDataSet();
            this.stock2022FEB09BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_2022FEB09TableAdapter = new SETWebScraper.SETDataSetTableAdapters.stock_2022FEB09TableAdapter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock2022FEB09BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1167, 714);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.btnClearFilter);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1159, 688);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stock Info.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(366, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyUp);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(233, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyUp);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(510, 68);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(134, 23);
            this.btnClearFilter.TabIndex = 9;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "-",
            "กระดาษและวัสดุการพิมพ์",
            "กองทุนรวมอสังหาริมทรัพย์และกองทรัสต์เพื่อการลงทุนในอสังหาริมทรัพย์",
            "การท่องเที่ยวและสันทนาการ",
            "การแพทย์",
            "ขนส่งและโลจิสติกส์",
            "ของใช้ในครัวเรือนและสำนักงาน",
            "ของใช้ส่วนตัวและเวชภัณฑ์",
            "เงินทุนและหลักทรัพย์",
            "ชิ้นส่วนอิเล็กทรอนิกส์",
            "เทคโนโลยีสารสนเทศและการสื่อสาร",
            "ธนาคาร",
            "ธุรกิจการเกษตร",
            "บรรจุภัณฑ์",
            "บริการเฉพาะกิจ",
            "บริการรับเหมาก่อสร้าง",
            "ประกันภัยและประกันชีวิต",
            "ปิโตรเคมีและเคมีภัณฑ์",
            "พลังงานและสาธารณูปโภค",
            "พัฒนาอสังหาริมทรัพย์",
            "พาณิชย์",
            "แฟชั่น",
            "ยานยนต์",
            "วัสดุก่อสร้าง",
            "วัสดุอุตสาหกรรมและเครื่องจักร",
            "สื่อและสิ่งพิมพ์",
            "หมวดบริษัทจดทะเบียนที่อยู่ระหว่างฟื้นฟูการดำเนินงาน",
            "เหมืองแร่",
            "เหล็ก และ ผลิตภัณฑ์โลหะ",
            "อาหารและเครื่องดื่ม"});
            this.comboBox3.Location = new System.Drawing.Point(741, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(221, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
            this.comboBox3.TextChanged += new System.EventHandler(this.comboBox3_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "-",
            "เกษตรและอุตสาหกรรมอาหาร",
            "ทรัพยากร",
            "เทคโนโลยี",
            "ธุรกิจการเงิน",
            "บริการ",
            "สินค้าอุตสาหกรรม",
            "สินค้าอุปโภคบริโภค",
            "อสังหาริมทรัพย์และก่อสร้าง"});
            this.comboBox2.Location = new System.Drawing.Point(451, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(221, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sector :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SET",
            "mai"});
            this.comboBox1.Location = new System.Drawing.Point(284, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Industry :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Company Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bisiness Details :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Market :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(862, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stock_symbol,
            this.company_name,
            this.business_details,
            this.market,
            this.industry,
            this.sector,
            this.website,
            this.company_address,
            this.zipcode,
            this.tel,
            this.fax});
            this.dataGridView2.Location = new System.Drawing.Point(9, 105);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cordia New", 15F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1144, 575);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView2_RowPostPaint);
            // 
            // stock_symbol
            // 
            this.stock_symbol.DataPropertyName = "stock_symbol";
            this.stock_symbol.Frozen = true;
            this.stock_symbol.HeaderText = "stock_symbol";
            this.stock_symbol.Name = "stock_symbol";
            this.stock_symbol.ReadOnly = true;
            // 
            // company_name
            // 
            this.company_name.DataPropertyName = "company_name";
            this.company_name.Frozen = true;
            this.company_name.HeaderText = "company_name";
            this.company_name.Name = "company_name";
            this.company_name.ReadOnly = true;
            this.company_name.Width = 330;
            // 
            // business_details
            // 
            this.business_details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.business_details.DataPropertyName = "business_details";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("TH SarabunPSK", 16F);
            this.business_details.DefaultCellStyle = dataGridViewCellStyle1;
            this.business_details.FillWeight = 550F;
            this.business_details.HeaderText = "business_details";
            this.business_details.Name = "business_details";
            this.business_details.ReadOnly = true;
            // 
            // market
            // 
            this.market.DataPropertyName = "market";
            this.market.HeaderText = "market";
            this.market.Name = "market";
            this.market.ReadOnly = true;
            // 
            // industry
            // 
            this.industry.DataPropertyName = "industry";
            this.industry.HeaderText = "industry";
            this.industry.Name = "industry";
            this.industry.ReadOnly = true;
            // 
            // sector
            // 
            this.sector.DataPropertyName = "sector";
            this.sector.HeaderText = "sector";
            this.sector.Name = "sector";
            this.sector.ReadOnly = true;
            // 
            // website
            // 
            this.website.DataPropertyName = "website";
            this.website.HeaderText = "website";
            this.website.Name = "website";
            this.website.ReadOnly = true;
            this.website.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.website.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // company_address
            // 
            this.company_address.DataPropertyName = "company_address";
            this.company_address.HeaderText = "company_address";
            this.company_address.Name = "company_address";
            this.company_address.ReadOnly = true;
            // 
            // zipcode
            // 
            this.zipcode.DataPropertyName = "zipcode";
            this.zipcode.HeaderText = "zipcode";
            this.zipcode.Name = "zipcode";
            this.zipcode.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "tel";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            // 
            // fax
            // 
            this.fax.DataPropertyName = "fax";
            this.fax.HeaderText = "fax";
            this.fax.Name = "fax";
            this.fax.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.txtResult);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtUrl);
            this.tabPage2.Controls.Add(this.btnScrape);
            this.tabPage2.Controls.Add(this.lblPercentDownload);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1159, 688);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Stock Info.";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1038, 561);
            this.dataGridView1.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(52, 46);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(1038, 32);
            this.txtResult.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Url :";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(52, 20);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(878, 20);
            this.txtUrl.TabIndex = 8;
            this.txtUrl.Text = "https://www.set.or.th/set/factsheet.do?symbol=byd&ssoPageId=3&language=th&country" +
    "=TH";
            // 
            // btnScrape
            // 
            this.btnScrape.Location = new System.Drawing.Point(936, 19);
            this.btnScrape.Name = "btnScrape";
            this.btnScrape.Size = new System.Drawing.Size(75, 23);
            this.btnScrape.TabIndex = 7;
            this.btnScrape.Text = "Start";
            this.btnScrape.UseVisualStyleBackColor = true;
            this.btnScrape.Click += new System.EventHandler(this.btnScrape_Click);
            // 
            // lblPercentDownload
            // 
            this.lblPercentDownload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPercentDownload.AutoSize = true;
            this.lblPercentDownload.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentDownload.Location = new System.Drawing.Point(537, 652);
            this.lblPercentDownload.Name = "lblPercentDownload";
            this.lblPercentDownload.Size = new System.Drawing.Size(15, 13);
            this.lblPercentDownload.TabIndex = 13;
            this.lblPercentDownload.Text = "%";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(52, 648);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1038, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // sETDataSet
            // 
            this.sETDataSet.DataSetName = "SETDataSet";
            this.sETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stock2022FEB09BindingSource
            // 
            this.stock2022FEB09BindingSource.DataMember = "stock_2022FEB09";
            this.stock2022FEB09BindingSource.DataSource = this.sETDataSet;
            // 
            // stock_2022FEB09TableAdapter
            // 
            this.stock_2022FEB09TableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1015, 19);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 714);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock2022FEB09BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnScrape;
        private System.Windows.Forms.Label lblPercentDownload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private SETDataSet sETDataSet;
        private System.Windows.Forms.BindingSource stock2022FEB09BindingSource;
        private SETDataSetTableAdapters.stock_2022FEB09TableAdapter stock_2022FEB09TableAdapter;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn market;
        private System.Windows.Forms.DataGridViewTextBoxColumn industry;
        private System.Windows.Forms.DataGridViewTextBoxColumn sector;
        private System.Windows.Forms.DataGridViewLinkColumn website;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.Button btnCancel;
    }
}

