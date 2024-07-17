namespace _2001215742_HoThanhHai_Buoi2
{
    partial class Oclock
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
            this.dongHoTick1 = new UC_Control.DongHoTick();
            this.SuspendLayout();
            // 
            // dongHoTick1
            // 
            this.dongHoTick1.Location = new System.Drawing.Point(23, 62);
            this.dongHoTick1.Name = "dongHoTick1";
            this.dongHoTick1.Size = new System.Drawing.Size(336, 180);
            this.dongHoTick1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 319);
            this.Controls.Add(this.dongHoTick1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Control.DongHoTick dongHoTick1;


    }
}

