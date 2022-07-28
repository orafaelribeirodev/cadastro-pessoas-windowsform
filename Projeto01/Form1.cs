using Dominio;

namespace Projeto01
{
    public partial class Form1 : Form
    {
        //id => serial
        //string => varchar / text
        //int => integer
        //Int64 => bigint
        //Int16 => smallint
        //bool => boolean
        //DateTime => Date / TimeStamp

        private int id { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarLista(string filtro = "")
        {
            string filtroSql = "";
            if (filtro != "")
            {
                filtroSql = $" where pes_nome like '%{filtro}%'";
            }

            dataGridView1.Rows.Clear();
            List<Dominio.Pessoa> listaPessoas = Ado.Pessoa.Carregar(filtroSql);
            for (int i = 0; i < listaPessoas.Count; i++)
            {
                dataGridView1.Rows.Add(
                    listaPessoas[i].pes_id,
                    listaPessoas[i].pes_nome,
                    listaPessoas[i].pes_nasc,
                    listaPessoas[i].pes_sexo
                    );
            }
        }

        private void NovaFicha()
        {
            TxtNome.Clear();
            MtbNascimento.Clear();
            RbMasculino.Checked = true;
            id = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNome.Text))
            {
                MessageBox.Show("Campo nome é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(MtbNascimento.Text == "  /  /")
            {
                MessageBox.Show("Campo data de nascimento é obrigatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Dominio.Pessoa pessoa = new Dominio.Pessoa();
            pessoa.pes_id = id;
            pessoa.pes_nome = TxtNome.Text;
            pessoa.pes_nasc = MtbNascimento.Text;
            pessoa.pes_sexo = RbMasculino.Checked ? "M" : "F";
            string salvarStatus = "";
            //Se o id for 0 significar que e um novo registro
            if (id == 0)
            {
                salvarStatus = Ado.Pessoa.Salvar(pessoa);
            }
            else
            {
                salvarStatus = Ado.Pessoa.Editar(pessoa);
            }
            if (salvarStatus == "")
            {
                CarregarLista();
                NovaFicha();
                MessageBox.Show("Pessoa salva com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(salvarStatus, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Verifca se existe uma pessoa selecionada
            if (id > 0)
            {
                if (MessageBox.Show(@"Confirmar exclusão da pessoa: " + TxtNome.Text, @"Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string excluirStatus = Ado.Pessoa.Excluir(id);
                    if (excluirStatus == "")
                    {
                        NovaFicha();
                        CarregarLista();
                    }
                    else
                    {
                        MessageBox.Show(excluirStatus, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("É preciso selecionar uma pessoa da lista para poder exclui-la", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            NovaFicha();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var checkId = dataGridView1.Rows[e.RowIndex].Cells["PES_ID"].Value;
            if (checkId != null)
            {
                id = Convert.ToInt32(checkId.ToString());
                TxtNome.Text = dataGridView1.Rows[e.RowIndex].Cells["PES_NOME"].Value.ToString();
                MtbNascimento.Text = dataGridView1.Rows[e.RowIndex].Cells["PES_NASC"].Value.ToString();
                string sexo = dataGridView1.Rows[e.RowIndex].Cells["PES_SEXO"].Value.ToString();
                if (sexo == "M")
                {
                    RbMasculino.Checked = true;
                }
                else
                {
                    RbFerminino.Checked = true;
                }
            }
        }

        private void BtnPesqusar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisar.Text))
            {
                CarregarLista();
                return;
            }
            CarregarLista(txtPesquisar.Text);
        }
    }
}