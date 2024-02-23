namespace Biblioteca_Unimar
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label_contrasena = new System.Windows.Forms.Label();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_contrasena = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.BackColor = System.Drawing.Color.Transparent;
            this.label_usuario.Location = new System.Drawing.Point(158, 357);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(64, 20);
            this.label_usuario.TabIndex = 1;
            this.label_usuario.Text = "Usuario";
            // 
            // label_contrasena
            // 
            this.label_contrasena.AutoSize = true;
            this.label_contrasena.BackColor = System.Drawing.Color.Transparent;
            this.label_contrasena.Location = new System.Drawing.Point(159, 432);
            this.label_contrasena.Name = "label_contrasena";
            this.label_contrasena.Size = new System.Drawing.Size(92, 20);
            this.label_contrasena.TabIndex = 2;
            this.label_contrasena.Text = "Contraseña";
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Location = new System.Drawing.Point(154, 328);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(284, 26);
            this.textBox_usuario.TabIndex = 3;
            // 
            // textBox_contrasena
            // 
            this.textBox_contrasena.Location = new System.Drawing.Point(154, 403);
            this.textBox_contrasena.Name = "textBox_contrasena";
            this.textBox_contrasena.Size = new System.Drawing.Size(284, 26);
            this.textBox_contrasena.TabIndex = 4;
            this.textBox_contrasena.UseSystemPasswordChar = true;
            // 
            // label_login
            // 
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Doppio One", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(119, 193);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(347, 113);
            this.label_login.TabIndex = 5;
            this.label_login.Text = "Sistema de Biblioteca UNIMAR";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(154, 518);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(284, 49);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Iniciar Sesión";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(572, 641);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_contrasena);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.label_contrasena);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label_contrasena;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.TextBox textBox_contrasena;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button button_login;
    }
}