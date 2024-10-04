using SysPaciente.Entities;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SysPaciente.Forms
{
    public partial class FrmAdm : Form
    {
        //temporario
        private string _password;

        public FrmAdm()
        {
            InitializeComponent();

            //_password = "123";
            LoadPassword();

            //focus no campo não funciona
            this.TxtPassord.Focus();
        }

        private void LoadPassword()
        {
            _password = Data.GetPassword();
        }

        private void VerifyPassword()
        {
            //se a senha estiver correta
            if (this.TxtPassord.Text == _password)
            {
                PanelLogin.Visible = false;//retira o panel da tela

                //torna os botões enabled
                this.BtnEditClient.Enabled = true;
                this.BtnDelConsultations.Enabled = true;
                this.BtnChangePassword.Enabled = true;
            }
            else
            {
                //mostra a msg de senha errada
                LblError.Visible = true;
            }
        }

        private void ChangePassword()
        {
            //verifica se o panel de alterar a senha visivel
            if(!this.PainelChangePassword.Visible)
            {
                //torna o botão invisivel
                this.BtnChangePassword.Visible = false;

                //tornao o painel visivel
                this.PainelChangePassword.Visible = true;

                //limpa os campos
                this.TxtCurrentPassword.Text = string.Empty;
                this.TxtNewPassword.Text = string.Empty;
                this.TxtConfirmPassword.Text = string.Empty;

                //retira os avisos da tela
                this.LblPasswordWrong.Visible = false;
                this.LblPasswordsNotMatch.Visible = false;
                this.LblPasswordFieldInBlank.Visible = false;
                this.LblConfirmFieldInBlank.Visible = false;
            }
            else
            {
                //captura a nova senha
                //_password = this.TxtNewPassword.Text;
                string newPassword = this.TxtNewPassword.Text;

                //torna o botão para alterar senha visivel
                this.BtnChangePassword.Visible = true;

                //torna o painel invisivel
                this.PainelChangePassword.Visible = false;

                string resp = Data.SetPassword(newPassword);

                if(resp == "Registro editado com sucesso.")
                {
                    _password = newPassword;
                }
                else
                {
                    MessageBox.Show(resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckToChangePassword()
        {
            //verifica se a senha digitada como senha atual está correta
            if (this.TxtCurrentPassword.Text != _password)
            {
                this.LblPasswordWrong.Visible = true;//torna o aviso de senha errada visivel
            }
            else
            {   //apaga o aviso de senha errada
                this.LblPasswordWrong.Visible = false;

                bool NewPassordFild = TxtNewPasswordIsNull();
                bool ConfirmPassordFild = TxtConfirmPasswordIsNull();

                //verifica se os campos estão em branco-é chamado assim para que haja uma verificação individual
                if (NewPassordFild && ConfirmPassordFild)
                {
                    //verifica se os campos tem valores correspondentes
                    if (this.TxtNewPassword.Text == this.TxtConfirmPassword.Text)
                    {
                        this.LblPasswordsNotMatch.Visible = false;
                        ChangePassword();//chama o método que troca a senha e tira o painel da tela
                    }
                    else
                        this.LblPasswordsNotMatch.Visible = true;//torna o aviso de senhas diferentes visivel

                }
            }
        }

        private void CancelChangePassword()
        {
            //torna o botão para alterar senha visivel
            this.BtnChangePassword.Visible = true;

            //torna o painel invisivel
            this.PainelChangePassword.Visible = false;
        }

        //verifica se o campo da nova senha está vasio
        private bool TxtNewPasswordIsNull()
        {
            if (String.IsNullOrWhiteSpace(this.TxtNewPassword.Text))
            {
                Debug.WriteLine("O campo da nova senha está em branco");
                this.LblPasswordFieldInBlank.Visible = true;

                return false;
            }
            else
                return true;
        }

        //verifica se o campo de confirmar nova senha estao vasio
        private bool TxtConfirmPasswordIsNull()
        {
            if (String.IsNullOrWhiteSpace(this.TxtConfirmPassword.Text))
            {
                Debug.WriteLine("O campo de confirmar a nova senha está em branco");
                this.LblConfirmFieldInBlank.Visible = true;

                return false;
            }
            else
                return true;
        }

        //--------------- métodos do visual studio ---------------
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            VerifyPassword();
        }

        private void TxtPassord_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica se foi pressionado o enter
            if (e.KeyChar == '\r') VerifyPassword();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }

        private void BtnConfirmPasswordChange_Click(object sender, EventArgs e)
        {
            CheckToChangePassword();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CancelChangePassword();
        }

        private void BtnEditClient_Click(object sender, EventArgs e)
        {
            FormLoader.OpenChildForm(new FrmAdmClients());
        }

        private void TxtNewPassword_TextChanged(object sender, EventArgs e)
        {
            this.LblPasswordFieldInBlank.Visible = false;
        }

        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            this.LblConfirmFieldInBlank.Visible = false;
        }

        private void BtnDelConsultations_Click(object sender, EventArgs e)
        {
            FormLoader.OpenChildForm(new FrmAdmConsultations());
        }
    }
}
