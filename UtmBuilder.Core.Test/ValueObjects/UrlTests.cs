using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.core.ValueObjects;
using UtmBuilder.core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Test.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        private const string InvalidUrl = "banana";
        private const string ValidUrl = "https://balta.io";

        [TestMethod]
        [ExpectedException(typeof(InvalidUrlException))]
        public void DadoUmaUrlInvalidoDeveRetornarUmaExcecao()
        {
            new Url(InvalidUrl);
        }

        //[TestMethod]
        //public void DadoUmaUrValidoNaoDeveRetornarUmaExcecao()
        //{
        //    new Url(ValidUrl);
        //    Assert.IsTrue(true);
        //}

        [TestMethod]
        [DataRow("", true)]
        [DataRow("http", true)]
        [DataRow("banana", true)]
        [DataRow("https://balta.io", false)]
        public void TestUrl(
            string link,
            bool expectException)
        {
            if (expectException)
            {
                try
                {
                    new Url(link);
                    Assert.Fail();
                }
                catch (InvalidUrlException e) 
                {
                    Assert.IsTrue(true);
                }
            }
            else 
            {
                new Url(link);
                Assert.IsTrue(true);
            }
        }
    }
}
