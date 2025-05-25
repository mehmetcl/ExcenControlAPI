namespace ExcenControlAPI.Services
{
    public class LedService : ILedService
    {
        private bool _status = false;

        public bool GetStatus() => _status;

        public void SetStatus(bool isOn)
        {
            _status = isOn;
        }
    }
}
