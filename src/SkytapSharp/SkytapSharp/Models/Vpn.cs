namespace SkytapSharp.Models
{
    public class Vpn
    {
        /// <summary>
        /// Gets the identifer for the VPN in the form of "vpn-#"
        /// 
        /// This is RO in the API
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the human-readable name for the VPN
        /// 
        /// This is RW in the API
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the status of the VPN tunnel
        /// 
        /// inactive or active
        /// 
        /// This is RO in the API
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets if the VPN is enabled or disabled
        /// 
        /// This is RW in the API
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets if Dead Peer Detection is enabled.
        /// 
        /// This is RW in the API
        /// </summary>
        public bool? DpdEnabled { get; set; }

        /// <summary>
        /// Gets what region this VPN exists in.
        /// 
        /// This is RO in the API
        /// </summary>
        public string Region { get; set; }

    }
}
