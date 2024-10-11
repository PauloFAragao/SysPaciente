using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SysPaciente.Entities
{
    internal class FormLoader
    {
        public static Panel PanelBody { get; set; }

        private static Form _activeForm;

        //relacionado ao menu
        public static Panel PanelMenu { get; set; }
        public static System.Windows.Forms.Button MenuButton { get; set; }

        private static bool _menu = false;// Indica se o menu está aberto ou não

        public static void OpenChildForm(Form childForm)
        {
            if (_activeForm != null)// verifica se tem alguma form aberta e fecha
            {
                _activeForm.Close();
            }

            _activeForm = childForm;// atualizando a referencia local a form que vai ser aberta

            // abrindo a form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelBody.Controls.Add(childForm);
            PanelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // lidando com o menu
            if (_menu)
            {
                MenuController();
            }

        }

        //sobrecarga para ser chamada pelo botão no menu
        public static void MenuController()
        {

            if (_menu)
            {
                _menu = !_menu;
                PanelMenu.Visible = false;
                MenuButton.BackColor = Color.FromArgb(70, 130, 180);
                MenuButton.ForeColor = Color.Black;
            }
            else
            {
                _menu = !_menu;
                PanelMenu.Visible = true;
                MenuButton.BackColor = Color.FromArgb(63, 72, 204);
                MenuButton.ForeColor = Color.White;
                PanelMenu.BringToFront();//trazendo para frente
            }
        }
    }
}
