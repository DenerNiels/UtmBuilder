using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.core;
using UtmBuilder.core.ValueObjects;

namespace UtmBuilder.Core.Test
{
    
    [TestClass]
    public class UtmTests
    {
        private const string Result = "https://balta.io/" +
                "?utm_source=src" +
                "&utm_medium=med" +
                "&utm_campaing=nme" +
                "&utm_id=id" +
                "&utm_term=ter" +
                "&utm_content=ctn";
        private readonly Url _url = new("https://balta.io/");
        private readonly Campaing _campaing = new(
                    "src",
                    "med",
                    "nme",
                    "id",
                    "ter",
                    "ctn");
        [TestMethod]
        public void ShouldReturnUrlFromUtm()
        {
            var utm = new Utm(_url, _campaing);
            Assert.AreEqual(Result, utm.ToString());
            Assert.AreEqual(Result, (string)utm);
        }


        [TestMethod]
        public void ShouldReturnUtmFromUrl() 
        {
            Utm utm = Result;
            Assert.AreEqual("https://balta.io/", utm.Url.Address);
            Assert.AreEqual("src", utm.Campaing.Source);
            Assert.AreEqual("med", utm.Campaing.Medium);
            Assert.AreEqual("nme", utm.Campaing.Name);
            Assert.AreEqual("id", utm.Campaing.Id);
            Assert.AreEqual("ter", utm.Campaing.Term);
            Assert.AreEqual("ctn", utm.Campaing.Content);
        }
    }
}
