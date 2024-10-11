using SysPaciente.Entities;
using SysPaciente.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SysPaciente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // classe FormLoader
            FormLoader.PanelBody = this.PanelBody;
            FormLoader.PanelMenu = this.PanelMenu;
            FormLoader.MenuButton = this.BtnMenu;

            // classe que controla os botões
            MenuButtonController.SetButtonsData(this.BtnHome, this.BtnClients, this.BtnConsultations, this.BtnConfigurations);

            // o botão inicio (BtnHome) começa selecionado
            MenuButtonController.SetBtnHomeSelected();
            FormLoader.OpenChildForm(new FrmHome());
        }

        private void Clients()
        {
            //passando o botão que deve ficar selecionado
            MenuButtonController.SetBtnClientsSelected();

            //carregar a form
            FormLoader.OpenChildForm(new FrmClients());
        }

        private void Consultations()
        {
            //passando o botão que deve ficar selecionado
            MenuButtonController.SetBtnConsultationsSelected();
            
            //carregar a form
            FormLoader.OpenChildForm(new FrmConsultations());
        }

        private void Settings()
        {
            //passando o botão que deve ficar selecionado
            MenuButtonController.SetBtnConfigurationsSelected();

            //carregar a form
            FormLoader.OpenChildForm(new FrmSettings());
        }

        private void Home()
        {
            //passando o botão que deve ficar selecionado
            MenuButtonController.SetBtnHomeSelected();

            //carregar a form
            FormLoader.OpenChildForm(new FrmHome());
        }

        private void Adm()
        {
            //desativando todos os botões
            MenuButtonController.UnselectCurrentButton();

            //carregar a form
            FormLoader.OpenChildForm(new FrmAdm());
        }

        //------------------------- métodos criados pelo visual studio -------------------------

        //------------------------- botões da interface
        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            Clients();
        }

        private void BtnConsultations_Click(object sender, EventArgs e)
        {
            Consultations();
        }

        private void BtnConfigurations_Click(object sender, EventArgs e)
        {
            Settings();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FormLoader.MenuController();
        }

        //------------------------- botões do menu
        private void BtnMHome_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void BtnMClients_Click(object sender, EventArgs e)
        {
            Clients();
        }

        private void BtnMConsultations_Click(object sender, EventArgs e)
        {
            Consultations();
        }

        private void BtnMConfigurations_Click(object sender, EventArgs e)
        {
            Settings();
        }

        private void BtnMAdministration_Click(object sender, EventArgs e)
        {
            Adm();
        }

    }
}
