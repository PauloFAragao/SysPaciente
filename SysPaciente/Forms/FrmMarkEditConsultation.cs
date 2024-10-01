using SysPaciente.Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace SysPaciente.Forms
{
    public partial class FrmMarkEditConsultation : Form
    {
        private int _tipe;//0 - adicionar |  1 - editar
        private int _idConsultation;

        private bool _searchForName;

        private int _idClient;
        private string _name;
        private string _telephone;
        private string _dateOfBirth;
        private string _consultationDate;
        private string _status;
        TimeSpan _timeOfConsultation;

        public FrmMarkEditConsultation(int idConsultation, int idClient, string consultationDate, 
            string timeOfConsultation, string status)
        {
            InitializeComponent();

            // inicializando as variaveis
            _searchForName = true;
            _tipe = 1;// essa form vai editar 
            _idConsultation = idConsultation;
            _idClient = idClient;
            _consultationDate = consultationDate;
            _timeOfConsultation = TimeSpan.Parse(timeOfConsultation);
            _status = status;

            LoadData();
        }

        public FrmMarkEditConsultation()
        {
            InitializeComponent();

            _tipe = 0;// se essa form vai adiconar ou editar 
            _searchForName = true;// inicia buscando por nome
            _idClient = -1;// inicia assim para indicar que não foi selecionado um cliente

            ConfigureFilds();
        }

        private void ConfigureFilds()
        {
            // panel para pesquisar clientes
            this.PanelClients.Dock = DockStyle.Fill;

            this.LblClientTelephone.Text = "- - -";
            this.LblClientDateOfBirth.Text = "- - -";
        }

        private void LoadData()
        {
            string[] str = Data.SearchCliente(_idClient);

            _name = str[0];
            _telephone = str[1];
            _dateOfBirth = str[2];

            // preenchendo os campos do form
            this.LblClientName.Text = _name;
            this.LblClientTelephone.Text = _telephone;
            this.LblClientDateOfBirth.Text = _dateOfBirth;
            this.TxtTimeOfConsultation.Text = _timeOfConsultation.ToString();
            this.CbxStatus.Text = _status;

            this.DateTimePicker.Text = _consultationDate;

            // editando a interface
            this.GbStatus.Visible = true;
            this.BtnMark.Text = "Editar";

            // panel para pesquisar clientes
            this.PanelClients.Dock = DockStyle.Fill;
        }

        private bool LoadClientsData()
        {
            DataTable dataTable = Data.ShowClients();

            if (dataTable != null)
            {
                this.DgvData.DataSource = dataTable;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ChangeText()
        {
            _searchForName = !_searchForName;

            if (_searchForName)
            {
                this.BtnSearchMode.Text = "Mudar para cpf";
                LblSearch.Text = "Buscar por nome:";

                //para quando clicar no botão já fazer a pesquisa
                if (!String.IsNullOrWhiteSpace(this.TxtSearchText.Text))
                    Search();
            }
            else
            {
                this.BtnSearchMode.Text = "Mudar para nome";
                LblSearch.Text = "Buscar por cpf:";

                //para quando clicar no botão já fazer a pesquisa
                if (!String.IsNullOrWhiteSpace(this.TxtSearchText.Text))
                    Search();
            }

            this.TxtSearchText.Focus();
        }

        private void ChangePanelPanelclientsVisibility()
        {
            this.PanelClients.Visible = true;// tornando o campo visivel
            if (LoadClientsData()) // carregando os dados
            {
                HideColumns();
                ChangeColumns();
            }
        }

        private void HideColumns()
        {
            this.DgvData.Columns[0].Visible = false;//id
            this.DgvData.Columns[11].Visible = false;//número da identidade
            this.DgvData.Columns[12].Visible = false;//número do cpf
        }

        private void ChangeColumns()
        {
            // Altera o texto do cabeçalho da coluna 1 para "Nome do paciente"
            this.DgvData.Columns[1].HeaderText = "Nome do paciente";
            this.DgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 2 para "Contato"
            this.DgvData.Columns[2].HeaderText = "Contato";
            this.DgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 3 para "Data de nascimento"
            this.DgvData.Columns[3].HeaderText = "Data de nascimento";
            this.DgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 4 para "Rua"
            this.DgvData.Columns[4].HeaderText = "Rua";
            this.DgvData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 5 para "Número da casa"
            this.DgvData.Columns[5].HeaderText = "Número da casa";
            this.DgvData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 6 para "Bairro"
            this.DgvData.Columns[6].HeaderText = "Bairro";
            this.DgvData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 7 para "Cidade"
            this.DgvData.Columns[7].HeaderText = "Cidade";
            this.DgvData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 8 para "Complemento"
            this.DgvData.Columns[8].HeaderText = "Cep";
            this.DgvData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 9 para "Complemento"
            this.DgvData.Columns[9].HeaderText = "Estado";
            this.DgvData.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 10 para "Complemento"
            this.DgvData.Columns[10].HeaderText = "Complemento";
            this.DgvData.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 13 para "Histórico de consultas"
            this.DgvData.Columns[13].HeaderText = "Histórico de consultas";
            this.DgvData.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void Search()
        {
            DataTable dataTable;

            if (_searchForName)
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

        private void SelectClient()
        {
            if (DgvData.Rows.Count > 0)
            {
                _idClient = Convert.ToInt32(this.DgvData.CurrentRow.Cells["idClient"].Value);
                _name = Convert.ToString(this.DgvData.CurrentRow.Cells["name"].Value);
                _telephone = Convert.ToString(this.DgvData.CurrentRow.Cells["telephone"].Value);

                DateTime date = Convert.ToDateTime(this.DgvData.CurrentRow.Cells["dateOfBirth"].Value);
                _dateOfBirth = date.ToString("dd/MM/yyyy");

                this.LblClientName.Text = _name;
                this.LblClientTelephone.Text = _telephone;
                this.LblClientDateOfBirth.Text = _dateOfBirth;

                this.PanelClients.Visible = false;
            }
            else
            {
                MessageBox.Show("A tabela não tem dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CaptureAndVerifyData()
        {
            if (TimeSpan.TryParse(this.TxtTimeOfConsultation.Text, out TimeSpan value))
            {
                _timeOfConsultation = value;
                return true;
            }
            else
            {
                MessageBox.Show("O campo da hora da consulta não foi preenchido corretamente!",
                    "Campos não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private void Confirm()
        {
            if (_idClient == -1)
            {
                MessageBox.Show("Primeiro selecione um cliente", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CaptureAndVerifyData())
            {
                DateTime time = Convert.ToDateTime(DateTimePicker.Text);

                if(_tipe == 0)
                {
                    string resp = Data.InsertConsultation(Convert.ToDateTime(DateTimePicker.Text), _timeOfConsultation, _idClient, 0);

                    if (resp == "Registro inserido com sucesso.")
                    {
                        MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoader.OpenChildForm(new FrmConsultations());
                    }

                    else
                        MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string resp = Data.EditConsultation(_idConsultation, Convert.ToDateTime(DateTimePicker.Text), _timeOfConsultation, _idClient, this.CbxStatus.SelectedIndex);

                    if (resp == "Registro editado com sucesso.")
                    {
                        MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoader.OpenChildForm(new FrmConsultations());
                    }

                    else
                        MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //-------------------------- métodos criados pelo visual studio --------------------------

        private void BtnPickClient_Click(object sender, EventArgs e)
        {
            ChangePanelPanelclientsVisibility();
        }

        private void BtnSearchMode_Click(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            SelectClient();
        }

        private void BtnCancelSearch_Click(object sender, EventArgs e)
        {
            this.PanelClients.Visible = false;
        }

        private void BtnMark_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormLoader.OpenChildForm(new FrmConsultations());
        }

        private void TxtSearchText_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
