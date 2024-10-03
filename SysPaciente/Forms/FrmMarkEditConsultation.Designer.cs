namespace SysPaciente.Forms
{
    partial class FrmMarkEditConsultation
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
            this.BtnMark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblClientDateOfBirth = new System.Windows.Forms.Label();
            this.LblClientTelephone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblClientName = new System.Windows.Forms.Label();
            this.BtnPickClient = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtTimeOfConsultation = new System.Windows.Forms.TextBox();
            this.GbStatus = new System.Windows.Forms.GroupBox();
            this.CbxStatus = new System.Windows.Forms.ComboBox();
            this.PanelClients = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancelSearch = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnSearchMode = new System.Windows.Forms.Button();
            this.TxtSearchText = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbStatus.SuspendLayout();
            this.PanelClients.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(838, 414);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(97, 35);
            this.BtnCancel.TabIndex = 106;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnMark
            // 
            this.BtnMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnMark.FlatAppearance.BorderSize = 0;
            this.BtnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMark.ForeColor = System.Drawing.Color.White;
            this.BtnMark.Location = new System.Drawing.Point(686, 414);
            this.BtnMark.Name = "BtnMark";
            this.BtnMark.Size = new System.Drawing.Size(137, 35);
            this.BtnMark.TabIndex = 105;
            this.BtnMark.Text = "Marcar";
            this.BtnMark.UseVisualStyleBackColor = false;
            this.BtnMark.Click += new System.EventHandler(this.BtnMark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Horario da consulta*:";
            // 
            // LblClientDateOfBirth
            // 
            this.LblClientDateOfBirth.AutoSize = true;
            this.LblClientDateOfBirth.Location = new System.Drawing.Point(122, 91);
            this.LblClientDateOfBirth.Name = "LblClientDateOfBirth";
            this.LblClientDateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.LblClientDateOfBirth.TabIndex = 14;
            this.LblClientDateOfBirth.Text = "00/00/0000";
            // 
            // LblClientTelephone
            // 
            this.LblClientTelephone.AutoSize = true;
            this.LblClientTelephone.Location = new System.Drawing.Point(122, 71);
            this.LblClientTelephone.Name = "LblClientTelephone";
            this.LblClientTelephone.Size = new System.Drawing.Size(76, 13);
            this.LblClientTelephone.TabIndex = 13;
            this.LblClientTelephone.Text = "(00)0000-0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data de nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblClientDateOfBirth);
            this.groupBox2.Controls.Add(this.LblClientTelephone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LblClientName);
            this.groupBox2.Controls.Add(this.BtnPickClient);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 480);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paciente";
            // 
            // LblClientName
            // 
            this.LblClientName.AutoSize = true;
            this.LblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientName.Location = new System.Drawing.Point(46, 38);
            this.LblClientName.Name = "LblClientName";
            this.LblClientName.Size = new System.Drawing.Size(147, 16);
            this.LblClientName.TabIndex = 10;
            this.LblClientName.Text = "Selecione um paciente.";
            this.LblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPickClient
            // 
            this.BtnPickClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnPickClient.FlatAppearance.BorderSize = 0;
            this.BtnPickClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPickClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPickClient.ForeColor = System.Drawing.Color.White;
            this.BtnPickClient.Location = new System.Drawing.Point(49, 421);
            this.BtnPickClient.Name = "BtnPickClient";
            this.BtnPickClient.Size = new System.Drawing.Size(137, 35);
            this.BtnPickClient.TabIndex = 7;
            this.BtnPickClient.Text = "Selecionar Cliente";
            this.BtnPickClient.UseVisualStyleBackColor = false;
            this.BtnPickClient.Click += new System.EventHandler(this.BtnPickClient_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(118, 38);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(209, 20);
            this.DateTimePicker.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data da consulta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.button24);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtTimeOfConsultation);
            this.groupBox1.Location = new System.Drawing.Point(271, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 240);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcação";
            // 
            // TxtTimeOfConsultation
            // 
            this.TxtTimeOfConsultation.Location = new System.Drawing.Point(118, 76);
            this.TxtTimeOfConsultation.Name = "TxtTimeOfConsultation";
            this.TxtTimeOfConsultation.Size = new System.Drawing.Size(209, 20);
            this.TxtTimeOfConsultation.TabIndex = 2;
            // 
            // GbStatus
            // 
            this.GbStatus.Controls.Add(this.CbxStatus);
            this.GbStatus.Location = new System.Drawing.Point(271, 258);
            this.GbStatus.Name = "GbStatus";
            this.GbStatus.Size = new System.Drawing.Size(503, 72);
            this.GbStatus.TabIndex = 108;
            this.GbStatus.TabStop = false;
            this.GbStatus.Text = "Status";
            this.GbStatus.Visible = false;
            // 
            // CbxStatus
            // 
            this.CbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxStatus.FormattingEnabled = true;
            this.CbxStatus.ItemHeight = 13;
            this.CbxStatus.Items.AddRange(new object[] {
            "Marcada",
            "Remarcada",
            "Realizada",
            "Faltou",
            "Cancelada",
            "Pendente"});
            this.CbxStatus.Location = new System.Drawing.Point(139, 28);
            this.CbxStatus.Name = "CbxStatus";
            this.CbxStatus.Size = new System.Drawing.Size(209, 21);
            this.CbxStatus.TabIndex = 14;
            // 
            // PanelClients
            // 
            this.PanelClients.Controls.Add(this.panel1);
            this.PanelClients.Controls.Add(this.panel2);
            this.PanelClients.Location = new System.Drawing.Point(838, 19);
            this.PanelClients.Name = "PanelClients";
            this.PanelClients.Size = new System.Drawing.Size(686, 205);
            this.PanelClients.TabIndex = 109;
            this.PanelClients.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 144);
            this.panel1.TabIndex = 103;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToOrderColumns = true;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.Location = new System.Drawing.Point(0, 0);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(686, 144);
            this.DgvData.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.BtnCancelSearch);
            this.panel2.Controls.Add(this.BtnSelect);
            this.panel2.Controls.Add(this.BtnSearchMode);
            this.panel2.Controls.Add(this.TxtSearchText);
            this.panel2.Controls.Add(this.LblSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 61);
            this.panel2.TabIndex = 2;
            // 
            // BtnCancelSearch
            // 
            this.BtnCancelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelSearch.FlatAppearance.BorderSize = 0;
            this.BtnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCancelSearch.Location = new System.Drawing.Point(572, 14);
            this.BtnCancelSearch.Name = "BtnCancelSearch";
            this.BtnCancelSearch.Size = new System.Drawing.Size(97, 35);
            this.BtnCancelSearch.TabIndex = 13;
            this.BtnCancelSearch.Text = "Cancelar";
            this.BtnCancelSearch.UseVisualStyleBackColor = false;
            this.BtnCancelSearch.Click += new System.EventHandler(this.BtnCancelSearch_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelect.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnSelect.FlatAppearance.BorderSize = 0;
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelect.ForeColor = System.Drawing.Color.White;
            this.BtnSelect.Location = new System.Drawing.Point(461, 14);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(105, 35);
            this.BtnSelect.TabIndex = 8;
            this.BtnSelect.Text = "Selecionar";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnSearchMode
            // 
            this.BtnSearchMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnSearchMode.FlatAppearance.BorderSize = 0;
            this.BtnSearchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchMode.ForeColor = System.Drawing.Color.White;
            this.BtnSearchMode.Location = new System.Drawing.Point(316, 14);
            this.BtnSearchMode.Name = "BtnSearchMode";
            this.BtnSearchMode.Size = new System.Drawing.Size(137, 35);
            this.BtnSearchMode.TabIndex = 6;
            this.BtnSearchMode.Text = "Mudar para cpf";
            this.BtnSearchMode.UseVisualStyleBackColor = false;
            this.BtnSearchMode.Click += new System.EventHandler(this.BtnSearchMode_Click);
            // 
            // TxtSearchText
            // 
            this.TxtSearchText.Location = new System.Drawing.Point(97, 22);
            this.TxtSearchText.Name = "TxtSearchText";
            this.TxtSearchText.Size = new System.Drawing.Size(209, 20);
            this.TxtSearchText.TabIndex = 1;
            this.TxtSearchText.TextChanged += new System.EventHandler(this.TxtSearchText_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(8, 25);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(90, 13);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Buscar por nome:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "08:00";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "08:20";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "09:00";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(176, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "08:40";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(419, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "09:40";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(338, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "09:20";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(419, 141);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "11:40";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(338, 141);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 22;
            this.button8.Text = "11:20";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(257, 141);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 21;
            this.button9.Text = "11:00";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(176, 141);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 20;
            this.button10.Text = "10:40";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(95, 141);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 19;
            this.button11.Text = "10:20";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(14, 141);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 18;
            this.button12.Text = "10:00";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(419, 199);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 35;
            this.button13.Text = "18:40";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(338, 199);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 34;
            this.button14.Text = "18:20";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(257, 199);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 33;
            this.button15.Text = "18:00";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(176, 199);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 32;
            this.button16.Text = "17:40";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(95, 199);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 31;
            this.button17.Text = "17:20";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(14, 199);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 30;
            this.button18.Text = "17:00";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(419, 170);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 29;
            this.button19.Text = "15:40";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(338, 170);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 28;
            this.button20.Text = "15:20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(257, 170);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 27;
            this.button21.Text = "15:00";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(176, 170);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 26;
            this.button22.Text = "14:40";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(95, 170);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 25;
            this.button23.Text = "14:20";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(14, 170);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 24;
            this.button24.Text = "14:00";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // FrmMarkEditConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 474);
            this.Controls.Add(this.PanelClients);
            this.Controls.Add(this.GbStatus);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnMark);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMarkEditConsultation";
            this.Text = "FrmMarkEditConsultation";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbStatus.ResumeLayout(false);
            this.PanelClients.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblClientDateOfBirth;
        private System.Windows.Forms.Label LblClientTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblClientName;
        private System.Windows.Forms.Button BtnPickClient;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtTimeOfConsultation;
        private System.Windows.Forms.GroupBox GbStatus;
        private System.Windows.Forms.ComboBox CbxStatus;
        private System.Windows.Forms.Panel PanelClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCancelSearch;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnSearchMode;
        private System.Windows.Forms.TextBox TxtSearchText;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}