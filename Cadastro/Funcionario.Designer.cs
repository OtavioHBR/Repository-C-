namespace Form_PIM.Cadastro
{
    partial class Funcionario
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
            txtIdEdit = new TextBox();
            label14 = new Label();
            button7 = new Button();
            dateTimePickerEdit = new DateTimePicker();
            mtbSalEdit = new MaskedTextBox();
            label7 = new Label();
            mtbHSEdit = new MaskedTextBox();
            label8 = new Label();
            mtbHEEdit = new MaskedTextBox();
            label9 = new Label();
            txtProfEdit = new TextBox();
            label10 = new Label();
            txtNomeEdit = new TextBox();
            label11 = new Label();
            btnConfirmEdit = new Button();
            btnCancelEdit = new Button();
            label12 = new Label();
            button5 = new Button();
            button6 = new Button();
            groupAdd = new GroupBox();
            dateTimePickerAdd = new DateTimePicker();
            mtbSalAdd = new MaskedTextBox();
            mtbHSAdd = new MaskedTextBox();
            mtbHEAdd = new MaskedTextBox();
            txtCargoAdd = new TextBox();
            txtNomeAdd = new TextBox();
            label13 = new Label();
            label5 = new Label();
            label4 = new Label();
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
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Size = new Size(175, 21);
            tABELADEFUNCIONÁRIOSToolStripMenuItem.Text = "TABELA DE FUNCIONÁRIOS";
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
            btnConfirmAdd.TabIndex = 7;
            btnConfirmAdd.Text = "Confirmar";
            btnConfirmAdd.UseVisualStyleBackColor = false;
            btnConfirmAdd.Click += btnConfirm_Click;
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
            btnCancelAdd.TabIndex = 6;
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
            groupEdit.Controls.Add(txtIdEdit);
            groupEdit.Controls.Add(label14);
            groupEdit.Controls.Add(button7);
            groupEdit.Controls.Add(dateTimePickerEdit);
            groupEdit.Controls.Add(mtbSalEdit);
            groupEdit.Controls.Add(label7);
            groupEdit.Controls.Add(mtbHSEdit);
            groupEdit.Controls.Add(label8);
            groupEdit.Controls.Add(mtbHEEdit);
            groupEdit.Controls.Add(label9);
            groupEdit.Controls.Add(txtProfEdit);
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
            groupEdit.TabIndex = 1;
            groupEdit.TabStop = false;
            groupEdit.Text = "Editar";
            // 
            // txtIdEdit
            // 
            txtIdEdit.Location = new Point(215, 142);
            txtIdEdit.Name = "txtIdEdit";
            txtIdEdit.Size = new Size(124, 26);
            txtIdEdit.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(185, 93);
            label14.Name = "label14";
            label14.Size = new Size(184, 18);
            label14.TabIndex = 22;
            label14.Text = "Id de quem deseja alterar";
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
            // dateTimePickerEdit
            // 
            dateTimePickerEdit.Location = new Point(82, 701);
            dateTimePickerEdit.Name = "dateTimePickerEdit";
            dateTimePickerEdit.Size = new Size(124, 26);
            dateTimePickerEdit.TabIndex = 5;
            // 
            // mtbSalEdit
            // 
            mtbSalEdit.Location = new Point(350, 701);
            mtbSalEdit.Mask = "$00000";
            mtbSalEdit.Name = "mtbSalEdit";
            mtbSalEdit.Size = new Size(123, 26);
            mtbSalEdit.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(350, 638);
            label7.Name = "label7";
            label7.Size = new Size(58, 18);
            label7.TabIndex = 14;
            label7.Text = "Salário";
            // 
            // mtbHSEdit
            // 
            mtbHSEdit.Location = new Point(350, 528);
            mtbHSEdit.Mask = "00:00";
            mtbHSEdit.Name = "mtbHSEdit";
            mtbHSEdit.Size = new Size(123, 26);
            mtbHSEdit.TabIndex = 4;
            mtbHSEdit.ValidatingType = typeof(DateTime);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(82, 635);
            label8.Name = "label8";
            label8.Size = new Size(154, 18);
            label8.TabIndex = 13;
            label8.Text = "Data de Contratação";
            // 
            // mtbHEEdit
            // 
            mtbHEEdit.Location = new Point(82, 528);
            mtbHEEdit.Mask = "00:00";
            mtbHEEdit.Name = "mtbHEEdit";
            mtbHEEdit.Size = new Size(124, 26);
            mtbHEEdit.TabIndex = 3;
            mtbHEEdit.ValidatingType = typeof(DateTime);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F);
            label9.Location = new Point(350, 458);
            label9.Name = "label9";
            label9.Size = new Size(109, 18);
            label9.TabIndex = 12;
            label9.Text = "Hora de Saída";
            // 
            // txtProfEdit
            // 
            txtProfEdit.Location = new Point(350, 338);
            txtProfEdit.Name = "txtProfEdit";
            txtProfEdit.Size = new Size(123, 26);
            txtProfEdit.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F);
            label10.Location = new Point(82, 458);
            label10.Name = "label10";
            label10.Size = new Size(123, 18);
            label10.TabIndex = 11;
            label10.Text = "Hora de Entrada";
            // 
            // txtNomeEdit
            // 
            txtNomeEdit.Location = new Point(82, 338);
            txtNomeEdit.Name = "txtNomeEdit";
            txtNomeEdit.Size = new Size(124, 26);
            txtNomeEdit.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F);
            label11.Location = new Point(357, 285);
            label11.Name = "label11";
            label11.Size = new Size(52, 18);
            label11.TabIndex = 10;
            label11.Text = "Cargo";
            // 
            // btnConfirmEdit
            // 
            btnConfirmEdit.Anchor = AnchorStyles.Bottom;
            btnConfirmEdit.BackColor = Color.FromArgb(192, 192, 0);
            btnConfirmEdit.Cursor = Cursors.Hand;
            btnConfirmEdit.FlatStyle = FlatStyle.Popup;
            btnConfirmEdit.Location = new Point(280, 867);
            btnConfirmEdit.Name = "btnConfirmEdit";
            btnConfirmEdit.Size = new Size(100, 34);
            btnConfirmEdit.TabIndex = 8;
            btnConfirmEdit.Text = "Confirmar";
            btnConfirmEdit.UseVisualStyleBackColor = false;
            btnConfirmEdit.Click += btnConfirmEdit_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.Anchor = AnchorStyles.Bottom;
            btnCancelEdit.BackColor = Color.Red;
            btnCancelEdit.FlatStyle = FlatStyle.Popup;
            btnCancelEdit.Location = new Point(174, 867);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(100, 34);
            btnCancelEdit.TabIndex = 7;
            btnCancelEdit.Text = "Cancelar";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F);
            label12.Location = new Point(82, 285);
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
            groupAdd.Controls.Add(dateTimePickerAdd);
            groupAdd.Controls.Add(mtbSalAdd);
            groupAdd.Controls.Add(mtbHSAdd);
            groupAdd.Controls.Add(mtbHEAdd);
            groupAdd.Controls.Add(txtCargoAdd);
            groupAdd.Controls.Add(txtNomeAdd);
            groupAdd.Controls.Add(label13);
            groupAdd.Controls.Add(label5);
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
            // dateTimePickerAdd
            // 
            dateTimePickerAdd.Location = new Point(795, 252);
            dateTimePickerAdd.Name = "dateTimePickerAdd";
            dateTimePickerAdd.Size = new Size(123, 26);
            dateTimePickerAdd.TabIndex = 5;
            // 
            // mtbSalAdd
            // 
            mtbSalAdd.Cursor = Cursors.IBeam;
            mtbSalAdd.InsertKeyMode = InsertKeyMode.Overwrite;
            mtbSalAdd.Location = new Point(795, 91);
            mtbSalAdd.Mask = "$00000";
            mtbSalAdd.Name = "mtbSalAdd";
            mtbSalAdd.RightToLeft = RightToLeft.No;
            mtbSalAdd.Size = new Size(123, 26);
            mtbSalAdd.TabIndex = 2;
            // 
            // mtbHSAdd
            // 
            mtbHSAdd.Location = new Point(498, 255);
            mtbHSAdd.Mask = "00:00";
            mtbHSAdd.Name = "mtbHSAdd";
            mtbHSAdd.Size = new Size(123, 26);
            mtbHSAdd.TabIndex = 4;
            mtbHSAdd.ValidatingType = typeof(DateTime);
            // 
            // mtbHEAdd
            // 
            mtbHEAdd.Location = new Point(182, 255);
            mtbHEAdd.Mask = "00:00";
            mtbHEAdd.Name = "mtbHEAdd";
            mtbHEAdd.Size = new Size(124, 26);
            mtbHEAdd.TabIndex = 3;
            mtbHEAdd.ValidatingType = typeof(DateTime);
            // 
            // txtCargoAdd
            // 
            txtCargoAdd.Location = new Point(498, 93);
            txtCargoAdd.Name = "txtCargoAdd";
            txtCargoAdd.Size = new Size(123, 26);
            txtCargoAdd.TabIndex = 1;
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
            label13.Size = new Size(58, 18);
            label13.TabIndex = 8;
            label13.Text = "Salário";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(795, 196);
            label5.Name = "label5";
            label5.Size = new Size(154, 18);
            label5.TabIndex = 7;
            label5.Text = "Data de Contratação";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(498, 196);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 6;
            label4.Text = "Hora de Saída";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(182, 196);
            label3.Name = "label3";
            label3.Size = new Size(123, 18);
            label3.TabIndex = 5;
            label3.Text = "Hora de Entrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(498, 37);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 4;
            label2.Text = "Cargo";
            label2.Click += label2_Click;
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
            groupDelete.Controls.Add(txtIdDel);
            groupDelete.Controls.Add(label6);
            groupDelete.Controls.Add(btnCancelDel);
            groupDelete.Controls.Add(btnConfirmDel);
            groupDelete.Controls.Add(dataGridView1);
            groupDelete.Dock = DockStyle.Fill;
            groupDelete.Location = new Point(0, 765);
            groupDelete.Name = "groupDelete";
            groupDelete.Size = new Size(1130, 266);
            groupDelete.TabIndex = 2;
            groupDelete.TabStop = false;
            groupDelete.Text = "Excluir";
            // 
            // txtIdDel
            // 
            txtIdDel.Location = new Point(306, 135);
            txtIdDel.Name = "txtIdDel";
            txtIdDel.Size = new Size(100, 23);
            txtIdDel.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(264, 86);
            label6.Name = "label6";
            label6.Size = new Size(184, 18);
            label6.TabIndex = 5;
            label6.Text = "Id de quem deseja excluir";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, -10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(10, 10);
            dataGridView1.TabIndex = 16;
            // 
            // Funcionario
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
            Name = "Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionario";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private MaskedTextBox mtbSalAdd;
        private MaskedTextBox mtbHSAdd;
        private MaskedTextBox mtbHEAdd;
        private TextBox txtCargoAdd;
        private TextBox txtNomeAdd;
        private MaskedTextBox mtbSalEdit;
        private MaskedTextBox mtbDCEdit;
        private MaskedTextBox mtbHSEdit;
        private MaskedTextBox mtbHEEdit;
        private TextBox txtProfEdit;
        private TextBox txtNomeEdit;
        private DateTimePicker dateTimePickerAdd;
        private DateTimePicker dateTimePickerEdit;
        private TextBox txtIdEdit;
        private Label label14;
        private Button button7;
        private DataGridView dataGridView1;
        private ToolStripMenuItem tABELADEFUNCIONÁRIOSToolStripMenuItem;
        private TextBox txtIdDel;
    }
}