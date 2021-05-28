using EscreverSMS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class SMSTests
    {
        [TestMethod]
        public void DeveSerInputValidoUppercase()
        {
            SMS sms = new SMS("");

            Assert.AreEqual("", sms.SequenciaNumerica());
        }

        [TestMethod]
        public void DeveSerInputValidoLowercase()
        {
            SMS sms = new SMS("");

            Assert.AreEqual("", sms.SequenciaNumerica());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NaoDeveSerInputValido()
        {
            _ = new SMS(""
                );
        }
    }
}
