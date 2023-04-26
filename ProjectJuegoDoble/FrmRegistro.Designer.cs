namespace ProjectJuegoDoble
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtNickN = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbFechaNa = new System.Windows.Forms.Label();
            this.lblNickN = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.mskCedula = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(210, 28);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(162, 25);
            this.lbTitulo.TabIndex = 24;
            this.lbTitulo.Text = "Crear Jugador";
            this.lbTitulo.Click += new System.EventHandler(this.lbTitulo_Click);
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.txtPass);
            this.gbxCliente.Controls.Add(this.label1);
            this.gbxCliente.Controls.Add(this.dtFechaNac);
            this.gbxCliente.Controls.Add(this.txtNickN);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.lbFechaNa);
            this.gbxCliente.Controls.Add(this.lblNickN);
            this.gbxCliente.Controls.Add(this.lbNom);
            this.gbxCliente.Controls.Add(this.lbNombre);
            this.gbxCliente.Controls.Add(this.mskCedula);
            this.gbxCliente.Location = new System.Drawing.Point(82, 63);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(410, 358);
            this.gbxCliente.TabIndex = 25;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Datos de cliente";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(161, 250);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(159, 20);
            this.txtPass.TabIndex = 22;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Location = new System.Drawing.Point(161, 198);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(159, 20);
            this.dtFechaNac.TabIndex = 20;
            // 
            // txtNickN
            // 
            this.txtNickN.Location = new System.Drawing.Point(161, 158);
            this.txtNickN.Name = "txtNickN";
            this.txtNickN.Size = new System.Drawing.Size(159, 20);
            this.txtNickN.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // lbFechaNa
            // 
            this.lbFechaNa.AutoSize = true;
            this.lbFechaNa.Location = new System.Drawing.Point(47, 204);
            this.lbFechaNa.Name = "lbFechaNa";
            this.lbFechaNa.Size = new System.Drawing.Size(93, 13);
            this.lbFechaNa.TabIndex = 6;
            this.lbFechaNa.Text = "Fecha Nacimiento";
            // 
            // lblNickN
            // 
            this.lblNickN.AutoSize = true;
            this.lblNickN.Location = new System.Drawing.Point(85, 161);
            this.lblNickN.Name = "lblNickN";
            this.lblNickN.Size = new System.Drawing.Size(55, 13);
            this.lblNickN.TabIndex = 3;
            this.lblNickN.Text = "Nickname";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(96, 112);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(44, 13);
            this.lbNom.TabIndex = 2;
            this.lbNom.Text = "Nombre";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(100, 66);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(40, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Cédula";
            // 
            // mskCedula
            // 
            this.mskCedula.Location = new System.Drawing.Point(161, 59);
            this.mskCedula.Mask = "#-####-####";
            this.mskCedula.Name = "mskCedula";
            this.mskCedula.Size = new System.Drawing.Size(159, 20);
            this.mskCedula.TabIndex = 0;
            this.mskCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(397, 448);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 69);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(574, 646);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.TextBox txtNickN;
        private System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lbFechaNa;
        public System.Windows.Forms.Label lblNickN;
        public System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.MaskedTextBox mskCedula;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnGuardar;
    }
}