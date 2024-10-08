using SysPaciente.Entities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SysPaciente.Forms
{
    public partial class FrmSettings : Form
    {
        Settings settings;

        public FrmSettings()
        {
            InitializeComponent();

            //texto de aviso
            this.LblWarning.Text = "   Atenção alterar dados dessa pagina pode \ngerar a necessidade de reagendar consultas!";
            this.LblWarning.Visible = false;

            // 
            settings = new Settings();

            this.LblStartAndEnd.Text = "Horários de inicio e \nfim de expediente:";

            // carregar os dados
            LoadData();

            // criando os eventos
            CreatingEvents();
        }

        private void LoadData()
        {
            Settings settings = Data.GetSettings();

            // interface: dias trabalhados
            this.CbMonday.Checked = settings.workOnMondays;
            this.CbTuesday.Checked = settings.workOnTuesdays;
            this.CbWednesday.Checked = settings.workOnWednesdays;
            this.CbThursday.Checked = settings.workOnThursdays;
            this.CbFriday.Checked = settings.workOnFridays;
            this.CbSaturday.Checked = settings.workOnSaturdays;
            this.CbSunday.Checked = settings.workOnSundays;

            TimeSpan? timeSpan;

            // horarios das segundas
            if (settings.workOnMondays)
            {
                timeSpan = settings.startOfWorkOnMondays;
                this.TxtStartOfWorkOnMondays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfWorkOnMondays;
                this.TxtEndOfWorkOnMondays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.startOfBreakOnMondays;
                this.TxtStartOfBreakOnMondays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfBreakOnMondays;
                this.TxtEndOfBreakOnMondays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

            }
            else
            {
                this.TxtStartOfWorkOnMondays.Text = "---";
                this.TxtEndOfWorkOnMondays.Text = "---";
                this.TxtStartOfBreakOnMondays.Text = "---";
                this.TxtEndOfBreakOnMondays.Text = "---";
            }

            // horarios das terças
            if (settings.workOnTuesdays)
            {
                timeSpan = settings.startOfWorkOnTuesdays;
                this.TxtStartOfWorkOnTuesdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfWorkOnTuesdays;
                this.TxtEndOfWorkOnTuesdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.startOfBreakOnTuesdays;
                this.TxtStartOfBreakOnTuesdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfBreakOnTuesdays;
                this.TxtEndOfBreakOnTuesdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

            }
            else
            {
                this.TxtStartOfWorkOnTuesdays.Text = "---";
                this.TxtEndOfWorkOnTuesdays.Text = "---";
                this.TxtStartOfBreakOnTuesdays.Text = "---";
                this.TxtEndOfBreakOnTuesdays.Text = "---";
            }

            // horarios das quartas
            if (settings.workOnWednesdays)
            {
                timeSpan = settings.startOfWorkOnWednesdays;
                this.TxtStartOfWorkOnWednesdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfWorkOnWednesdays;
                this.TxtEndOfWorkOnWednesdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";


                timeSpan = settings.startOfBreakOnWednesdays;
                this.TxtStartOfBreakOnWednesdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfBreakOnWednesdays;
                this.TxtEndOfBreakOnWednesdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

            }
            else
            {
                this.TxtStartOfWorkOnWednesdays.Text = "---";
                this.TxtEndOfWorkOnWednesdays.Text = "---";
                this.TxtStartOfBreakOnWednesdays.Text = "---";
                this.TxtEndOfBreakOnWednesdays.Text = "---";
            }

            // horarios das quintas
            if (settings.workOnThursdays)
            {
                timeSpan = settings.startOfWorkOnThursdays;
                this.TxtStartOfWorkOnThursdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfWorkOnThursdays;
                this.TxtEndOfWorkOnThursdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.startOfBreakOnThursdays;
                this.TxtStartOfBreakOnThursdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfBreakOnThursdays;
                this.TxtEndOfBreakOnThursdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

            }
            else
            {
                this.TxtStartOfWorkOnThursdays.Text = "---";
                this.TxtEndOfWorkOnThursdays.Text = "---";
                this.TxtStartOfBreakOnThursdays.Text = "---";
                this.TxtEndOfBreakOnThursdays.Text = "---";
            }

            // horarios das sextas
            if (settings.workOnFridays)
            {
                timeSpan = settings.startOfWorkOnFridays;
                this.TxtStartOfWorkOnFridays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfWorkOnFridays;
                this.TxtEndOfWorkOnFridays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.startOfBreakOnFridays;
                this.TxtStartOfBreakOnFridays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfBreakOnFridays;
                this.TxtEndOfBreakOnFridays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

            }
            else
            {
                this.TxtStartOfWorkOnFridays.Text = "---";
                this.TxtEndOfWorkOnFridays.Text = "---";
                this.TxtStartOfBreakOnFridays.Text = "---";
                this.TxtEndOfBreakOnFridays.Text = "---";
            }

            // horarios dos sabados
            if (settings.workOnThursdays)
            {
                timeSpan = settings.startOfWorkOnSaturdays;
                this.TxtStartOfWorkOnSaturdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfWorkOnSaturdays;
                this.TxtEndOfWorkOnSaturdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.startOfBreakOnSaturdays;
                this.TxtStartOfBreakOnSaturdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfBreakOnSaturdays;
                this.TxtEndOfBreakOnSaturdays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

            }
            else
            {
                this.TxtStartOfWorkOnSaturdays.Text = "---";
                this.TxtEndOfWorkOnSaturdays.Text = "---";
                this.TxtStartOfBreakOnSaturdays.Text = "---";
                this.TxtEndOfBreakOnSaturdays.Text = "---";
            }

            // horario de trabalho aos domingos
            if (settings.workOnThursdays)
            {
                timeSpan = settings.endOfBreakOnSaturdays;
                this.TxtStartOfWorkOnSundays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfBreakOnSaturdays;
                this.TxtEndOfWorkOnSundays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfBreakOnSaturdays;
                this.TxtStartOfBreakOnSundays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

                timeSpan = settings.endOfBreakOnSaturdays;
                this.TxtEndOfBreakOnSundays.Text = timeSpan != null ? timeSpan.Value.ToString(@"hh\:mm") : "---";

            }
            else
            {
                this.TxtStartOfWorkOnSundays.Text = "---";
                this.TxtEndOfWorkOnSundays.Text = "---";
                this.TxtStartOfBreakOnSundays.Text = "---";
                this.TxtEndOfBreakOnSundays.Text = "---";
            }

            // tempo médio das consultas em minutos 
            this.TxtStandardConsultationTime.Text = settings.standardConsultationTime.ToString();
        }

        private void CreatingEvents()
        {
            // eventos dos CheckBox
            this.CbMonday.CheckedChanged += CbMonday_CheckedChanged;
            this.CbTuesday.CheckedChanged += CbTuesday_CheckedChanged;
            this.CbWednesday.CheckedChanged += CbWednesday_CheckedChanged;
            this.CbThursday.CheckedChanged += CbThursday_CheckedChanged;
            this.CbFriday.CheckedChanged += CbFriday_CheckedChanged;
            this.CbSaturday.CheckedChanged += CbSaturday_CheckedChanged;
            this.CbSunday.CheckedChanged += CbSunday_CheckedChanged;

            // eventos dos TextBox dos horarios de trabalho
            this.TxtStartOfWorkOnMondays.TextChanged += TxtStartOfWorkOnMondays_TextChanged;// segunda
            this.TxtEndOfWorkOnMondays.TextChanged += TxtEndOfWorkOnMondays_TextChanged;
            this.TxtStartOfWorkOnTuesdays.TextChanged += TxtStartOfWorkOnTuesdays_TextChanged;// terça
            this.TxtEndOfWorkOnTuesdays.TextChanged += TxtEndOfWorkOnTuesdays_TextChanged;
            this.TxtStartOfWorkOnWednesdays.TextChanged += TxtStartOfWorkOnWednesdays_TextChanged;// quarta
            this.TxtEndOfWorkOnWednesdays.TextChanged += TxtEndOfWorkOnWednesdays_TextChanged;
            this.TxtStartOfWorkOnThursdays.TextChanged += TxtStartOfWorkOnThursdays_TextChanged;// quinta
            this.TxtEndOfWorkOnThursdays.TextChanged += TxtEndOfWorkOnThursdays_TextChanged;
            this.TxtStartOfWorkOnFridays.TextChanged += TxtStartOfWorkOnFridays_TextChanged;// sexta
            this.TxtEndOfWorkOnFridays.TextChanged += TxtEndOfWorkOnFridays_TextChanged;
            this.TxtStartOfWorkOnSaturdays.TextChanged += TxtStartOfWorkOnSaturdays_TextChanged;// sabado
            this.TxtEndOfWorkOnSaturdays.TextChanged += TxtEndOfWorkOnSaturdays_TextChanged;
            this.TxtStartOfWorkOnSundays.TextChanged += TxtStartOfWorkOnSundays_TextChanged;// domingo
            this.TxtEndOfWorkOnSundays.TextChanged += TxtEndOfWorkOnSundays_TextChanged;

            // evetos dos TextBox dos horarios de almoço
            this.TxtStartOfBreakOnMondays.TextChanged += TxtStartOfBreakOnMondays_TextChanged;// segunda
            this.TxtEndOfBreakOnMondays.TextChanged += TxtEndOfBreakOnMondays_TextChanged;
            this.TxtStartOfBreakOnTuesdays.TextChanged += TxtStartOfBreakOnTuesdays_TextChanged;// terça
            this.TxtEndOfBreakOnTuesdays.TextChanged += TxtEndOfBreakOnTuesdays_TextChanged;
            this.TxtStartOfBreakOnWednesdays.TextChanged += TxtStartOfBreakOnWednesdays_TextChanged;// quarta
            this.TxtEndOfBreakOnWednesdays.TextChanged += TxtEndOfBreakOnWednesdays_TextChanged;
            this.TxtStartOfBreakOnThursdays.TextChanged += TxtStartOfBreakOnThursdays_TextChanged;// quinta
            this.TxtEndOfBreakOnThursdays.TextChanged += TxtEndOfBreakOnThursdays_TextChanged;
            this.TxtStartOfBreakOnFridays.TextChanged += TxtStartOfBreakOnFridays_TextChanged;// sexta
            this.TxtEndOfBreakOnFridays.TextChanged += TxtEndOfBreakOnFridays_TextChanged;
            this.TxtStartOfBreakOnSaturdays.TextChanged += TxtStartOfBreakOnSaturdays_TextChanged;// sabado
            this.TxtEndOfBreakOnSaturdays.TextChanged += TxtEndOfBreakOnSaturdays_TextChanged;
            this.TxtStartOfBreakOnSundays.TextChanged += TxtStartOfBreakOnSundays_TextChanged;// domingo
            this.TxtEndOfBreakOnSundays.TextChanged += TxtEndOfBreakOnSundays_TextChanged;

            // evento do TxtStandardConsultationTime
            this.TxtStandardConsultationTime.TextChanged += TxtStandardConsultationTime_TextChanged;

        }

        // método que vai capturar os dados dos check box
        private void CaptureDays()
        {
            // dias trabalhados
            settings.workOnMondays = this.CbMonday.Checked;// segundas
            settings.workOnTuesdays = this.CbTuesday.Checked;// terça
            settings.workOnWednesdays = this.CbWednesday.Checked;// quarta
            settings.workOnThursdays = this.CbThursday.Checked;// quinta 
            settings.workOnFridays = this.CbFriday.Checked;//sexta
            settings.workOnSaturdays = this.CbSaturday.Checked;// sabado
            settings.workOnSundays = this.CbSunday.Checked;// domingo
        }

        // método que vai verificar e capturar os dados dos horarios de trabalho
        private void CaptureJobSchedules()
        {
            if (settings.workOnMondays)// se trabalha as segundas
            {
                // tentando capturar o horario das segundas 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnMondays.Text, out TimeSpan swm))// horario inicial
                    settings.startOfWorkOnMondays = swm;

                else
                    settings.startOfWorkOnMondays = null;

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnMondays.Text, out TimeSpan ewm))// horario final
                    settings.endOfWorkOnMondays = ewm;

                else
                    settings.endOfWorkOnMondays = null;
            }
            else
            {
                settings.startOfWorkOnMondays = null;
                settings.endOfWorkOnMondays = null;
            }

            if (settings.workOnTuesdays)// se trabalha as terças
            {
                // tentando capturar o horario das terças 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnTuesdays.Text, out TimeSpan swtu))// horario inicial
                    settings.startOfWorkOnTuesdays = swtu;

                else
                    settings.startOfWorkOnTuesdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnTuesdays.Text, out TimeSpan ewtu))// horario final
                    settings.endOfWorkOnTuesdays = ewtu;

                else
                    settings.endOfWorkOnTuesdays = null;
            }
            else
            {
                settings.startOfWorkOnTuesdays = null;
                settings.endOfWorkOnTuesdays = null;
            }

            if (settings.workOnWednesdays)// se trabalha as quartas
            {
                // tentando capturar o horario das quartas 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnWednesdays.Text, out TimeSpan sww))// horario inicial
                    settings.startOfWorkOnWednesdays = sww;

                else
                    settings.startOfWorkOnWednesdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnWednesdays.Text, out TimeSpan eww))// horario final
                    settings.endOfWorkOnWednesdays = eww;

                else
                    settings.endOfWorkOnWednesdays = null;
            }
            else
            {
                settings.startOfWorkOnWednesdays = null;
                settings.endOfWorkOnWednesdays = null;
            }

            if (settings.workOnThursdays)// se trabalha as quintas
            {
                // tentando capturar o horario das quintas 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnThursdays.Text, out TimeSpan swth))// horario inicial
                    settings.startOfWorkOnThursdays = swth;

                else
                    settings.startOfWorkOnThursdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnThursdays.Text, out TimeSpan ewth))// horario final
                    settings.endOfWorkOnThursdays = ewth;

                else
                    settings.endOfWorkOnThursdays = null;
            }
            else
            {
                settings.startOfWorkOnThursdays = null;
                settings.endOfWorkOnThursdays = null;

            }

            if (settings.workOnFridays)// se trabalha as sextas
            {
                // tentando capturar o horario das sextas 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnFridays.Text, out TimeSpan swf))// horario inicial
                    settings.startOfWorkOnFridays = swf;

                else
                    settings.startOfWorkOnFridays = null;

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnFridays.Text, out TimeSpan ewf))// horario final
                    settings.endOfWorkOnFridays = ewf;

                else
                    settings.endOfWorkOnFridays = null;
            }
            else
            {
                settings.startOfWorkOnFridays = null;
                settings.endOfWorkOnFridays = null;
            }

            if (settings.workOnSaturdays)// se trabalha aos sabados
            {
                // tentando capturar o horario das sabados 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnSaturdays.Text, out TimeSpan swsa))// horario inicial
                    settings.startOfWorkOnSaturdays = swsa;

                else
                    settings.startOfWorkOnSaturdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnSaturdays.Text, out TimeSpan ewsa))// horario final
                    settings.endOfWorkOnSaturdays = ewsa;

                else
                    settings.endOfWorkOnSaturdays = null;
            }
            else
            {
                settings.startOfWorkOnSaturdays = null;
                settings.endOfWorkOnSaturdays = null;
            }

            if (settings.workOnSundays)// se trabalha aos domingos
            {
                // tentando capturar o horario das domingos 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnSundays.Text, out TimeSpan swsu))// horario inicial
                    settings.startOfWorkOnSundays = swsu;

                else
                    settings.startOfWorkOnSundays = null;

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnSundays.Text, out TimeSpan ewsu))// horario final
                    settings.endOfWorkOnSundays = ewsu;

                else
                    settings.endOfWorkOnSundays = null;
            }
            else
            {
                settings.startOfWorkOnSundays = null;
                settings.endOfWorkOnSundays = null;

            }
        }

        // método que vai verificar e capturar os dados dos horarios de almoço
        private void CaptureLunchSchedules()
        {
            if (settings.workOnMondays)// se trabalha as segundas
            {
                // tentando capturar o horario das segundas 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnMondays.Text, out TimeSpan swm))// horario inicial
                    settings.startOfBreakOnMondays = swm;

                else
                    settings.startOfBreakOnMondays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnMondays.Text, out TimeSpan ewm))// horario final
                    settings.endOfBreakOnMondays = ewm;

                else
                    settings.endOfBreakOnMondays = null;
            }
            else
            {
                settings.startOfBreakOnMondays = null;
                settings.endOfBreakOnMondays = null;
            }

            if (settings.workOnTuesdays)// se trabalha as terças
            {
                // tentando capturar o horario das terças 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnTuesdays.Text, out TimeSpan swm))// horario inicial
                    settings.startOfBreakOnTuesdays = swm;

                else
                    settings.startOfBreakOnTuesdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnTuesdays.Text, out TimeSpan ewm))// horario final
                    settings.endOfBreakOnTuesdays = ewm;

                else
                    settings.endOfBreakOnTuesdays = null;
            }
            else
            {
                settings.startOfBreakOnTuesdays = null;
                settings.endOfBreakOnTuesdays = null;
            }

            if (settings.workOnWednesdays)// se trabalha as quartas
            {
                // tentando capturar o horario das quartas 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnWednesdays.Text, out TimeSpan swm))// horario inicial
                    settings.startOfBreakOnWednesdays = swm;

                else
                    settings.startOfBreakOnWednesdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnWednesdays.Text, out TimeSpan ewm))// horario final
                    settings.endOfBreakOnWednesdays = ewm;

                else
                    settings.endOfBreakOnWednesdays = null;
            }
            else
            {
                settings.startOfBreakOnWednesdays = null;
                settings.endOfBreakOnWednesdays = null;
            }

            if (settings.workOnThursdays)// se trabalha as quintas
            {
                // tentando capturar o horario das quintas 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnThursdays.Text, out TimeSpan swm))// horario inicial
                    settings.startOfBreakOnThursdays = swm;

                else
                    settings.startOfBreakOnThursdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnThursdays.Text, out TimeSpan ewm))// horario final
                    settings.endOfBreakOnThursdays = ewm;

                else
                    settings.endOfBreakOnThursdays = null;
            }
            else
            {
                settings.startOfBreakOnThursdays = null;
                settings.endOfBreakOnThursdays = null;
            }

            if (settings.workOnFridays)// se trabalha as sextas
            {
                // tentando capturar o horario das sextas 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnFridays.Text, out TimeSpan swm))// horario inicial
                    settings.startOfBreakOnFridays = swm;

                else
                    settings.startOfBreakOnFridays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnFridays.Text, out TimeSpan ewm))// horario final
                    settings.endOfBreakOnFridays = ewm;

                else
                    settings.endOfBreakOnFridays = null;
            }
            else
            {
                settings.startOfBreakOnFridays = null;
                settings.endOfBreakOnFridays = null;
            }

            if (settings.workOnSaturdays)// se trabalha aos sabados
            {
                // tentando capturar o horario das sabados 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnSaturdays.Text, out TimeSpan swm))// horario inicial
                    settings.startOfBreakOnSaturdays = swm;

                else
                    settings.startOfBreakOnSaturdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnSaturdays.Text, out TimeSpan ewm))// horario final
                    settings.endOfBreakOnSaturdays = ewm;

                else
                    settings.endOfBreakOnSaturdays = null;
            }
            else
            {
                settings.startOfBreakOnSaturdays = null;
                settings.endOfBreakOnSaturdays = null;

            }

            if (settings.workOnSundays)// se trabalha aos domingos
            {
                // tentando capturar o horario das domingos 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnSundays.Text, out TimeSpan swm))// horario inicial
                    settings.startOfBreakOnSundays = swm;

                else
                    settings.startOfBreakOnSundays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnSundays.Text, out TimeSpan ewm))// horario final
                    settings.endOfBreakOnSundays = ewm;

                else
                    settings.endOfBreakOnSundays = null;
            }
            else
            {
                settings.startOfBreakOnSundays = null;
                settings.endOfBreakOnSundays = null;
            }
        }

        private void Confirm()
        {
            CaptureDays(); // capturando os dias trabalhados
            CaptureJobSchedules(); // capturando os horarios de trabalho 
            CaptureLunchSchedules();// capturando os horarios de almoço

            // capturando o tempo padrão das consultas
            if (int.TryParse(this.TxtStandardConsultationTime.Text, out int value))
            {
                settings.standardConsultationTime = value;
            }

            //settings.PrintDaysWorked();

            string resp = Data.InsertSettings(settings);// enviando para o banco de dados

            Debug.WriteLine(resp);

            ScheduleManager.update();// mandando atualizar os horarios no gerenciador

            ChangeBtnConfirmToDisabled();// mudando o botão
        }

        private void ChangeBtnConfirmToEnabled()
        {
            this.BtnConfirm.BackColor = Color.FromArgb(63, 72, 204);
            this.BtnConfirm.ForeColor = Color.White;
            this.BtnConfirm.Enabled = true;

            //texto de aviso
            this.LblWarning.Visible = true;
        }

        private void ChangeBtnConfirmToDisabled()
        {
            this.BtnConfirm.BackColor = SystemColors.ControlDarkDark;
            this.BtnConfirm.ForeColor = SystemColors.AppWorkspace;
            this.BtnConfirm.Enabled = false;

            //texto de aviso
            this.LblWarning.Visible = false;
        }


        //------------------------- métodos dos eventos -------------------------

        //------------------------- Checkeboxes
        private void CbMonday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void CbTuesday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void CbWednesday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void CbThursday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void CbFriday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void CbSaturday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void CbSunday_CheckedChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        //------------------------- inicio hórarios de trabalho
        private void TxtStartOfWorkOnMondays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfWorkOnTuesdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfWorkOnWednesdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfWorkOnThursdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfWorkOnFridays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfWorkOnSaturdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfWorkOnSundays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        //------------------------- final hórarios de trabalho
        private void TxtEndOfWorkOnMondays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfWorkOnTuesdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfWorkOnWednesdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfWorkOnThursdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfWorkOnFridays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfWorkOnSaturdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfWorkOnSundays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        //------------------------- inicio hórarios almoço
        private void TxtStartOfBreakOnMondays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfBreakOnTuesdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfBreakOnWednesdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfBreakOnThursdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfBreakOnFridays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfBreakOnSaturdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtStartOfBreakOnSundays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        //------------------------- final hórarios almoço
        private void TxtEndOfBreakOnMondays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfBreakOnTuesdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfBreakOnWednesdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfBreakOnThursdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfBreakOnFridays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfBreakOnSaturdays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        private void TxtEndOfBreakOnSundays_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        //------------------------- tempo médio das consultas
        private void TxtStandardConsultationTime_TextChanged(object sender, EventArgs e)
        {
            ChangeBtnConfirmToEnabled();
        }

        //------------------------- evento do botão
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }
    }
}
