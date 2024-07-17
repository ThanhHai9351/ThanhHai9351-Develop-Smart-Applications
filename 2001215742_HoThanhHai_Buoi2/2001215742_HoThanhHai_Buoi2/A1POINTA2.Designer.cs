namespace _2001215742_HoThanhHai_Buoi2
{
    partial class A1POINTA2
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
            this.ttsv1 = new UC_Control.TTSV();
            this.login1 = new UC_Control.Login();
            this.SuspendLayout();
            // 
            // ttsv1
            // 
            this.ttsv1.Location = new System.Drawing.Point(36, 12);
            this.ttsv1.Name = "ttsv1";
            this.ttsv1.Size = new System.Drawing.Size(465, 173);
            this.ttsv1.TabIndex = 0;
            // 
            // login1
            // 
            this.login1.Location = new System.Drawing.Point(101, 176);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(341, 252);
            this.login1.TabIndex = 1;
            // 
            // A1POINTA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 376);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.ttsv1);
            this.Name = "A1POINTA2";
            this.Text = "A1POINTA2";
            this.Load += new System.EventHandler(this.A1POINTA2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Control.TTSV ttsv1;
        private UC_Control.Login login1;
    }
}