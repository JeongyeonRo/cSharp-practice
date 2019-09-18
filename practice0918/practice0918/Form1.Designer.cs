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
            this.label1 = new System.Windows.Forms.Label();
            this.cusLastName = new System.Windows.Forms.Label();
            this.cusFirstName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cusDescription = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cusFullName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentDay = new System.Windows.Forms.Label();
            this.cusIsQualified = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cusDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // createCustomer
            // 
            this.createCustomer.Location = new System.Drawing.Point(12, 12);
            this.createCustomer.Name = "createCustomer";
            this.createCustomer.Size = new System.Drawing.Size(75, 23);
            this.createCustomer.TabIndex = 0;
            this.createCustomer.Text = "customer";
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
            this.cusDetail.Location = new System.Drawing.Point(93, 12);
            this.cusDetail.Name = "cusDetail";
            this.cusDetail.Size = new System.Drawing.Size(274, 215);
            this.cusDetail.TabIndex = 1;
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
            // cusLastName
            // 
            this.cusLastName.AutoSize = true;
            this.cusLastName.Location = new System.Drawing.Point(73, 11);
            this.cusLastName.Name = "cusLastName";
            this.cusLastName.Size = new System.Drawing.Size(34, 12);
            this.cusLastName.TabIndex = 1;
            this.cusLastName.Text = "Hong";
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
            // currentDay
            // 
            this.currentDay.AutoSize = true;
            this.currentDay.Location = new System.Drawing.Point(159, 241);
            this.currentDay.Name = "currentDay";
            this.currentDay.Size = new System.Drawing.Size(41, 12);
            this.currentDay.TabIndex = 2;
            this.currentDay.Text = "Today";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 262);
            this.Controls.Add(this.currentDay);
            this.Controls.Add(this.cusDetail);
            this.Controls.Add(this.createCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cusDetail.ResumeLayout(false);
            this.cusDetail.PerformLayout();
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
    }
}

