namespace SysPaciente.Forms
{
    partial class FrmAdmConsultations
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelChangeDate = new System.Windows.Forms.Panel();
            this.BtnCancelChangeDate = new System.Windows.Forms.Button();
            this.BtnChangeDate = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.BtnDate = new System.Windows.Forms.Button();
            this.LblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearchText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.LblSearch = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.PanelChangeDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PanelChangeDate);
            this.panel2.Controls.Add(this.DgvData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 377);
            this.panel2.TabIndex = 5;
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
            this.DgvData.Size = new System.Drawing.Size(992, 377);
            this.DgvData.TabIndex = 1;
            // 
            // BtnDate
            // 
            this.BtnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnDate.FlatAppearance.BorderSize = 0;
            this.BtnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDate.ForeColor = System.Drawing.Color.White;
            this.BtnDate.Location = new System.Drawing.Point(751, 40);
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
            this.LblDate.Location = new System.Drawing.Point(347, 51);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(65, 13);
            this.LblDate.TabIndex = 12;
            this.LblDate.Text = "01/01/2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Data:";
            // 
            // TxtSearchText
            // 
            this.TxtSearchText.Location = new System.Drawing.Point(98, 48);
            this.TxtSearchText.Name = "TxtSearchText";
            this.TxtSearchText.Size = new System.Drawing.Size(209, 20);
            this.TxtSearchText.TabIndex = 1;
            this.TxtSearchText.TextChanged += new System.EventHandler(this.TxtSearchText_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnDel);
            this.panel1.Controls.Add(this.BtnDate);
            this.panel1.Controls.Add(this.LblDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtSearchText);
            this.panel1.Controls.Add(this.LblSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 97);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modo Administrador";
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.BtnDel.FlatAppearance.BorderSize = 0;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDel.ForeColor = System.Drawing.Color.White;
            this.BtnDel.Location = new System.Drawing.Point(863, 40);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(97, 35);
            this.BtnDel.TabIndex = 14;
            this.BtnDel.Text = "Deletar";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Location = new System.Drawing.Point(8, 51);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(90, 13);
            this.LblSearch.TabIndex = 0;
            this.LblSearch.Text = "Buscar por nome:";
            // 
            // FrmAdmConsultations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdmConsultations";
            this.Text = "FrmAdmConsultations";
            this.Load += new System.EventHandler(this.FrmAdmConsultations_Load);
            this.panel2.ResumeLayout(false);
            this.PanelChangeDate.ResumeLayout(false);
            this.PanelChangeDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelChangeDate;
        private System.Windows.Forms.Button BtnCancelChangeDate;
        private System.Windows.Forms.Button BtnChangeDate;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Button BtnDate;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Label label2;
    }
}