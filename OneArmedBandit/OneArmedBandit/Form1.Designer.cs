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
            this.Nudgebutton1 = new System.Windows.Forms.Button();
            this.Nudgebutton2 = new System.Windows.Forms.Button();
            this.Nudgebutton3 = new System.Windows.Forms.Button();
            this.Spinbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(250, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Will\'s Wicked Winners !";
            // 
            // Nudgebutton1
            // 
            this.Nudgebutton1.BackColor = System.Drawing.Color.Orange;
            this.Nudgebutton1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nudgebutton1.Location = new System.Drawing.Point(203, 303);
            this.Nudgebutton1.Name = "Nudgebutton1";
            this.Nudgebutton1.Size = new System.Drawing.Size(75, 32);
            this.Nudgebutton1.TabIndex = 1;
            this.Nudgebutton1.Text = "Nudge";
            this.Nudgebutton1.UseVisualStyleBackColor = false;
            this.Nudgebutton1.Click += new System.EventHandler(this.Nudgebutton1_Click);
            // 
            // Nudgebutton2
            // 
            this.Nudgebutton2.BackColor = System.Drawing.Color.Orange;
            this.Nudgebutton2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nudgebutton2.Location = new System.Drawing.Point(371, 303);
            this.Nudgebutton2.Name = "Nudgebutton2";
            this.Nudgebutton2.Size = new System.Drawing.Size(75, 32);
            this.Nudgebutton2.TabIndex = 2;
            this.Nudgebutton2.Text = "Nudge";
            this.Nudgebutton2.UseVisualStyleBackColor = false;
            this.Nudgebutton2.Click += new System.EventHandler(this.Nudgebutton2_Click);
            // 
            // Nudgebutton3
            // 
            this.Nudgebutton3.BackColor = System.Drawing.Color.Orange;
            this.Nudgebutton3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nudgebutton3.Location = new System.Drawing.Point(527, 303);
            this.Nudgebutton3.Name = "Nudgebutton3";
            this.Nudgebutton3.Size = new System.Drawing.Size(75, 32);
            this.Nudgebutton3.TabIndex = 3;
            this.Nudgebutton3.Text = "Nudge";
            this.Nudgebutton3.UseVisualStyleBackColor = false;
            this.Nudgebutton3.Click += new System.EventHandler(this.Nudgebutton3_Click);
            // 
            // Spinbutton
            // 
            this.Spinbutton.BackColor = System.Drawing.Color.Orange;
            this.Spinbutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spinbutton.Location = new System.Drawing.Point(371, 373);
            this.Spinbutton.Name = "Spinbutton";
            this.Spinbutton.Size = new System.Drawing.Size(75, 42);
            this.Spinbutton.TabIndex = 4;
            this.Spinbutton.Text = "SPIN";
            this.Spinbutton.UseVisualStyleBackColor = false;
            this.Spinbutton.Click += new System.EventHandler(this.Spinbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Spinbutton);
            this.Controls.Add(this.Nudgebutton3);
            this.Controls.Add(this.Nudgebutton2);
            this.Controls.Add(this.Nudgebutton1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nudgebutton1;
        private System.Windows.Forms.Button Nudgebutton2;
        private System.Windows.Forms.Button Nudgebutton3;
        private System.Windows.Forms.Button Spinbutton;
    }
}

