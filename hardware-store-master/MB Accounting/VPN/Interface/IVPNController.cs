namespace VPN.Interface
{
    public interface IVPNController
    {
        public bool Connect();
        public bool Disconnect();
        public bool IsConnected();
    }
}
