using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SysPaciente.Forms
{
    public partial class FrmConsultations : Form
    {
        bool SearchForName;

        DateTime date = DateTime.Now;

        public FrmConsultations()
        {
            InitializeComponent();

            //inicia buscando por nome
            SearchForName = true;

            //texto com a data na tela
            this.LblDate.Text = date.ToShortDateString();
        }

        //muda o texto do botão e do label
        private void ChangeText()
        {
            SearchForName = !SearchForName;

            if (SearchForName)
            {
                this.BtnSearchMode.Text = "Mudar para cpf";
                LblSearch.Text = "Buscar por nome:";
            }
            else
            {
                this.BtnSearchMode.Text = "Mudar para nome";
                LblSearch.Text = "Buscar por cpf:";
            }
        }

        //pega a data selecionada no DateTimePicker e guarda na variavel
        private void ChangeDate()
        {
            date = this.DateTimePicker.Value;

            this.LblDate.Text = date.ToShortDateString();

            ChangePanelChangeDateVisibility(false);
        }

        private void ChangePanelChangeDateVisibility(bool value)
        {
            this.PanelChangeDate.Visible = value;
        }

        //--------------------------------- métodos criados pelo visual studio
        private void BtnSearchMode_Click(object sender, EventArgs e)
        {
            ChangeText();
        }

        private void BtnChangeDate_Click(object sender, EventArgs e)
        {
            ChangeDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePanelChangeDateVisibility(true);
        }

        private void BtnCancelChangeDate_Click(object sender, EventArgs e)
        {
            ChangePanelChangeDateVisibility(false);
        }
    }
}
