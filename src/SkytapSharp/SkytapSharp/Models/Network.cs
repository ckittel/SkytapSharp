using System.Collections.Generic;
using System.Net;

namespace SkytapSharp.Models
{
    public class Network
    {
        public Network()
        {
            Tunnels = new List<object>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Domain { get; set; }
        public IPAddress Gateway { get; set; }
        public string NetworkType { get; set; }
        public string PrimaryNameserver { get; set; }
        public string Subnet { get; set; }
        public string SubnetAddr { get; set; }
        public int SubnetSize { get; set; }
        public bool IsTunnelable { get; set; }

        public List<object> Tunnels { get; set; }
        public List<object> VpnAttachments { get; set; } 

    }
}