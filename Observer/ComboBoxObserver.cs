using System.Windows.Forms;

namespace B22_Ex03.Observer
{
    public class ComboBoxObserver : IObserver
    {
        private readonly ComboBox r_ComboBox;

        public ComboBoxObserver(ComboBox i_ComboBox)
        {
            r_ComboBox = i_ComboBox;
        }

        public void Update(ButtonLoginSubject i_ButtonLoginSubject)
        {
            r_ComboBox.Enabled = i_ButtonLoginSubject.IsLoggedIn;
        }
    }
}
