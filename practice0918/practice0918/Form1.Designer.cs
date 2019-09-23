namespace practice0918
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.createCustomer = new System.Windows.Forms.Button();
            this.cusDetail = new System.Windows.Forms.Panel();
            this.cusIsQualified = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cusFullName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cusDescription = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cusFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cusLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentDay = new System.Windows.Forms.Label();
            this.cusNewPanel = new System.Windows.Forms.Panel();
            this.cusNewDescription = new System.Windows.Forms.TextBox();
            this.cusNewAddress = new System.Windows.Forms.TextBox();
            this.cusNewFirstName = new System.Windows.Forms.TextBox();
            this.cusNewBirth = new System.Windows.Forms.TextBox();
            this.cusNewLastName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.customerList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cusList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusDetail.SuspendLayout();
            this.cusNewPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cusList)).BeginInit();
            this.SuspendLayout();
            // 
            // createCustomer
            // 
            this.createCustomer.Location = new System.Drawing.Point(158, 212);
            this.createCustomer.Name = "createCustomer";
            this.createCustomer.Size = new System.Drawing.Size(75, 23);
            this.createCustomer.TabIndex = 0;
            this.createCustomer.Text = "생성";
            this.createCustomer.UseVisualStyleBackColor = true;
            this.createCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // cusDetail
            // 
            this.cusDetail.Controls.Add(this.cusIsQualified);
            this.cusDetail.Controls.Add(this.label8);
            this.cusDetail.Controls.Add(this.cusFullName);
            this.cusDetail.Controls.Add(this.label6);
            this.cusDetail.Controls.Add(this.cusDescription);
            this.cusDetail.Controls.Add(this.label7);
            this.cusDetail.Controls.Add(this.cusAddress);
            this.cusDetail.Controls.Add(this.label5);
            this.cusDetail.Controls.Add(this.cusAge);
            this.cusDetail.Controls.Add(this.label4);
            this.cusDetail.Controls.Add(this.cusFirstName);
            this.cusDetail.Controls.Add(this.label3);
            this.cusDetail.Controls.Add(this.cusLastName);
            this.cusDetail.Controls.Add(this.label1);
            this.cusDetail.Location = new System.Drawing.Point(268, 12);
            this.cusDetail.Name = "cusDetail";
            this.cusDetail.Size = new System.Drawing.Size(168, 247);
            this.cusDetail.TabIndex = 1;
            // 
            // cusIsQualified
            // 
            this.cusIsQualified.AutoSize = true;
            this.cusIsQualified.Location = new System.Drawing.Point(73, 106);
            this.cusIsQualified.Name = "cusIsQualified";
            this.cusIsQualified.Size = new System.Drawing.Size(11, 12);
            this.cusIsQualified.TabIndex = 13;
            this.cusIsQualified.Text = "-";
            this.cusIsQualified.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "가능여부";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // cusFullName
            // 
            this.cusFullName.AutoSize = true;
            this.cusFullName.Location = new System.Drawing.Point(73, 56);
            this.cusFullName.Name = "cusFullName";
            this.cusFullName.Size = new System.Drawing.Size(81, 12);
            this.cusFullName.TabIndex = 11;
            this.cusFullName.Text = "Gildong Hong";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "이름 성";
            // 
            // cusDescription
            // 
            this.cusDescription.AutoSize = true;
            this.cusDescription.Location = new System.Drawing.Point(73, 153);
            this.cusDescription.Name = "cusDescription";
            this.cusDescription.Size = new System.Drawing.Size(11, 12);
            this.cusDescription.TabIndex = 9;
            this.cusDescription.Text = "-";
            this.cusDescription.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "설명";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // cusAddress
            // 
            this.cusAddress.AutoSize = true;
            this.cusAddress.Location = new System.Drawing.Point(73, 130);
            this.cusAddress.Name = "cusAddress";
            this.cusAddress.Size = new System.Drawing.Size(11, 12);
            this.cusAddress.TabIndex = 7;
            this.cusAddress.Text = "-";
            this.cusAddress.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "주소";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // cusAge
            // 
            this.cusAge.AutoSize = true;
            this.cusAge.Location = new System.Drawing.Point(73, 82);
            this.cusAge.Name = "cusAge";
            this.cusAge.Size = new System.Drawing.Size(11, 12);
            this.cusAge.TabIndex = 5;
            this.cusAge.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "나이";
            // 
            // cusFirstName
            // 
            this.cusFirstName.AutoSize = true;
            this.cusFirstName.Location = new System.Drawing.Point(73, 33);
            this.cusFirstName.Name = "cusFirstName";
            this.cusFirstName.Size = new System.Drawing.Size(48, 12);
            this.cusFirstName.TabIndex = 3;
            this.cusFirstName.Text = "Gildong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름";
            // 
            // cusLastName
            // 
            this.cusLastName.AutoSize = true;
            this.cusLastName.Location = new System.Drawing.Point(73, 11);
            this.cusLastName.Name = "cusLastName";
            this.cusLastName.Size = new System.Drawing.Size(34, 12);
            this.cusLastName.TabIndex = 1;
            this.cusLastName.Text = "Hong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "성";
            // 
            // currentDay
            // 
            this.currentDay.AutoSize = true;
            this.currentDay.Location = new System.Drawing.Point(239, 440);
            this.currentDay.Name = "currentDay";
            this.currentDay.Size = new System.Drawing.Size(41, 12);
            this.currentDay.TabIndex = 2;
            this.currentDay.Text = "Today";
            // 
            // cusNewPanel
            // 
            this.cusNewPanel.Controls.Add(this.cusNewDescription);
            this.cusNewPanel.Controls.Add(this.cusNewAddress);
            this.cusNewPanel.Controls.Add(this.cusNewFirstName);
            this.cusNewPanel.Controls.Add(this.createCustomer);
            this.cusNewPanel.Controls.Add(this.cusNewBirth);
            this.cusNewPanel.Controls.Add(this.cusNewLastName);
            this.cusNewPanel.Controls.Add(this.label10);
            this.cusNewPanel.Controls.Add(this.label11);
            this.cusNewPanel.Controls.Add(this.label12);
            this.cusNewPanel.Controls.Add(this.label13);
            this.cusNewPanel.Controls.Add(this.label14);
            this.cusNewPanel.Location = new System.Drawing.Point(12, 12);
            this.cusNewPanel.Name = "cusNewPanel";
            this.cusNewPanel.Size = new System.Drawing.Size(248, 247);
            this.cusNewPanel.TabIndex = 3;
            this.cusNewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // cusNewDescription
            // 
            this.cusNewDescription.Location = new System.Drawing.Point(48, 121);
            this.cusNewDescription.Multiline = true;
            this.cusNewDescription.Name = "cusNewDescription";
            this.cusNewDescription.Size = new System.Drawing.Size(185, 85);
            this.cusNewDescription.TabIndex = 21;
            // 
            // cusNewAddress
            // 
            this.cusNewAddress.Location = new System.Drawing.Point(48, 94);
            this.cusNewAddress.Name = "cusNewAddress";
            this.cusNewAddress.Size = new System.Drawing.Size(185, 21);
            this.cusNewAddress.TabIndex = 20;
            // 
            // cusNewFirstName
            // 
            this.cusNewFirstName.Location = new System.Drawing.Point(48, 38);
            this.cusNewFirstName.Name = "cusNewFirstName";
            this.cusNewFirstName.Size = new System.Drawing.Size(100, 21);
            this.cusNewFirstName.TabIndex = 19;
            // 
            // cusNewBirth
            // 
            this.cusNewBirth.Location = new System.Drawing.Point(48, 65);
            this.cusNewBirth.Name = "cusNewBirth";
            this.cusNewBirth.Size = new System.Drawing.Size(100, 21);
            this.cusNewBirth.TabIndex = 18;
            this.cusNewBirth.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // cusNewLastName
            // 
            this.cusNewLastName.Location = new System.Drawing.Point(48, 11);
            this.cusNewLastName.Name = "cusNewLastName";
            this.cusNewLastName.Size = new System.Drawing.Size(100, 21);
            this.cusNewLastName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "설명";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "주소";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "생일";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "이름";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 13;
            this.label14.Text = "성";
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.ItemHeight = 12;
            this.customerList.Location = new System.Drawing.Point(442, 12);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(180, 256);
            this.customerList.TabIndex = 4;
            this.customerList.Click += new System.EventHandler(this.CustomerList_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cusList);
            this.panel1.Location = new System.Drawing.Point(12, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 172);
            this.panel1.TabIndex = 5;
            // 
            // cusList
            // 
            this.cusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.cusList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cusList.Location = new System.Drawing.Point(0, 0);
            this.cusList.Name = "cusList";
            this.cusList.RowTemplate.Height = 23;
            this.cusList.Size = new System.Drawing.Size(424, 172);
            this.cusList.TabIndex = 0;
            this.cusList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CusList_CellClick);
            this.cusList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "나이";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "가능여부";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.cusNewPanel);
            this.Controls.Add(this.currentDay);
            this.Controls.Add(this.cusDetail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cusDetail.ResumeLayout(false);
            this.cusDetail.PerformLayout();
            this.cusNewPanel.ResumeLayout(false);
            this.cusNewPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cusList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createCustomer;
        private System.Windows.Forms.Panel cusDetail;
        private System.Windows.Forms.Label cusFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cusLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cusDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cusAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cusAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cusFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label currentDay;
        private System.Windows.Forms.Label cusIsQualified;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel cusNewPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cusNewDescription;
        private System.Windows.Forms.TextBox cusNewAddress;
        private System.Windows.Forms.TextBox cusNewFirstName;
        private System.Windows.Forms.TextBox cusNewBirth;
        private System.Windows.Forms.TextBox cusNewLastName;
        private System.Windows.Forms.ListBox customerList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView cusList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

