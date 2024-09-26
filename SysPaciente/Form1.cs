using SysPaciente.Entities;
using SysPaciente.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPaciente
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private bool menu;

        public Form1()
        {
            InitializeComponent();

            //enviando a referencia do panel para a classe
            FormLoader.PanelBody = this.PanelBody;

            //o menu começa recolido
            menu = false;

            //o botão inicio (BtnHome) começa selecionado
            currentButton = BtnHome;
            FormLoader.OpenChildForm(new FrmHome());
        }

        //desseleciona o botão ativo e seleciona o novo botão
        private void ActivateButton(object btnSender)
        {
            if (btnSender != currentButton)
            {
                //resetando o outro botão q estava selecionado
                if (currentButton != null)
                {
                    currentButton.BackColor = Color.FromArgb(70, 130, 180);
                    currentButton.ForeColor = Color.Black;
                }

                //marcando o botão o botão selecionado
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(63, 72, 204);
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        //desseleciona o botão ativo - para ser chamado pelo menu adm
        private void DesactivateButton()
        {
            //resetando o outro botão q estava selecionado
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(70, 130, 180);
                currentButton.ForeColor = Color.Black;
                currentButton = null;
            }
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

        //quando o botão pacientes for clicado
        private void Clients()
        {
            //passando o botão que deve ficar selecionado
            Button btn = this.BtnClients;
            ActivateButton(btn);

            //desativar o menu se ele estiver ativado
            MenuController();

            //carregar a form
            FormLoader.OpenChildForm(new FrmClients());
        }

        private void Consultations()
        {
            //passando o botão que deve ficar selecionado
            Button btn = this.BtnConsultations;
            ActivateButton(btn);

            //desativar o menu se ele estiver ativado
            MenuController();
            
            //carregar a form
            FormLoader.OpenChildForm(new FrmConsultations());
        }

        private void Settings()
        {
            //passando o botão que deve ficar selecionado
            Button btn = this.BtnConfigurations;
            ActivateButton(btn);

            //desativar o menu se ele estiver ativado
            MenuController();

            //carregar a form
            FormLoader.OpenChildForm(new FrmSettings());
        }

        private void Home()
        {
            //passando o botão que deve ficar selecionado
            Button btn = this.BtnHome;
            ActivateButton(btn);

            //desativar o menu se ele estiver ativado
            MenuController();

            //carregar a form
            FormLoader.OpenChildForm(new FrmHome());
        }

        private void Adm()
        {
            //desativando todos os botões
            DesactivateButton();

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
            //ActivateButton(sender);
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            Clients();
            //ActivateButton(sender);
        }

        private void BtnConsultations_Click(object sender, EventArgs e)
        {
            Consultations();
            //ActivateButton(sender);
        }

        private void BtnConfigurations_Click(object sender, EventArgs e)
        {
            Settings();
            //ActivateButton(sender);
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
