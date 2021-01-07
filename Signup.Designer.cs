namespace TechnologicalInfrastructure
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.txtSignUp = new System.Windows.Forms.Label();
            this.tbContrasena2 = new System.Windows.Forms.TextBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnBackSignup = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.txtContrasena2 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(369, 88);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(300, 31);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbApellido
            // 
            this.tbApellido.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellido.Location = new System.Drawing.Point(369, 140);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(300, 31);
            this.tbApellido.TabIndex = 1;
            this.tbApellido.TextChanged += new System.EventHandler(this.tbApellido_TextChanged);
            // 
            // tbDocumento
            // 
            this.tbDocumento.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDocumento.Location = new System.Drawing.Point(369, 192);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(300, 31);
            this.tbDocumento.TabIndex = 2;
            this.tbDocumento.TextChanged += new System.EventHandler(this.tbDocumento_TextChanged);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(369, 244);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(300, 31);
            this.tbCorreo.TabIndex = 3;
            this.tbCorreo.TextChanged += new System.EventHandler(this.tbCorreo_TextChanged);
            // 
            // tbCelular
            // 
            this.tbCelular.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCelular.Location = new System.Drawing.Point(369, 292);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(300, 31);
            this.tbCelular.TabIndex = 4;
            this.tbCelular.TextChanged += new System.EventHandler(this.tbCelular_TextChanged);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(369, 343);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(300, 31);
            this.tbUsuario.TabIndex = 5;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            // 
            // tbContrasena
            // 
            this.tbContrasena.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasena.Location = new System.Drawing.Point(369, 395);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '*';
            this.tbContrasena.Size = new System.Drawing.Size(300, 31);
            this.tbContrasena.TabIndex = 6;
            this.tbContrasena.TextChanged += new System.EventHandler(this.tbContrasena_TextChanged);
            // 
            // txtSignUp
            // 
            this.txtSignUp.AutoSize = true;
            this.txtSignUp.BackColor = System.Drawing.Color.Transparent;
            this.txtSignUp.Font = new System.Drawing.Font("RuneScape UF", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSignUp.Location = new System.Drawing.Point(358, 12);
            this.txtSignUp.Name = "txtSignUp";
            this.txtSignUp.Size = new System.Drawing.Size(192, 64);
            this.txtSignUp.TabIndex = 7;
            this.txtSignUp.Text = "Sign Up";
            this.txtSignUp.Click += new System.EventHandler(this.txtSignUp_Click);
            // 
            // tbContrasena2
            // 
            this.tbContrasena2.Font = new System.Drawing.Font("RuneScape UF", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasena2.Location = new System.Drawing.Point(369, 445);
            this.tbContrasena2.Name = "tbContrasena2";
            this.tbContrasena2.PasswordChar = '*';
            this.tbContrasena2.Size = new System.Drawing.Size(300, 31);
            this.tbContrasena2.TabIndex = 8;
            this.tbContrasena2.TextChanged += new System.EventHandler(this.tbContrasena2_TextChanged);
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("RuneScape UF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(389, 499);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(150, 50);
            this.btnSignup.TabIndex = 9;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnBackSignup
            // 
            this.btnBackSignup.Font = new System.Drawing.Font("RuneScape UF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSignup.Location = new System.Drawing.Point(3, 3);
            this.btnBackSignup.Name = "btnBackSignup";
            this.btnBackSignup.Size = new System.Drawing.Size(50, 50);
            this.btnBackSignup.TabIndex = 10;
            this.btnBackSignup.Text = "<";
            this.btnBackSignup.UseVisualStyleBackColor = true;
            this.btnBackSignup.Click += new System.EventHandler(this.btnBackSignup_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNombre.Font = new System.Drawing.Font("RuneScape UF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(285, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(70, 27);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Text = "Name:";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtApellido.Font = new System.Drawing.Font("RuneScape UF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtApellido.Location = new System.Drawing.Point(234, 144);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 27);
            this.txtApellido.TabIndex = 12;
            this.txtApellido.Text = "Last Name:";
            this.txtApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.AutoSize = true;
            this.txtDocumento.BackColor = System.Drawing.Color.Transparent;
            this.txtDocumento.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDocumento.Font = new System.Drawing.Font("RuneScape UF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDocumento.Location = new System.Drawing.Point(243, 196);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(112, 27);
            this.txtDocumento.TabIndex = 13;
            this.txtDocumento.Text = "Document:";
            this.txtDocumento.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCorreo.Font = new System.Drawing.Font("RuneScape UF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCorreo.Location = new System.Drawing.Point(289, 248);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(66, 27);
            this.txtCorreo.TabIndex = 14;
            this.txtCorreo.Text = "Email:";
            this.txtCorreo.Click += new System.EventHandler(this.txtCorreo_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.AutoSize = true;
            this.txtCelular.BackColor = System.Drawing.Color.Transparent;
            this.txtCelular.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCelular.Font = new System.Drawing.Font("RuneScape UF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCelular.Location = new System.Drawing.Point(202, 296);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(157, 27);
            this.txtCelular.TabIndex = 15;
            this.txtCelular.Text = "Phone Number:";
            this.txtCelular.Click += new System.EventHandler(this.txtCelular_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.BackColor = System.Drawing.Color.Transparent;
            this.txtContrasena.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtContrasena.Font = new System.Drawing.Font("RuneScape UF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtContrasena.Location = new System.Drawing.Point(242, 399);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(113, 27);
            this.txtContrasena.TabIndex = 16;
            this.txtContrasena.Text = "Password:";
            this.txtContrasena.Click += new System.EventHandler(this.txtContrasena_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUsuario.Font = new System.Drawing.Font("RuneScape UF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsuario.Location = new System.Drawing.Point(245, 347);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(114, 27);
            this.txtUsuario.TabIndex = 17;
            this.txtUsuario.Text = "Username:";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // txtContrasena2
            // 
            this.txtContrasena2.AutoSize = true;
            this.txtContrasena2.BackColor = System.Drawing.Color.Transparent;
            this.txtContrasena2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtContrasena2.Font = new System.Drawing.Font("RuneScape UF", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtContrasena2.Location = new System.Drawing.Point(159, 449);
            this.txtContrasena2.Name = "txtContrasena2";
            this.txtContrasena2.Size = new System.Drawing.Size(196, 27);
            this.txtContrasena2.TabIndex = 18;
            this.txtContrasena2.Text = "Confirm Password:";
            this.txtContrasena2.Click += new System.EventHandler(this.txtContrasena2_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.White;
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Location = new System.Drawing.Point(800, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 37);
            this.btnMinimizar.TabIndex = 19;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Location = new System.Drawing.Point(840, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 37);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtContrasena2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBackSignup);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.tbContrasena2);
            this.Controls.Add(this.txtSignUp);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbDocumento);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Techonological Infrastructure";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.Label txtSignUp;
        private System.Windows.Forms.TextBox tbContrasena2;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnBackSignup;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.Label txtDocumento;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label txtCelular;
        private System.Windows.Forms.Label txtContrasena;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label txtContrasena2;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}