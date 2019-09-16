namespace WindowsFormsApp0914Hello
{
    partial class calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.sum1 = new System.Windows.Forms.TextBox();
            this.sum2 = new System.Windows.Forms.TextBox();
            this.sumBtn = new System.Windows.Forms.Button();
            this.sumResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "여기를 클릭하세요";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // sum1
            // 
            this.sum1.Location = new System.Drawing.Point(23, 58);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(100, 21);
            this.sum1.TabIndex = 1;
            // 
            // sum2
            // 
            this.sum2.Location = new System.Drawing.Point(23, 85);
            this.sum2.Name = "sum2";
            this.sum2.Size = new System.Drawing.Size(100, 21);
            this.sum2.TabIndex = 2;
            // 
            // sumBtn
            // 
            this.sumBtn.Location = new System.Drawing.Point(143, 58);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(94, 48);
            this.sumBtn.TabIndex = 3;
            this.sumBtn.Text = "SUM";
            this.sumBtn.UseVisualStyleBackColor = true;
            this.sumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // sumResult
            // 
            this.sumResult.Location = new System.Drawing.Point(23, 112);
            this.sumResult.Name = "sumResult";
            this.sumResult.Size = new System.Drawing.Size(214, 21);
            this.sumResult.TabIndex = 4;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 382);
            this.Controls.Add(this.sumResult);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.sum2);
            this.Controls.Add(this.sum1);
            this.Controls.Add(this.label1);
            this.Name = "calculator";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sum1;
        private System.Windows.Forms.TextBox sum2;
        private System.Windows.Forms.Button sumBtn;
        private System.Windows.Forms.TextBox sumResult;
    }
}

