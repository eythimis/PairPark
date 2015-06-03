using System;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairPark.Controllers;
using System.Web;
using System.Net.Http;

namespace PairPark.Tests
{
    [TestClass]
    public class TestControllerUnitTest
    {
       
        public TestController _controller { get; set; }
        public HttpRequestMessage _request { get; set; }

        public TestControllerUnitTest()
        {
            _request = new HttpRequestMessage();
            _request.RequestUri = new Uri("http://localhost:52537/");

            _controller = new PairPark.Controllers.TestController();
            _controller.Request = _request;
        }

        [TestMethod]
        public void TestWorks()
        {
            
            
        }

        public void GetToken()
        {
            //Arrange
            var username = "tim";
            var password = "123";
            _request.RequestUri = new Uri(_request.RequestUri.AbsoluteUri + "/token");
            _request.Headers.Add("Content-Type","application/x-www-form-urlencoded");
            //_request.Headers.Add("Authorization","Bearer " + " DeguYJAIMU7nFKJwPkVbU3aiqSpo70ynPav8cXqYS1xaGxblBDuUHrioL50JRJah9doVIU-TA9VlcNa29s6jR1wHNPJ4cj0Kboi8zjzKnH-A1lJ4sn2rMqVgKgYcgn4hZITE-rjHXAYTyEjhwLNJ7qxpf6S7tU8164YctrvwTHtGavH6so5E1PaNH_ZjijnUmMxHMWPv_FKV7uelIkBikQ");
            _request.Method = HttpMethod.Get;
            _request.Content = new StringContent("grant_type=password&username=" + username + "&password=" + password);


            //Act
            


        }




        
    }
}
