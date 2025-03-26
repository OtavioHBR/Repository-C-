namespace Form_PIM.Cadastro
{
    partial class Produto
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
            menuFuncionario = new MenuStrip();
            tABELADEFUNCIONÁRIOSToolStripMenuItem = new ToolStripMenuItem();
            eNTRADADEPRODUTOSToolStripMenuItem = new ToolStripMenuItem();
            sAÍDADEPRODUTOSToolStripMenuItem = new ToolStripMenuItem();
            vOLTARToolStripMenuItem = new ToolStripMenuItem();
            btnConfirmAdd = new Button();
            btnCancelAdd = new Button();
            btnCancelDel = new Button();
            btnConfirmDel = new Button();
            groupEdit = new GroupBox();
            mtbValCompEdit = new MaskedTextBox();
            txtNomeEdit = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtIdFornEdit = new TextBox();
            mtbValVendaEdit = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            txtIdEdit = new TextBox();
            button7 = new Button();
            label11 = new Label();
            btnConfirmEdit = new Button();
            btnCancelEdit = new Button();
            button5 = new Button();
            button6 = new Button();
            groupAdd = new GroupBox();
            txtIdFornAdd = new TextBox();
            mtbValVendaAdd = new MaskedTextBox();
            mtbValCompAdd = new MaskedTextBox();
            txtNomeAdd = new TextBox();
            label13 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupDelete = new GroupBox();
            txtIdDel = new TextBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            menuFuncionario.SuspendLayout();
            groupEdit.SuspendLayout();
            groupAdd.SuspendLayout();
            groupDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuFuncionario
            // 
            menuFuncionario.BackColor = Color.Transparent;
            menuFuncionario.Font = new Font("Arial", 9F);
            menuFuncionario.Items.AddRange(new ToolStripItem[] { tABELADEFUNCIONÁRIOSToolStripMenuItem, eNTRADADEPRODUTOSToolStripMenuItem, sAÍDADEPRODUTOSToolStripMenuItem, vOLTARToolStripMenuItem });
            menuFuncionario.Location = new Point(0, 0);
            menuFuncionario.Name = "menuFuncionario";
            menuFuncionario.Size = new Size(1684, 25);
            menuFuncionario.TabIndex = 0;
            menuFuncionario.Text = "menuStrip1";
            // 
            // tABELADEFUNCIONÁRIOSToolStripMenuItem
            // 
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Name = "tABELADEFUNCIONÁRIOSToolStripMenuItem";
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Size = new Size(152, 21);
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Text = "TABELA DE PRODUTOS";
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Click += tABELADEFUNCIONÁRIOSToolStripMenuItem_Click;
            // 
            // eNTRADADEPRODUTOSToolStripMenuItem
            // 
            eNTRADADEPRODUTOSToolStripMenuItem.Name = "eNTRADADEPRODUTOSToolStripMenuItem";
            eNTRADADEPRODUTOSToolStripMenuItem.Size = new Size(165, 21);
            eNTRADADEPRODUTOSToolStripMenuItem.Text = "ENTRADA DE PRODUTOS";
            eNTRADADEPRODUTOSToolStripMenuItem.Click += eNTRADADEPRODUTOSToolStripMenuItem_Click;
            // 
            // sAÍDADEPRODUTOSToolStripMenuItem
            // 
            sAÍDADEPRODUTOSToolStripMenuItem.Name = "sAÍDADEPRODUTOSToolStripMenuItem";
            sAÍDADEPRODUTOSToolStripMenuItem.Size = new Size(143, 21);
            sAÍDADEPRODUTOSToolStripMenuItem.Text = "SAÍDA DE PRODUTOS";
            sAÍDADEPRODUTOSToolStripMenuItem.Click += sAÍDADEPRODUTOSToolStripMenuItem_Click;
            // 
            // vOLTARToolStripMenuItem
            // 
            vOLTARToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vOLTARToolStripMenuItem.Name = "vOLTARToolStripMenuItem";
            vOLTARToolStripMenuItem.Size = new Size(105, 21);
            vOLTARToolStripMenuItem.Text = "<<VOLTAR>>";
            vOLTARToolStripMenuItem.Click += vOLTARToolStripMenuItem_Click;
            // 
            // btnConfirmAdd
            // 
            btnConfirmAdd.Anchor = AnchorStyles.Bottom;
            btnConfirmAdd.BackColor = Color.FromArgb(192, 192, 0);
            btnConfirmAdd.Cursor = Cursors.Hand;
            btnConfirmAdd.FlatStyle = FlatStyle.Popup;
            btnConfirmAdd.Font = new Font("Arial", 12F);
            btnConfirmAdd.Location = new Point(568, 657);
            btnConfirmAdd.Name = "btnConfirmAdd";
            btnConfirmAdd.Size = new Size(100, 34);
            btnConfirmAdd.TabIndex = 5;
            btnConfirmAdd.Text = "Confirmar";
            btnConfirmAdd.UseVisualStyleBackColor = false;
            btnConfirmAdd.Click += btnConfirmAdd_Click;
            // 
            // btnCancelAdd
            // 
            btnCancelAdd.Anchor = AnchorStyles.Bottom;
            btnCancelAdd.BackColor = Color.Red;
            btnCancelAdd.FlatStyle = FlatStyle.Popup;
            btnCancelAdd.Font = new Font("Arial", 12F);
            btnCancelAdd.Location = new Point(462, 657);
            btnCancelAdd.Name = "btnCancelAdd";
            btnCancelAdd.Size = new Size(100, 34);
            btnCancelAdd.TabIndex = 4;
            btnCancelAdd.Text = "Cancelar";
            btnCancelAdd.UseVisualStyleBackColor = false;
            btnCancelAdd.Click += btnCancelAdd_Click;
            // 
            // btnCancelDel
            // 
            btnCancelDel.Anchor = AnchorStyles.Bottom;
            btnCancelDel.BackColor = Color.Red;
            btnCancelDel.FlatStyle = FlatStyle.Popup;
            btnCancelDel.Font = new Font("Arial", 12F);
            btnCancelDel.Location = new Point(672, 116);
            btnCancelDel.Name = "btnCancelDel";
            btnCancelDel.Size = new Size(100, 34);
            btnCancelDel.TabIndex = 1;
            btnCancelDel.Text = "Cancelar";
            btnCancelDel.UseVisualStyleBackColor = false;
            btnCancelDel.Click += btnCancelDel_Click;
            // 
            // btnConfirmDel
            // 
            btnConfirmDel.Anchor = AnchorStyles.Bottom;
            btnConfirmDel.BackColor = Color.FromArgb(192, 192, 0);
            btnConfirmDel.Cursor = Cursors.Hand;
            btnConfirmDel.FlatStyle = FlatStyle.Popup;
            btnConfirmDel.Font = new Font("Arial", 12F);
            btnConfirmDel.Location = new Point(778, 116);
            btnConfirmDel.Name = "btnConfirmDel";
            btnConfirmDel.Size = new Size(100, 34);
            btnConfirmDel.TabIndex = 2;
            btnConfirmDel.Text = "Confirmar";
            btnConfirmDel.UseVisualStyleBackColor = false;
            btnConfirmDel.Click += btnConfirmDel_Click;
            // 
            // groupEdit
            // 
            groupEdit.Controls.Add(mtbValCompEdit);
            groupEdit.Controls.Add(txtNomeEdit);
            groupEdit.Controls.Add(label7);
            groupEdit.Controls.Add(label8);
            groupEdit.Controls.Add(txtIdFornEdit);
            groupEdit.Controls.Add(mtbValVendaEdit);
            groupEdit.Controls.Add(label4);
            groupEdit.Controls.Add(label5);
            groupEdit.Controls.Add(txtIdEdit);
            groupEdit.Controls.Add(button7);
            groupEdit.Controls.Add(label11);
            groupEdit.Controls.Add(btnConfirmEdit);
            groupEdit.Controls.Add(btnCancelEdit);
            groupEdit.Controls.Add(button5);
            groupEdit.Controls.Add(button6);
            groupEdit.Dock = DockStyle.Right;
            groupEdit.Font = new Font("Arial", 12F);
            groupEdit.Location = new Point(1130, 25);
            groupEdit.Name = "groupEdit";
            groupEdit.Size = new Size(554, 1006);
            groupEdit.TabIndex = 2;
            groupEdit.TabStop = false;
            groupEdit.Text = "Editar";
            // 
            // mtbValCompEdit
            // 
            mtbValCompEdit.Cursor = Cursors.IBeam;
            mtbValCompEdit.InsertKeyMode = InsertKeyMode.Overwrite;
            mtbValCompEdit.Location = new Point(330, 346);
            mtbValCompEdit.Mask = "$000";
            mtbValCompEdit.Name = "mtbValCompEdit";
            mtbValCompEdit.RightToLeft = RightToLeft.No;
            mtbValCompEdit.Size = new Size(123, 26);
            mtbValCompEdit.TabIndex = 3;
            // 
            // txtNomeEdit
            // 
            txtNomeEdit.Location = new Point(330, 158);
            txtNomeEdit.Name = "txtNomeEdit";
            txtNomeEdit.Size = new Size(124, 26);
            txtNomeEdit.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(330, 256);
            label7.Name = "label7";
            label7.Size = new Size(127, 18);
            label7.TabIndex = 35;
            label7.Text = "Valor de Compra";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(330, 68);
            label8.Name = "label8";
            label8.Size = new Size(50, 18);
            label8.TabIndex = 34;
            label8.Text = "Nome";
            // 
            // txtIdFornEdit
            // 
            txtIdFornEdit.Location = new Point(85, 346);
            txtIdFornEdit.Name = "txtIdFornEdit";
            txtIdFornEdit.Size = new Size(124, 26);
            txtIdFornEdit.TabIndex = 2;
            // 
            // mtbValVendaEdit
            // 
            mtbValVendaEdit.Cursor = Cursors.IBeam;
            mtbValVendaEdit.Location = new Point(85, 534);
            mtbValVendaEdit.Mask = "$000";
            mtbValVendaEdit.Name = "mtbValVendaEdit";
            mtbValVendaEdit.RightToLeft = RightToLeft.No;
            mtbValVendaEdit.Size = new Size(123, 26);
            mtbValVendaEdit.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(82, 444);
            label4.Name = "label4";
            label4.Size = new Size(115, 18);
            label4.TabIndex = 29;
            label4.Text = "Valor de Venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(82, 256);
            label5.Name = "label5";
            label5.Size = new Size(127, 18);
            label5.TabIndex = 28;
            label5.Text = "Id do Fornecedor";
            // 
            // txtIdEdit
            // 
            txtIdEdit.Location = new Point(82, 158);
            txtIdEdit.Name = "txtIdEdit";
            txtIdEdit.Size = new Size(124, 26);
            txtIdEdit.TabIndex = 0;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom;
            button7.BackColor = Color.Red;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Arial", 12F);
            button7.Location = new Point(-668, 817);
            button7.Name = "button7";
            button7.Size = new Size(100, 34);
            button7.TabIndex = 4;
            button7.Text = "Cancelar";
            button7.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F);
            label11.Location = new Point(82, 50);
            label11.Name = "label11";
            label11.Size = new Size(103, 36);
            label11.TabIndex = 10;
            label11.Text = "ID de quem \r\ndeseja alterar";
            // 
            // btnConfirmEdit
            // 
            btnConfirmEdit.Anchor = AnchorStyles.Bottom;
            btnConfirmEdit.BackColor = Color.FromArgb(192, 192, 0);
            btnConfirmEdit.Cursor = Cursors.Hand;
            btnConfirmEdit.FlatStyle = FlatStyle.Popup;
            btnConfirmEdit.Location = new Point(280, 856);
            btnConfirmEdit.Name = "btnConfirmEdit";
            btnConfirmEdit.Size = new Size(100, 34);
            btnConfirmEdit.TabIndex = 6;
            btnConfirmEdit.Text = "Confirmar";
            btnConfirmEdit.UseVisualStyleBackColor = false;
            btnConfirmEdit.Click += btnConfirmEdit_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Anchor = AnchorStyles.Bottom;
            btnCancelEdit.BackColor = Color.Red;
            btnCancelEdit.FlatStyle = FlatStyle.Popup;
            btnCancelEdit.Location = new Point(174, 856);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(100, 34);
            btnCancelEdit.TabIndex = 5;
            btnCancelEdit.Text = "Cancelar";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom;
            button5.BackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(-425, 948);
            button5.Name = "button5";
            button5.Size = new Size(100, 34);
            button5.TabIndex = 4;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom;
            button6.BackColor = Color.FromArgb(192, 192, 0);
            button6.Cursor = Cursors.Hand;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(-319, 948);
            button6.Name = "button6";
            button6.Size = new Size(100, 34);
            button6.TabIndex = 3;
            button6.Text = "Confirmar";
            button6.UseVisualStyleBackColor = false;
            // 
            // groupAdd
            // 
            groupAdd.Controls.Add(txtIdFornAdd);
            groupAdd.Controls.Add(mtbValVendaAdd);
            groupAdd.Controls.Add(mtbValCompAdd);
            groupAdd.Controls.Add(txtNomeAdd);
            groupAdd.Controls.Add(label13);
            groupAdd.Controls.Add(label3);
            groupAdd.Controls.Add(label2);
            groupAdd.Controls.Add(label1);
            groupAdd.Controls.Add(btnCancelAdd);
            groupAdd.Controls.Add(btnConfirmAdd);
            groupAdd.Dock = DockStyle.Top;
            groupAdd.Font = new Font("Arial", 12F);
            groupAdd.Location = new Point(0, 25);
            groupAdd.Name = "groupAdd";
            groupAdd.Size = new Size(1130, 740);
            groupAdd.TabIndex = 0;
            groupAdd.TabStop = false;
            groupAdd.Text = "Adicionar";
            // 
            // txtIdFornAdd
            // 
            txtIdFornAdd.Location = new Point(660, 237);
            txtIdFornAdd.Name = "txtIdFornAdd";
            txtIdFornAdd.Size = new Size(124, 26);
            txtIdFornAdd.TabIndex = 1;
            // 
            // mtbValVendaAdd
            // 
            mtbValVendaAdd.Cursor = Cursors.IBeam;
            mtbValVendaAdd.Location = new Point(660, 413);
            mtbValVendaAdd.Mask = "$000";
            mtbValVendaAdd.Name = "mtbValVendaAdd";
            mtbValVendaAdd.RightToLeft = RightToLeft.No;
            mtbValVendaAdd.Size = new Size(123, 26);
            mtbValVendaAdd.TabIndex = 3;
            // 
            // mtbValCompAdd
            // 
            mtbValCompAdd.Cursor = Cursors.IBeam;
            mtbValCompAdd.InsertKeyMode = InsertKeyMode.Overwrite;
            mtbValCompAdd.Location = new Point(341, 413);
            mtbValCompAdd.Mask = "$000";
            mtbValCompAdd.Name = "mtbValCompAdd";
            mtbValCompAdd.RightToLeft = RightToLeft.No;
            mtbValCompAdd.Size = new Size(123, 26);
            mtbValCompAdd.TabIndex = 2;
            // 
            // txtNomeAdd
            // 
            txtNomeAdd.Location = new Point(341, 239);
            txtNomeAdd.Name = "txtNomeAdd";
            txtNomeAdd.Size = new Size(124, 26);
            txtNomeAdd.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F);
            label13.Location = new Point(341, 344);
            label13.Name = "label13";
            label13.Size = new Size(127, 18);
            label13.TabIndex = 8;
            label13.Text = "Valor de Compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(657, 344);
            label3.Name = "label3";
            label3.Size = new Size(115, 18);
            label3.TabIndex = 5;
            label3.Text = "Valor de Venda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(657, 183);
            label2.Name = "label2";
            label2.Size = new Size(127, 18);
            label2.TabIndex = 4;
            label2.Text = "Id do Fornecedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(341, 183);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // groupDelete
            // 
            groupDelete.Controls.Add(txtIdDel);
            groupDelete.Controls.Add(label6);
            groupDelete.Controls.Add(btnCancelDel);
            groupDelete.Controls.Add(btnConfirmDel);
            groupDelete.Controls.Add(dataGridView1);
            groupDelete.Dock = DockStyle.Fill;
            groupDelete.Location = new Point(0, 765);
            groupDelete.Name = "groupDelete";
            groupDelete.Size = new Size(1130, 266);
            groupDelete.TabIndex = 1;
            groupDelete.TabStop = false;
            groupDelete.Text = "Excluir";
            // 
            // txtIdDel
            // 
            txtIdDel.Location = new Point(289, 148);
            txtIdDel.Name = "txtIdDel";
            txtIdDel.Size = new Size(124, 23);
            txtIdDel.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(264, 86);
            label6.Name = "label6";
            label6.Size = new Size(187, 18);
            label6.TabIndex = 5;
            label6.Text = "ID de quem deseja excluir";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, -10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(10, 10);
            dataGridView1.TabIndex = 16;
            // 
            // Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1684, 1031);
            ControlBox = false;
            Controls.Add(groupDelete);
            Controls.Add(groupAdd);
            Controls.Add(groupEdit);
            Controls.Add(menuFuncionario);
            Name = "Produto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produto";
            WindowState = FormWindowState.Maximized;
            menuFuncionario.ResumeLayout(false);
            menuFuncionario.PerformLayout();
            groupEdit.ResumeLayout(false);
            groupEdit.PerformLayout();
            groupAdd.ResumeLayout(false);
            groupAdd.PerformLayout();
            groupDelete.ResumeLayout(false);
            groupDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuFuncionario;
        private ToolStripMenuItem vOLTARToolStripMenuItem;
        private Button btnConfirmAdd;
        private Button btnCancelAdd;
        private GroupBox groupEdit;
        private GroupBox groupAdd;
        private Button btnCancelEdit;
        private Button btnConfirmEdit;
        private Button btnCancelDel;
        private Button btnConfirmDel;
        private Button button5;
        private Button button6;
        private GroupBox groupDelete;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label13;
        private Label label11;
        private MaskedTextBox mtbValCompAdd;
        private TextBox txtNomeAdd;
        private MaskedTextBox mtbDCEdit;
        private DateTimePicker dateTimePickerAdd;
        private Button button7;
        private DataGridView dataGridView1;
        private ToolStripMenuItem tABELADEFUNCIONÁRIOSToolStripMenuItem;
        private MaskedTextBox mtbValVendaAdd;
        private TextBox txtIdFornAdd;
        private TextBox txtIdEdit;
        private TextBox txtIdDel;
        private ToolStripMenuItem eNTRADADEPRODUTOSToolStripMenuItem;
        private ToolStripMenuItem sAÍDADEPRODUTOSToolStripMenuItem;
        private MaskedTextBox mtbValCompEdit;
        private TextBox txtNomeEdit;
        private Label label7;
        private Label label8;
        private TextBox txtIdFornEdit;
        private MaskedTextBox mtbValVendaEdit;
        private Label label4;
    }
}