using System;

namespace SkytapSharp.Models
{
    /// <summary>
    /// Files uploaded to your account are called assets.  These files
    /// can be downloaded onto VMs in your account, as well as shared with
    /// other users via Projects.
    /// 
    /// Via the API, assets can only be viewed, referenced, and have their
    /// ownership managed.  Cannot create, modify, or delete at this time.
    /// </summary>
    public class Asset
    {
        /// <summary>
        /// Gets the identifier for the asset
        /// 
        /// This is RO in the API
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets the human-readable name for the asset
        /// 
        /// This is RO in the API
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the size, in MB, of the asset.
        /// 
        /// This is RO in the API
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the Owner Url.
        /// 
        /// Like other resources that may be owned, a asset belongs
        /// to exactly one user, and updaging the owner field
        /// 
        /// This is RW in the API
        /// </summary>
        public Uri Owner { get; set; }

        /// <summary>
        /// Gets the region where the asset is housed
        /// 
        /// This will be either "US-West" or "US-East"
        /// 
        /// This is RO in the API
        /// </summary>
        public string Region { get; set; }
    }
}
