namespace Form_PIM.Estoque
{
    partial class EntradaEstoque
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
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtQtd = new TextBox();
            btnCancel = new Button();
            btnVerif = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            cADASTRODEPRODUTOSToolStripMenuItem = new ToolStripMenuItem();
            tABELADEPRODUTOSToolStripMenuItem = new ToolStripMenuItem();
            vOLTARToolStripMenuItem = new ToolStripMenuItem();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(330, 115);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.Size = new Size(154, 26);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 18);
            label1.TabIndex = 1;
            label1.Text = "Id do produto à ser adicionado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 287);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 2;
            label2.Text = "Quantidade";
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(330, 279);
            txtQtd.Margin = new Padding(4);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(154, 26);
            txtQtd.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(154, 369);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 38);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnVerif
            // 
            btnVerif.BackColor = Color.FromArgb(192, 192, 0);
            btnVerif.FlatStyle = FlatStyle.Popup;
            btnVerif.Location = new Point(501, 185);
            btnVerif.Name = "btnVerif";
            btnVerif.Size = new Size(91, 48);
            btnVerif.TabIndex = 2;
            btnVerif.Text = "Verificar\r\nProduto";
            btnVerif.UseVisualStyleBackColor = false;
            btnVerif.Click += btnConfirm_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 197);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 26);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 205);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 18);
            label3.TabIndex = 7;
            label3.Text = "Nome do Produto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, -8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(10, 10);
            dataGridView1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Arial", 10F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cADASTRODEPRODUTOSToolStripMenuItem, tABELADEPRODUTOSToolStripMenuItem, vOLTARToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(658, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // cADASTRODEPRODUTOSToolStripMenuItem
            // 
            cADASTRODEPRODUTOSToolStripMenuItem.Name = "cADASTRODEPRODUTOSToolStripMenuItem";
            cADASTRODEPRODUTOSToolStripMenuItem.Size = new Size(201, 20);
            cADASTRODEPRODUTOSToolStripMenuItem.Text = "CADASTRO DE PRODUTOS";
            cADASTRODEPRODUTOSToolStripMenuItem.Click += cADASTRODEPRODUTOSToolStripMenuItem_Click;
            // 
            // tABELADEPRODUTOSToolStripMenuItem
            // 
            tABELADEPRODUTOSToolStripMenuItem.Name = "tABELADEPRODUTOSToolStripMenuItem";
            tABELADEPRODUTOSToolStripMenuItem.Size = new Size(175, 20);
            tABELADEPRODUTOSToolStripMenuItem.Text = "TABELA DE PRODUTOS";
            tABELADEPRODUTOSToolStripMenuItem.Click += tABELADEPRODUTOSToolStripMenuItem_Click;
            // 
            // vOLTARToolStripMenuItem
            // 
            vOLTARToolStripMenuItem.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vOLTARToolStripMenuItem.Name = "vOLTARToolStripMenuItem";
            vOLTARToolStripMenuItem.Size = new Size(102, 20);
            vOLTARToolStripMenuItem.Text = "<<VOLTAR>>";
            vOLTARToolStripMenuItem.Click += vOLTARToolStripMenuItem_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(192, 192, 0);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Location = new Point(330, 369);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(91, 38);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Confirmar";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // EntradaEstoque
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(658, 508);
            ControlBox = false;
            Controls.Add(btnConfirm);
            Controls.Add(menuStrip1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btnVerif);
            Controls.Add(btnCancel);
            Controls.Add(txtQtd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "EntradaEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtQtd;
        private Button btnCancel;
        private Button btnVerif;
        private TextBox textBox1;
        private Label label3;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cADASTRODEPRODUTOSToolStripMenuItem;
        private ToolStripMenuItem tABELADEPRODUTOSToolStripMenuItem;
        private ToolStripMenuItem vOLTARToolStripMenuItem;
        private Button btnConfirm;
    }
}