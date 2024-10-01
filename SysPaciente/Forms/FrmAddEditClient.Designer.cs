namespace SysPaciente.Forms
{
    partial class FrmAddEditClient
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtIdNumber = new System.Windows.Forms.TextBox();
            this.LblIdentidade = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MskCpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MskDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtComplement = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtHouseNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxState = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MskCep = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNeighborhood = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblAdm = new System.Windows.Forms.Label();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(751, 413);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(97, 35);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtIdNumber
            // 
            this.TxtIdNumber.Location = new System.Drawing.Point(79, 36);
            this.TxtIdNumber.Name = "TxtIdNumber";
            this.TxtIdNumber.Size = new System.Drawing.Size(171, 20);
            this.TxtIdNumber.TabIndex = 11;
            // 
            // LblIdentidade
            // 
            this.LblIdentidade.AutoSize = true;
            this.LblIdentidade.Location = new System.Drawing.Point(19, 39);
            this.LblIdentidade.Name = "LblIdentidade";
            this.LblIdentidade.Size = new System.Drawing.Size(67, 13);
            this.LblIdentidade.TabIndex = 87;
            this.LblIdentidade.Text = "Identidade*: ";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Location = new System.Drawing.Point(49, 78);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(30, 13);
            this.LblCpf.TabIndex = 86;
            this.LblCpf.Text = "Cpf*:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MskCpf);
            this.groupBox3.Controls.Add(this.TxtIdNumber);
            this.groupBox3.Controls.Add(this.LblIdentidade);
            this.groupBox3.Controls.Add(this.LblCpf);
            this.groupBox3.Location = new System.Drawing.Point(26, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(751, 123);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documentos";
            // 
            // MskCpf
            // 
            this.MskCpf.Location = new System.Drawing.Point(79, 75);
            this.MskCpf.Mask = "000.000.000-00";
            this.MskCpf.Name = "MskCpf";
            this.MskCpf.Size = new System.Drawing.Size(171, 20);
            this.MskCpf.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MskTel);
            this.groupBox2.Controls.Add(this.MskDateOfBirth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtName);
            this.groupBox2.Controls.Add(this.LblName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(26, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(751, 78);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identificação";
            // 
            // MskDateOfBirth
            // 
            this.MskDateOfBirth.Location = new System.Drawing.Point(519, 35);
            this.MskDateOfBirth.Mask = "00/00/0000";
            this.MskDateOfBirth.Name = "MskDateOfBirth";
            this.MskDateOfBirth.Size = new System.Drawing.Size(70, 20);
            this.MskDateOfBirth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Data de nascimento*:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(60, 35);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(190, 20);
            this.TxtName.TabIndex = 1;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(19, 38);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(45, 13);
            this.LblName.TabIndex = 99;
            this.LblName.Text = "Nome*: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Telefone*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Complemento:";
            // 
            // TxtComplement
            // 
            this.TxtComplement.Location = new System.Drawing.Point(420, 36);
            this.TxtComplement.Name = "TxtComplement";
            this.TxtComplement.Size = new System.Drawing.Size(190, 20);
            this.TxtComplement.TabIndex = 6;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnConfirm.FlatAppearance.BorderSize = 0;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(630, 413);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(97, 35);
            this.BtnConfirm.TabIndex = 13;
            this.BtnConfirm.Text = "Adicionar";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Número*:";
            // 
            // TxtHouseNumber
            // 
            this.TxtHouseNumber.Location = new System.Drawing.Point(292, 36);
            this.TxtHouseNumber.Name = "TxtHouseNumber";
            this.TxtHouseNumber.Size = new System.Drawing.Size(48, 20);
            this.TxtHouseNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Cidade*:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxState);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.MskCep);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtComplement);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtHouseNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtCity);
            this.groupBox1.Controls.Add(this.TxtStreet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtNeighborhood);
            this.groupBox1.Location = new System.Drawing.Point(26, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 123);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // CbxState
            // 
            this.CbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxState.FormattingEnabled = true;
            this.CbxState.ItemHeight = 13;
            this.CbxState.Items.AddRange(new object[] {
            "Acre - AC",
            "Alagoas - AL",
            "Amapá - AP",
            "Amazonas - AM",
            "Bahia - BA",
            "Ceará - CE",
            "Distrito Federal - DF",
            "Espírito Santo - ES",
            "Goiás - GO",
            "Maranhão - MA",
            "Mato Grosso - MT",
            "Mato Grosso do Sul - MS",
            "Minas Gerais - MG",
            "Pará - PA",
            "Paraíba - PB",
            "Paraná - PR",
            "Pernambuco - PE",
            "Piauí - PI",
            "Rio de Janeiro - RJ",
            "Rio Grande do Norte - RN",
            "Rio Grande do Sul - RS",
            "Rondônia - RO",
            "Roraima - RR",
            "Santa Catarina - SC",
            "São Paulo - SP",
            "Sergipe - SE",
            "Tocantins - TO"});
            this.CbxState.Location = new System.Drawing.Point(537, 75);
            this.CbxState.Name = "CbxState";
            this.CbxState.Size = new System.Drawing.Size(160, 21);
            this.CbxState.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(484, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 89;
            this.label10.Text = "Estado*:";
            // 
            // MskCep
            // 
            this.MskCep.Location = new System.Drawing.Point(648, 36);
            this.MskCep.Mask = "00000-000";
            this.MskCep.Name = "MskCep";
            this.MskCep.Size = new System.Drawing.Size(70, 20);
            this.MskCep.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Cep*:";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(292, 75);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(190, 20);
            this.TxtCity.TabIndex = 9;
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(49, 36);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(190, 20);
            this.TxtStreet.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Rua*: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Bairro*:";
            // 
            // TxtNeighborhood
            // 
            this.TxtNeighborhood.Location = new System.Drawing.Point(53, 75);
            this.TxtNeighborhood.Name = "TxtNeighborhood";
            this.TxtNeighborhood.Size = new System.Drawing.Size(190, 20);
            this.TxtNeighborhood.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Atenção: Todos os campos marcados com * devem ser preenchidos";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.LblAdm);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnConfirm);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(63, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 472);
            this.panel1.TabIndex = 82;
            // 
            // LblAdm
            // 
            this.LblAdm.AutoSize = true;
            this.LblAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdm.Location = new System.Drawing.Point(368, 11);
            this.LblAdm.Name = "LblAdm";
            this.LblAdm.Size = new System.Drawing.Size(210, 16);
            this.LblAdm.TabIndex = 22;
            this.LblAdm.Text = "Modo de edição de administrador";
            this.LblAdm.Visible = false;
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(309, 35);
            this.MskTel.Mask = "(00)0000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(97, 20);
            this.MskTel.TabIndex = 100;
            this.MskTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MskTel_KeyPress);
            this.MskTel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MskTel_KeyUp);
            // 
            // FrmAddEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 474);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAddEditClient";
            this.Text = "FrmAddEditClient";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtIdNumber;
        private System.Windows.Forms.Label LblIdentidade;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtComplement;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtHouseNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNeighborhood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblAdm;
        private System.Windows.Forms.MaskedTextBox MskCpf;
        private System.Windows.Forms.MaskedTextBox MskDateOfBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxState;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MskCep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MskTel;
    }
}