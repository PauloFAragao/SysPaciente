using SysPaciente.Entities;
using System;
using System.Windows.Forms;

namespace SysPaciente.Forms
{
    public partial class FrmAddEditClient : Form
    {
        int Tipe;//0 - adicionar |  1 - editar simples | 2 - editar adm
        int Id;

        //variaveis para conter o valor dos campos
        string name = "";
        string telephone = "";
        string street = "";
        string houseNumber = "";
        string neighborhood = "";
        string city = "";
        string complement = "";
        string idNumber = "";
        string cpf = "";

        //sobrecarca do construtor para edição de dados
        public FrmAddEditClient(int tipe, int id, string name, string telephone, string street, string houseNumber,
            string neighborhood, string city, string complement, string idNumber, string cpf)
        {
            InitializeComponent();

            //se vai adiinoar um paciente ou editar os dados dele
            Tipe = tipe;
            //id para edição
            Id = id;

            //carregando os dados
            LoadData(name, telephone, street, houseNumber, neighborhood, city, complement, idNumber, cpf);
        }

        public FrmAddEditClient(int tipe)
        {
            InitializeComponent();

            //se vai adiinoar um paciente ou editar os dados dele
            Tipe = tipe;

            //carregando os dados
            LoadData();
        }

        //sobrecarga do método para edição dedados
        private void LoadData(string name, string telephone, string street, string houseNumber,
            string neighborhood, string city, string complement, string idNumber, string cpf)
        {
            LoadData();

            //colocando os dados nos campos
            this.TxtName.Text = name;
            this.TxtTelephone.Text = telephone;
            this.TxtStreet.Text = street;
            this.TxtHouseNumber.Text = houseNumber;
            this.TxtNeighborhood.Text = neighborhood;
            this.TxtCity.Text = city;
            this.TxtComplement.Text = complement;
            this.TxtIdNumber.Text = idNumber;
            this.TxtCpf.Text = cpf;
        }

        private void LoadData()
        {
            //modo de editar simples
            if (Tipe == 1)
            {
                this.TxtIdNumber.Enabled = false;
                this.TxtCpf.Enabled = false;

                this.LblIdentidade.Text = "Identidade: ";
                this.LblCpf.Text = "cpf: ";

                this.BtnConfirm.Text = "Editar";
            }
        }

        //método que vai criar uma caixa de erro
        private void ErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //método para capturar e verificar as infirmações inseridas no formulario
        private bool CaptureAndVerifyData()
        {
            bool allFieldsFilledIn = true;

            //verificando e capturando dados
            if (!String.IsNullOrWhiteSpace(this.TxtName.Text))
                name = this.TxtName.Text;
            else
                allFieldsFilledIn = false;

            if (!String.IsNullOrWhiteSpace(this.TxtTelephone.Text))
                telephone = this.TxtTelephone.Text;
            else
                allFieldsFilledIn = false;

            if (!String.IsNullOrWhiteSpace(this.TxtStreet.Text))
                street = this.TxtStreet.Text;
            else
                allFieldsFilledIn = false;

            if (!String.IsNullOrWhiteSpace(this.TxtHouseNumber.Text))
                houseNumber = this.TxtHouseNumber.Text;
            else
                allFieldsFilledIn = false;

            if (!String.IsNullOrWhiteSpace(this.TxtHouseNumber.Text))
                houseNumber = this.TxtHouseNumber.Text;
            else
                allFieldsFilledIn = false;

            if (!String.IsNullOrWhiteSpace(this.TxtNeighborhood.Text))
                neighborhood = this.TxtNeighborhood.Text;
            else
                allFieldsFilledIn = false;

            if (!String.IsNullOrWhiteSpace(this.TxtCity.Text))
                city = this.TxtCity.Text;
            else
                allFieldsFilledIn = false;

            if (!String.IsNullOrWhiteSpace(this.TxtComplement.Text))
                complement = this.TxtComplement.Text;

            if (!String.IsNullOrWhiteSpace(this.TxtIdNumber.Text))
                idNumber = this.TxtIdNumber.Text;
            else
                allFieldsFilledIn = false;

            if (!String.IsNullOrWhiteSpace(this.TxtCpf.Text))
                cpf = this.TxtCpf.Text;
            else
                allFieldsFilledIn = false;

            return allFieldsFilledIn;
        }

        //método chamar o método CaptureAndVerifyData() e enviar para a classe Data
        private void VerifyAndSendData()
        {
            if (CaptureAndVerifyData())//captura e verifica os dados do formulario
            {
                if (Tipe == 0)//para adicionar um novo paciente
                {
                    string resp = Data.InsertClient(name, telephone, street, houseNumber, neighborhood, city, complement, idNumber, cpf);

                    if (resp == "Registro inserido com sucesso.")
                    {
                        MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoader.OpenChildForm(new FrmClients());
                    }

                    else
                        ErrorMessage(resp, "Erro");
                }
                else if(Tipe == 1)//para editar um paciente
                {
                    string resp = Data.EditClient(Id, name, telephone, street, houseNumber, neighborhood, city, complement);

                    if (resp == "Registro editado com sucesso.")
                    {
                        MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoader.OpenChildForm(new FrmClients());
                    }

                    else
                        ErrorMessage(resp, "Erro");
                }
                else//para edição de adm
                {

                }
            }
            else//se algum campo importante estiver em branco dá uma msg de erro
            {
                string msg = "Os seguintes campos não foram preenchidos:";
                msg += name == "" ? "\nNome" : "";
                msg += telephone == "" ? "\nTelefone" : "";
                msg += street == "" ? "\nRua" : "";
                msg += houseNumber == "" ? "\nNúmero" : "";
                msg += neighborhood == "" ? "\nBairro" : "";
                msg += city == "" ? "\nCidade" : "";
                msg += idNumber == "" ? "\nIdentidade" : "";
                msg += cpf == "" ? "\nCpf" : "";

                ErrorMessage(msg, "Campos não preenchidos");
            }
        }

        //------------------------------- métodos criados pelo visual studio
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            VerifyAndSendData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormLoader.OpenChildForm(new FrmClients());
        }
    }
}
