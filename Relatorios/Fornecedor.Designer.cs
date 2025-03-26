namespace Form_PIM.Relatorios
{
    partial class Fornecedor
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
            menuStrip1 = new MenuStrip();
            fUNCIONÁRIOSToolStripMenuItem = new ToolStripMenuItem();
            vOLTARToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fUNCIONÁRIOSToolStripMenuItem, vOLTARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1684, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fUNCIONÁRIOSToolStripMenuItem
            // 
            fUNCIONÁRIOSToolStripMenuItem.Font = new Font("Arial", 9F);
            fUNCIONÁRIOSToolStripMenuItem.Name = "fUNCIONÁRIOSToolStripMenuItem";
            fUNCIONÁRIOSToolStripMenuItem.Size = new Size(209, 20);
            fUNCIONÁRIOSToolStripMenuItem.Text = "CADASTRO DE FORNECEDORES";
            fUNCIONÁRIOSToolStripMenuItem.Click += fUNCIONÁRIOSToolStripMenuItem_Click;
            // 
            // vOLTARToolStripMenuItem
            // 
            vOLTARToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vOLTARToolStripMenuItem.Name = "vOLTARToolStripMenuItem";
            vOLTARToolStripMenuItem.Size = new Size(102, 20);
            vOLTARToolStripMenuItem.Text = "<<VOLTAR>>";
            vOLTARToolStripMenuItem.Click += vOLTARToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1684, 1007);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1684, 1031);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1700, 1070);
            MinimumSize = new Size(1678, 1000);
            Name = "Fornecedor";
            Text = "Fornecedor";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fUNCIONÁRIOSToolStripMenuItem;
        private ToolStripMenuItem vOLTARToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}