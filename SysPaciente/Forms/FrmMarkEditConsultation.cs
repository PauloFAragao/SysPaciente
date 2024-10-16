﻿using SysPaciente.Entities;
using System;
using System.Data;
using System.Windows.Forms;
using SysPaciente.Entities.Enums;
using System.Collections.Generic;
using System.Diagnostics;

namespace SysPaciente.Forms
{
    public partial class FrmMarkEditConsultation : Form
    {
        private int _tipe;//0 - adicionar |  1 - editar
        private bool _searchForName;// modo de pesquisa

        // dados da consulta e do paciente
        private int _idConsultation;
        private int _idClient;
        private string _name;
        private string _telephone;
        private string _dateOfBirth;
        private string _consultationDate;
        private string _status;
        TimeSpan _timeOfConsultation;

        // backup das informações para comparação em caso de remarcação
        private string _consultationDateMemory;
        TimeSpan _timeOfConsultationMemory;

        // para o sistema de mudar a cor dos botões
        private Button _selectedButton;

        // lista com os botões
        private List<Button> _buttons = new List<Button>();

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

            // configura os elementos da janela
            ConfigureFilds();

            // cuida dos botões dinamicos e do tamanho do panel
            LoadSchedule();
        }

        private void LoadSchedule()
        {
            Schedules schedule = ScheduleManager.GetSchedules(DateTimePicker.Value);

            int x = 13, y = 110;

            if (schedule != null)
            {
                int count = schedule.Times.Count;
                int verifier = 5;

                for (int i = 0; i < count; i++)
                {
                    bool enableButton = schedule.Times[i].Item2;

                    // verifica se as datas são iguais e se o horario já passou
                    if (DateTime.Now.Date == schedule.Date.Date &&
                        DateTime.Now.TimeOfDay > schedule.Times[i].Item1 )
                    {
                        enableButton = false;
                    }

                    // cria o botão
                    CreateButton(x, y, schedule.Times[i].Item1.ToString(@"hh\:mm"), enableButton);

                    x += 85;// muda a posição do botão na horizontal

                    if (i == verifier)// verifica se chegou ao limite de botões na fileira horizontal
                    {
                        x = 13;
                        y += 33;

                        verifier += 6;
                    }
                }

                // tamanho do panel para a quantidad de botões
                if (count <= 6)
                    this.Panel.Height = 267;//234 + 33;

                else if (count <= 12)
                    this.Panel.Height = 300;//234 + 33 * 2;

                else if (count <= 18)
                    this.Panel.Height = 333;//234 + 33 * 3;

                else if (count <= 24)
                    this.Panel.Height = 366;//234 + 33 * 4;

                else if (count <= 30)
                    this.Panel.Height = 399;//234 + 33 * 4;

                else if (count <= 36)
                    this.Panel.Height = 432;
                
            }
        }

        private void CreateButton(int x, int y, string name, bool enabled)
        {
            Button newbutton = new Button();

            newbutton.Enabled = enabled;
            newbutton.Text = name;// texto
            newbutton.Location = new System.Drawing.Point(x, y);// posição
            newbutton.Click += new EventHandler(DinamicButton_Click);// evento
            newbutton.FlatStyle = FlatStyle.Flat;// estilo
            newbutton.FlatAppearance.BorderSize = 0;// estilo da borda
            newbutton.ForeColor = System.Drawing.Color.White;// cor do texto
            newbutton.BackColor = enabled ? System.Drawing.Color.SteelBlue
                : System.Drawing.Color.Gray;// cor de fundo
            //newbutton.BackColor = System.Drawing.Color.DeepSkyBlue; // Gray

            _buttons.Add(newbutton);
            GbSchedule.Controls.Add(newbutton);
        }

        // muda a cor do botão para ele ficar selecionado
        private void ChangeButtonCollor(Button sender)
        {
            if (_selectedButton != null)
            {
                _selectedButton.BackColor = System.Drawing.Color.SteelBlue;
                _selectedButton.ForeColor = System.Drawing.Color.White;
                _selectedButton = null;
            }

            _selectedButton = sender;
            _selectedButton.BackColor = System.Drawing.Color.SkyBlue;
            _selectedButton.ForeColor = System.Drawing.Color.Black;
        }

