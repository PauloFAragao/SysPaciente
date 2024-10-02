namespace SysPaciente.Forms
{
    partial class FrmConsultations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDate = new System.Windows.Forms.Button();
            this.LblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMark = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnChangeStatus = new System.Windows.Forms.Button();
            this.TxtSearchText = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelAlterStatus = new System.Windows.Forms.Panel();
            this.CbxStatus = new System.Windows.Forms.ComboBox();
            this.BtnCancelAlterStatus = new System.Windows.Forms.Button();
            this.BtnAlterStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelChangeDate = new System.Windows.Forms.Panel();
            this.BtnCancelChangeDate = new System.Windows.Forms.Button();
            this.BtnChangeDate = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelAlterStatus.SuspendLayout();
            this.PanelChangeDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.BtnDate);
            this.panel1.Controls.Add(this.LblDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnMark);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnChangeStatus);
            this.panel1.Controls.Add(this.TxtSearchText);
            this.panel1.Controls.Add(this.LblSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 80);
            this.panel1.TabIndex = 1;
            // 
            // BtnDate
            // 
            this.BtnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnDate.FlatAppearance.BorderSize = 0;
            this.BtnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDate.ForeColor = System.Drawing.Color.White;
            this.BtnDate.Location = new System.Drawing.Point(503, 22);
            this.BtnDate.Name = "BtnDate";
            this.BtnDate.Size = new System.Drawing.Size(104, 35);
            this.BtnDate.TabIndex = 13;
            this.BtnDate.Text = "Trocar data";
            this.BtnDate.UseVisualStyleBackColor = false;
            this.BtnDate.Click += new System.EventHandler(this.BtnDate_Click);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(347, 33);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(65, 13);
            this.LblDate.TabIndex = 12;
            this.LblDate.Text = "01/01/2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data:";
            // 
            // BtnMark
            // 
            this.BtnMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMark.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnMark.FlatAppearance.BorderSize = 0;
            this.BtnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMark.ForeColor = System.Drawing.Color.White;
            this.BtnMark.Location = new System.Drawing.Point(852, 22);
            this.BtnMark.Name = "BtnMark";
            this.BtnMark.Size = new System.Drawing.Size(128, 35);
            this.BtnMark.TabIndex = 9;
            this.BtnMark.Text = "Marcar consulta";
            this.BtnMark.UseVisualStyleBackColor = false;
            this.BtnMark.Click += new System.EventHandler(this.BtnMark_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(745, 22);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(97, 35);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnChangeStatus
            // 
            this.BtnChangeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnChangeStatus.FlatAppearance.BorderSize = 0;
            this.BtnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.BtnChangeStatus.Location = new System.Drawing.Point(622, 22);
            this.BtnChangeStatus.Name = "BtnChangeStatus";
            this.BtnChangeStatus.Size = new System.Drawing.Size(107, 35);
            this.BtnChangeStatus.TabIndex = 7;
            this.BtnChangeStatus.Text = "Alterar status";
            this.BtnChangeStatus.UseVisualStyleBackColor = false;
            this.BtnChangeStatus.Click += new System.EventHandler(this.BtnChangeStatus_Click);
            // 
            // TxtSearchText
            // 
            this.TxtSearchText.Location = new System.Drawing.Point(98, 30);
            this.TxtSearchText.Name = "TxtSearchText";
            this.TxtSearchText.Size = new System.Drawing.Size(209, 20);
            this.TxtSearchText.TabIndex = 1;
            this.TxtSearchText.TextChanged += new System.EventHandler(this.TxtSearchText_TextChanged);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(8, 33);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(90, 13);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Buscar por nome:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PanelAlterStatus);
            this.panel2.Controls.Add(this.PanelChangeDate);
            this.panel2.Controls.Add(this.DgvData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 394);
            this.panel2.TabIndex = 3;
            // 
            // PanelAlterStatus
            // 
            this.PanelAlterStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelAlterStatus.Controls.Add(this.CbxStatus);
            this.PanelAlterStatus.Controls.Add(this.BtnCancelAlterStatus);
            this.PanelAlterStatus.Controls.Add(this.BtnAlterStatus);
            this.PanelAlterStatus.Controls.Add(this.label2);
            this.PanelAlterStatus.Location = new System.Drawing.Point(312, 39);
            this.PanelAlterStatus.Name = "PanelAlterStatus";
            this.PanelAlterStatus.Size = new System.Drawing.Size(433, 154);
            this.PanelAlterStatus.TabIndex = 13;
            this.PanelAlterStatus.Visible = false;
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
            this.CbxStatus.Location = new System.Drawing.Point(130, 56);
            this.CbxStatus.Name = "CbxStatus";
            this.CbxStatus.Size = new System.Drawing.Size(160, 21);
            this.CbxStatus.TabIndex = 13;
            // 
            // BtnCancelAlterStatus
            // 
            this.BtnCancelAlterStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelAlterStatus.FlatAppearance.BorderSize = 0;
            this.BtnCancelAlterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelAlterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelAlterStatus.ForeColor = System.Drawing.Color.White;
            this.BtnCancelAlterStatus.Location = new System.Drawing.Point(249, 92);
            this.BtnCancelAlterStatus.Name = "BtnCancelAlterStatus";
            this.BtnCancelAlterStatus.Size = new System.Drawing.Size(137, 35);
            this.BtnCancelAlterStatus.TabIndex = 12;
            this.BtnCancelAlterStatus.Text = "Cancelar";
            this.BtnCancelAlterStatus.UseVisualStyleBackColor = false;
            this.BtnCancelAlterStatus.Click += new System.EventHandler(this.BtnCancelAlterStatus_Click);
            // 
            // BtnAlterStatus
            // 
            this.BtnAlterStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnAlterStatus.FlatAppearance.BorderSize = 0;
            this.BtnAlterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterStatus.ForeColor = System.Drawing.Color.White;
            this.BtnAlterStatus.Location = new System.Drawing.Point(31, 92);
            this.BtnAlterStatus.Name = "BtnAlterStatus";
            this.BtnAlterStatus.Size = new System.Drawing.Size(137, 35);
            this.BtnAlterStatus.TabIndex = 11;
            this.BtnAlterStatus.Text = "Confirmar";
            this.BtnAlterStatus.UseVisualStyleBackColor = false;
            this.BtnAlterStatus.Click += new System.EventHandler(this.BtnAlterStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alterar status";
            // 
            // PanelChangeDate
            // 
            this.PanelChangeDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelChangeDate.Controls.Add(this.BtnCancelChangeDate);
            this.PanelChangeDate.Controls.Add(this.BtnChangeDate);
            this.PanelChangeDate.Controls.Add(this.DateTimePicker);
            this.PanelChangeDate.Controls.Add(this.label3);
            this.PanelChangeDate.Location = new System.Drawing.Point(313, 39);
            this.PanelChangeDate.Name = "PanelChangeDate";
            this.PanelChangeDate.Size = new System.Drawing.Size(433, 215);
            this.PanelChangeDate.TabIndex = 2;
            this.PanelChangeDate.Visible = false;
            // 
            // BtnCancelChangeDate
            // 
            this.BtnCancelChangeDate.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelChangeDate.FlatAppearance.BorderSize = 0;
            this.BtnCancelChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelChangeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelChangeDate.ForeColor = System.Drawing.Color.White;
            this.BtnCancelChangeDate.Location = new System.Drawing.Point(251, 130);
            this.BtnCancelChangeDate.Name = "BtnCancelChangeDate";
            this.BtnCancelChangeDate.Size = new System.Drawing.Size(137, 35);
            this.BtnCancelChangeDate.TabIndex = 12;
            this.BtnCancelChangeDate.Text = "Cancelar";
            this.BtnCancelChangeDate.UseVisualStyleBackColor = false;
            this.BtnCancelChangeDate.Click += new System.EventHandler(this.BtnCancelChangeDate_Click);
            // 
            // BtnChangeDate
            // 
            this.BtnChangeDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnChangeDate.FlatAppearance.BorderSize = 0;
            this.BtnChangeDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeDate.ForeColor = System.Drawing.Color.White;
            this.BtnChangeDate.Location = new System.Drawing.Point(37, 130);
            this.BtnChangeDate.Name = "BtnChangeDate";
            this.BtnChangeDate.Size = new System.Drawing.Size(137, 35);
            this.BtnChangeDate.TabIndex = 11;
            this.BtnChangeDate.Text = "Confirmar";
            this.BtnChangeDate.UseVisualStyleBackColor = false;
            this.BtnChangeDate.Click += new System.EventHandler(this.BtnChangeDate_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(96, 62);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.DateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trocar a data";
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
            this.DgvData.Size = new System.Drawing.Size(992, 394);
            this.DgvData.TabIndex = 1;
            // 
            // FrmConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsultations";
            this.Text = "FrmConsultations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PanelAlterStatus.ResumeLayout(false);
            this.PanelAlterStatus.PerformLayout();
            this.PanelChangeDate.ResumeLayout(false);
            this.PanelChangeDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnMark;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnChangeStatus;
        private System.Windows.Forms.TextBox TxtSearchText;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Button BtnDate;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelChangeDate;
        private System.Windows.Forms.Button BtnCancelChangeDate;
        private System.Windows.Forms.Button BtnChangeDate;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelAlterStatus;
        private System.Windows.Forms.Button BtnCancelAlterStatus;
        private System.Windows.Forms.Button BtnAlterStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxStatus;
    }
}