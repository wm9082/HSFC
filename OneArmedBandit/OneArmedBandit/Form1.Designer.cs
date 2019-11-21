namespace OneArmedBandit
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudgeButton1 = new System.Windows.Forms.Button();
            this.nudgeButton3 = new System.Windows.Forms.Button();
            this.nudgeButton2 = new System.Windows.Forms.Button();
            this.spinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(270, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "One Armed Bandit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudgeButton1
            // 
            this.nudgeButton1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeButton1.Location = new System.Drawing.Point(147, 298);
            this.nudgeButton1.Name = "nudgeButton1";
            this.nudgeButton1.Size = new System.Drawing.Size(100, 38);
            this.nudgeButton1.TabIndex = 1;
            this.nudgeButton1.Text = "NUDGE";
            this.nudgeButton1.UseVisualStyleBackColor = true;
            // 
            // nudgeButton3
            // 
            this.nudgeButton3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeButton3.Location = new System.Drawing.Point(568, 298);
            this.nudgeButton3.Name = "nudgeButton3";
            this.nudgeButton3.Size = new System.Drawing.Size(100, 38);
            this.nudgeButton3.TabIndex = 2;
            this.nudgeButton3.Text = "NUDGE";
            this.nudgeButton3.UseVisualStyleBackColor = true;
            // 
            // nudgeButton2
            // 
            this.nudgeButton2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeButton2.Location = new System.Drawing.Point(359, 298);
            this.nudgeButton2.Name = "nudgeButton2";
            this.nudgeButton2.Size = new System.Drawing.Size(100, 38);
            this.nudgeButton2.TabIndex = 3;
            this.nudgeButton2.Text = "NUDGE";
            this.nudgeButton2.UseVisualStyleBackColor = true;
            // 
            // spinButton
            // 
            this.spinButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.Location = new System.Drawing.Point(359, 379);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(100, 38);
            this.spinButton.TabIndex = 4;
            this.spinButton.Text = "SPIN";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.nudgeButton2);
            this.Controls.Add(this.nudgeButton3);
            this.Controls.Add(this.nudgeButton1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "One Armed Bandit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nudgeButton1;
        private System.Windows.Forms.Button nudgeButton3;
        private System.Windows.Forms.Button nudgeButton2;
        private System.Windows.Forms.Button spinButton;
    }
}

