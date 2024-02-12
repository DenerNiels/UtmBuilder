
using UtmBuilder.core.ValueObjects;
using UtmBuilder.core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Test.ValueObjects
{
    [TestClass]
    public class CampaingTests
    {
        [TestMethod]
        [DataRow("", "", "", true)]
        [DataRow("src", "", "", true)]
        [DataRow("src", "med", "", true)]
        [DataRow("src", "med", "nme", false)]
        public void TestCampaing(
            string source,
            string medium,
            string name,
            bool expectException) 
        
        {
            if (expectException)
            {
                try
                {
                    new Campaing(source, medium, name);
                    Assert.Fail();
                }
                catch (InvalidCampaingException) 
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                new Campaing(source, medium, name);
                Assert.IsTrue(true);
            }
        }
    }
}
