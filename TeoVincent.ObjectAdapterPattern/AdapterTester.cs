using FakeItEasy;
using Xunit;

namespace TeoVincent.ObjectAdapterPattern
{
    public class AdapterTester
    {
        private readonly Client client;
 
        public AdapterTester()
        {
            client = new Client();
        }
 
        [Fact]
        public void call_request_method_in_target()
        {
            // arrange
            ITarget target = A.Fake<ITarget>();
 
            // act
            client.CallRequest(target);
 
            // assert
            A.CallTo(() => target.Request()).MustHaveHappened();
        }
    }
}
