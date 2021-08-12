using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using WebApi;

namespace ChaBarNote.Test
{
    [TestClass]
    public class AdminTest
    {
        private HttpClient _client;
        public AdminTest()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = server.CreateClient();

        }


        [TestMethod]
        public void PostLoginTest()
        {
            var request = new HttpRequestMessage(new HttpMethod("POST"), $"/api/Admin/Login");

            var response = _client.SendAsync(request).Result;

            Assert.AreEqual(HttpStatusCode.UnsupportedMediaType, response.StatusCode);
        }


        [TestMethod]
        public void PostAddUserTest()
        {
            var request = new HttpRequestMessage(new HttpMethod("POST"), $"/api/Admin/PostAddUser");

            var response = _client.SendAsync(request).Result;

            Assert.AreEqual(HttpStatusCode.UnsupportedMediaType, response.StatusCode);
        }
    }
}
