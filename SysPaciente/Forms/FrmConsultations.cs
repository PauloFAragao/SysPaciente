using SysPaciente.Entities;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SysPaciente.Forms
{
    public partial class FrmConsultations : Form
    {
        private DateTime _date;

        public FrmConsultations()
        {
            InitializeComponent();

            //capturando a data do sistema
            _date = DateTime.Now;

            //texto com a data na tela
            this.LblDate.Text = _date.ToShortDateString();

            //carregando os dados
            Task.Run(() => Initialize());

        }

        private void Search()
        {
            if (!String.IsNullOrWhiteSpace(this.TxtSearchText.Text))
                Task.Run(() => SearchName());

            else
                Task.Run(() => LoadData());
        }

        //pega a data selecionada no DateTimePicker e guarda na variavel
        private void ChangeDate()
        {
            _date = this.DateTimePicker.Value;

            this.LblDate.Text = _date.ToShortDateString();

            ChangePanelChangedateVisibility(false);

            Task.Run(() => LoadData());
        }

        private void ChangePanelChangedateVisibility(bool value)
        {
            EnableAndDisableUiButtons(!value);// para os botões da interface

            this.PanelChangeDate.Visible = value;
        }

        private void ChangePanelAlterstatusVicibility(bool value)
        {
            EnableAndDisableUiButtons(!value);// para os botões da interface

            if (DgvData.Rows.Count > 0)
            {
                this.PanelAlterStatus.Visible = value;

                CbxStatus.Text = Convert.ToString(this.DgvData.CurrentRow.Cells["statusDescription"].Value);
            }
            else
            {
                MessageBox.Show("A tabela não tem dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                EnableAndDisableUiButtons(true);
            }
        }

        private void EnableAndDisableUiButtons(bool value)
        {
            this.BtnDate.Enabled = value;
            this.BtnChangeStatus.Enabled = value;
            this.BtnEdit.Enabled = value;
            this.BtnMark.Enabled = value;
        }

        private void Edit()
        {
            if (DgvData.Rows.Count > 0)
            {
                FormLoader.OpenChildForm(new FrmMarkEditConsultation(
                    Convert.ToInt32(this.DgvData.CurrentRow.Cells["idConsultation"].Value),
                    Convert.ToInt32(this.DgvData.CurrentRow.Cells["idClient"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["consultationDate"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["timeOfConsultation"].Value),
                    Convert.ToString(this.DgvData.CurrentRow.Cells["statusDescription"].Value)));
            }
            else
            {
                MessageBox.Show("A tabela não tem dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditStatus()
        {
            string resp = Data.EditConsultationStatus(
                Convert.ToInt32(this.DgvData.CurrentRow.Cells["idConsultation"].Value),
                this.CbxStatus.SelectedIndex);

            if (resp == "Registro editado com sucesso.")
            {
                MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangePanelAlterstatusVicibility(false);

                Task.Run(() => LoadData());
            }
            else
                MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //--------------------------------- Thread
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
            DataTable dataTable = Data.SearchWithDate(_date);

            if (dataTable != null)
            {
                ThreadHelper.SetPropertyValue(DgvData, "DataSource", dataTable);
                return true;
            }
            else
                return false;
        }

        private void HideColumns()
        {
            ThreadHelper.SetColumnVisibility(this.DgvData, 0, false);//id da colsulta
            ThreadHelper.SetColumnVisibility(this.DgvData, 2, false);//data
            ThreadHelper.SetColumnVisibility(this.DgvData, 4, false);//id do paciente
            ThreadHelper.SetColumnVisibility(this.DgvData, 5, false);//valor inteiro do status da consulta
        }

        private void ChangeColumns()
        {
            // Altera o texto do cabeçalho da coluna 1 para "Nome do paciente"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 1, "Nome do paciente");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 1, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 3 para "Horário da colsulta"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 3, "Horário da colsulta");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 3, DataGridViewAutoSizeColumnMode.AllCells);

            // Altera o texto do cabeçalho da coluna 6 para "Horário da colsulta"
            ThreadHelper.SetColumnHeaderText(this.DgvData, 6, "Horário da colsulta");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 6, DataGridViewAutoSizeColumnMode.AllCells);
        }

        private void SearchName()
        {
            DataTable dataTable = Data.SearchWithDateAndName(_date, this.TxtSearchText.Text);

            if (dataTable != null)
            {
                ThreadHelper.SetPropertyValue(this.DgvData, "DataSource", dataTable);
            }

            ThreadHelper.SetPropertyValue(this.BtnSearch, "Enabled", true);
        }

        //--------------------------------- métodos criados pelo visual studio

        private void BtnChangeDate_Click(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void BtnCancelChangeDate_Click(object sender, EventArgs e)
        {
            ChangePanelChangedateVisibility(false);
        }

        private void BtnDate_Click(object sender, EventArgs e)
        {
            ChangePanelChangedateVisibility(true);
        }

        private void BtnChangeStatus_Click(object sender, EventArgs e)
        {
            ChangePanelAlterstatusVicibility(true);
        }

        private void BtnCancelAlterStatus_Click(object sender, EventArgs e)
        {
            ChangePanelAlterstatusVicibility(false);
        }

        private void BtnAlterStatus_Click(object sender, EventArgs e)
        {
            EditStatus();
        }

        private void BtnMark_Click(object sender, EventArgs e)
        {
            FormLoader.OpenChildForm(new FrmMarkEditConsultation());
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
