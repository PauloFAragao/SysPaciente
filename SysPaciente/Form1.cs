using SysPaciente.Entities;
using SysPaciente.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SysPaciente
{
    public partial class Form1 : Form
    {
        private bool menu;

        public Form1()
        {
            InitializeComponent();

            //enviando a referencia do panel para a classe
            FormLoader.PanelBody = this.PanelBody;

            //o menu começa recolido
            menu = false;

            //
            MenuButtonController.SetButtonsData(this.BtnHome, this.BtnClients, this.BtnConsultations, this.BtnConfigurations);

            //o botão inicio (BtnHome) começa selecionado
            MenuButtonController.SetBtnHomeSelected();
            FormLoader.OpenChildForm(new FrmHome());
        }

        //sobrecarga para desativar o menu
        private void MenuController()
        {
            if (menu)
            {
                Button btn = this.BtnMenu;
                MenuController(btn);
            } 
        }

        //sobrecarga para ser chamada pelo botão no menu
        private void MenuController(object sender)
        {
            Button bt = (Button)sender;

            if (menu)
            {
                menu = !menu;
                this.PanelMenu.Visible = false;
                bt.BackColor = Color.FromArgb(70, 130, 180);
                bt.ForeColor = Color.Black;
            }
            else
            {
                menu = !menu;
                this.PanelMenu.Visible = true;
                bt.BackColor = Color.FromArgb(63, 72, 204);
                bt.ForeColor = Color.White;
                PanelMenu.BringToFront();//trazendo para frente
            }
        }

        private void Clients()
        {
            //passando o botão que deve ficar selecionado
            MenuButtonController.SetBtnClientsSelected();

            //desativar o menu se ele estiver ativado
            MenuController();

            //carregar a form
            FormLoader.OpenChildForm(new FrmClients());
        }

        private void Consultations()
        {
            //passando o botão que deve ficar selecionado
            MenuButtonController.SetBtnConsultationsSelected();

            //desativar o menu se ele estiver ativado
            MenuController();
            
            //carregar a form
            FormLoader.OpenChildForm(new FrmConsultations());
        }

        private void Settings()
        {
            //passando o botão que deve ficar selecionado
            MenuButtonController.SetBtnConfigurationsSelected();

            //desativar o menu se ele estiver ativado
            MenuController();

            //carregar a form
            FormLoader.OpenChildForm(new FrmSettings());
        }

        private void Home()
        {
            //passando o botão que deve ficar selecionado
            MenuButtonController.SetBtnHomeSelected();

            //desativar o menu se ele estiver ativado
            MenuController();

            //carregar a form
            FormLoader.OpenChildForm(new FrmHome());
        }

        private void Adm()
        {
            //desativando todos os botões
            MenuButtonController.UnselectCurrentButton();

            //desativar o menu se ele estiver ativado
            MenuController();

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
            MenuController(sender);
        }

        //------------------------- botões do menu
        private void BtnMHome_Click(object sender, EventArgs e)
        {
            //Button btn = this.BtnHome;
            //ActivateButton(btn);
            Home();
            //MenuController();
        }

        private void BtnMClients_Click(object sender, EventArgs e)
        {
            Clients();
            //MenuController();
        }

        private void BtnMConsultations_Click(object sender, EventArgs e)
        {
            //Button btn = this.BtnConsultations;
            //ActivateButton(btn);
            Consultations();
            //MenuController();
        }

        private void BtnMConfigurations_Click(object sender, EventArgs e)
        {
            //Button btn = this.BtnConfigurations;
            //ActivateButton(btn);
            Settings();
            //MenuController();
        }

        private void BtnMAdministration_Click(object sender, EventArgs e)
        {


            Adm();

            //Debug.WriteLine( Data.InsertClient("Maria das Dores",
            //"2128861234","Rua A","102","Fazendinha","Rio de Janeiro","Fundos","123456789","12345678901") );
        }

    }
}
