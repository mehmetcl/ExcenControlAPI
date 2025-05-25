namespace ExcenControlAPI.Services
{
    public interface ILedService
    {
        bool GetStatus();
        void SetStatus(bool isOn);
    }
}
