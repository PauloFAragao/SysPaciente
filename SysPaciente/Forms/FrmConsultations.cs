using SysPaciente.Entities;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using SysPaciente.Entities.Enums;

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

            if (LoadData())
            {
                HideColumns();
                ChangeColumns();
            }
        }

        private bool LoadData()
        {
            //DataTable dataTable = Data.ShowConsultationsByDate(_date, "");

            DataTable dataTable = Data.SearchWithDate(_date);

            if (dataTable != null)
            {
                //this.DgvData.DataSource = ChangeStatus(dataTable);
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
            this.DgvData.Columns[0].Visible = false;//id da colsulta
            this.DgvData.Columns[2].Visible = false;//data
            this.DgvData.Columns[4].Visible = false;//id do paciente
            this.DgvData.Columns[5].Visible = false;//valor inteiro do status da consulta
        }

        private void ChangeColumns()
        {
            // Altera o texto do cabeçalho da coluna 1 para "Nome do paciente"
            this.DgvData.Columns[1].HeaderText = "Nome do paciente";
            this.DgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 3 para "Horário da colsulta"
            this.DgvData.Columns[3].HeaderText = "Horário da colsulta";
            this.DgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 6 para "Horário da colsulta"
            this.DgvData.Columns[6].HeaderText = "Status";
            this.DgvData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void Search()
        {
            if (!String.IsNullOrWhiteSpace(this.TxtSearchText.Text))
            {
                //DataTable dataTable = Data.ShowConsultationsByDate(_date, this.TxtSearchText.Text);
                DataTable dataTable = Data.SearchWithDateAndName(_date, this.TxtSearchText.Text);

                if (dataTable != null)
                    this.DgvData.DataSource = dataTable;//ChangeStatus(dataTable);
            }
            else
                LoadData();
        }

        //pega a data selecionada no DateTimePicker e guarda na variavel
        private void ChangeDate()
        {
            _date = this.DateTimePicker.Value;

            this.LblDate.Text = _date.ToShortDateString();

            ChangePanelChangedateVisibility(false);

            LoadData();
        }

        private void ChangePanelChangedateVisibility(bool value)
        {
            this.PanelChangeDate.Visible = value;
        }

        private void ChangePanelAlterstatusVicibility(bool value)
        {
            if (DgvData.Rows.Count > 0)
            {
                this.PanelAlterStatus.Visible = value;

                CbxStatus.Text = Convert.ToString(this.DgvData.CurrentRow.Cells["statusDescription"].Value);
            }
            else
            {
                MessageBox.Show("A tabela não tem dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                LoadData();
            }
            else
                MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TxtSearchText_TextChanged(object sender, EventArgs e)
        {
            Search();
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
    }
}
