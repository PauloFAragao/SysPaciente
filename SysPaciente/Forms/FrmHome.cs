using System;
using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
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

            // carregando os dados
            Task.Run(() => Initialize());

            // quantidade de pendencias
            this.LblPending.Text = DgvData.Rows.Count.ToString();
        }

        private void Atualize()
        {
            Debug.WriteLine("Atualizou");
            LoadPendingTable();
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
        //---------------------------- Thread

        private void Initialize()
        {
            // capturando pendencias
            if (LoadPendingTable())
            {
                HideColumns();
                ChangeColumns();

                // para iniciar com a primeira linha selecionada
                ThreadHelper.SelectFirstRow(this.DgvData);
            }
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
                //this.DgvData.DataSource = dataTable;
                ThreadHelper.SetPropertyValue(DgvData, "DataSource", dataTable);
            }

            return isNotNull;
        }

        private void HideColumns()
        { 
            ThreadHelper.SetColumnVisibility(this.DgvData, 0, false);
            ThreadHelper.SetColumnVisibility(this.DgvData, 1, false);
        }

        private void ChangeColumns()
        {
            ThreadHelper.SetColumnHeaderText(this.DgvData, 2, "Nome do paciente");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 2, DataGridViewAutoSizeColumnMode.AllCells);

            ThreadHelper.SetColumnHeaderText(this.DgvData, 3, "Telefone");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 3, DataGridViewAutoSizeColumnMode.AllCells);

            ThreadHelper.SetColumnHeaderText(this.DgvData, 4, "Data da consulta");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 4, DataGridViewAutoSizeColumnMode.AllCells);

            ThreadHelper.SetColumnHeaderText(this.DgvData, 5, "Horário da consulta");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 5, DataGridViewAutoSizeColumnMode.AllCells);

            ThreadHelper.SetColumnHeaderText(this.DgvData, 6, "Status da consulta");
            ThreadHelper.SetColumnAutoSizeMode(this.DgvData, 6, DataGridViewAutoSizeColumnMode.AllCells);
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
