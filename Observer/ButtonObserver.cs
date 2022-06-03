using System.Windows.Forms;

namespace B22_Ex03.Observer
{
    public class ButtonObserver : IObserver
    {
        private readonly Button r_Button;

        public ButtonObserver(Button i_Button)
        {
            r_Button = i_Button;
        }

        public void Update(ButtonLoginSubject i_ButtonLoginSubject)
        {
            r_Button.Enabled = i_ButtonLoginSubject.IsLoggedIn;
        }
    }
}
