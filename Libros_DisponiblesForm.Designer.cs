namespace Biblioteca_Unimar
{
    partial class Libros_DisponiblesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libros_DisponiblesForm));
            this.listBoxLibrosDisponibles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegresarLibrDispo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxLibrosDisponibles
            // 
            this.listBoxLibrosDisponibles.FormattingEnabled = true;
            this.listBoxLibrosDisponibles.ItemHeight = 20;
            this.listBoxLibrosDisponibles.Location = new System.Drawing.Point(89, 119);
            this.listBoxLibrosDisponibles.Name = "listBoxLibrosDisponibles";
            this.listBoxLibrosDisponibles.Size = new System.Drawing.Size(770, 324);
            this.listBoxLibrosDisponibles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libros Disponibles en la Biblioteca";
            // 
            // buttonRegresarLibrDispo
            // 
            this.buttonRegresarLibrDispo.Location = new System.Drawing.Point(13, 13);
            this.buttonRegresarLibrDispo.Name = "buttonRegresarLibrDispo";
            this.buttonRegresarLibrDispo.Size = new System.Drawing.Size(100, 34);
            this.buttonRegresarLibrDispo.TabIndex = 2;
            this.buttonRegresarLibrDispo.Text = "Regresar";
            this.buttonRegresarLibrDispo.UseVisualStyleBackColor = true;
            this.buttonRegresarLibrDispo.Click += new System.EventHandler(this.buttonRegresarLibrDispo_Click);
            // 
            // Libros_DisponiblesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 487);
            this.Controls.Add(this.buttonRegresarLibrDispo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLibrosDisponibles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Libros_DisponiblesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libros Disponibles";
            this.Load += new System.EventHandler(this.Libros_DisponiblesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLibrosDisponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegresarLibrDispo;
    }
}