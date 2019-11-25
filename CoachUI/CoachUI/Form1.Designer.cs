namespace CoachUI
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
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Addbuttton = new System.Windows.Forms.Button();
            this.Getbutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.seatBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Seat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.SystemColors.Window;
            this.Clearbutton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clearbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Clearbutton.Location = new System.Drawing.Point(449, 384);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(82, 36);
            this.Clearbutton.TabIndex = 0;
            this.Clearbutton.Text = "Clear by name.";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Addbuttton
            // 
            this.Addbuttton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Addbuttton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbuttton.Location = new System.Drawing.Point(261, 332);
            this.Addbuttton.Name = "Addbuttton";
            this.Addbuttton.Size = new System.Drawing.Size(124, 36);
            this.Addbuttton.TabIndex = 2;
            this.Addbuttton.Text = "Add to bus.";
            this.Addbuttton.UseVisualStyleBackColor = false;
            this.Addbuttton.Click += new System.EventHandler(this.Addbuttton_Click);
            // 
            // Getbutton
            // 
            this.Getbutton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Getbutton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Getbutton.Location = new System.Drawing.Point(407, 332);
            this.Getbutton.Name = "Getbutton";
            this.Getbutton.Size = new System.Drawing.Size(133, 36);
            this.Getbutton.TabIndex = 3;
            this.Getbutton.Text = "Get by name.";
            this.Getbutton.UseVisualStyleBackColor = false;
            this.Getbutton.Click += new System.EventHandler(this.Getbutton_Click_1);
            // 
            // Removebutton
            // 
            this.Removebutton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Removebutton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebutton.Location = new System.Drawing.Point(261, 384);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(169, 36);
            this.Removebutton.TabIndex = 5;
            this.Removebutton.Text = "Remove by name.";
            this.Removebutton.UseVisualStyleBackColor = false;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // Age
            // 
            this.Age.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.Location = new System.Drawing.Point(249, 203);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(50, 30);
            this.Age.TabIndex = 8;
            this.Age.Text = "Age";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(317, 148);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 26);
            this.nameBox.TabIndex = 10;
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.Location = new System.Drawing.Point(317, 203);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(48, 26);
            this.ageBox.TabIndex = 11;
            // 
            // seatBox
            // 
            this.seatBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatBox.Location = new System.Drawing.Point(502, 202);
            this.seatBox.Name = "seatBox";
            this.seatBox.Size = new System.Drawing.Size(48, 26);
            this.seatBox.TabIndex = 12;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(317, 82);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(233, 38);
            this.Title.TabIndex = 13;
            this.Title.Text = "Will\'s wild rides !";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(249, 151);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(50, 23);
            this.Name.TabIndex = 14;
            this.Name.Text = "Name";
            // 
            // Seat
            // 
            this.Seat.AutoSize = true;
            this.Seat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seat.Location = new System.Drawing.Point(403, 202);
            this.Seat.Name = "Seat";
            this.Seat.Size = new System.Drawing.Size(74, 23);
            this.Seat.TabIndex = 15;
            this.Seat.Text = "Seat No.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoachUI.Properties.Resources.CRASHED_COACH____;
            this.pictureBox1.Location = new System.Drawing.Point(-54, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 537);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 443);
            this.Controls.Add(this.Seat);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.seatBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.Getbutton);
            this.Controls.Add(this.Addbuttton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.pictureBox1);
            //this.Name = "Form1";
            this.Text = "Will\'s wild rides !";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Addbuttton;
        private System.Windows.Forms.Button Getbutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.TextBox seatBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Seat;
    }
}

