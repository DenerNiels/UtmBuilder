

using System.Text.RegularExpressions;
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
            InvalidUrlException.ThrowIfInvalidUrl(address,);
        }

        /// <summary>
        /// Address of URL (Website link)
        /// </summary>

        public string Address { get; }
    }
}
