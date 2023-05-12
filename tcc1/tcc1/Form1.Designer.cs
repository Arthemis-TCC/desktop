namespace tcc1
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
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chbox_lembre = new System.Windows.Forms.CheckBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_senha.Location = new System.Drawing.Point(44, 170);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(244, 20);
            this.txt_senha.TabIndex = 16;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_email.Location = new System.Drawing.Point(44, 100);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(243, 20);
            this.txt_email.TabIndex = 14;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(41, 82);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(44, 15);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "E-mail:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btn_sair);
            this.groupBox1.Controls.Add(this.lbl_senha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_senha);
            this.groupBox1.Controls.Add(this.chbox_lembre);
            this.groupBox1.Controls.Add(this.btn_entrar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(265, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 353);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.LightGreen;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_sair.Location = new System.Drawing.Point(44, 259);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(91, 43);
            this.btn_sair.TabIndex = 19;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(41, 152);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(44, 15);
            this.lbl_senha.TabIndex = 18;
            this.lbl_senha.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Login";
            // 
            // chbox_lembre
            // 
            this.chbox_lembre.AutoSize = true;
            this.chbox_lembre.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_lembre.Location = new System.Drawing.Point(44, 216);
            this.chbox_lembre.Name = "chbox_lembre";
            this.chbox_lembre.Size = new System.Drawing.Size(80, 17);
            this.chbox_lembre.TabIndex = 6;
            this.chbox_lembre.Text = "Lembre-me";
            this.chbox_lembre.UseVisualStyleBackColor = true;
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_entrar.Location = new System.Drawing.Point(179, 259);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(91, 43);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "ENTRAR";
            this.btn_entrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::tcc1.Properties.Resources.a50d5452928760cf3c255b40cb4b8876_removebg_preview_2;
            this.pictureBox1.Location = new System.Drawing.Point(695, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 107);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::tcc1.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(819, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbox_lembre;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

