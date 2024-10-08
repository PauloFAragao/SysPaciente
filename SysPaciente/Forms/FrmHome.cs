using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using SysPaciente.Entities;

namespace SysPaciente.Forms
{
    public partial class FrmHome : Form
    {
        Timer _timer = new Timer();

        public FrmHome()
        {
            InitializeComponent();

            _timer.Interval = 60000;//300000; // 5 minutos em milissegundos
            _timer.Tick += Timer_Tick;
            _timer.Start();

            LoadData();
        }

        private void LoadData()
        {
            // quantidade de consultas marcadas para hoje
            LblConsultationsAmount.Text = Data.GetConsultationsAmount(DateTime.Now).ToString();


            // proximo horario disponivel
            string FreeTimeText;
            if (DateTime.TryParse(ScheduleManager.GetFreeSchedule().ToString(), out DateTime nextFreeTime))
            {
                FreeTimeText = "Dia: ";
                FreeTimeText += nextFreeTime.ToString("dd/MM/yyyy");
                FreeTimeText += "  horário: ";
                FreeTimeText += nextFreeTime.TimeOfDay;
            }
            else
            {
                FreeTimeText = "Sem data livre pelos proximos 7 dias";
            }
            LblFreeTime.Text = FreeTimeText;


            // capturando pendencias
            if(LoadPendingTable())
            {
                HideColumns();
                ChangeColumns();
            }

        }

        private void Atualize()
        {
            Debug.WriteLine("Atualizou");
            LoadPendingTable();
        }

        private bool LoadPendingTable()
        {
            // capturando dados para a tabela
            DataTable dataTable = Data.SearchPendingIssues();

            // pegano as consultas marcadas que estão com status atrasado
            DataTable dt = Data.SearchEntriesThatNeedToBeUpdated();

            // para controle se tem dados
            bool isNotNull = false;

            if (dataTable != null)// verificando se tem dados
            {
                isNotNull = true;
            }
            if (dt != null)// verificando se tem dados
            {
                isNotNull = true;

                dataTable.Merge(dt);
            }

            if (isNotNull)
            {
                this.DgvData.DataSource = dataTable;

                this.LblPending.Text = dataTable.Rows.Count.ToString();
            }

            return isNotNull;
        }

        private void HideColumns()
        {
            this.DgvData.Columns[0].Visible = false;
            this.DgvData.Columns[1].Visible = false;
        }

        private void ChangeColumns()
        {
            this.DgvData.Columns[2].HeaderText = "Nome do paciente";
            this.DgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.DgvData.Columns[3].HeaderText = "Telefone";
            this.DgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.DgvData.Columns[4].HeaderText = "Data da consulta";
            this.DgvData.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.DgvData.Columns[5].HeaderText = "Horário da consulta";
            this.DgvData.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.DgvData.Columns[6].HeaderText = "Status da consulta";
            this.DgvData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            }
        }

        private void EnableAndDisableUiButtons(bool value)
        {
            this.BtnChangeStatus.Enabled = value;
            this.BtnEdit.Enabled = value;
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
                LoadPendingTable();
            }
            else
                MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //---------------------------- Eventos

        private void Timer_Tick(object sender, EventArgs e)
        {
            Atualize();
        }

        //---------------------------- Métodos criados pelo visual studio
        private void BtnChangeStatus_Click(object sender, EventArgs e)
        {
            ChangePanelAlterstatusVicibility(true);
        }

        private void BtnAlterStatus_Click(object sender, EventArgs e)
        {
            EditStatus();
        }

        private void BtnCancelAlterStatus_Click(object sender, EventArgs e)
        {
            ChangePanelAlterstatusVicibility(false);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }
    }
}
