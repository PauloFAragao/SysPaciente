using System.Windows.Forms;

namespace SysPaciente.Entities
{
    internal class FormLoader
    {
        public static Panel PanelBody { get; set; }

        private static Form _activeForm;

        public static void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelBody.Controls.Add(childForm);
            PanelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


    }
}
