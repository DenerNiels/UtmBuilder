using System.Text;
using UtmBuilder.core.ValueObjects.Exceptions;

namespace UtmBuilder.core.ValueObjects
{
    public class Url : ValueObjects
    {
       

        /// <summary>
        /// Create a new URL
        /// </summary>
        /// <param name="address">Address of URL (Website link)</param>
        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalidUrl(address);
        }

        /// <summary>
        /// Address of URL (Website link)
        /// </summary>

        public string Address { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Address);
            sb.Append("utm_source=");
            return "";
        }
    }
}
