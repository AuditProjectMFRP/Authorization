using Authorization_service;
using Authorization_service.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Authorization.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /*[Test]
        public void IsTokenNotNull()
        {
            var TokenObj = new TokenController();
            var Result = TokenObj.AuthenticateUser(new Authenticate() { Name = "subhanshu", Password = "bankhwal" });
            Assert.IsNotNull(Result);
        }

        [Test]
        public void IsTokenNull()
        {
            var TokenObj = new TokenController();
            var Result =TokenObj.AuthenticateUser(new Authenticate(){Name = "wronginput",Password = "wronginput"});
            Assert.IsNull(Result);
        }*/

    }
}