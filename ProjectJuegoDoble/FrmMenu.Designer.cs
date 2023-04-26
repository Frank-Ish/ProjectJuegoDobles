namespace ProjectJuegoDoble
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbMRegistro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLog1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al juego";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Si quieres iniciar una partida, inicia sesion.";
            // 
            // lbMRegistro
            // 
            this.lbMRegistro.AutoSize = true;
            this.lbMRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMRegistro.Location = new System.Drawing.Point(367, 183);
            this.lbMRegistro.Name = "lbMRegistro";
            this.lbMRegistro.Size = new System.Drawing.Size(246, 16);
            this.lbMRegistro.TabIndex = 4;
            this.lbMRegistro.Text = "Registrate para poder acceder al juego.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = global::ProjectJuegoDoble.Properties.Resources.iconRegistro;
            this.button1.Location = new System.Drawing.Point(445, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 101);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLog1
            // 
            this.btnLog1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLog1.Image = global::ProjectJuegoDoble.Properties.Resources.login2;
            this.btnLog1.Location = new System.Drawing.Point(86, 265);
            this.btnLog1.Name = "btnLog1";
            this.btnLog1.Size = new System.Drawing.Size(96, 101);
            this.btnLog1.TabIndex = 3;
            this.btnLog1.UseVisualStyleBackColor = false;
            this.btnLog1.Click += new System.EventHandler(this.btnLog1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMRegistro);
            this.Controls.Add(this.btnLog1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnLog1;
        private System.Windows.Forms.Label lbMRegistro;
        private System.Windows.Forms.Button button1;
    }
}