using SysPaciente.Entities;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SysPaciente.Forms
{
    public partial class FrmAddEditClient : Form
    {
        private int _tipe;//0 - adicionar |  1 - editar simples | 2 - editar adm
        private int _id;

        //variaveis para conter o valor dos campos
        string _name = "";
        string _telephone = "";
        string _dateOfBirth = "";
        string _street = "";
        string _houseNumber = "";
        string _neighborhood = "";
        string _city = "";
        string _cep = "";
        string _state = "";
        string _complement = "";
        string _idNumber = "";
        string _cpf = "";

        //sobrecarca do construtor para edição de dados
        public FrmAddEditClient(int tipe, int id, string name, string telephone, DateTime dateOfBirth, string street, string houseNumber,
            string neighborhood, string city, string cep, string state, string complement, string idNumber, string cpf)
        {
            InitializeComponent();

            //se vai adiinoar um paciente ou editar os dados dele
            _tipe = tipe;
            //id para edição
            _id = id;

            //carregando os dados
            LoadData(name, telephone, dateOfBirth, street, houseNumber, neighborhood, city, cep, state, complement, idNumber, cpf);
        }

        public FrmAddEditClient(int tipe)
        {
            InitializeComponent();

            //se vai adiinoar um paciente ou editar os dados dele
            _tipe = tipe;

            //pra já carregar o RJ selecionado
            this.CbxState.SelectedIndex = 18;
            this.TxtName.Focus();//não funciona

            //carregando os dados
            LoadData();
        }

        //sobrecarga do método para edição dedados
        private void LoadData(string name, string telephone, DateTime dateOfBirth, string street, string houseNumber,
            string neighborhood, string city, string cep, string state, string complement, string idNumber, string cpf)
        {
            LoadData();

            //colocando os dados nos campos
            this.TxtName.Text = name;
            this.TxtTelephone.Text = telephone;
            this.MskDateOfBirth.Text = dateOfBirth.ToString("dd-MM-yyyy");
            this.TxtStreet.Text = street;
            this.TxtHouseNumber.Text = houseNumber;
            this.TxtNeighborhood.Text = neighborhood;
            this.TxtCity.Text = city;
            this.MskCep.Text = cep;
            this.CbxState.Text = state;
            this.TxtComplement.Text = complement;
            this.TxtIdNumber.Text = idNumber;
            this.MskCpf.Text = cpf;
        }

        private void LoadData()
        {
            //modo de editar simples
            if (_tipe == 1)
            {
                //tornando campos desabilitados para evitar edição de dados
                this.TxtIdNumber.Enabled = false;
                this.MskCpf.Enabled = false;
                this.TxtName.Enabled = false;

                //mudando nome dos labels para tirar o *
                this.LblIdentidade.Text = "Identidade: ";
                this.LblCpf.Text = "cpf: ";
                this.LblName.Text = "Nome:";

                //mudando o nome do botão
                this.BtnConfirm.Text = "Editar";
            }
            //modo de edição de adm
            else if (_tipe == 2)
            {
                //label que indica modo de edição de administrador
                this.LblAdm.Visible = true;

                //mudando nome do botão
                this.BtnConfirm.Text = "Editar";
            }
        }

        //método para capturar e verificar as infirmações inseridas no formulario
        private bool CaptureAndVerifyData()
        {
            bool allFieldsAreCorrect = true;
            string msg = "Os seguintes campos não foram preenchidos:";

            // nome
            if (!String.IsNullOrWhiteSpace(this.TxtName.Text))
                _name = this.TxtName.Text;
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nNome";
            }

            // telefone
            if (!String.IsNullOrWhiteSpace(this.TxtTelephone.Text))
                _telephone = this.TxtTelephone.Text;
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nTelefone";
            }

            // data de nascimento
            if (this.MskDateOfBirth.MaskCompleted)
            {
                _dateOfBirth = this.MskDateOfBirth.Text;
            }
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nData de nascimento";
            }

            // rua
            if (!String.IsNullOrWhiteSpace(this.TxtStreet.Text))
                _street = this.TxtStreet.Text;
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nRua";
            }

            // numero da casa
            if (!String.IsNullOrWhiteSpace(this.TxtHouseNumber.Text))
                _houseNumber = this.TxtHouseNumber.Text;
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nNúmero da casa";
            }

            // cep
            if (this.MskCep.MaskCompleted)
            {
                _cep = this.MskCep.Text;
            }
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nCep";
            }

            // bairo
            if (!String.IsNullOrWhiteSpace(this.TxtNeighborhood.Text))
                _neighborhood = this.TxtNeighborhood.Text;
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nBairro";
            }

            // cidade
            if (!String.IsNullOrWhiteSpace(this.TxtCity.Text))
                _city = this.TxtCity.Text;
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nCidade";
            }

            // numero da identidade
            if (!String.IsNullOrWhiteSpace(this.TxtIdNumber.Text))
                _idNumber = this.TxtIdNumber.Text;
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nNúmero da identidade";
            }

            // numero do cpf
            if (this.MskCpf.MaskCompleted)
            {
                _cpf = this.MskCpf.Text;
                _cpf = new string(_cpf.Where(char.IsDigit).ToArray());//tirando os pontos e o traço
            }
            else
            {
                allFieldsAreCorrect = false;
                msg += "\nNúmero do Cpf";
            }

            // complemento - não é mercado com *
            if (!String.IsNullOrWhiteSpace(this.TxtComplement.Text))
                _complement = this.TxtComplement.Text;

            // simplesmente capturando o valor do campo pq sempre vai estar preenchido
            _state = this.CbxState.Text;

            if (!allFieldsAreCorrect)// se algum campo não foi preencido dá um erro
            {
                MessageBox.Show(msg, "Campos não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CpfValidator.Validate(_cpf))// se o cfp não for valido 
            {
                MessageBox.Show("O cpf digitado não é valido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                allFieldsAreCorrect = false;
            }

            return allFieldsAreCorrect;
        }

        //método chamar o método CaptureAndVerifyData() e enviar para a classe Data
        private void VerifyAndSendData()
        {
            if (CaptureAndVerifyData())//captura e verifica os dados do formulario
            {

                //converter a data de nascimento
                DateTime birth = DateTime.Parse(_dateOfBirth);

                if (_tipe == 0)//para adicionar um novo paciente
                {
                    string resp =  Data.InsertClient(_name, _telephone, birth, _street, _houseNumber, _neighborhood, 
                        _city, _cep, _state, _complement, _idNumber, _cpf);

                    if (resp == "Registro inserido com sucesso.")
                    {
                        MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoader.OpenChildForm(new FrmClients());
                    }

                    else
                        MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (_tipe == 1)//para editar um paciente
                {
                    string resp = Data.EditClient(_id, _telephone, birth, _street, _houseNumber, _neighborhood, _city, _cep, _state, _complement);

                    if (resp == "Registro editado com sucesso.")
                    {
                        MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoader.OpenChildForm(new FrmClients());
                    }

                    else
                        MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else//para edição de adm
                {
                    string resp = Data.EditClientAdm(_id, _name, _telephone, birth, _street, _houseNumber, _neighborhood, _city, _cep, _state, _complement, _idNumber, _cpf);

                    if (resp == "Registro editado com sucesso.")
                    {
                        MessageBox.Show(resp, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormLoader.OpenChildForm(new FrmClients());

                        //mandando o botão de clientes ficar selecionado
                        MenuButtonController.SetBtnClientsSelected();
                    }

                    else
                        MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Cancel()
        {
            if (_tipe == 2)//para adicionar um novo paciente
            {
                //mandando o botão de clientes ficar selecionado
                MenuButtonController.SetBtnClientsSelected();
            }

            FormLoader.OpenChildForm(new FrmClients());
        }

        //------------------------------- métodos criados pelo visual studio
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            VerifyAndSendData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
