using System;
using System.Data;
using System.Windows.Forms;
using SysPaciente.Entities;

namespace SysPaciente.Forms
{
    public partial class FrmClients : Form
    {
        bool SearchForName;

        public FrmClients()
        {
            InitializeComponent();

            //inicia buscando por nome
            SearchForName = true;

            if(LoadData())
            {
                HideColumns();
                ChangeColumns();
            }

            //colocando o focus no campo
            this.TxtSearchText.Focus();
        }

        private bool LoadData()
        {
            DataTable dataTable = Data.ShowClients();

            if(dataTable != null)
            {
                this.DgvData.DataSource = dataTable;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void HideColumns()
        {
            this.DgvData.Columns[0].Visible = false;//id
            this.DgvData.Columns[8].Visible = false;//número da identidade
            this.DgvData.Columns[9].Visible = false;//número do cpf
        }

        private void ChangeColumns()
        {
            // Altera o texto do cabeçalho da coluna 1 para "Nome do paciente"
            this.DgvData.Columns[1].HeaderText = "Nome do paciente";
            this.DgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 2 para "Contato"
            this.DgvData.Columns[2].HeaderText = "Contato";
            this.DgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 3 para "Rua"
            this.DgvData.Columns[3].HeaderText = "Rua";
            this.DgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 4 para "Número da casa"
            this.DgvData.Columns[4].HeaderText = "Número da casa";
            this.DgvData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 5 para "Bairro"
            this.DgvData.Columns[5].HeaderText = "Bairro";
            this.DgvData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 6 para "Cidade"
            this.DgvData.Columns[6].HeaderText = "Cidade";
            this.DgvData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 7 para "Complemento"
            this.DgvData.Columns[7].HeaderText = "Complemento";
            this.DgvData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 9 para "Histórico de consultas"
            this.DgvData.Columns[10].HeaderText = "Histórico de consultas";
            this.DgvData.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ChangeText()
        {
            SearchForName = !SearchForName;

            if (SearchForName)
            {
                this.BtnSearchMode.Text = "Mudar para cpf";
                LblSearch.Text = "Buscar por nome:";

                //para quando clicar no botão já fazer a pesquisa
                Search();
            }
            else
            {
                this.BtnSearchMode.Text = "Mudar para nome";
                LblSearch.Text = "Buscar por cpf:";

                //para quando clicar no botão já fazer a pesquisa
                Search();
            }
            this.TxtSearchText.Focus();
        }

        private void Search()
        {
            DataTable dataTable;

            if(SearchForName)
            {
                dataTable = Data.SearchClienteName(this.TxtSearchText.Text);
                this.DgvData.DataSource = dataTable;
            }
            else
            {
                dataTable = Data.SearchClienteCPF(this.TxtSearchText.Text);
                this.DgvData.DataSource = dataTable;
            }
            
        }

        private void NewEdit(int value)
        {
            if(value == 0)
                FormLoader.OpenChildForm(new FrmAddEditClient(0));
            else if(value == 1)
                FormLoader.OpenChildForm(new FrmAddEditClient(1,
                    Convert.ToInt32(this.DgvData.CurrentRow.Cells["idClient"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["name"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["telephone"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["street"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["houseNumber"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["neighborhood"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["city"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["complement"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["idNumber"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["cpf"].Value)));
        }

        //------------------ métodos criados pelo visual studio
        private void BtnSearchMode_Click(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void TxtSearchText_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            NewEdit(0);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            NewEdit(1);
        }
    }
}
