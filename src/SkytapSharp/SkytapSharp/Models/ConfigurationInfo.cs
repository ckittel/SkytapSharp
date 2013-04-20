namespace SkytapSharp.Models
{
    /// <summary>
    /// This class represents a configuration in Skytap.  Like a template, a configuration
    /// is a specification that describes one or more virutal machines.
    /// </summary>
    public class ConfigurationInfo
    {
        /// <summary>
        /// Gets the identifier for the configuration
        /// 
        /// This is RO in the API
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets the URL for the configuration
        /// 
        /// This is RO in the API
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the human-readable name of the configuration
        /// 
        /// This is RW in the API.  Max length is 255.
        /// </summary>
        public string Name { get; set; }
    }
}