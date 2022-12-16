namespace ExpertTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.axTR1 = new AxITGExpertCtlLib.AxITGExpertCtl();
            this.axTR0 = new AxITGExpertCtlLib.AxITGExpertCtl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQueryAccount = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Market = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Symbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Open = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.High = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Low = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Close = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tickerBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBtn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axTR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTR0)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAccount
            // 
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(85, 12);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(145, 20);
            this.cmbAccount.TabIndex = 0;
            // 
            // axTR1
            // 
            this.axTR1.Enabled = true;
            this.axTR1.Location = new System.Drawing.Point(596, 10);
            this.axTR1.Name = "axTR1";
            this.axTR1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTR1.OcxState")));
            this.axTR1.Size = new System.Drawing.Size(28, 29);
            this.axTR1.TabIndex = 1;
            // 
            // axTR0
            // 
            this.axTR0.Enabled = true;
            this.axTR0.Location = new System.Drawing.Point(630, 10);
            this.axTR0.Name = "axTR0";
            this.axTR0.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTR0.OcxState")));
            this.axTR0.Size = new System.Drawing.Size(28, 29);
            this.axTR0.TabIndex = 31;
            this.axTR0.ReceiveData += new System.EventHandler(this.axTR0_ReceiveData);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "계좌번호";
            // 
            // btnQueryAccount
            // 
            this.btnQueryAccount.Location = new System.Drawing.Point(387, 10);
            this.btnQueryAccount.Name = "btnQueryAccount";
            this.btnQueryAccount.Size = new System.Drawing.Size(75, 21);
            this.btnQueryAccount.TabIndex = 3;
            this.btnQueryAccount.Text = "계좌조회";
            this.btnQueryAccount.UseVisualStyleBackColor = true;
            this.btnQueryAccount.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(306, 11);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(75, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 352);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.saveFileBtn);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(765, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(591, 5);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(168, 26);
            this.saveFileBtn.TabIndex = 33;
            this.saveFileBtn.Text = "파일로 저장";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 12);
            this.label11.TabIndex = 32;
            this.label11.Text = "label11";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Market,
            this.Symbol,
            this.Date,
            this.Open,
            this.High,
            this.Low,
            this.Close,
            this.Diff,
            this.Volume,
            this.Money});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 283);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // Market
            // 
            this.Market.Text = "Market";
            this.Market.Width = 70;
            // 
            // Symbol
            // 
            this.Symbol.Text = "Symbol";
            this.Symbol.Width = 70;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 70;
            // 
            // Open
            // 
            this.Open.Text = "Open";
            this.Open.Width = 70;
            // 
            // High
            // 
            this.High.Text = "High";
            this.High.Width = 70;
            // 
            // Low
            // 
            this.Low.Text = "Low";
            this.Low.Width = 70;
            // 
            // Close
            // 
            this.Close.Text = "Close";
            this.Close.Width = 70;
            // 
            // Diff
            // 
            this.Diff.Text = "Diff";
            this.Diff.Width = 70;
            // 
            // Volume
            // 
            this.Volume.Text = "Volume";
            this.Volume.Width = 70;
            // 
            // Money
            // 
            this.Money.Text = "Money";
            this.Money.Width = 70;
            // 
            // tickerBtn
            // 
            this.tickerBtn.Location = new System.Drawing.Point(6, 18);
            this.tickerBtn.Name = "tickerBtn";
            this.tickerBtn.Size = new System.Drawing.Size(168, 26);
            this.tickerBtn.TabIndex = 3;
            this.tickerBtn.Text = "전체종목불러오기";
            this.tickerBtn.UseVisualStyleBackColor = true;
            this.tickerBtn.Click += new System.EventHandler(this.tickerBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(657, 18);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(67, 26);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "조회";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(104, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 22);
            this.textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(294, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 57);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. 개별 검색으로 조회";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker2.Location = new System.Drawing.Point(562, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(70, 25);
            this.dateTimePicker2.TabIndex = 42;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(70, 25);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "(3) 날짜";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "(2) 종목코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "(1) 시장코드";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tickerBtn);
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 57);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. 틱커 목록으로 조회";
            // 
            // searchBtn2
            // 
            this.searchBtn2.Location = new System.Drawing.Point(669, 70);
            this.searchBtn2.Name = "searchBtn2";
            this.searchBtn2.Size = new System.Drawing.Size(67, 26);
            this.searchBtn2.TabIndex = 39;
            this.searchBtn2.Text = "조회";
            this.searchBtn2.UseVisualStyleBackColor = true;
            this.searchBtn2.Click += new System.EventHandler(this.searchBtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 540);
            this.Controls.Add(this.searchBtn2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnQueryAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axTR1);
            this.Controls.Add(this.axTR0);
            this.Controls.Add(this.cmbAccount);
            this.Name = "Form1";
            this.Text = "해외주식데이터";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axTR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTR0)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAccount;
        private AxITGExpertCtlLib.AxITGExpertCtl axTR1;
        private AxITGExpertCtlLib.AxITGExpertCtl axTR0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQueryAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Market;
        private System.Windows.Forms.ColumnHeader Symbol;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Open;
        private System.Windows.Forms.ColumnHeader High;
        private System.Windows.Forms.ColumnHeader Low;
        private System.Windows.Forms.ColumnHeader Close;
        private System.Windows.Forms.ColumnHeader Diff;
        private System.Windows.Forms.ColumnHeader Volume;
        private System.Windows.Forms.ColumnHeader Money;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button tickerBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchBtn2;
    }
}

