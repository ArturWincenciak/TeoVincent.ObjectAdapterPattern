namespace TeoVincent.ObjectAdapterPattern
{
    public class Client
    {
        public void CallRequest(ITarget target)
        {
            target.Request();
        }
    }
}