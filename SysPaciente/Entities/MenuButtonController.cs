using System.Drawing;
using System.Windows.Forms;

namespace SysPaciente.Entities
{
    internal class MenuButtonController
    {
        private static Button _btnHome;
        private static Button _btnClients;
        private static Button _btnConsultations;
        private static Button _btnConfigurations;

        private static Button _currentButton;

        private static Color _unselectedButton = Color.FromArgb(70, 130, 180);
        private static Color _selectedButton = Color.FromArgb(63, 72, 204);

        public static void SetButtonsData(Button btnHome, Button btnClients, Button btnConsultations, Button btnConfigurations)
        {
            _btnHome = btnHome;
            _btnClients = btnClients;
            _btnConsultations = btnConsultations;
            _btnConfigurations = btnConfigurations;
        }

        public  static void UnselectCurrentButton()
        {
            _currentButton.BackColor = _unselectedButton;
            _currentButton.ForeColor = Color.Black;
            _currentButton = null;
        }

        public static void SetBtnHomeSelected()
        {
            if(_currentButton != _btnHome)
            {
                if (_currentButton != null)
                    UnselectCurrentButton();

                _currentButton = _btnHome;
                _currentButton.BackColor = _selectedButton;
                _currentButton.ForeColor = Color.White;
            }
        }

        public static void SetBtnClientsSelected()
        {
            if (_currentButton != _btnClients)
            {
                if (_currentButton != null)
                    UnselectCurrentButton();

                _currentButton = _btnClients;
                _currentButton.BackColor = _selectedButton;
                _currentButton.ForeColor = Color.White;
            }
        }

        public static void SetBtnConsultationsSelected()
        {
            if (_currentButton != _btnConsultations)
            {
                if (_currentButton != null)
                    UnselectCurrentButton();

                _currentButton = _btnConsultations;
                _currentButton.BackColor = _selectedButton;
                _currentButton.ForeColor = Color.White;
            }
        }

        public static void SetBtnConfigurationsSelected()
        {
            if (_currentButton != _btnConfigurations)
            {
                if (_currentButton != null)
                    UnselectCurrentButton();

                _currentButton = _btnConfigurations;
                _currentButton.BackColor = _selectedButton;
                _currentButton.ForeColor = Color.White;
            }
        }

    }
}
