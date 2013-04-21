namespace SkytapSharp.Models
{
    public class Tunnel
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public Network SourceNetwork { get; set; }
        public Network TargetNetwork { get; set; }
    }
}
