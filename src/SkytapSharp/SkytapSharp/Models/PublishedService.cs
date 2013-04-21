using System.Net;

namespace SkytapSharp.Models
{
    public class PublishedService
    {
        public string Id { get; set; }
        public int InternalPort { get; set; }
        public int ExternalPort { get; set; }
        public IPAddress ExternalIp { get; set; }
    }
}
