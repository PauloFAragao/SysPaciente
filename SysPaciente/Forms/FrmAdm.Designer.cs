namespace SysPaciente.Forms
{
    partial class FrmAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDelClients = new System.Windows.Forms.Button();
            this.BtnEditClient = new System.Windows.Forms.Button();
            this.BtnDelConsultations = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCurrentPassword = new System.Windows.Forms.TextBox();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.PainelChangePassword = new System.Windows.Forms.Panel();
            this.BtnConfirmPasswordChange = new System.Windows.Forms.Button();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblError = new System.Windows.Forms.Label();
            this.TxtPassord = new System.Windows.Forms.TextBox();
            this.LblPasswordWrong = new System.Windows.Forms.Label();
            this.LblPasswordsNotMatch = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PainelChangePassword.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDelClients
            // 
            this.BtnDelClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnDelClients.Enabled = false;
            this.BtnDelClients.FlatAppearance.BorderSize = 0;
            this.BtnDelClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelClients.ForeColor = System.Drawing.Color.White;
            this.BtnDelClients.Location = new System.Drawing.Point(51, 161);
            this.BtnDelClients.Name = "BtnDelClients";
            this.BtnDelClients.Size = new System.Drawing.Size(137, 35);
            this.BtnDelClients.TabIndex = 8;
            this.BtnDelClients.Text = "Deletar Pacientes";
            this.BtnDelClients.UseVisualStyleBackColor = false;
            // 
            // BtnEditClient
            // 
            this.BtnEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnEditClient.Enabled = false;
            this.BtnEditClient.FlatAppearance.BorderSize = 0;
            this.BtnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditClient.ForeColor = System.Drawing.Color.White;
            this.BtnEditClient.Location = new System.Drawing.Point(51, 103);
            this.BtnEditClient.Name = "BtnEditClient";
            this.BtnEditClient.Size = new System.Drawing.Size(137, 35);
            this.BtnEditClient.TabIndex = 9;
            this.BtnEditClient.Text = "Editar Paciente";
            this.BtnEditClient.UseVisualStyleBackColor = false;
            // 
            // BtnDelConsultations
            // 
            this.BtnDelConsultations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnDelConsultations.Enabled = false;
            this.BtnDelConsultations.FlatAppearance.BorderSize = 0;
            this.BtnDelConsultations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelConsultations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelConsultations.ForeColor = System.Drawing.Color.White;
            this.BtnDelConsultations.Location = new System.Drawing.Point(51, 220);
            this.BtnDelConsultations.Name = "BtnDelConsultations";
            this.BtnDelConsultations.Size = new System.Drawing.Size(137, 35);
            this.BtnDelConsultations.TabIndex = 10;
            this.BtnDelConsultations.Text = "Deletar Consultas";
            this.BtnDelConsultations.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Painel de administrador";
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.Location = new System.Drawing.Point(40, 47);
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.PasswordChar = '*';
            this.TxtCurrentPassword.Size = new System.Drawing.Size(225, 20);
            this.TxtCurrentPassword.TabIndex = 12;
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnChangePassword.Enabled = false;
            this.BtnChangePassword.FlatAppearance.BorderSize = 0;
            this.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangePassword.ForeColor = System.Drawing.Color.White;
            this.BtnChangePassword.Location = new System.Drawing.Point(728, 47);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(137, 35);
            this.BtnChangePassword.TabIndex = 13;
            this.BtnChangePassword.Text = "Alterar senha";
            this.BtnChangePassword.UseVisualStyleBackColor = false;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Senha Atual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nova senha:";
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Location = new System.Drawing.Point(40, 108);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PasswordChar = '*';
            this.TxtNewPassword.Size = new System.Drawing.Size(225, 20);
            this.TxtNewPassword.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Repetir nova senha:";
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(40, 151);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.Size = new System.Drawing.Size(225, 20);
            this.TxtConfirmPassword.TabIndex = 17;
            // 
            // PainelChangePassword
            // 
            this.PainelChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelChangePassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PainelChangePassword.Controls.Add(this.BtnCancel);
            this.PainelChangePassword.Controls.Add(this.LblPasswordsNotMatch);
            this.PainelChangePassword.Controls.Add(this.LblPasswordWrong);
            this.PainelChangePassword.Controls.Add(this.BtnConfirmPasswordChange);
            this.PainelChangePassword.Controls.Add(this.label3);
            this.PainelChangePassword.Controls.Add(this.label5);
            this.PainelChangePassword.Controls.Add(this.TxtCurrentPassword);
            this.PainelChangePassword.Controls.Add(this.TxtConfirmPassword);
            this.PainelChangePassword.Controls.Add(this.TxtNewPassword);
            this.PainelChangePassword.Controls.Add(this.label4);
            this.PainelChangePassword.Location = new System.Drawing.Point(660, 88);
            this.PainelChangePassword.Name = "PainelChangePassword";
            this.PainelChangePassword.Size = new System.Drawing.Size(303, 295);
            this.PainelChangePassword.TabIndex = 19;
            this.PainelChangePassword.Visible = false;
            // 
            // BtnConfirmPasswordChange
            // 
            this.BtnConfirmPasswordChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnConfirmPasswordChange.FlatAppearance.BorderSize = 0;
            this.BtnConfirmPasswordChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmPasswordChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmPasswordChange.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmPasswordChange.Location = new System.Drawing.Point(40, 215);
            this.BtnConfirmPasswordChange.Name = "BtnConfirmPasswordChange";
            this.BtnConfirmPasswordChange.Size = new System.Drawing.Size(124, 35);
            this.BtnConfirmPasswordChange.TabIndex = 19;
            this.BtnConfirmPasswordChange.Text = "Alterar senha";
            this.BtnConfirmPasswordChange.UseVisualStyleBackColor = false;
            this.BtnConfirmPasswordChange.Click += new System.EventHandler(this.BtnConfirmPasswordChange_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelLogin.Controls.Add(this.BtnLogin);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.LblError);
            this.PanelLogin.Controls.Add(this.TxtPassord);
            this.PanelLogin.Location = new System.Drawing.Point(294, 103);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(360, 253);
            this.PanelLogin.TabIndex = 20;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(109, 165);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(137, 35);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Entrar";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senha de administrador:";
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Location = new System.Drawing.Point(133, 126);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(93, 16);
            this.LblError.TabIndex = 2;
            this.LblError.Text = "Senha Errada!";
            this.LblError.Visible = false;
            // 
            // TxtPassord
            // 
            this.TxtPassord.Location = new System.Drawing.Point(70, 99);
            this.TxtPassord.Name = "TxtPassord";
            this.TxtPassord.PasswordChar = '*';
            this.TxtPassord.Size = new System.Drawing.Size(225, 20);
            this.TxtPassord.TabIndex = 0;
            this.TxtPassord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassord_KeyPress);
            // 
            // LblPasswordWrong
            // 
            this.LblPasswordWrong.AutoSize = true;
            this.LblPasswordWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasswordWrong.ForeColor = System.Drawing.Color.Red;
            this.LblPasswordWrong.Location = new System.Drawing.Point(102, 70);
            this.LblPasswordWrong.Name = "LblPasswordWrong";
            this.LblPasswordWrong.Size = new System.Drawing.Size(93, 16);
            this.LblPasswordWrong.TabIndex = 20;
            this.LblPasswordWrong.Text = "Senha Errada!";
            this.LblPasswordWrong.Visible = false;
            // 
            // LblPasswordsNotMatch
            // 
            this.LblPasswordsNotMatch.AutoSize = true;
            this.LblPasswordsNotMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasswordsNotMatch.ForeColor = System.Drawing.Color.Red;
            this.LblPasswordsNotMatch.Location = new System.Drawing.Point(58, 179);
            this.LblPasswordsNotMatch.Name = "LblPasswordsNotMatch";
            this.LblPasswordsNotMatch.Size = new System.Drawing.Size(190, 16);
            this.LblPasswordsNotMatch.TabIndex = 21;
            this.LblPasswordsNotMatch.Text = "As senhas não correspondem!";
            this.LblPasswordsNotMatch.Visible = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(179, 215);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(86, 35);
            this.BtnCancel.TabIndex = 22;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 474);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.PainelChangePassword);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnDelConsultations);
            this.Controls.Add(this.BtnEditClient);
            this.Controls.Add(this.BtnDelClients);
            this.Name = "FrmAdm";
            this.Text = "FrmAdm";
            this.PainelChangePassword.ResumeLayout(false);
            this.PainelChangePassword.PerformLayout();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDelClients;
        private System.Windows.Forms.Button BtnEditClient;
        private System.Windows.Forms.Button BtnDelConsultations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCurrentPassword;
        private System.Windows.Forms.Button BtnChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Panel PainelChangePassword;
        private System.Windows.Forms.Button BtnConfirmPasswordChange;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.TextBox TxtPassord;
        private System.Windows.Forms.Label LblPasswordWrong;
        private System.Windows.Forms.Label LblPasswordsNotMatch;
        private System.Windows.Forms.Button BtnCancel;
    }
}