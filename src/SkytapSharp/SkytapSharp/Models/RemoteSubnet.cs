namespace SkytapSharp.Models
{
    public class RemoteSubnet
    {
        public string Id { get; set; }
        public string CidrBlock { get; set; }
        public bool? Excluded { get; set; }
    }
}
