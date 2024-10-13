using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysPaciente.Entities;

namespace SysPaciente.Forms
{
    public partial class FrmClients : Form
    {
        private bool _searchForName;
        
        public FrmClients()
        {
            InitializeComponent();

            // inicia buscando por nome
            _searchForName = true;

            //carregando os dados
            Task.Run(() => Initialize());

            // colocando o focus no campo
            this.TxtSearchText.Focus();
        }

        private void ChangeText()
        {
            _searchForName = CbSearchMode.Checked;// caputrar o modo de busca

            if (!_searchForName)// mudar o texto
                this.LblSearch.Text = "Buscar por nome:";

            else
                this.LblSearch.Text = "Buscar por cpf:";

            this.TxtSearchText.Focus();// colocar o focus na caixa de busca
        }

        private void Search()
        {
            this.BtnSearch.Enabled = false;

            if (_searchForName)
                Task.Run(() => SearchName());

            else
                Task.Run(() => SearchCpf());
        }

        private void NewEdit(int value)
        {
            if (value == 0)
            {
                FormLoader.OpenChildForm(new FrmAddEditClient(0));

                return;
            }

            //verifica se tem alguma linha no DataGridView
            if (DgvData.Rows.Count > 0)
            {
                FormLoader.OpenChildForm(new FrmAddEditClient(1,
                    Convert.ToInt32(this.DgvData.CurrentRow.Cells["idClient"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["name"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["telephone"].Value),
                    Convert.ToDateTime(this.DgvData.CurrentRow.Cells["dateOfBirth"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["street"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["houseNumber"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["neighborhood"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["city"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["cep"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["state"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["complement"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["idNumber"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["cpf"].Value)));
            }
            else
            {
                MessageBox.Show("A tabela não tem dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void View()
        {
            if (DgvData.Rows.Count > 0)
            {
                FormLoader.OpenChildForm(new FrmClientHistorical(
                Convert.ToInt32(this.DgvData.CurrentRow.Cells["idClient"].Value),
                Convert.ToString(this.DgvData.CurrentRow.Cells["name"].Value)));
            }
            else
            {
                MessageBox.Show("A tabela não tem dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------ Thread
        private void Initialize()
        {
            if (LoadData())
            {
                HideColumns();
                ChangeColumns();

                // para iniciar com a primeira linha selecionada
                ThreadHelper.SelectFirstRow(this.DgvData);
            }
        }

        private bool LoadData()
        {
            DataTable dataTable = Data.ShowClients();

            if (dataTable != null)
            {
                // carregando os dados no DataGridView
                ThreadHelper.SetPropertyValue(DgvData, "DataSource", dataTable);
                return true;
            }
            else
                return false;
        }

        private void HideColumns()
        {
            ThreadHelper.SetColumnVisibility(this.DgvData, 0, false);//mudando a visibilidade da coluna id
            ThreadHelper.SetColumnVisibility(this.DgvData, 11, false);//mudando a visibilidade da coluna número da identidade
            ThreadHelper.SetColumnVisibility(this.DgvData, 12, false);//mudando a visibilidade da coluna número do cpf
        }

        private void ChangeColumns()
        {
            // Altera o texto do cabeçalho da coluna 1 para "Nome do paciente"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 1, "Nome do paciente");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 1, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 2 para "Contato"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 2, "Contato");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 2, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 3 para "Data de nascimento"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 3, "Data de nascimento");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 3, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 4 para "Rua"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 4, "Rua");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 4, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 5 para "Número da casa"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 5, "Número da casa");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 5, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 6 para "Bairro"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 6, "Bairro");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 6, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 7 para "Cidade"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 7, "Cidade");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 7, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 8 para "Cep"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 8, "Cep");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 8, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 9 para "Estado"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 9, "Estado");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 9, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 10 para "Complemento"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 10, "Complemento");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 10, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 13 para "Histórico de consultas"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 13, "Histórico de consultas");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 13, DataGridViewAutoSizeColumnMode.AllCells);
        }

        private void SearchName()
        {
            DataTable dataTable = Data.SearchClienteName(this.TxtSearchText.Text);

            if (dataTable != null)
            {
                ThreadHelper.SetPropertyValue(this.DgvData, "DataSource", dataTable);
            }

            ThreadHelper.SetPropertyValue(this.BtnSearch, "Enabled", true);
        }

        private void SearchCpf()
        {
            DataTable dataTable = Data.SearchClienteCPF(this.TxtSearchText.Text);

            if (dataTable != null)
            {
                ThreadHelper.SetPropertyValue(this.DgvData, "DataSource", dataTable);
            }

            ThreadHelper.SetPropertyValue(this.BtnSearch, "Enabled", true);
        }

        //------------------ métodos criados pelo visual studio

        private void BtnNew_Click(object sender, EventArgs e)
        {
            NewEdit(0);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            NewEdit(1);
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            View();
        }

        private void CbSearchMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
