using SysPaciente.Entities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SysPaciente.Forms
{
    public partial class FrmSettings : Form
    {
        Settings _settings;

        public FrmSettings()
        {
            InitializeComponent();

            //texto de aviso
            this.LblWarning.Text = "   Atenção alterar dados dessa pagina pode \ngerar a necessidade de reagendar consultas!";
            this.LblWarning.Visible = false;

            // objeto que vai guardar todos os dados das configurações
            _settings = new Settings();

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
            _settings.workOnMondays = this.CbMonday.Checked;// segundas
            _settings.workOnTuesdays = this.CbTuesday.Checked;// terça
            _settings.workOnWednesdays = this.CbWednesday.Checked;// quarta
            _settings.workOnThursdays = this.CbThursday.Checked;// quinta 
            _settings.workOnFridays = this.CbFriday.Checked;//sexta
            _settings.workOnSaturdays = this.CbSaturday.Checked;// sabado
            _settings.workOnSundays = this.CbSunday.Checked;// domingo
        }

        // método que vai verificar e capturar os dados dos horarios de trabalho
        private bool CaptureJobSchedules()
        {
            bool resp = true;

            string errorMsg = "Por favor preencha os seguintes campos:";

            if (_settings.workOnMondays)// se trabalha as segundas
            {
                // tentando capturar o horario das segundas 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnMondays.Text, out TimeSpan swm))// horario inicial
                    _settings.startOfWorkOnMondays = swm;

                else
                {
                    //settings.startOfWorkOnMondays = null;
                    resp = false;

                    errorMsg += "\n-Horário do inicio do expediente as Segundas-Feiras";
                }

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnMondays.Text, out TimeSpan ewm))// horario final
                    _settings.endOfWorkOnMondays = ewm;

                else
                {
                    //settings.endOfWorkOnMondays = null;
                    resp = false;

                    errorMsg += "\n-Horário do final do expediente as Segundas-Feiras";
                }
            }
            else
            {
                _settings.startOfWorkOnMondays = null;
                _settings.endOfWorkOnMondays = null;
            }

            if (_settings.workOnTuesdays)// se trabalha as terças
            {
                // tentando capturar o horario das terças 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnTuesdays.Text, out TimeSpan swtu))// horario inicial
                    _settings.startOfWorkOnTuesdays = swtu;

                else  
                {
                    //settings.startOfWorkOnTuesdays = null;
                    resp = false;

                    errorMsg += "\n-Horário do inicio do expediente as Terças-Feiras";
                }

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnTuesdays.Text, out TimeSpan ewtu))// horario final
                    _settings.endOfWorkOnTuesdays = ewtu;

                else 
                {
                    //settings.endOfWorkOnTuesdays = null;
                    resp = false;

                    errorMsg += "\n-Horário do final do expediente as Terças-Feiras";
                }
            }
            else
            {
                _settings.startOfWorkOnTuesdays = null;
                _settings.endOfWorkOnTuesdays = null;
            }

            if (_settings.workOnWednesdays)// se trabalha as quartas
            {
                // tentando capturar o horario das quartas 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnWednesdays.Text, out TimeSpan sww))// horario inicial
                    _settings.startOfWorkOnWednesdays = sww;

                else
                {
                    //settings.startOfWorkOnWednesdays = null;
                    resp = false;

                    errorMsg += "\n-Horário do inicio do expediente as Quartas-Feiras";
                }

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnWednesdays.Text, out TimeSpan eww))// horario final
                    _settings.endOfWorkOnWednesdays = eww;

                else
                {
                    //settings.endOfWorkOnWednesdays = null;
                    resp = false;

                    errorMsg += "\n-Horário do final do expediente as Quartas-Feiras";
                }
            }
            else
            {
                _settings.startOfWorkOnWednesdays = null;
                _settings.endOfWorkOnWednesdays = null;
            }

            if (_settings.workOnThursdays)// se trabalha as quintas
            {
                // tentando capturar o horario das quintas 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnThursdays.Text, out TimeSpan swth))// horario inicial
                    _settings.startOfWorkOnThursdays = swth;

                else
                {
                    //settings.startOfWorkOnThursdays = null;
                    resp = false;

                    errorMsg += "\n-Horário do inicio do expediente as Quintas-Feiras";
                }

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnThursdays.Text, out TimeSpan ewth))// horario final
                    _settings.endOfWorkOnThursdays = ewth;

                else
                {
                    //settings.endOfWorkOnThursdays = null;
                    resp = false;

                    errorMsg += "\n-Horário do final do expediente as Quintas-Feiras";
                }
            }
            else
            {
                _settings.startOfWorkOnThursdays = null;
                _settings.endOfWorkOnThursdays = null;
            }

            if (_settings.workOnFridays)// se trabalha as sextas
            {
                // tentando capturar o horario das sextas 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnFridays.Text, out TimeSpan swf))// horario inicial
                    _settings.startOfWorkOnFridays = swf;

                else
                {
                    //settings.startOfWorkOnFridays = null;
                    resp = false;

                    errorMsg += "\n-Horário do inicio do expediente as Sextas-Feiras";
                }

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnFridays.Text, out TimeSpan ewf))// horario final
                    _settings.endOfWorkOnFridays = ewf;

                else
                {
                    //settings.endOfWorkOnFridays = null;
                    resp = false;

                    errorMsg += "\n-Horário do final do expediente as Sextas-Feiras";
                }
            }
            else
            {
                _settings.startOfWorkOnFridays = null;
                _settings.endOfWorkOnFridays = null;
            }

            if (_settings.workOnSaturdays)// se trabalha aos sabados
            {
                // tentando capturar o horario das sabados 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnSaturdays.Text, out TimeSpan swsa))// horario inicial
                    _settings.startOfWorkOnSaturdays = swsa;

                else
                {
                    //settings.startOfWorkOnSaturdays = null;
                    resp = false;

                    errorMsg += "\n-Horário do inicio do expediente aos Sábados";
                }

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnSaturdays.Text, out TimeSpan ewsa))// horario final
                    _settings.endOfWorkOnSaturdays = ewsa;

                else
                {
                    //settings.endOfWorkOnSaturdays = null;
                    resp = false;

                    errorMsg += "\n-Horário do final do expediente aos Sábados";
                }
            }
            else
            {
                _settings.startOfWorkOnSaturdays = null;
                _settings.endOfWorkOnSaturdays = null;
            }

            if (_settings.workOnSundays)// se trabalha aos domingos
            {
                // tentando capturar o horario das domingos 
                if (TimeSpan.TryParse(this.TxtStartOfWorkOnSundays.Text, out TimeSpan swsu))// horario inicial
                    _settings.startOfWorkOnSundays = swsu;

                else
                {
                    //settings.startOfWorkOnSundays = null;
                    resp = false;

                    errorMsg += "\n-Horário do inicio do expediente aos Domingos";
                }

                if (TimeSpan.TryParse(this.TxtEndOfWorkOnSundays.Text, out TimeSpan ewsu))// horario final
                    _settings.endOfWorkOnSundays = ewsu;

                else
                {
                    //settings.endOfWorkOnSundays = null;
                    resp = false;

                    errorMsg += "\n-Horário do final do expediente aos Domingos";
                }
            }
            else
            {
                _settings.startOfWorkOnSundays = null;
                _settings.endOfWorkOnSundays = null;

            }


            if (!resp)
                MessageBox.Show(errorMsg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return resp;
        }

        // método que vai verificar e capturar os dados dos horarios de almoço
        private void CaptureLunchSchedules()
        {
            

            if (_settings.workOnMondays)// se trabalha as segundas
            {
                // tentando capturar o horario das segundas 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnMondays.Text, out TimeSpan swm))// horario inicial
                    _settings.startOfBreakOnMondays = swm;

                else
                    _settings.startOfBreakOnMondays = null;
                

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnMondays.Text, out TimeSpan ewm))// horario final
                    _settings.endOfBreakOnMondays = ewm;

                else
                    _settings.endOfBreakOnMondays = null;
                
            }
            else
            {
                _settings.startOfBreakOnMondays = null;
                _settings.endOfBreakOnMondays = null;
            }

            if (_settings.workOnTuesdays)// se trabalha as terças
            {
                // tentando capturar o horario das terças 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnTuesdays.Text, out TimeSpan swm))// horario inicial
                    _settings.startOfBreakOnTuesdays = swm;

                else
                    _settings.startOfBreakOnTuesdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnTuesdays.Text, out TimeSpan ewm))// horario final
                    _settings.endOfBreakOnTuesdays = ewm;

                else
                    _settings.endOfBreakOnTuesdays = null;
            }
            else
            {
                _settings.startOfBreakOnTuesdays = null;
                _settings.endOfBreakOnTuesdays = null;
            }

            if (_settings.workOnWednesdays)// se trabalha as quartas
            {
                // tentando capturar o horario das quartas 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnWednesdays.Text, out TimeSpan swm))// horario inicial
                    _settings.startOfBreakOnWednesdays = swm;

                else
                    _settings.startOfBreakOnWednesdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnWednesdays.Text, out TimeSpan ewm))// horario final
                    _settings.endOfBreakOnWednesdays = ewm;

                else
                    _settings.endOfBreakOnWednesdays = null;
            }
            else
            {
                _settings.startOfBreakOnWednesdays = null;
                _settings.endOfBreakOnWednesdays = null;
            }

            if (_settings.workOnThursdays)// se trabalha as quintas
            {
                // tentando capturar o horario das quintas 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnThursdays.Text, out TimeSpan swm))// horario inicial
                    _settings.startOfBreakOnThursdays = swm;

                else
                    _settings.startOfBreakOnThursdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnThursdays.Text, out TimeSpan ewm))// horario final
                    _settings.endOfBreakOnThursdays = ewm;

                else
                    _settings.endOfBreakOnThursdays = null;
            }
            else
            {
                _settings.startOfBreakOnThursdays = null;
                _settings.endOfBreakOnThursdays = null;
            }

            if (_settings.workOnFridays)// se trabalha as sextas
            {
                // tentando capturar o horario das sextas 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnFridays.Text, out TimeSpan swm))// horario inicial
                    _settings.startOfBreakOnFridays = swm;

                else
                    _settings.startOfBreakOnFridays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnFridays.Text, out TimeSpan ewm))// horario final
                    _settings.endOfBreakOnFridays = ewm;

                else
                    _settings.endOfBreakOnFridays = null;
            }
            else
            {
                _settings.startOfBreakOnFridays = null;
                _settings.endOfBreakOnFridays = null;
            }

            if (_settings.workOnSaturdays)// se trabalha aos sabados
            {
                // tentando capturar o horario das sabados 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnSaturdays.Text, out TimeSpan swm))// horario inicial
                    _settings.startOfBreakOnSaturdays = swm;

                else
                    _settings.startOfBreakOnSaturdays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnSaturdays.Text, out TimeSpan ewm))// horario final
                    _settings.endOfBreakOnSaturdays = ewm;

                else
                    _settings.endOfBreakOnSaturdays = null;
            }
            else
            {
                _settings.startOfBreakOnSaturdays = null;
                _settings.endOfBreakOnSaturdays = null;
            }

            if (_settings.workOnSundays)// se trabalha aos domingos
            {
                // tentando capturar o horario das domingos 
                if (TimeSpan.TryParse(this.TxtStartOfBreakOnSundays.Text, out TimeSpan swm))// horario inicial
                    _settings.startOfBreakOnSundays = swm;

                else
                    _settings.startOfBreakOnSundays = null;

                if (TimeSpan.TryParse(this.TxtEndOfBreakOnSundays.Text, out TimeSpan ewm))// horario final
                    _settings.endOfBreakOnSundays = ewm;

                else
                    _settings.endOfBreakOnSundays = null;
            }
            else
            {
                _settings.startOfBreakOnSundays = null;
                _settings.endOfBreakOnSundays = null;
            }

        }

        private void Confirm()
        {
            CaptureDays();// capturando os dias trabalhados

            if (!CaptureJobSchedules())// capturando os horarios de trabalho 
                return;// se os campos não foram preenchidos coretamente
            
            CaptureLunchSchedules();// capturando os horarios de almoço

            // capturando o tempo padrão das consultas
            if (int.TryParse(this.TxtStandardConsultationTime.Text, out int value))
            {
                if(value < 10)
                {
                    MessageBox.Show("O tempo padrão das consultas não pode ser menor do que 10 minutos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _settings.standardConsultationTime = value;
            }

            string resp = Data.InsertSettings(_settings);// enviando para o banco de dados

            Debug.WriteLine(resp);

            ScheduleManager.update();// mandando atualizar os horarios no gerenciador

            // mandando verificar se alguma consulta vai ficar com status pendente
            string status = _settings.ProcessFutureConsultations();
            if (status != "")
            {
                MessageBox.Show(status, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
