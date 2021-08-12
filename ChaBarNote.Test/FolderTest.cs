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
    public class FolderTest
    {
        private HttpClient _client;
        public FolderTest()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = server.CreateClient();

        }

        [TestMethod]
        public void DeleteFolderTest()
        {
            var request = new HttpRequestMessage(new HttpMethod("POST"), $"/api/Folder/DeleteFolder");

            var response = _client.SendAsync(request).Result;

            Assert.AreEqual(HttpStatusCode.UnsupportedMediaType, response.StatusCode);
        }
    }
}
