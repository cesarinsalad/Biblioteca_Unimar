namespace Biblioteca_Unimar
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rgst_prest = new System.Windows.Forms.Button();
            this.rgst_alum = new System.Windows.Forms.Button();
            this.prest_act = new System.Windows.Forms.Button();
            this.libros_dispon = new System.Windows.Forms.Button();
            this.sancion_alumns = new System.Windows.Forms.Button();
            this.renov_prest = new System.Windows.Forms.Button();
            this.rgst_devol = new System.Windows.Forms.Button();
            this.agg_libr_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Doppio One", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Biblioteca UNIMAR";
            // 
            // rgst_prest
            // 
            this.rgst_prest.Location = new System.Drawing.Point(255, 144);
            this.rgst_prest.Name = "rgst_prest";
            this.rgst_prest.Size = new System.Drawing.Size(216, 106);
            this.rgst_prest.TabIndex = 2;
            this.rgst_prest.Text = "Registrar Préstamo";
            this.rgst_prest.UseVisualStyleBackColor = true;
            this.rgst_prest.Click += new System.EventHandler(this.rgst_prest_Click);
            // 
            // rgst_alum
            // 
            this.rgst_alum.Location = new System.Drawing.Point(26, 144);
            this.rgst_alum.Name = "rgst_alum";
            this.rgst_alum.Size = new System.Drawing.Size(216, 108);
            this.rgst_alum.TabIndex = 3;
            this.rgst_alum.Text = "Registrar Alumno";
            this.rgst_alum.UseVisualStyleBackColor = true;
            this.rgst_alum.Click += new System.EventHandler(this.rgst_alum_Click);
            // 
            // prest_act
            // 
            this.prest_act.Location = new System.Drawing.Point(485, 144);
            this.prest_act.Name = "prest_act";
            this.prest_act.Size = new System.Drawing.Size(216, 108);
            this.prest_act.TabIndex = 4;
            this.prest_act.Text = "Préstamos Activos";
            this.prest_act.UseVisualStyleBackColor = true;
            this.prest_act.Click += new System.EventHandler(this.prest_act_Click);
            // 
            // libros_dispon
            // 
            this.libros_dispon.Location = new System.Drawing.Point(714, 144);
            this.libros_dispon.Name = "libros_dispon";
            this.libros_dispon.Size = new System.Drawing.Size(216, 108);
            this.libros_dispon.TabIndex = 5;
            this.libros_dispon.Text = "Libros Disponibles";
            this.libros_dispon.UseVisualStyleBackColor = true;
            this.libros_dispon.Click += new System.EventHandler(this.libros_dispon_Click);
            // 
            // sancion_alumns
            // 
            this.sancion_alumns.Location = new System.Drawing.Point(26, 292);
            this.sancion_alumns.Name = "sancion_alumns";
            this.sancion_alumns.Size = new System.Drawing.Size(216, 108);
            this.sancion_alumns.TabIndex = 6;
            this.sancion_alumns.Text = "Alumnos Sancionados";
            this.sancion_alumns.UseVisualStyleBackColor = true;
            this.sancion_alumns.Click += new System.EventHandler(this.sancion_alumns_Click);
            // 
            // renov_prest
            // 
            this.renov_prest.Location = new System.Drawing.Point(255, 292);
            this.renov_prest.Name = "renov_prest";
            this.renov_prest.Size = new System.Drawing.Size(216, 108);
            this.renov_prest.TabIndex = 7;
            this.renov_prest.Text = "Renovar Préstamo";
            this.renov_prest.UseVisualStyleBackColor = true;
            this.renov_prest.Click += new System.EventHandler(this.renov_prest_Click);
            // 
            // rgst_devol
            // 
            this.rgst_devol.Location = new System.Drawing.Point(485, 292);
            this.rgst_devol.Name = "rgst_devol";
            this.rgst_devol.Size = new System.Drawing.Size(216, 108);
            this.rgst_devol.TabIndex = 8;
            this.rgst_devol.Text = "Registrar Devolución";
            this.rgst_devol.UseVisualStyleBackColor = true;
            this.rgst_devol.Click += new System.EventHandler(this.rgst_devol_Click);
            // 
            // agg_libr_new
            // 
            this.agg_libr_new.Location = new System.Drawing.Point(714, 292);
            this.agg_libr_new.Name = "agg_libr_new";
            this.agg_libr_new.Size = new System.Drawing.Size(216, 108);
            this.agg_libr_new.TabIndex = 9;
            this.agg_libr_new.Text = "Agregar Libros Nuevos";
            this.agg_libr_new.UseVisualStyleBackColor = true;
            this.agg_libr_new.Click += new System.EventHandler(this.agg_libr_new_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(963, 470);
            this.Controls.Add(this.agg_libr_new);
            this.Controls.Add(this.rgst_devol);
            this.Controls.Add(this.renov_prest);
            this.Controls.Add(this.sancion_alumns);
            this.Controls.Add(this.libros_dispon);
            this.Controls.Add(this.prest_act);
            this.Controls.Add(this.rgst_alum);
            this.Controls.Add(this.rgst_prest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rgst_prest;
        private System.Windows.Forms.Button rgst_alum;
        private System.Windows.Forms.Button prest_act;
        private System.Windows.Forms.Button libros_dispon;
        private System.Windows.Forms.Button sancion_alumns;
        private System.Windows.Forms.Button renov_prest;
        private System.Windows.Forms.Button rgst_devol;
        private System.Windows.Forms.Button agg_libr_new;
    }
}