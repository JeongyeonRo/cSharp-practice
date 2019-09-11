namespace loginForm
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
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.PW_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(71, 80);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(119, 21);
            this.ID_txt.TabIndex = 0;
            // 
            // PW_txt
            // 
            this.PW_txt.Location = new System.Drawing.Point(71, 110);
            this.PW_txt.Name = "PW_txt";
            this.PW_txt.PasswordChar = '*';
            this.PW_txt.Size = new System.Drawing.Size(119, 21);
            this.PW_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(196, 80);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(76, 51);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Font = new System.Drawing.Font("굴림", 15F);
            this.L.Location = new System.Drawing.Point(108, 36);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(102, 20);
            this.L.TabIndex = 5;
            this.L.Text = "Login Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 206);
            this.Controls.Add(this.L);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PW_txt);
            this.Controls.Add(this.ID_txt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox PW_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label L;
    }
}

