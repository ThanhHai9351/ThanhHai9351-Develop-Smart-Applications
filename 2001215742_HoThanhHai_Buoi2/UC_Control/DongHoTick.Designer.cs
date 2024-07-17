namespace UC_Control
{
    partial class DongHoTick
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTime = new System.Windows.Forms.Label();
            this.lb_Step = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(25, 50);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(135, 33);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "00:00:00";
            // 
            // lb_Step
            // 
            this.lb_Step.AutoSize = true;
            this.lb_Step.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Step.Location = new System.Drawing.Point(215, 50);
            this.lb_Step.Name = "lb_Step";
            this.lb_Step.Size = new System.Drawing.Size(66, 33);
            this.lb_Step.TabIndex = 1;
            this.lb_Step.Text = "000";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(63, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 33);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLap
            // 
            this.btnLap.Location = new System.Drawing.Point(179, 106);
            this.btnLap.Name = "btnLap";
            this.btnLap.Size = new System.Drawing.Size(75, 33);
            this.btnLap.TabIndex = 3;
            this.btnLap.Text = "Lap";
            this.btnLap.UseVisualStyleBackColor = true;
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);
            // 
            // DongHoTick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLap);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lb_Step);
            this.Controls.Add(this.lbTime);
            this.Name = "DongHoTick";
            this.Size = new System.Drawing.Size(336, 180);
            this.Load += new System.EventHandler(this.DongHo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lb_Step;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLap;
    }
}
