namespace Form_PIM.Operacional
{
    partial class LoginFuncionario
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
            gpAdd = new GroupBox();
            btnConfirmAdd = new Button();
            btnCancelAdd = new Button();
            txtSenhaAdd = new TextBox();
            txtIdFuncAdd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            gpEdit = new GroupBox();
            txtIdLoginEdit = new TextBox();
            label6 = new Label();
            btnConfirmEdit = new Button();
            btnCancelEdit = new Button();
            txtSenhaEdit = new TextBox();
            txtIdFuncEdit = new TextBox();
            label4 = new Label();
            label5 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            gpDel = new GroupBox();
            txtIdDel = new TextBox();
            btnConfirmDel = new Button();
            btnCancelDel = new Button();
            label1 = new Label();
            gpTable = new GroupBox();
            dataGridView1 = new DataGridView();
            gpAdd.SuspendLayout();
            gpEdit.SuspendLayout();
            menuStrip1.SuspendLayout();
            gpDel.SuspendLayout();
            gpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gpAdd
            // 
            gpAdd.Controls.Add(btnConfirmAdd);
            gpAdd.Controls.Add(btnCancelAdd);
            gpAdd.Controls.Add(txtSenhaAdd);
            gpAdd.Controls.Add(txtIdFuncAdd);
            gpAdd.Controls.Add(label3);
            gpAdd.Controls.Add(label2);
            gpAdd.Dock = DockStyle.Left;
            gpAdd.Font = new Font("Arial", 10F);
            gpAdd.Location = new Point(0, 0);
            gpAdd.Name = "gpAdd";
            gpAdd.Size = new Size(566, 1031);
            gpAdd.TabIndex = 0;
            gpAdd.TabStop = false;
            gpAdd.Text = "Adicionar";
            gpAdd.Enter += gpAdd_Enter;
            // 
            // btnConfirmAdd
            // 
            btnConfirmAdd.BackColor = Color.FromArgb(192, 192, 0);
            btnConfirmAdd.FlatStyle = FlatStyle.Popup;
            btnConfirmAdd.Location = new Point(325, 643);
            btnConfirmAdd.Name = "btnConfirmAdd";
            btnConfirmAdd.Size = new Size(86, 36);
            btnConfirmAdd.TabIndex = 3;
            btnConfirmAdd.Text = "Confirmar";
            btnConfirmAdd.UseVisualStyleBackColor = false;
            btnConfirmAdd.Click += btnConfirmAdd_Click;
            // 
            // btnCancelAdd
            // 
            btnCancelAdd.BackColor = Color.Red;
            btnCancelAdd.FlatStyle = FlatStyle.Popup;
            btnCancelAdd.Location = new Point(198, 643);
            btnCancelAdd.Name = "btnCancelAdd";
            btnCancelAdd.Size = new Size(86, 36);
            btnCancelAdd.TabIndex = 2;
            btnCancelAdd.Text = "Cancelar";
            btnCancelAdd.UseVisualStyleBackColor = false;
            btnCancelAdd.Click += btnCancelAdd_Click;
            // 
            // txtSenhaAdd
            // 
            txtSenhaAdd.Location = new Point(281, 494);
            txtSenhaAdd.Name = "txtSenhaAdd";
            txtSenhaAdd.Size = new Size(158, 23);
            txtSenhaAdd.TabIndex = 1;
            // 
            // txtIdFuncAdd
            // 
            txtIdFuncAdd.Location = new Point(281, 352);
            txtIdFuncAdd.Name = "txtIdFuncAdd";
            txtIdFuncAdd.Size = new Size(158, 23);
            txtIdFuncAdd.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 501);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 1;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 359);
            label2.Name = "label2";
            label2.Size = new Size(117, 16);
            label2.TabIndex = 0;
            label2.Text = "Id do Funcionário";
            // 
            // gpEdit
            // 
            gpEdit.Controls.Add(txtIdLoginEdit);
            gpEdit.Controls.Add(label6);
            gpEdit.Controls.Add(btnConfirmEdit);
            gpEdit.Controls.Add(btnCancelEdit);
            gpEdit.Controls.Add(txtSenhaEdit);
            gpEdit.Controls.Add(txtIdFuncEdit);
            gpEdit.Controls.Add(label4);
            gpEdit.Controls.Add(label5);
            gpEdit.Controls.Add(menuStrip1);
            gpEdit.Dock = DockStyle.Right;
            gpEdit.Font = new Font("Arial", 10F);
            gpEdit.Location = new Point(1118, 0);
            gpEdit.Name = "gpEdit";
            gpEdit.Size = new Size(566, 1031);
            gpEdit.TabIndex = 2;
            gpEdit.TabStop = false;
            gpEdit.Text = "Editar";
            // 
            // txtIdLoginEdit
            // 
            txtIdLoginEdit.Location = new Point(291, 279);
            txtIdLoginEdit.Name = "txtIdLoginEdit";
            txtIdLoginEdit.Size = new Size(158, 23);
            txtIdLoginEdit.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(137, 286);
            label6.Name = "label6";
            label6.Size = new Size(77, 16);
            label6.TabIndex = 12;
            label6.Text = "Id do Login";
            // 
            // btnConfirmEdit
            // 
            btnConfirmEdit.BackColor = Color.FromArgb(192, 192, 0);
            btnConfirmEdit.FlatStyle = FlatStyle.Popup;
            btnConfirmEdit.Location = new Point(305, 715);
            btnConfirmEdit.Name = "btnConfirmEdit";
            btnConfirmEdit.Size = new Size(86, 36);
            btnConfirmEdit.TabIndex = 4;
            btnConfirmEdit.Text = "Confirmar";
            btnConfirmEdit.UseVisualStyleBackColor = false;
            btnConfirmEdit.Click += btnConfirmEdit_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.Red;
            btnCancelEdit.FlatStyle = FlatStyle.Popup;
            btnCancelEdit.Location = new Point(176, 715);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(86, 36);
            btnCancelEdit.TabIndex = 3;
            btnCancelEdit.Text = "Cancelar";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // txtSenhaEdit
            // 
            txtSenhaEdit.Location = new Point(291, 565);
            txtSenhaEdit.Name = "txtSenhaEdit";
            txtSenhaEdit.Size = new Size(158, 23);
            txtSenhaEdit.TabIndex = 2;
            // 
            // txtIdFuncEdit
            // 
            txtIdFuncEdit.Location = new Point(291, 422);
            txtIdFuncEdit.Name = "txtIdFuncEdit";
            txtIdFuncEdit.Size = new Size(158, 23);
            txtIdFuncEdit.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(151, 572);
            label4.Name = "label4";
            label4.Size = new Size(48, 16);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 429);
            label5.Name = "label5";
            label5.Size = new Size(117, 16);
            label5.TabIndex = 6;
            label5.Text = "Id do Funcionário";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(452, 916);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(109, 27);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(101, 23);
            menuToolStripMenuItem.Text = "<<Voltar>>";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // gpDel
            // 
            gpDel.Controls.Add(txtIdDel);
            gpDel.Controls.Add(btnConfirmDel);
            gpDel.Controls.Add(btnCancelDel);
            gpDel.Controls.Add(label1);
            gpDel.Dock = DockStyle.Fill;
            gpDel.Font = new Font("Arial", 10F);
            gpDel.Location = new Point(566, 0);
            gpDel.Name = "gpDel";
            gpDel.Size = new Size(552, 1031);
            gpDel.TabIndex = 1;
            gpDel.TabStop = false;
            gpDel.Text = "Excluir";
            // 
            // txtIdDel
            // 
            txtIdDel.Location = new Point(217, 148);
            txtIdDel.Name = "txtIdDel";
            txtIdDel.Size = new Size(119, 23);
            txtIdDel.TabIndex = 0;
            // 
            // btnConfirmDel
            // 
            btnConfirmDel.BackColor = Color.FromArgb(192, 192, 0);
            btnConfirmDel.FlatStyle = FlatStyle.Popup;
            btnConfirmDel.Location = new Point(279, 212);
            btnConfirmDel.Name = "btnConfirmDel";
            btnConfirmDel.Size = new Size(86, 36);
            btnConfirmDel.TabIndex = 2;
            btnConfirmDel.Text = "Confirmar";
            btnConfirmDel.UseVisualStyleBackColor = false;
            btnConfirmDel.Click += btnConfirmDel_Click;
            // 
            // btnCancelDel
            // 
            btnCancelDel.BackColor = Color.Red;
            btnCancelDel.Cursor = Cursors.Hand;
            btnCancelDel.FlatStyle = FlatStyle.Popup;
            btnCancelDel.Location = new Point(187, 212);
            btnCancelDel.Name = "btnCancelDel";
            btnCancelDel.Size = new Size(86, 36);
            btnCancelDel.TabIndex = 1;
            btnCancelDel.Text = "Cancelar";
            btnCancelDel.UseVisualStyleBackColor = false;
            btnCancelDel.Click += btnCancelDel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 91);
            label1.Name = "label1";
            label1.Size = new Size(77, 16);
            label1.TabIndex = 0;
            label1.Text = "Id do Login";
            // 
            // gpTable
            // 
            gpTable.Controls.Add(dataGridView1);
            gpTable.Dock = DockStyle.Bottom;
            gpTable.Font = new Font("Arial", 10F);
            gpTable.Location = new Point(566, 327);
            gpTable.Name = "gpTable";
            gpTable.Size = new Size(552, 704);
            gpTable.TabIndex = 3;
            gpTable.TabStop = false;
            gpTable.Text = "Tabela de Logins";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(546, 682);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LoginFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1684, 1031);
            ControlBox = false;
            Controls.Add(gpTable);
            Controls.Add(gpDel);
            Controls.Add(gpEdit);
            Controls.Add(gpAdd);
            MaximumSize = new Size(1700, 1070);
            MinimumSize = new Size(1678, 1000);
            Name = "LoginFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Funcionario";
            WindowState = FormWindowState.Maximized;
            gpAdd.ResumeLayout(false);
            gpAdd.PerformLayout();
            gpEdit.ResumeLayout(false);
            gpEdit.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gpDel.ResumeLayout(false);
            gpDel.PerformLayout();
            gpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpAdd;
        private GroupBox gpEdit;
        private GroupBox gpDel;
        private GroupBox gpTable;
        private DataGridView dataGridView1;
        private TextBox txtIdDel;
        private Button btnConfirmDel;
        private Button btnCancelDel;
        private Label label1;
        private Button btnConfirmAdd;
        private Button btnCancelAdd;
        private TextBox txtSenhaAdd;
        private TextBox txtIdFuncAdd;
        private Label label3;
        private Label label2;
        private TextBox txtIdLoginEdit;
        private Label label6;
        private Button btnConfirmEdit;
        private Button btnCancelEdit;
        private TextBox txtSenhaEdit;
        private TextBox txtIdFuncEdit;
        private Label label4;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
    }
}