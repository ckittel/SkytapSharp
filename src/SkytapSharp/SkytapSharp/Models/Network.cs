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

        /// <summary>
        /// Gets the identifier for the virtual network
        /// 
        /// This is RO in the API
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the human-readable name of the network
        /// 
        /// This is RW in the API
        /// </summary>
        public string Name { get; set; }

        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the domain name
        /// 
        /// This is RW in the API
        /// </summary>
        public string Domain { get; set; }

        public IPAddress Gateway { get; set; }

        /// <summary>
        /// Gets the type of network (Automatic or Manual)
        /// 
        /// This is RO in the API
        /// </summary>
        public string NetworkType { get; set; }

        /// <summary>
        /// Gets or sets the user-provided primary name server for
        /// this network.
        /// 
        /// This is RW in the API
        /// </summary>
        public string PrimaryNameserver { get; set; }

        /// <summary>
        /// Gets or sets the user-provided secondary name server for
        /// this network.
        /// 
        /// This is RW in the API
        /// </summary>
        public string SecondaryNameserver { get; set; }

        public string Subnet { get; set; }
        public string SubnetAddr { get; set; }
        public int SubnetSize { get; set; }

        /// <summary>
        /// Gets or sets if network if visible to other networks to
        /// connect to or not
        /// 
        /// This is RW in the API
        /// </summary>
        public bool Tunnelable { get; set; }

        /// <summary>
        /// Gets a list of connections between this network and other
        /// networks
        /// </summary>
        public List<object> Tunnels { get; set; }

        public List<object> VpnAttachments { get; set; } 

    }
}