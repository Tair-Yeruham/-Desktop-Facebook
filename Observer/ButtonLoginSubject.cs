namespace B22_Ex03.Observer
{
    public delegate void EnableControlsAfterLoggedIn(ButtonLoginSubject i_ButtonLoginSubject);

    public class ButtonLoginSubject
    {
        private EnableControlsAfterLoggedIn m_EnableControlsAfterLoggedIn;

        public bool IsLoggedIn { get; set; }

        public void AddObserver(EnableControlsAfterLoggedIn i_EnableControlsAfterLoggedIn)
        {
            m_EnableControlsAfterLoggedIn += i_EnableControlsAfterLoggedIn;
        }

        public void RemoveObserver(EnableControlsAfterLoggedIn i_EnableControlsAfterLoggedIn)
        {
            m_EnableControlsAfterLoggedIn -= i_EnableControlsAfterLoggedIn;
        }

        public void Notify()
        {
            m_EnableControlsAfterLoggedIn?.Invoke(this);
        }
    }
}