        private void ConfigureFilds()
        {
            // tamanho do panel
            this.Panel.Height = 230;

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
            this.LblClientDateOfBirth.Text = _dateOfBirth.Substring(0, 10);
            this.TxtTimeOfConsultation.Text = _timeOfConsultation.ToString();
            this.CbxStatus.Text = _status;
            this.DateTimePicker.Text = _consultationDate;

            // guardando os dados para verificação em caso de remarcação
            _timeOfConsultationMemory = _timeOfConsultation;
            _consultationDateMemory = _consultationDate;

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

        private void ChangePanelclientsVisibility()
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
                // Guartando o valor temporariamente
                int idClient = Convert.ToInt32(this.DgvData.CurrentRow.Cells["idClient"].Value);

                //verificar se o cliente tem alguma consulta marcada
                if (Data.CheckIfClientHasAnyConsultationsScheduled(idClient))
                {
                    MessageBox.Show("O cliente selecionado já tem uma consulta marcada", 
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                //capturando os dados do cliente selecionado
                _idClient = idClient;
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
            
            if (DateTime.Now > Convert.ToDateTime(DateTimePicker.Value))
            {
                MessageBox.Show("Só é possível marcar consultas em datas e horários futuros",
                    "Data Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

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
                //DateTime time = Convert.ToDateTime(DateTimePicker.Text);
                DateTime consultationDate = Convert.ToDateTime(DateTimePicker.Text);

                if (_tipe == 0)// para adiconar
                {
                    string resp = Data.InsertConsultation(consultationDate, _timeOfConsultation, _idClient, 0);

                    if (resp == "Registro inserido com sucesso.")
                    {
                        MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //passando o botão que deve ficar selecionado
                        MenuButtonController.SetBtnConsultationsSelected();

                        // mandando atualizar o gerenciador
                        ScheduleManager.SetScheduleBusy(consultationDate, _timeOfConsultation);

                        FormLoader.OpenChildForm(new FrmConsultations());
                    }

                    else
                        MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else// para editar
                {
                    // no caso da edição ser uma remarcação vai editar a consulta para remarcada e criar uma nova consulta
                    if (this.CbxStatus.SelectedIndex == (int)Status.Remarcada)
                    {
                        // mesma data e mesmo horario
                        if (_consultationDateMemory == _consultationDate &&
                            _timeOfConsultation == _timeOfConsultationMemory)
                        {
                            MessageBox.Show("Para remarcar a data e o horario não podem ser iguais",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;
                        }

                        // primeiro muda o status da consulta para remarcada
                        string remarcar = Data.EditConsultationStatus(
                            _idConsultation, this.CbxStatus.SelectedIndex);

                        if (remarcar == "Registro editado com sucesso.")//a alteração ocoreu com sucesso
                        {

                            // agora criando a nova consulta
                            string resp = Data.InsertConsultation(consultationDate, _timeOfConsultation, _idClient, 0);

                            if (resp == "Registro inserido com sucesso.")
                            {
                                MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //passando o botão que deve ficar selecionado
                                MenuButtonController.SetBtnConsultationsSelected();

                                // mandando atualizar o gerenciador
                                ScheduleManager.SetScheduleBusy(consultationDate, _timeOfConsultation);

                                FormLoader.OpenChildForm(new FrmConsultations());
                            }

                            else
                                MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show(remarcar, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else// se não for remarcação só edita
                    {
                        string resp = Data.EditConsultation(_idConsultation, consultationDate, _timeOfConsultation, _idClient, this.CbxStatus.SelectedIndex);

                        if (resp == "Registro editado com sucesso.")
                        {
                            MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //passando o botão que deve ficar selecionado
                            MenuButtonController.SetBtnConsultationsSelected();

                            // mandando atualizar o gerenciador
                            ScheduleManager.SetScheduleBusy(consultationDate, _timeOfConsultation);

                            FormLoader.OpenChildForm(new FrmConsultations());
                        }

                        else
                            MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ValueChanged()
        {
            // primeiro deleta os botões que tem na tela
            foreach (Button btn in _buttons)
            {
                GbSchedule.Controls.Remove(btn);
            }

            // limpa a lista
            _buttons.Clear();

            // reseta o tamanho do Panel
            this.Panel.Height = 230;

            // limpando o textBox do horario
            //this.TxtTimeOfConsultation.Text = string.Empty;

            // carrega e adiciona os novos botões
            LoadSchedule();
        }

        //-------------------------- Evento de click dos botões dinamicos --------------------------

        private void DinamicButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (_selectedButton == btn)
                return;

            ChangeButtonCollor(btn);

            this.TxtTimeOfConsultation.Text = btn.Text;
        }

        //-------------------------- métodos criados pelo visual studio --------------------------

        private void BtnPickClient_Click(object sender, EventArgs e)
        {
            ChangePanelclientsVisibility();
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
            //passando o botão que deve ficar selecionado
            MenuButtonController.SetBtnConsultationsSelected();

            FormLoader.OpenChildForm(new FrmConsultations());
        }

        private void TxtSearchText_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void BtnFit_Click(object sender, EventArgs e)
        {
            this.TxtTimeOfConsultation.Enabled = !this.TxtTimeOfConsultation.Enabled;
        }
    }
}
