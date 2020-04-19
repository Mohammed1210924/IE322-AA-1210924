namespace IE322_AA_1210924
{
    partial class Picture_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Picture_form));
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picTry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.Gold;
            this.btnLoadImage.Location = new System.Drawing.Point(15, 15);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(799, 65);
            this.btnLoadImage.TabIndex = 9;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(15, 616);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 33);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picTry
            // 
            this.picTry.BackColor = System.Drawing.Color.Transparent;
            this.picTry.Location = new System.Drawing.Point(15, 90);
            this.picTry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTry.Name = "picTry";
            this.picTry.Size = new System.Drawing.Size(799, 517);
            this.picTry.TabIndex = 7;
            this.picTry.TabStop = false;
            this.picTry.Click += new System.EventHandler(this.PicTry_Click);
            // 
            // Picture_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 653);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picTry);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Picture_form";
            this.Text = "Picture_form";
            this.Load += new System.EventHandler(this.Picture_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picTry;
    }
}