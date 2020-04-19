namespace IE322_AA_1210924
{
    partial class Check_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBrownie = new System.Windows.Forms.CheckBox();
            this.chkDonut = new System.Windows.Forms.CheckBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.chkBrownie);
            this.panel1.Controls.Add(this.chkDonut);
            this.panel1.Controls.Add(this.chkCoffee);
            this.panel1.Location = new System.Drawing.Point(15, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 119);
            this.panel1.TabIndex = 8;
            // 
            // chkBrownie
            // 
            this.chkBrownie.AutoSize = true;
            this.chkBrownie.Location = new System.Drawing.Point(17, 83);
            this.chkBrownie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBrownie.Name = "chkBrownie";
            this.chkBrownie.Size = new System.Drawing.Size(92, 23);
            this.chkBrownie.TabIndex = 7;
            this.chkBrownie.Text = "Brownie";
            this.chkBrownie.UseVisualStyleBackColor = true;
            // 
            // chkDonut
            // 
            this.chkDonut.AutoSize = true;
            this.chkDonut.Location = new System.Drawing.Point(17, 50);
            this.chkDonut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(78, 23);
            this.chkDonut.TabIndex = 6;
            this.chkDonut.Text = "Donut";
            this.chkDonut.UseVisualStyleBackColor = true;
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(17, 17);
            this.chkCoffee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(80, 23);
            this.chkCoffee.TabIndex = 5;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.UseVisualStyleBackColor = true;
            this.chkCoffee.CheckedChanged += new System.EventHandler(this.chkCoffee_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(15, 182);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 33);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShow.Location = new System.Drawing.Point(15, 15);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(112, 33);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Check_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(287, 230);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnShow);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Check_form";
            this.Text = "Check_form";
            this.Load += new System.EventHandler(this.Check_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkBrownie;
        private System.Windows.Forms.CheckBox chkDonut;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShow;
    }
}