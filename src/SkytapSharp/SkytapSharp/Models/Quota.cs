namespace SkytapSharp.Models
{
    public class Quota
    {
        public string Id { get; set; }
        public string Limit { get; set; }
        public string QuotaType { get; set; }
        public string Units { get; set; }
        public decimal Usage { get; set; }
    }
}
