namespace eAirFlow.WebAPI.Settings
{
    public class PayPalSettings
    {
        public string ClientId { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
        public string Mode { get; set; } = "sandbox";
    }
}
