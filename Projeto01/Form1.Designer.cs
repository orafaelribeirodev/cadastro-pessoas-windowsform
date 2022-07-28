namespace Projeto01
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MtbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RbMasculino = new System.Windows.Forms.RadioButton();
            this.RbFerminino = new System.Windows.Forms.RadioButton();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PES_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PES_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PES_NASC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PES_SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnPesqusar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNome.Location = new System.Drawing.Point(12, 28);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(531, 29);
            this.TxtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // MtbNascimento
            // 
            this.MtbNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtbNascimento.Location = new System.Drawing.Point(549, 28);
            this.MtbNascimento.Mask = "00/00/0000";
            this.MtbNascimento.Name = "MtbNascimento";
            this.MtbNascimento.Size = new System.Drawing.Size(158, 29);
            this.MtbNascimento.TabIndex = 2;
            this.MtbNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(546, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(721, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // RbMasculino
            // 
            this.RbMasculino.AutoSize = true;
            this.RbMasculino.Checked = true;
            this.RbMasculino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbMasculino.Location = new System.Drawing.Point(721, 30);
            this.RbMasculino.Name = "RbMasculino";
            this.RbMasculino.Size = new System.Drawing.Size(99, 25);
            this.RbMasculino.TabIndex = 5;
            this.RbMasculino.TabStop = true;
            this.RbMasculino.Text = "Masculino";
            this.RbMasculino.UseVisualStyleBackColor = true;
            // 
            // RbFerminino
            // 
            this.RbFerminino.AutoSize = true;
            this.RbFerminino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RbFerminino.Location = new System.Drawing.Point(826, 30);
            this.RbFerminino.Name = "RbFerminino";
            this.RbFerminino.Size = new System.Drawing.Size(93, 25);
            this.RbFerminino.TabIndex = 6;
            this.RbFerminino.Text = "Feminino";
            this.RbFerminino.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.Location = new System.Drawing.Point(775, 70);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(144, 47);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(669, 70);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(100, 47);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PES_ID,
            this.PES_NOME,
            this.PES_NASC,
            this.PES_SEXO});
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(907, 306);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // PES_ID
            // 
            this.PES_ID.HeaderText = "PES_ID";
            this.PES_ID.Name = "PES_ID";
            this.PES_ID.ReadOnly = true;
            // 
            // PES_NOME
            // 
            this.PES_NOME.HeaderText = "PES_NOME";
            this.PES_NOME.Name = "PES_NOME";
            this.PES_NOME.ReadOnly = true;
            this.PES_NOME.Width = 300;
            // 
            // PES_NASC
            // 
            this.PES_NASC.HeaderText = "PES_NASC";
            this.PES_NASC.Name = "PES_NASC";
            this.PES_NASC.ReadOnly = true;
            // 
            // PES_SEXO
            // 
            this.PES_SEXO.HeaderText = "PES_SEXO";
            this.PES_SEXO.Name = "PES_SEXO";
            this.PES_SEXO.ReadOnly = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(529, 70);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 47);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnPesqusar
            // 
            this.BtnPesqusar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnPesqusar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesqusar.Image")));
            this.BtnPesqusar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesqusar.Location = new System.Drawing.Point(369, 70);
            this.BtnPesqusar.Name = "BtnPesqusar";
            this.BtnPesqusar.Size = new System.Drawing.Size(154, 47);
            this.BtnPesqusar.TabIndex = 11;
            this.BtnPesqusar.Text = "Pesquisar";
            this.BtnPesqusar.UseVisualStyleBackColor = true;
            this.BtnPesqusar.Click += new System.EventHandler(this.BtnPesqusar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.Location = new System.Drawing.Point(12, 81);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(339, 29);
            this.txtPesquisar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 442);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.BtnPesqusar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.RbFerminino);
            this.Controls.Add(this.RbMasculino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MtbNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TELA DE CADASTRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtNome;
        private Label label1;
        private MaskedTextBox MtbNascimento;
        private Label label2;
        private Label label3;
        private RadioButton RbMasculino;
        private RadioButton RbFerminino;
        private Button BtnSalvar;
        private Button BtnExcluir;
        private DataGridView dataGridView1;
        private Button BtnCancelar;
        private DataGridViewTextBoxColumn PES_ID;
        private DataGridViewTextBoxColumn PES_NOME;
        private DataGridViewTextBoxColumn PES_NASC;
        private DataGridViewTextBoxColumn PES_SEXO;
        private Button BtnPesqusar;
        private TextBox txtPesquisar;
    }
}