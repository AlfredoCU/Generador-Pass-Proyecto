namespace Generador_de_contraseñas
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.MenuPrincipal = new MaterialSkin.Controls.MaterialTabControl();
            this.Pantalla1 = new System.Windows.Forms.TabPage();
            this.Password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Salir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ImagenLlave = new System.Windows.Forms.PictureBox();
            this.Generar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Mensaje1 = new MaterialSkin.Controls.MaterialLabel();
            this.Pantalla2 = new System.Windows.Forms.TabPage();
            this.mensaje4 = new MaterialSkin.Controls.MaterialLabel();
            this.mensaje3 = new MaterialSkin.Controls.MaterialLabel();
            this.mensaje2 = new MaterialSkin.Controls.MaterialLabel();
            this.Seleccionar = new MaterialSkin.Controls.MaterialTabSelector();
            this.MenuPrincipal.SuspendLayout();
            this.Pantalla1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLlave)).BeginInit();
            this.Pantalla2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(52, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(108, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Controls.Add(this.Pantalla1);
            this.MenuPrincipal.Controls.Add(this.Pantalla2);
            this.MenuPrincipal.Depth = 0;
            this.MenuPrincipal.Location = new System.Drawing.Point(1, 103);
            this.MenuPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.SelectedIndex = 0;
            this.MenuPrincipal.Size = new System.Drawing.Size(634, 175);
            this.MenuPrincipal.TabIndex = 4;
            // 
            // Pantalla1
            // 
            this.Pantalla1.BackColor = System.Drawing.Color.White;
            this.Pantalla1.Controls.Add(this.Password);
            this.Pantalla1.Controls.Add(this.Salir);
            this.Pantalla1.Controls.Add(this.ImagenLlave);
            this.Pantalla1.Controls.Add(this.Generar);
            this.Pantalla1.Controls.Add(this.Mensaje1);
            this.Pantalla1.Location = new System.Drawing.Point(4, 22);
            this.Pantalla1.Name = "Pantalla1";
            this.Pantalla1.Padding = new System.Windows.Forms.Padding(3);
            this.Pantalla1.Size = new System.Drawing.Size(626, 149);
            this.Pantalla1.TabIndex = 0;
            this.Pantalla1.Text = "Contraseña";
            // 
            // Password
            // 
            this.Password.Depth = 0;
            this.Password.Hint = "";
            this.Password.Location = new System.Drawing.Point(263, 38);
            this.Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.Size = new System.Drawing.Size(355, 23);
            this.Password.TabIndex = 6;
            this.Password.Text = "Generar";
            this.Password.UseSystemPasswordChar = false;
            // 
            // Salir
            // 
            this.Salir.Depth = 0;
            this.Salir.ForeColor = System.Drawing.Color.Transparent;
            this.Salir.Location = new System.Drawing.Point(462, 88);
            this.Salir.MouseState = MaterialSkin.MouseState.HOVER;
            this.Salir.Name = "Salir";
            this.Salir.Primary = true;
            this.Salir.Size = new System.Drawing.Size(158, 55);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // ImagenLlave
            // 
            this.ImagenLlave.Image = ((System.Drawing.Image)(resources.GetObject("ImagenLlave.Image")));
            this.ImagenLlave.Location = new System.Drawing.Point(17, 24);
            this.ImagenLlave.Name = "ImagenLlave";
            this.ImagenLlave.Size = new System.Drawing.Size(128, 119);
            this.ImagenLlave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenLlave.TabIndex = 3;
            this.ImagenLlave.TabStop = false;
            // 
            // Generar
            // 
            this.Generar.Depth = 0;
            this.Generar.ForeColor = System.Drawing.Color.Transparent;
            this.Generar.Location = new System.Drawing.Point(170, 88);
            this.Generar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Generar.Name = "Generar";
            this.Generar.Primary = true;
            this.Generar.Size = new System.Drawing.Size(284, 55);
            this.Generar.TabIndex = 2;
            this.Generar.Text = "Generar contraseña";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // Mensaje1
            // 
            this.Mensaje1.AutoSize = true;
            this.Mensaje1.BackColor = System.Drawing.Color.Transparent;
            this.Mensaje1.Depth = 0;
            this.Mensaje1.Font = new System.Drawing.Font("Roboto", 11F);
            this.Mensaje1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Mensaje1.Location = new System.Drawing.Point(167, 38);
            this.Mensaje1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mensaje1.Name = "Mensaje1";
            this.Mensaje1.Size = new System.Drawing.Size(90, 19);
            this.Mensaje1.TabIndex = 0;
            this.Mensaje1.Text = "Contraseña:";
            // 
            // Pantalla2
            // 
            this.Pantalla2.Controls.Add(this.mensaje4);
            this.Pantalla2.Controls.Add(this.mensaje3);
            this.Pantalla2.Controls.Add(this.mensaje2);
            this.Pantalla2.Location = new System.Drawing.Point(4, 22);
            this.Pantalla2.Name = "Pantalla2";
            this.Pantalla2.Padding = new System.Windows.Forms.Padding(3);
            this.Pantalla2.Size = new System.Drawing.Size(626, 149);
            this.Pantalla2.TabIndex = 1;
            this.Pantalla2.Text = "Objetivo del sistema";
            this.Pantalla2.UseVisualStyleBackColor = true;
            // 
            // mensaje4
            // 
            this.mensaje4.AutoSize = true;
            this.mensaje4.Depth = 0;
            this.mensaje4.Font = new System.Drawing.Font("Roboto", 11F);
            this.mensaje4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mensaje4.Location = new System.Drawing.Point(58, 127);
            this.mensaje4.MouseState = MaterialSkin.MouseState.HOVER;
            this.mensaje4.Name = "mensaje4";
            this.mensaje4.Size = new System.Drawing.Size(192, 19);
            this.mensaje4.TabIndex = 2;
            this.mensaje4.Text = "Atentamente ArdComputer.";
            // 
            // mensaje3
            // 
            this.mensaje3.AutoSize = true;
            this.mensaje3.Depth = 0;
            this.mensaje3.Font = new System.Drawing.Font("Roboto", 11F);
            this.mensaje3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mensaje3.Location = new System.Drawing.Point(58, 67);
            this.mensaje3.MouseState = MaterialSkin.MouseState.HOVER;
            this.mensaje3.Name = "mensaje3";
            this.mensaje3.Size = new System.Drawing.Size(511, 38);
            this.mensaje3.TabIndex = 1;
            this.mensaje3.Text = "Con el fin de proteger mejor nuestras diferentes cuentas y no exponerlas a \r\nuna " +
    "vulnerabilidad de nuestra información.";
            // 
            // mensaje2
            // 
            this.mensaje2.AutoSize = true;
            this.mensaje2.Depth = 0;
            this.mensaje2.Font = new System.Drawing.Font("Roboto", 11F);
            this.mensaje2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mensaje2.Location = new System.Drawing.Point(58, 13);
            this.mensaje2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mensaje2.Name = "mensaje2";
            this.mensaje2.Size = new System.Drawing.Size(511, 38);
            this.mensaje2.TabIndex = 0;
            this.mensaje2.Text = "Es un generador de contraseñas en el cual nos ayudara a probar diferentes \r\nposib" +
    "ilidades de obtener contraseñas aleatorias.";
            // 
            // Seleccionar
            // 
            this.Seleccionar.BaseTabControl = this.MenuPrincipal;
            this.Seleccionar.Depth = 0;
            this.Seleccionar.Location = new System.Drawing.Point(-3, 61);
            this.Seleccionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(638, 22);
            this.Seleccionar.TabIndex = 5;
            this.Seleccionar.Text = "Seleccionar";
            // 
            // PantallaPrincipal
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 287);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.MenuPrincipal);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERADOR DE CONTRASEÑAS";
            this.MenuPrincipal.ResumeLayout(false);
            this.Pantalla1.ResumeLayout(false);
            this.Pantalla1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLlave)).EndInit();
            this.Pantalla2.ResumeLayout(false);
            this.Pantalla2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTabControl MenuPrincipal;
        private System.Windows.Forms.TabPage Pantalla2;
        private MaterialSkin.Controls.MaterialTabSelector Seleccionar;
        private MaterialSkin.Controls.MaterialLabel mensaje4;
        private MaterialSkin.Controls.MaterialLabel mensaje3;
        private MaterialSkin.Controls.MaterialLabel mensaje2;
        private System.Windows.Forms.TabPage Pantalla1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Password;
        private MaterialSkin.Controls.MaterialRaisedButton Salir;
        private System.Windows.Forms.PictureBox ImagenLlave;
        private MaterialSkin.Controls.MaterialRaisedButton Generar;
        private MaterialSkin.Controls.MaterialLabel Mensaje1;
    }
}

