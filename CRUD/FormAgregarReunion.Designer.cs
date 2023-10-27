namespace CRUD {
    partial class FormAgregarReunion {
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            txtFecha = new MaterialSkin.Controls.MaterialTextBox();
            txtHora = new MaterialSkin.Controls.MaterialTextBox();
            txtLugar = new MaterialSkin.Controls.MaterialTextBox();
            txtTema = new MaterialSkin.Controls.MaterialTextBox();
            btnAgregarReunion = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(69, 114);
            materialLabel1.Margin = new Padding(2, 0, 2, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(48, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Fecha:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(78, 212);
            materialLabel2.Margin = new Padding(2, 0, 2, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(39, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Hora:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(71, 311);
            materialLabel3.Margin = new Padding(2, 0, 2, 0);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(46, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Lugar:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(71, 405);
            materialLabel4.Margin = new Padding(2, 0, 2, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(46, 19);
            materialLabel4.TabIndex = 3;
            materialLabel4.Text = "Tema:";
            // 
            // txtFecha
            // 
            txtFecha.AnimateReadOnly = false;
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Depth = 0;
            txtFecha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFecha.LeadingIcon = null;
            txtFecha.Location = new Point(121, 101);
            txtFecha.Margin = new Padding(2, 2, 2, 2);
            txtFecha.MaxLength = 50;
            txtFecha.MouseState = MaterialSkin.MouseState.OUT;
            txtFecha.Multiline = false;
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(236, 50);
            txtFecha.TabIndex = 4;
            txtFecha.Text = "";
            txtFecha.TrailingIcon = null;
            // 
            // txtHora
            // 
            txtHora.AnimateReadOnly = false;
            txtHora.BorderStyle = BorderStyle.None;
            txtHora.Depth = 0;
            txtHora.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHora.LeadingIcon = null;
            txtHora.Location = new Point(121, 197);
            txtHora.Margin = new Padding(2, 2, 2, 2);
            txtHora.MaxLength = 50;
            txtHora.MouseState = MaterialSkin.MouseState.OUT;
            txtHora.Multiline = false;
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(236, 50);
            txtHora.TabIndex = 5;
            txtHora.Text = "";
            txtHora.TrailingIcon = null;
            // 
            // txtLugar
            // 
            txtLugar.AnimateReadOnly = false;
            txtLugar.BorderStyle = BorderStyle.None;
            txtLugar.Depth = 0;
            txtLugar.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLugar.LeadingIcon = null;
            txtLugar.Location = new Point(121, 293);
            txtLugar.Margin = new Padding(2, 2, 2, 2);
            txtLugar.MaxLength = 50;
            txtLugar.MouseState = MaterialSkin.MouseState.OUT;
            txtLugar.Multiline = false;
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(236, 50);
            txtLugar.TabIndex = 6;
            txtLugar.Text = "";
            txtLugar.TrailingIcon = null;
            // 
            // txtTema
            // 
            txtTema.AnimateReadOnly = false;
            txtTema.BorderStyle = BorderStyle.None;
            txtTema.Depth = 0;
            txtTema.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTema.LeadingIcon = null;
            txtTema.Location = new Point(121, 389);
            txtTema.Margin = new Padding(2, 2, 2, 2);
            txtTema.MaxLength = 50;
            txtTema.MouseState = MaterialSkin.MouseState.OUT;
            txtTema.Multiline = false;
            txtTema.Name = "txtTema";
            txtTema.Size = new Size(236, 50);
            txtTema.TabIndex = 7;
            txtTema.Text = "";
            txtTema.TrailingIcon = null;
            // 
            // btnAgregarReunion
            // 
            btnAgregarReunion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarReunion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarReunion.Depth = 0;
            btnAgregarReunion.HighEmphasis = true;
            btnAgregarReunion.Icon = null;
            btnAgregarReunion.Location = new Point(144, 486);
            btnAgregarReunion.Margin = new Padding(2, 3, 2, 3);
            btnAgregarReunion.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarReunion.Name = "btnAgregarReunion";
            btnAgregarReunion.NoAccentTextColor = Color.Empty;
            btnAgregarReunion.Size = new Size(154, 36);
            btnAgregarReunion.TabIndex = 8;
            btnAgregarReunion.Text = "Agregar Reunión";
            btnAgregarReunion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarReunion.UseAccentColor = false;
            btnAgregarReunion.UseVisualStyleBackColor = true;
            btnAgregarReunion.Click += btnAgregarReunion_Click_1;
            // 
            // FormAgregarReunion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 549);
            Controls.Add(btnAgregarReunion);
            Controls.Add(txtTema);
            Controls.Add(txtLugar);
            Controls.Add(txtHora);
            Controls.Add(txtFecha);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormAgregarReunion";
            Padding = new Padding(2, 32, 2, 2);
            Text = "Agregar nueva reunión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox txtFecha;
        private MaterialSkin.Controls.MaterialTextBox txtHora;
        private MaterialSkin.Controls.MaterialTextBox txtLugar;
        private MaterialSkin.Controls.MaterialTextBox txtTema;
        private MaterialSkin.Controls.MaterialButton btnAgregarReunion;
    }
}