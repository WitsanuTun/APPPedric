namespace APPPPPPPPPPPPPPPPPPPPPPPPPedric
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
            this.tGetNumber = new System.Windows.Forms.TextBox();
            this.laShow = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tGetNumber
            // 
            this.tGetNumber.BackColor = System.Drawing.SystemColors.InfoText;
            this.tGetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tGetNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.tGetNumber.Location = new System.Drawing.Point(281, 333);
            this.tGetNumber.Name = "tGetNumber";
            this.tGetNumber.Size = new System.Drawing.Size(246, 38);
            this.tGetNumber.TabIndex = 1;
            this.tGetNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tGetNumber_KeyDown);
            // 
            // laShow
            // 
            this.laShow.AutoSize = true;
            this.laShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.laShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShow.ForeColor = System.Drawing.Color.SeaShell;
            this.laShow.Location = new System.Drawing.Point(238, 374);
            this.laShow.Name = "laShow";
            this.laShow.Size = new System.Drawing.Size(349, 55);
            this.laShow.TabIndex = 2;
            this.laShow.Text = ".........................";
            // 
            // bOK
            // 
            this.bOK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOK.ForeColor = System.Drawing.SystemColors.Control;
            this.bOK.Location = new System.Drawing.Point(637, 12);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(139, 83);
            this.bOK.TabIndex = 3;
            this.bOK.Text = "ออกไปไอ้โง่";
            this.bOK.UseVisualStyleBackColor = false;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::APPPPPPPPPPPPPPPPPPPPPPPPPedric.Properties.Resources.cec7bc5f565a076e5c66c10cef4dede1_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(277, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.Control;
            this.reset.Location = new System.Drawing.Point(371, 251);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(70, 31);
            this.reset.TabIndex = 4;
            this.reset.Text = "รีเจนซี่";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::APPPPPPPPPPPPPPPPPPPPPPPPPedric.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.laShow);
            this.Controls.Add(this.tGetNumber);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tGetNumber;
        private System.Windows.Forms.Label laShow;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button reset;
    }
}

