using System.Text.RegularExpressions;


namespace UtmBuilder.core.ValueObjects.Exceptions
{
    public partial class InvalidCampaingException : Exception
    {
        private const string DefaultErrorMessage = "Invalid UTM Parameters";
        public InvalidCampaingException(string message = "Invalid UTM Parameters") : base(message)
        {
        }

        public static void ThrowIfNull(
        string? item,
        string message = DefaultErrorMessage)
        {
            if (string.IsNullOrEmpty(item))
                throw new InvalidCampaingException(message);
        }

        [GeneratedRegex(
            "^(http|https):(\\/\\/www\\.|\\/\\/www\\.|\\/\\/|\\/\\/)[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$|(http|https):(\\/\\/localhost:\\d*|\\/\\/127\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\\/.*)?$")]
        private static partial Regex UrlRegex();
    }
}
