namespace SkytapSharp.Models
{
    /// <summary>
    /// A template is a specification of one or more vitual machine images,
    /// plus associated resources such as network configurations, as well as
    /// metadata such as notes and tags.
    /// </summary>
    /// <remarks>
    /// The purpose of a template is to serve as a blueprint from which any
    /// number of runnable configurations can be created.  As such, a template
    /// is not directly runnable, and there are constraints on the ways a
    /// template can be modified once created.
    /// </remarks>
    public class Template
    {
        /// <summary>
        /// Gets the identifier for this template.
        /// 
        /// This is RO in the API
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets the URI reference for the template.
        /// 
        /// This is RO in the API
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the name of the template
        /// 
        /// This is RW in the API.  Max length 255.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets if the template is busy.
        /// 
        /// Many operations can make the template busy (such as changing
        /// runstates).  If you attempt to perform an operation on a
        /// busy tempate, you will likely receive an error.
        /// 
        /// This is RO in the API
        /// </summary>
        public bool? Busy { get; set; }

        /// <summary>
        /// Gets or sets the owner (via URI) of the template.
        /// 
        /// Setting this field to a new owner will be subjected to permission
        /// and quota constraints.
        /// 
        /// This is RW in the API
        /// </summary>
        public string OwnerUrl { get; set; }

        /// <summary>
        /// Gets if the template is from a Skytap public library
        /// 
        /// This is RO in the API
        /// </summary>
        public string Public { get; set; }

        /// <summary>
        /// Gets or sets the human-readable description for the template
        /// 
        /// This is RW in the API.  Max length 1000.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets what region the template is housed
        /// 
        /// This is RO in the API
        /// </summary>
        public string Regions { get; set; }

        //public List<VirtualMachine> Vms { get; set; } // ro 
        //public List<Network> Networks { get; set; } // ro


        // Undocumented API
        public string LockVersion { get; set; }
        public string TagList { get; set; }
    }
}
