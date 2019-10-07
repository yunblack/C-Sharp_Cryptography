namespace Prototype_487
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mainPanel01 = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.mainLabel01 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainPanel01.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 338);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(23, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 70);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(453, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 70);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(453, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 338);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(424, 338);
            this.panel5.TabIndex = 1;
            // 
            // mainPanel01
            // 
            this.mainPanel01.Controls.Add(this.label1);
            this.mainPanel01.Controls.Add(this.mainLabel01);
            this.mainPanel01.Controls.Add(this.startBtn);
            this.mainPanel01.Location = new System.Drawing.Point(23, 63);
            this.mainPanel01.Name = "mainPanel01";
            this.mainPanel01.Size = new System.Drawing.Size(854, 414);
            this.mainPanel01.TabIndex = 2;
            // 
            // startBtn
            // 
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Adobe Kaiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(333, 287);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(187, 45);
            this.startBtn.TabIndex = 0;
            this.startBtn.TabStop = false;
            this.startBtn.Text = "Start Crytography";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // mainLabel01
            // 
            this.mainLabel01.AutoSize = true;
            this.mainLabel01.Font = new System.Drawing.Font("Adobe Kaiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mainLabel01.ForeColor = System.Drawing.Color.White;
            this.mainLabel01.Location = new System.Drawing.Point(237, 165);
            this.mainLabel01.Name = "mainLabel01";
            this.mainLabel01.Size = new System.Drawing.Size(389, 30);
            this.mainLabel01.TabIndex = 1;
            this.mainLabel01.Text = "Online Secret Splitting and Sharing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Kaiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(359, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prototype Version";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.mainPanel01);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Prototype 7";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.mainPanel01.ResumeLayout(false);
            this.mainPanel01.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel mainPanel01;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainLabel01;
    }
}

