using SysPaciente.Entities;
using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;
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

            if(LoadData())
            {
                HideColumns();
                ChangeColumns();
            }
        }

        private bool LoadData()
        {
            DataTable dataTable = Data.ShowConsultationsByDate(_date, "");

            if (dataTable != null)
            {
                this.DgvData.DataSource = ChangeStatus(dataTable);
                return true;
            }
            else
            {
                return false;
            }
        }

        private DataTable ChangeStatus(DataTable dataTable)
        {
            // Adicionando a nova coluna
            dataTable.Columns.Add("Status da consulta", typeof(string));

            // Reorganizando as colunas
            dataTable.Columns["Status da consulta"].SetOrdinal(dataTable.Columns["status"].Ordinal + 1);

            Debug.WriteLine("Quantidade de rows: " + dataTable.Rows.Count);

            foreach (DataRow row in dataTable.Rows)
            {
                if(row != null)
                {
                    string status = Enum.GetName(typeof(Status), Convert.ToInt32(row["status"]));

                    row["Status da consulta"] = status;
                }
            }

            return dataTable;
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
            //mudando o tamanho da coluna para os valores serem coretamente exibidos
            this.DgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Altera o texto do cabeçalho da coluna 3 para "Horário da colsulta"
            this.DgvData.Columns[3].HeaderText = "Horário da colsulta";
            this.DgvData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void Search()
        {
            if (!String.IsNullOrWhiteSpace(this.TxtSearchText.Text))
            {
                DataTable dataTable = Data.ShowConsultationsByDate(_date, this.TxtSearchText.Text);

                if (dataTable != null)
                    this.DgvData.DataSource = ChangeStatus(dataTable);
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
    }
}
