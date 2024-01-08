using ClassLibAss2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAss2
{
    [TestFixture]
    public class UserAuthenticatorTests1
    {
        private UserAuthenticator userAuthenticator;

        [SetUp]
        public void Setup()
        {
            userAuthenticator = new UserAuthenticator();
        }

        [Test]
        public void TestUserRegistration()
        {
            // Test user registration
            Assert.IsTrue(userAuthenticator.RegisterUser("newUser", "password123"));
            Assert.IsFalse(userAuthenticator.RegisterUser("newUser", "password456"));
        }

        [Test]
        public void TestUserLogin()
        {
            // Test user login
            userAuthenticator.RegisterUser("existingUser", "password789");

            Assert.IsTrue(userAuthenticator.LoginUser("existingUser", "password789"));
            Assert.IsFalse(userAuthenticator.LoginUser("nonexistentUser", "invalidPassword"));
        }
    }
}
