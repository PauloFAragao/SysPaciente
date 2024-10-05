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
            this.LblClientDateOfBirth = new System.Windows.Forms.Label();
            this.LblClientTelephone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblClientName = new System.Windows.Forms.Label();
            this.BtnPickClient = new System.Windows.Forms.Button();
            this.GbStatus = new System.Windows.Forms.GroupBox();
            this.CbxStatus = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Panel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.GbSchedule = new System.Windows.Forms.GroupBox();
            this.BtnFit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTimeOfConsultation = new System.Windows.Forms.TextBox();
            this.PanelClients = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancelSearch = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnSearchMode = new System.Windows.Forms.Button();
            this.TxtSearchText = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.GbStatus.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.GbSchedule.SuspendLayout();
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
            this.BtnCancel.Location = new System.Drawing.Point(872, 415);
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
            this.BtnMark.Location = new System.Drawing.Point(729, 415);
            this.BtnMark.Name = "BtnMark";
            this.BtnMark.Size = new System.Drawing.Size(137, 35);
            this.BtnMark.TabIndex = 105;
            this.BtnMark.Text = "Marcar";
            this.BtnMark.UseVisualStyleBackColor = false;
            this.BtnMark.Click += new System.EventHandler(this.BtnMark_Click);
            // 
            // LblClientDateOfBirth
            // 
            this.LblClientDateOfBirth.AutoSize = true;
            this.LblClientDateOfBirth.Location = new System.Drawing.Point(117, 91);
            this.LblClientDateOfBirth.Name = "LblClientDateOfBirth";
            this.LblClientDateOfBirth.Size = new System.Drawing.Size(65, 13);
            this.LblClientDateOfBirth.TabIndex = 14;
            this.LblClientDateOfBirth.Text = "00/00/0000";
            // 
            // LblClientTelephone
            // 
            this.LblClientTelephone.AutoSize = true;
            this.LblClientTelephone.Location = new System.Drawing.Point(117, 71);
            this.LblClientTelephone.Name = "LblClientTelephone";
            this.LblClientTelephone.Size = new System.Drawing.Size(76, 13);
            this.LblClientTelephone.TabIndex = 13;
            this.LblClientTelephone.Text = "(00)0000-0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data de nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 71);
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
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 454);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paciente";
            // 
            // LblClientName
            // 
            this.LblClientName.AutoSize = true;
            this.LblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientName.Location = new System.Drawing.Point(36, 38);
            this.LblClientName.Name = "LblClientName";
            this.LblClientName.Size = new System.Drawing.Size(147, 16);
            this.LblClientName.TabIndex = 10;
            this.LblClientName.Text = "Selecione um paciente.";
            this.LblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPickClient
            // 
            this.BtnPickClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPickClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnPickClient.FlatAppearance.BorderSize = 0;
            this.BtnPickClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPickClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPickClient.ForeColor = System.Drawing.Color.White;
            this.BtnPickClient.Location = new System.Drawing.Point(42, 397);
            this.BtnPickClient.Name = "BtnPickClient";
            this.BtnPickClient.Size = new System.Drawing.Size(137, 35);
            this.BtnPickClient.TabIndex = 7;
            this.BtnPickClient.Text = "Selecionar Cliente";
            this.BtnPickClient.UseVisualStyleBackColor = false;
            this.BtnPickClient.Click += new System.EventHandler(this.BtnPickClient_Click);
            // 
            // GbStatus
            // 
            this.GbStatus.Controls.Add(this.CbxStatus);
            this.GbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbStatus.Location = new System.Drawing.Point(10, 10);
            this.GbStatus.Name = "GbStatus";
            this.GbStatus.Size = new System.Drawing.Size(527, 80);
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
            "Realizada",
            "Faltou",
            "Cancelada",
            "Pendente",
            "Remarcada"});
            this.CbxStatus.Location = new System.Drawing.Point(139, 28);
            this.CbxStatus.Name = "CbxStatus";
            this.CbxStatus.Size = new System.Drawing.Size(209, 21);
            this.CbxStatus.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(244, 474);
            this.panel3.TabIndex = 110;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GbStatus);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 148);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(547, 100);
            this.panel5.TabIndex = 112;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.panel4);
            this.Panel.Controls.Add(this.panel5);
            this.Panel.Location = new System.Drawing.Point(245, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(547, 248);
            this.Panel.TabIndex = 113;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.GbSchedule);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(547, 148);
            this.panel4.TabIndex = 114;
            // 
            // GbSchedule
            // 
            this.GbSchedule.Controls.Add(this.BtnFit);
            this.GbSchedule.Controls.Add(this.label1);
            this.GbSchedule.Controls.Add(this.DateTimePicker);
            this.GbSchedule.Controls.Add(this.label2);
            this.GbSchedule.Controls.Add(this.TxtTimeOfConsultation);
            this.GbSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbSchedule.Location = new System.Drawing.Point(10, 10);
            this.GbSchedule.Name = "GbSchedule";
            this.GbSchedule.Size = new System.Drawing.Size(527, 128);
            this.GbSchedule.TabIndex = 104;
            this.GbSchedule.TabStop = false;
            this.GbSchedule.Text = "Marcação";
            // 
            // BtnFit
            // 
            this.BtnFit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnFit.FlatAppearance.BorderSize = 0;
            this.BtnFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFit.ForeColor = System.Drawing.Color.White;
            this.BtnFit.Location = new System.Drawing.Point(352, 71);
            this.BtnFit.Name = "BtnFit";
            this.BtnFit.Size = new System.Drawing.Size(100, 28);
            this.BtnFit.TabIndex = 114;
            this.BtnFit.Text = "Encaixe";
            this.BtnFit.UseVisualStyleBackColor = false;
            this.BtnFit.Click += new System.EventHandler(this.BtnFit_Click);
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
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(118, 38);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(209, 20);
            this.DateTimePicker.TabIndex = 8;
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
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
            // TxtTimeOfConsultation
            // 
            this.TxtTimeOfConsultation.Enabled = false;
            this.TxtTimeOfConsultation.Location = new System.Drawing.Point(118, 76);
            this.TxtTimeOfConsultation.Name = "TxtTimeOfConsultation";
            this.TxtTimeOfConsultation.Size = new System.Drawing.Size(209, 20);
            this.TxtTimeOfConsultation.TabIndex = 2;
            // 
            // PanelClients
            // 
            this.PanelClients.Controls.Add(this.panel1);
            this.PanelClients.Controls.Add(this.panel2);
            this.PanelClients.Location = new System.Drawing.Point(831, 23);
            this.PanelClients.Name = "PanelClients";
            this.PanelClients.Size = new System.Drawing.Size(702, 184);
            this.PanelClients.TabIndex = 114;
            this.PanelClients.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 123);
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
            this.DgvData.Size = new System.Drawing.Size(702, 123);
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
            this.panel2.Size = new System.Drawing.Size(702, 61);
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
            this.BtnCancelSearch.Location = new System.Drawing.Point(588, 14);
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
            this.BtnSelect.Location = new System.Drawing.Point(477, 14);
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
            // FrmMarkEditConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 474);
            this.Controls.Add(this.PanelClients);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.BtnMark);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.panel3);
            this.Name = "FrmMarkEditConsultation";
            this.Text = "FrmMarkEditConsultation";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GbStatus.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.GbSchedule.ResumeLayout(false);
            this.GbSchedule.PerformLayout();
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
        private System.Windows.Forms.Label LblClientDateOfBirth;
        private System.Windows.Forms.Label LblClientTelephone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblClientName;
        private System.Windows.Forms.Button BtnPickClient;
        private System.Windows.Forms.GroupBox GbStatus;
        private System.Windows.Forms.ComboBox CbxStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox GbSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTimeOfConsultation;
        private System.Windows.Forms.Button BtnFit;
        private System.Windows.Forms.Panel PanelClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCancelSearch;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnSearchMode;
        private System.Windows.Forms.TextBox TxtSearchText;
        private System.Windows.Forms.Label LblSearch;
    }
}