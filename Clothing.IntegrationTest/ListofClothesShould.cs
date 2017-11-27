using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Clothing.IntegrationTest
{
    public class ListofClothesShould
    {
        private readonly TestServer Server;
        private readonly HttpClient Client;

        public ListofClothesShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("/warehouse");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnOkStatusSummary()
        {
            var response = await Client.GetAsync("/warehouse/summary");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
