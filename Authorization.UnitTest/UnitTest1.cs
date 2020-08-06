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
        public void IsTokenNotNull_When_ValidUserCredentialsAreUsed()
        {
            //Arrange

            //Act
            var TokenObj = new TokenController();
            var Result = TokenObj.AuthenticateUser(new Authenticate() { Name = "subhanshu", Password = "bankhwal" });

            //Assert
            Assert.IsNotNull(Result);
        }

        [Test]
        public void IsTokenNull_When_InalidUserCredentialsAreUsed()
        {
            //Arrange

            //Act
            var TokenObj = new TokenController();
            var Result =TokenObj.AuthenticateUser(new Authenticate(){Name = "wronginput",Password = "wronginput"});

            //Assert
            Assert.IsNull(Result);
        }*/

    }
}