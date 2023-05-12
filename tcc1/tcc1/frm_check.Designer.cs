namespace tcc1
{
    partial class frm_check
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pct_svn = new System.Windows.Forms.PictureBox();
            this.pct_iapp = new System.Windows.Forms.PictureBox();
            this.pct_cai = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_svn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_iapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_cai)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::tcc1.Properties.Resources.Group_22__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(239, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pct_svn
            // 
            this.pct_svn.BackgroundImage = global::tcc1.Properties.Resources.Group_20;
            this.pct_svn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_svn.Location = new System.Drawing.Point(71, 229);
            this.pct_svn.Name = "pct_svn";
            this.pct_svn.Size = new System.Drawing.Size(191, 108);
            this.pct_svn.TabIndex = 1;
            this.pct_svn.TabStop = false;
            this.pct_svn.Click += new System.EventHandler(this.pct_svn_Click);
            // 
            // pct_iapp
            // 
            this.pct_iapp.BackgroundImage = global::tcc1.Properties.Resources.Group_21;
            this.pct_iapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_iapp.Location = new System.Drawing.Point(314, 229);
            this.pct_iapp.Name = "pct_iapp";
            this.pct_iapp.Size = new System.Drawing.Size(191, 108);
            this.pct_iapp.TabIndex = 2;
            this.pct_iapp.TabStop = false;
            // 
            // pct_cai
            // 
            this.pct_cai.BackgroundImage = global::tcc1.Properties.Resources.Group_22;
            this.pct_cai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_cai.Location = new System.Drawing.Point(558, 229);
            this.pct_cai.Name = "pct_cai";
            this.pct_cai.Size = new System.Drawing.Size(191, 108);
            this.pct_cai.TabIndex = 3;
            this.pct_cai.TabStop = false;
            // 
            // frm_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tcc1.Properties.Resources.MicrosoftTeams_image__5__1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 505);
            this.Controls.Add(this.pct_cai);
            this.Controls.Add(this.pct_iapp);
            this.Controls.Add(this.pct_svn);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "frm_check";
            this.Text = "frm_check";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_svn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_iapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_cai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pct_svn;
        private System.Windows.Forms.PictureBox pct_iapp;
        private System.Windows.Forms.PictureBox pct_cai;
    }
}