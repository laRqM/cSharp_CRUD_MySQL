namespace CRUD {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAlumnoTable = new Button();
            btnReunionesTable = new Button();
            btnInstructoresTable = new Button();
            btnReunionesAgendadasTable = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            actualizarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            reuniónToolStripMenuItem = new ToolStripMenuItem();
            btnStripNuevaReunion = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAlumnoTable
            // 
            btnAlumnoTable.Location = new Point(12, 27);
            btnAlumnoTable.Name = "btnAlumnoTable";
            btnAlumnoTable.Size = new Size(133, 56);
            btnAlumnoTable.TabIndex = 0;
            btnAlumnoTable.Text = "Alumnos";
            btnAlumnoTable.UseVisualStyleBackColor = true;
            btnAlumnoTable.Click += btnAlumnoTable_Click;
            // 
            // btnReunionesTable
            // 
            btnReunionesTable.Location = new Point(12, 144);
            btnReunionesTable.Name = "btnReunionesTable";
            btnReunionesTable.Size = new Size(133, 56);
            btnReunionesTable.TabIndex = 1;
            btnReunionesTable.Text = "Reuniones";
            btnReunionesTable.UseVisualStyleBackColor = true;
            btnReunionesTable.Click += btnReunionesTable_Click;
            // 
            // btnInstructoresTable
            // 
            btnInstructoresTable.Location = new Point(12, 263);
            btnInstructoresTable.Name = "btnInstructoresTable";
            btnInstructoresTable.Size = new Size(133, 56);
            btnInstructoresTable.TabIndex = 2;
            btnInstructoresTable.Text = "Instructores";
            btnInstructoresTable.UseVisualStyleBackColor = true;
            btnInstructoresTable.Click += btnInstructoresTable_Click;
            // 
            // btnReunionesAgendadasTable
            // 
            btnReunionesAgendadasTable.Location = new Point(12, 382);
            btnReunionesAgendadasTable.Name = "btnReunionesAgendadasTable";
            btnReunionesAgendadasTable.Size = new Size(133, 56);
            btnReunionesAgendadasTable.TabIndex = 3;
            btnReunionesAgendadasTable.Text = "Reuniones Agendadas";
            btnReunionesAgendadasTable.UseVisualStyleBackColor = true;
            btnReunionesAgendadasTable.Click += btnReunionesAgendadasTable_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(151, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(637, 411);
            dataGridView1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { actualizarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 48);
            // 
            // actualizarToolStripMenuItem
            // 
            actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            actualizarToolStripMenuItem.Size = new Size(126, 22);
            actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(126, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { reuniónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // reuniónToolStripMenuItem
            // 
            reuniónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnStripNuevaReunion });
            reuniónToolStripMenuItem.Name = "reuniónToolStripMenuItem";
            reuniónToolStripMenuItem.Size = new Size(63, 22);
            reuniónToolStripMenuItem.Text = "Reunión";
            // 
            // btnStripNuevaReunion
            // 
            btnStripNuevaReunion.Name = "btnStripNuevaReunion";
            btnStripNuevaReunion.Size = new Size(155, 22);
            btnStripNuevaReunion.Text = "Nueva Reunión";
            btnStripNuevaReunion.Click += btnStripNuevaReunion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(btnReunionesAgendadasTable);
            Controls.Add(btnInstructoresTable);
            Controls.Add(btnReunionesTable);
            Controls.Add(btnAlumnoTable);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "CRUD usando C# and MySQL";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlumnoTable;
        private Button btnReunionesTable;
        private Button btnInstructoresTable;
        private Button btnReunionesAgendadasTable;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reuniónToolStripMenuItem;
        private ToolStripMenuItem btnStripNuevaReunion;
    }
}