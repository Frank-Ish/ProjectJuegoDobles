namespace ProjectJuegoDoble
{
    partial class FrmLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNickN = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lbPass);
            this.groupBox1.Controls.Add(this.lbNickN);
            this.groupBox1.Controls.Add(this.btnPerfil);
            this.groupBox1.Location = new System.Drawing.Point(269, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbNickN
            // 
            this.lbNickN.AutoSize = true;
            this.lbNickN.Location = new System.Drawing.Point(23, 225);
            this.lbNickN.Name = "lbNickN";
            this.lbNickN.Size = new System.Drawing.Size(55, 13);
            this.lbNickN.TabIndex = 1;
            this.lbNickN.Text = "Nickname";
            this.lbNickN.Click += new System.EventHandler(this.lbNickN_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(25, 266);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(53, 13);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 222);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(80, 263);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(159, 20);
            this.txtPass.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(102, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(64, 29);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Image = global::ProjectJuegoDoble.Properties.Resources.iconPerfil;
            this.btnPerfil.Location = new System.Drawing.Point(65, 19);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(139, 176);
            this.btnPerfil.TabIndex = 0;
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbNickN;
        private System.Windows.Forms.Button btnLogin;
    }
}