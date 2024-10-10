using System.Data;
using System.Windows.Forms;
using SysPaciente.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SysPaciente.Forms
{
    public partial class FrmClientHistorical : Form
    {
        private bool _menu;// Indica se o menu está aberto ou não

        public FrmClientHistorical(int id, string name)
        {
            InitializeComponent();

            if(LoadData(id, name))
            {
                ChangeColumns();
            }
        }

        private bool LoadData(int id, string name)
        {
            this.LblClientName.Text = name;

            DataTable dataTable = Data.ConsultationsOfClient(id);

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

        private void ChangeColumns()
        {
            this.DgvData.Columns[0].HeaderText = "Data da consulta";
            this.DgvData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.DgvData.Columns[1].HeaderText = "Hórario da consulta";
            this.DgvData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.DgvData.Columns[2].HeaderText = "Status da consulta";
            this.DgvData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void Back()
        {
            //carregar a form
            FormLoader.OpenChildForm(new FrmClients());
        }

        //-------------------- métodos criados pelo visual studio
        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            Back();
        }
    }
}
