namespace TeoVincent.ObjectAdapterPattern
{
    public class Adapter : ITarget
    {
        private readonly IAdaptee adaptee;
 
        public Adapter(IAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }
 
        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}