namespace SysPaciente
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelBar = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.BtnConsultations = new System.Windows.Forms.Button();
            this.BtnConfigurations = new System.Windows.Forms.Button();
            this.PanelBody = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnMAdministration = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnMConfigurations = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnMConsultations = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnMClients = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnMHome = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.PanelBar.SuspendLayout();
            this.PanelBody.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelBar.Controls.Add(this.BtnMenu);
            this.PanelBar.Controls.Add(this.BtnHome);
            this.PanelBar.Controls.Add(this.BtnClients);
            this.PanelBar.Controls.Add(this.BtnConsultations);
            this.PanelBar.Controls.Add(this.BtnConfigurations);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(0, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Padding = new System.Windows.Forms.Padding(10, 0, 25, 0);
            this.PanelBar.Size = new System.Drawing.Size(1008, 48);
            this.PanelBar.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.BtnHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(399, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(146, 48);
            this.BtnHome.TabIndex = 3;
            this.BtnHome.Text = "Inicio";
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClients.FlatAppearance.BorderSize = 0;
            this.BtnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClients.Location = new System.Drawing.Point(545, 0);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Size = new System.Drawing.Size(146, 48);
            this.BtnClients.TabIndex = 2;
            this.BtnClients.Text = "Pacientes";
            this.BtnClients.UseVisualStyleBackColor = true;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // BtnConsultations
            // 
            this.BtnConsultations.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConsultations.FlatAppearance.BorderSize = 0;
            this.BtnConsultations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultations.Location = new System.Drawing.Point(691, 0);
            this.BtnConsultations.Name = "BtnConsultations";
            this.BtnConsultations.Size = new System.Drawing.Size(146, 48);
            this.BtnConsultations.TabIndex = 1;
            this.BtnConsultations.Text = "Consultas";
            this.BtnConsultations.UseVisualStyleBackColor = true;
            this.BtnConsultations.Click += new System.EventHandler(this.BtnConsultations_Click);
            // 
            // BtnConfigurations
            // 
            this.BtnConfigurations.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnConfigurations.FlatAppearance.BorderSize = 0;
            this.BtnConfigurations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfigurations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfigurations.Location = new System.Drawing.Point(837, 0);
            this.BtnConfigurations.Name = "BtnConfigurations";
            this.BtnConfigurations.Size = new System.Drawing.Size(146, 48);
            this.BtnConfigurations.TabIndex = 0;
            this.BtnConfigurations.Text = "Configurações";
            this.BtnConfigurations.UseVisualStyleBackColor = true;
            this.BtnConfigurations.Click += new System.EventHandler(this.BtnConfigurations_Click);
            // 
            // PanelBody
            // 
            this.PanelBody.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelBody.Controls.Add(this.PanelMenu);
            this.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBody.Location = new System.Drawing.Point(0, 48);
            this.PanelBody.Name = "PanelBody";
            this.PanelBody.Size = new System.Drawing.Size(1008, 513);
            this.PanelBody.TabIndex = 1;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(146)))), ((int)(((byte)(190)))));
            this.PanelMenu.Controls.Add(this.panel7);
            this.PanelMenu.Controls.Add(this.panel6);
            this.PanelMenu.Controls.Add(this.panel5);
            this.PanelMenu.Controls.Add(this.panel4);
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(298, 428);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.BtnMAdministration);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 359);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(298, 69);
            this.panel7.TabIndex = 8;
            // 
            // BtnMAdministration
            // 
            this.BtnMAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMAdministration.Location = new System.Drawing.Point(-11, 2);
            this.BtnMAdministration.Name = "BtnMAdministration";
            this.BtnMAdministration.Size = new System.Drawing.Size(320, 64);
            this.BtnMAdministration.TabIndex = 3;
            this.BtnMAdministration.Text = "Administração";
            this.BtnMAdministration.UseVisualStyleBackColor = true;
            this.BtnMAdministration.Click += new System.EventHandler(this.BtnMAdministration_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BtnMConfigurations);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(298, 69);
            this.panel6.TabIndex = 7;
            // 
            // BtnMConfigurations
            // 
            this.BtnMConfigurations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMConfigurations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMConfigurations.Location = new System.Drawing.Point(-11, 2);
            this.BtnMConfigurations.Name = "BtnMConfigurations";
            this.BtnMConfigurations.Size = new System.Drawing.Size(320, 64);
            this.BtnMConfigurations.TabIndex = 3;
            this.BtnMConfigurations.Text = "Configurações";
            this.BtnMConfigurations.UseVisualStyleBackColor = true;
            this.BtnMConfigurations.Click += new System.EventHandler(this.BtnMConfigurations_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnMConsultations);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 69);
            this.panel5.TabIndex = 6;
            // 
            // BtnMConsultations
            // 
            this.BtnMConsultations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMConsultations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMConsultations.Location = new System.Drawing.Point(-11, 2);
            this.BtnMConsultations.Name = "BtnMConsultations";
            this.BtnMConsultations.Size = new System.Drawing.Size(320, 64);
            this.BtnMConsultations.TabIndex = 3;
            this.BtnMConsultations.Text = "Consultas";
            this.BtnMConsultations.UseVisualStyleBackColor = true;
            this.BtnMConsultations.Click += new System.EventHandler(this.BtnMConsultations_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnMClients);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 69);
            this.panel4.TabIndex = 5;
            // 
            // BtnMClients
            // 
            this.BtnMClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMClients.Location = new System.Drawing.Point(-11, 2);
            this.BtnMClients.Name = "BtnMClients";
            this.BtnMClients.Size = new System.Drawing.Size(320, 64);
            this.BtnMClients.TabIndex = 3;
            this.BtnMClients.Text = "Pacientes";
            this.BtnMClients.UseVisualStyleBackColor = true;
            this.BtnMClients.Click += new System.EventHandler(this.BtnMClients_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnMHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 69);
            this.panel3.TabIndex = 4;
            // 
            // BtnMHome
            // 
            this.BtnMHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMHome.Location = new System.Drawing.Point(-11, 2);
            this.BtnMHome.Name = "BtnMHome";
            this.BtnMHome.Size = new System.Drawing.Size(320, 64);
            this.BtnMHome.TabIndex = 3;
            this.BtnMHome.Text = "Inicio";
            this.BtnMHome.UseVisualStyleBackColor = true;
            this.BtnMHome.Click += new System.EventHandler(this.BtnMHome_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Image = global::SysPaciente.Properties.Resources.Menu;
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.Location = new System.Drawing.Point(10, 0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(89, 48);
            this.BtnMenu.TabIndex = 4;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.PanelBody);
            this.Controls.Add(this.PanelBar);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelBar.ResumeLayout(false);
            this.PanelBody.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Button BtnConfigurations;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnClients;
        private System.Windows.Forms.Button BtnConsultations;
        private System.Windows.Forms.Panel PanelBody;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnMHome;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnMClients;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button BtnMAdministration;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnMConfigurations;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnMConsultations;
    }
}

