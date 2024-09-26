﻿namespace SysPaciente.Forms
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
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnChangeStatus = new System.Windows.Forms.Button();
            this.TxtSearchText = new System.Windows.Forms.TextBox();
            this.LblSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.BtnSearchMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelChangeDate = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnChangeDate = new System.Windows.Forms.Button();
            this.BtnCancelChangeDate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.PanelChangeDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LblDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnSearchMode);
            this.panel1.Controls.Add(this.BtnView);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnChangeStatus);
            this.panel1.Controls.Add(this.TxtSearchText);
            this.panel1.Controls.Add(this.LblSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 98);
            this.panel1.TabIndex = 1;
            // 
            // BtnView
            // 
            this.BtnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnView.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnView.FlatAppearance.BorderSize = 0;
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnView.ForeColor = System.Drawing.Color.White;
            this.BtnView.Location = new System.Drawing.Point(852, 26);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(128, 35);
            this.BtnView.TabIndex = 9;
            this.BtnView.Text = "Marcar consulta";
            this.BtnView.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(745, 26);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(97, 35);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnChangeStatus
            // 
            this.BtnChangeStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnChangeStatus.FlatAppearance.BorderSize = 0;
            this.BtnChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.BtnChangeStatus.Location = new System.Drawing.Point(622, 26);
            this.BtnChangeStatus.Name = "BtnChangeStatus";
            this.BtnChangeStatus.Size = new System.Drawing.Size(107, 35);
            this.BtnChangeStatus.TabIndex = 7;
            this.BtnChangeStatus.Text = "Alterar status";
            this.BtnChangeStatus.UseVisualStyleBackColor = false;
            // 
            // TxtSearchText
            // 
            this.TxtSearchText.Location = new System.Drawing.Point(98, 34);
            this.TxtSearchText.Name = "TxtSearchText";
            this.TxtSearchText.Size = new System.Drawing.Size(209, 20);
            this.TxtSearchText.TabIndex = 1;
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(8, 37);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(90, 13);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Buscar por nome:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PanelChangeDate);
            this.panel2.Controls.Add(this.DgvData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 376);
            this.panel2.TabIndex = 3;
            // 
            // DgvData
            // 
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.Location = new System.Drawing.Point(0, 0);
            this.DgvData.Name = "DgvData";
            this.DgvData.Size = new System.Drawing.Size(992, 376);
            this.DgvData.TabIndex = 1;
            // 
            // BtnSearchMode
            // 
            this.BtnSearchMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnSearchMode.FlatAppearance.BorderSize = 0;
            this.BtnSearchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchMode.ForeColor = System.Drawing.Color.White;
            this.BtnSearchMode.Location = new System.Drawing.Point(322, 26);
            this.BtnSearchMode.Name = "BtnSearchMode";
            this.BtnSearchMode.Size = new System.Drawing.Size(137, 35);
            this.BtnSearchMode.TabIndex = 10;
            this.BtnSearchMode.Text = "Mudar para cpf";
            this.BtnSearchMode.UseVisualStyleBackColor = false;
            this.BtnSearchMode.Click += new System.EventHandler(this.BtnSearchMode_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data:";
            // 
            // LblDate
            // 
            this.LblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(467, 73);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(65, 13);
            this.LblDate.TabIndex = 12;
            this.LblDate.Text = "01/01/2000";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(465, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Trocar data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(96, 62);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.DateTimePicker.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.PanelChangeDate.ResumeLayout(false);
            this.PanelChangeDate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnChangeStatus;
        private System.Windows.Forms.TextBox TxtSearchText;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Button BtnSearchMode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelChangeDate;
        private System.Windows.Forms.Button BtnCancelChangeDate;
        private System.Windows.Forms.Button BtnChangeDate;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label3;
    }
}