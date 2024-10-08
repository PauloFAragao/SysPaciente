namespace SysPaciente.Forms
{
    partial class FrmHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblConsultationsAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblFreeTime = new System.Windows.Forms.Label();
            this.LblPending = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelAlterStatus = new System.Windows.Forms.Panel();
            this.CbxStatus = new System.Windows.Forms.ComboBox();
            this.BtnCancelAlterStatus = new System.Windows.Forms.Button();
            this.BtnAlterStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnChangeStatus = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelAlterStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultas Marcadas para Hoje:";
            // 
            // LblConsultationsAmount
            // 
            this.LblConsultationsAmount.AutoSize = true;
            this.LblConsultationsAmount.Location = new System.Drawing.Point(173, 24);
            this.LblConsultationsAmount.Name = "LblConsultationsAmount";
            this.LblConsultationsAmount.Size = new System.Drawing.Size(13, 13);
            this.LblConsultationsAmount.TabIndex = 1;
            this.LblConsultationsAmount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Próximo horário disponível para marcação:";
            // 
            // LblFreeTime
            // 
            this.LblFreeTime.AutoSize = true;
            this.LblFreeTime.Location = new System.Drawing.Point(227, 45);
            this.LblFreeTime.Name = "LblFreeTime";
            this.LblFreeTime.Size = new System.Drawing.Size(155, 13);
            this.LblFreeTime.TabIndex = 3;
            this.LblFreeTime.Text = "Dia: 01/01/2000 horário: 00:00";
            // 
            // LblPending
            // 
            this.LblPending.AutoSize = true;
            this.LblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPending.Location = new System.Drawing.Point(89, 86);
            this.LblPending.Name = "LblPending";
            this.LblPending.Size = new System.Drawing.Size(14, 16);
            this.LblPending.TabIndex = 5;
            this.LblPending.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pendências:";
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
            this.DgvData.Size = new System.Drawing.Size(992, 361);
            this.DgvData.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnChangeStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblConsultationsAmount);
            this.panel1.Controls.Add(this.LblPending);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LblFreeTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 113);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PanelAlterStatus);
            this.panel2.Controls.Add(this.DgvData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 361);
            this.panel2.TabIndex = 8;
            // 
            // PanelAlterStatus
            // 
            this.PanelAlterStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelAlterStatus.BackColor = System.Drawing.SystemColors.Control;
            this.PanelAlterStatus.Controls.Add(this.CbxStatus);
            this.PanelAlterStatus.Controls.Add(this.BtnCancelAlterStatus);
            this.PanelAlterStatus.Controls.Add(this.BtnAlterStatus);
            this.PanelAlterStatus.Controls.Add(this.label2);
            this.PanelAlterStatus.Location = new System.Drawing.Point(295, 3);
            this.PanelAlterStatus.Name = "PanelAlterStatus";
            this.PanelAlterStatus.Size = new System.Drawing.Size(433, 154);
            this.PanelAlterStatus.TabIndex = 14;
            this.PanelAlterStatus.Visible = false;
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
            // BtnChangeStatus
            // 
            this.BtnChangeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnChangeStatus.FlatAppearance.BorderSize = 0;
            this.BtnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.BtnChangeStatus.Location = new System.Drawing.Point(748, 54);
            this.BtnChangeStatus.Name = "BtnChangeStatus";
            this.BtnChangeStatus.Size = new System.Drawing.Size(107, 35);
            this.BtnChangeStatus.TabIndex = 8;
            this.BtnChangeStatus.Text = "Alterar status";
            this.BtnChangeStatus.UseVisualStyleBackColor = false;
            this.BtnChangeStatus.Click += new System.EventHandler(this.BtnChangeStatus_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(870, 54);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(97, 35);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PanelAlterStatus.ResumeLayout(false);
            this.PanelAlterStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblConsultationsAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblFreeTime;
        private System.Windows.Forms.Label LblPending;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelAlterStatus;
        private System.Windows.Forms.ComboBox CbxStatus;
        private System.Windows.Forms.Button BtnCancelAlterStatus;
        private System.Windows.Forms.Button BtnAlterStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnChangeStatus;
        private System.Windows.Forms.Button BtnEdit;
    }
}