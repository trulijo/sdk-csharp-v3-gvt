using Xunit;

namespace Trulioo.Client.V3.Tests
{
    public class ConnectionFacts
    {
        [Fact]
        public async void SayHello_Success()
        {
            //Arrange
            using var client = await BaseFact.GetTruliooClientAsync();
            var response = await client.Connection.SayHelloAsync("SomeUser");
            Assert.Contains("SomeUser", response);
        }

        [Fact]
        public async void Authentication_Success()
        {
            //Arrange
            using var client = await BaseFact.GetTruliooClientAsync();
            var response = await client.Connection.TestAuthenticationAsync();
            Assert.Contains(BaseFact.ClientId, response);
        }
    }
}