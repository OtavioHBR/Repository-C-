namespace Form_PIM.Cadastro
{
    partial class Cliente
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
            vOLTARToolStripMenuItem = new ToolStripMenuItem();
            btnConfirmAdd = new Button();
            btnCancelAdd = new Button();
            btnCancelDel = new Button();
            btnConfirmDel = new Button();
            groupEdit = new GroupBox();
            txtEmailEdit = new TextBox();
            label7 = new Label();
            txtEndEdit = new TextBox();
            button7 = new Button();
            mtbTelEdit = new MaskedTextBox();
            mtbCpfEdit = new MaskedTextBox();
            label9 = new Label();
            label10 = new Label();
            txtNomeEdit = new TextBox();
            label11 = new Label();
            btnConfirmEdit = new Button();
            btnCancelEdit = new Button();
            label12 = new Label();
            button5 = new Button();
            button6 = new Button();
            groupAdd = new GroupBox();
            txtEndAdd = new TextBox();
            txtEmailAdd = new TextBox();
            mtbCpfAdd = new MaskedTextBox();
            mtbTelAdd = new MaskedTextBox();
            txtNomeAdd = new TextBox();
            label13 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupDelete = new GroupBox();
            mtbCpfDel = new MaskedTextBox();
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
            menuFuncionario.Items.AddRange(new ToolStripItem[] { tABELADEFUNCIONÁRIOSToolStripMenuItem, vOLTARToolStripMenuItem });
            menuFuncionario.Location = new Point(0, 0);
            menuFuncionario.Name = "menuFuncionario";
            menuFuncionario.Size = new Size(1684, 25);
            menuFuncionario.TabIndex = 0;
            menuFuncionario.Text = "menuStrip1";
            // 
            // tABELADEFUNCIONÁRIOSToolStripMenuItem
            // 
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Name = "tABELADEFUNCIONÁRIOSToolStripMenuItem";
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Size = new Size(143, 21);
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Text = "TABELA DE CLIENTES";
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Click += tABELADEFUNCIONÁRIOSToolStripMenuItem_Click;
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
            btnConfirmAdd.TabIndex = 6;
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
            btnCancelAdd.TabIndex = 5;
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
            groupEdit.Controls.Add(txtEmailEdit);
            groupEdit.Controls.Add(label7);
            groupEdit.Controls.Add(txtEndEdit);
            groupEdit.Controls.Add(button7);
            groupEdit.Controls.Add(mtbTelEdit);
            groupEdit.Controls.Add(mtbCpfEdit);
            groupEdit.Controls.Add(label9);
            groupEdit.Controls.Add(label10);
            groupEdit.Controls.Add(txtNomeEdit);
            groupEdit.Controls.Add(label11);
            groupEdit.Controls.Add(btnConfirmEdit);
            groupEdit.Controls.Add(btnCancelEdit);
            groupEdit.Controls.Add(label12);
            groupEdit.Controls.Add(button5);
            groupEdit.Controls.Add(button6);
            groupEdit.Dock = DockStyle.Right;
            groupEdit.Font = new Font("Arial", 12F);
            groupEdit.Location = new Point(1130, 25);
            groupEdit.Name = "groupEdit";
            groupEdit.Size = new Size(554, 1006);
            groupEdit.TabIndex = 3;
            groupEdit.TabStop = false;
            groupEdit.Text = "Editar";
            // 
            // txtEmailEdit
            // 
            txtEmailEdit.Location = new Point(215, 689);
            txtEmailEdit.Name = "txtEmailEdit";
            txtEmailEdit.Size = new Size(124, 26);
            txtEmailEdit.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(215, 564);
            label7.Name = "label7";
            label7.Size = new Size(48, 18);
            label7.TabIndex = 24;
            label7.Text = "Email";
            // 
            // txtEndEdit
            // 
            txtEndEdit.Location = new Point(357, 448);
            txtEndEdit.Name = "txtEndEdit";
            txtEndEdit.Size = new Size(124, 26);
            txtEndEdit.TabIndex = 3;
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
            // mtbTelEdit
            // 
            mtbTelEdit.Location = new Point(82, 448);
            mtbTelEdit.Mask = "(99) 00000-0000";
            mtbTelEdit.Name = "mtbTelEdit";
            mtbTelEdit.Size = new Size(124, 26);
            mtbTelEdit.TabIndex = 2;
            // 
            // mtbCpfEdit
            // 
            mtbCpfEdit.Culture = new System.Globalization.CultureInfo("en-US");
            mtbCpfEdit.Location = new Point(82, 175);
            mtbCpfEdit.Mask = "000.000.000-00";
            mtbCpfEdit.Name = "mtbCpfEdit";
            mtbCpfEdit.Size = new Size(124, 26);
            mtbCpfEdit.TabIndex = 0;
            mtbCpfEdit.ValidatingType = typeof(DateTime);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F);
            label9.Location = new Point(357, 323);
            label9.Name = "label9";
            label9.Size = new Size(76, 18);
            label9.TabIndex = 12;
            label9.Text = "Endereço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F);
            label10.Location = new Point(82, 323);
            label10.Name = "label10";
            label10.Size = new Size(66, 18);
            label10.TabIndex = 11;
            label10.Text = "Telefone";
            // 
            // txtNomeEdit
            // 
            txtNomeEdit.Location = new Point(357, 175);
            txtNomeEdit.Name = "txtNomeEdit";
            txtNomeEdit.Size = new Size(124, 26);
            txtNomeEdit.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F);
            label11.Location = new Point(82, 50);
            label11.Name = "label11";
            label11.Size = new Size(110, 36);
            label11.TabIndex = 10;
            label11.Text = "CPF de quem \r\ndeseja alterar";
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F);
            label12.Location = new Point(357, 50);
            label12.Name = "label12";
            label12.Size = new Size(50, 18);
            label12.TabIndex = 9;
            label12.Text = "Nome";
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
            groupAdd.Controls.Add(txtEndAdd);
            groupAdd.Controls.Add(txtEmailAdd);
            groupAdd.Controls.Add(mtbCpfAdd);
            groupAdd.Controls.Add(mtbTelAdd);
            groupAdd.Controls.Add(txtNomeAdd);
            groupAdd.Controls.Add(label13);
            groupAdd.Controls.Add(label4);
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
            // txtEndAdd
            // 
            txtEndAdd.Location = new Point(498, 255);
            txtEndAdd.Name = "txtEndAdd";
            txtEndAdd.Size = new Size(123, 26);
            txtEndAdd.TabIndex = 4;
            // 
            // txtEmailAdd
            // 
            txtEmailAdd.Location = new Point(182, 255);
            txtEmailAdd.Name = "txtEmailAdd";
            txtEmailAdd.Size = new Size(124, 26);
            txtEmailAdd.TabIndex = 3;
            // 
            // mtbCpfAdd
            // 
            mtbCpfAdd.Culture = new System.Globalization.CultureInfo("en-US");
            mtbCpfAdd.Cursor = Cursors.IBeam;
            mtbCpfAdd.Location = new Point(498, 85);
            mtbCpfAdd.Mask = "000.000.000-00";
            mtbCpfAdd.Name = "mtbCpfAdd";
            mtbCpfAdd.RightToLeft = RightToLeft.No;
            mtbCpfAdd.Size = new Size(123, 26);
            mtbCpfAdd.TabIndex = 1;
            // 
            // mtbTelAdd
            // 
            mtbTelAdd.Cursor = Cursors.IBeam;
            mtbTelAdd.InsertKeyMode = InsertKeyMode.Overwrite;
            mtbTelAdd.Location = new Point(795, 91);
            mtbTelAdd.Mask = "(99) 00000-0000";
            mtbTelAdd.Name = "mtbTelAdd";
            mtbTelAdd.RightToLeft = RightToLeft.No;
            mtbTelAdd.Size = new Size(123, 26);
            mtbTelAdd.TabIndex = 2;
            // 
            // txtNomeAdd
            // 
            txtNomeAdd.Location = new Point(182, 93);
            txtNomeAdd.Name = "txtNomeAdd";
            txtNomeAdd.Size = new Size(124, 26);
            txtNomeAdd.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F);
            label13.Location = new Point(795, 37);
            label13.Name = "label13";
            label13.Size = new Size(66, 18);
            label13.TabIndex = 8;
            label13.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(498, 196);
            label4.Name = "label4";
            label4.Size = new Size(76, 18);
            label4.TabIndex = 6;
            label4.Text = "Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(182, 196);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(498, 37);
            label2.Name = "label2";
            label2.Size = new Size(41, 18);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(182, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // groupDelete
            // 
            groupDelete.Controls.Add(mtbCpfDel);
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
            // mtbCpfDel
            // 
            mtbCpfDel.Culture = new System.Globalization.CultureInfo("en-US");
            mtbCpfDel.Cursor = Cursors.IBeam;
            mtbCpfDel.Location = new Point(303, 124);
            mtbCpfDel.Mask = "000.000.000-00";
            mtbCpfDel.Name = "mtbCpfDel";
            mtbCpfDel.RightToLeft = RightToLeft.No;
            mtbCpfDel.Size = new Size(123, 23);
            mtbCpfDel.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(264, 86);
            label6.Name = "label6";
            label6.Size = new Size(205, 18);
            label6.TabIndex = 5;
            label6.Text = "CPF de quem deseja excluir";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, -10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(10, 10);
            dataGridView1.TabIndex = 16;
            // 
            // Cliente
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
            MainMenuStrip = menuFuncionario;
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label12;
        private MaskedTextBox mtbTelAdd;
        private TextBox txtNomeAdd;
        private MaskedTextBox mtbDCEdit;
        private MaskedTextBox mtbTelEdit;
        private MaskedTextBox mtbCpfEdit;
        private TextBox txtNomeEdit;
        private DateTimePicker dateTimePickerAdd;
        private Button button7;
        private DataGridView dataGridView1;
        private ToolStripMenuItem tABELADEFUNCIONÁRIOSToolStripMenuItem;
        private MaskedTextBox mtbCpfAdd;
        private TextBox txtEndAdd;
        private TextBox txtEmailAdd;
        private TextBox txtEndEdit;
        private Label label9;
        private TextBox txtEmailEdit;
        private Label label7;
        private MaskedTextBox mtbCpfDel;
    }
}