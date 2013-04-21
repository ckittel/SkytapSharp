namespace SkytapSharp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Quota
    {
        /// <summary>
        /// Gets the identifier for the quota
        /// 
        /// This is RO in the API
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the usage limit for the user.
        /// 
        /// What happens when the quota is reached depends on the quota type.
        ///  * When the SVM hours quota is reached, all running VMs are suspended.
        ///    Using more SVM hours required an increase in the quota limit.
        ///  * When the SVM quota is reached, no futher VMs can be started.  Stopping
        ///    running VMs "frees up" SVMs and allows more to be started.
        ///  * When the storage quota is reach, no more templates or configurations
        ///    may be created.  Deleting existing templates or configurations allows
        ///    more to be made.
        /// 
        /// This is RW in the API
        /// </summary>
        public string Limit { get; set; }

        /// <summary>
        /// Gets what kind of resource the quota is measuring type.  
        /// One of:
        ///  * concurrent_storage_size: MB/GB - Storage limits
        ///  * concurrent_svms: int - The number of Skytap VMs that may be used at the same time
        ///  * cumulative_svms: int - The number of hours of SVM usage (ie, SVM hours)
        /// 
        /// This is RO in the API
        /// </summary>
        public string QuotaType { get; set; }

        /// <summary>
        /// Gets the units related to the Limit and Usage fields.  The
        /// value of this is QuotaType specific.
        /// 
        /// This is RO in the API
        /// </summary>
        public string Units { get; set; }

        /// <summary>
        /// Gets the current usage information against the quota.  It is not required for every
        /// user to have a quota defined for all or even any quota type.  In case a user does
        /// not have a quota of a particular type, the quota for the customer account is used
        /// by default.
        /// 
        /// This is RO in the API
        /// </summary>
        public decimal Usage { get; set; }
    }
}
