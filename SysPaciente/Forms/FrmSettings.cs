using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPaciente.Forms
{
    public partial class FrmSettings : Form
    {

        public FrmSettings()
        {
            InitializeComponent();

            //texto de aviso
            this.LblWarning.Text = "   Atenção alterar dados dessa pagina pode \ngerar a necessidade de reagendar consultas!";
            this.LblWarning.Visible = false;
        }

        private void ChangeBtnConfirmToEnabled()
        {
            this.BtnConfirm.BackColor = Color.FromArgb(63, 72, 204);
            this.BtnConfirm.ForeColor = Color.White;
            this.BtnConfirm.Enabled = true;

            //texto de aviso
            this.LblWarning.Visible = true;
        }

        //------------------------- métodos criados pelo visual studio -------------------------

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

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
