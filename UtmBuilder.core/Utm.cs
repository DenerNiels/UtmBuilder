using UtmBuilder.core.ValueObjects;

namespace UtmBuilder.core
{
    public class Utm
    {
        public Utm(
            Url url,
            Campaing campaing)
        {
            Url = url;
            Campaing = campaing;
        }


        /// <summary>
        /// Url details
        /// </summary>
        public Url Url { get; }

        /// <summary>
        /// Campaing details
        /// </summary>
        public Campaing Campaing { get; }
    }
}
