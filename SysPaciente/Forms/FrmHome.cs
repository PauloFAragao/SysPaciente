using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using SysPaciente.Entities;

namespace SysPaciente.Forms
{
    public partial class FrmHome : Form
    {

        public FrmHome()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            // quantidade de consultas marcadas para hoje
            LblConsultationsAmount.Text = Data.GetConsultationsAmount(DateTime.Now).ToString();

            string FreeTimeText;
            if (DateTime.TryParse(ScheduleManager.GetFreeSchedule().ToString(), out DateTime nextFreeTime))
            {
                FreeTimeText = "Dia: ";
                FreeTimeText += nextFreeTime.ToString("dd/MM/yyyy");
                FreeTimeText += "  horário: ";
                FreeTimeText += nextFreeTime.TimeOfDay;
            }
            else
            {
                FreeTimeText = "Sem data livre pelos proximos 7 dias";
            }

            // proximo horario disponivel
            LblFreeTime.Text = FreeTimeText;
        }

    }
}
