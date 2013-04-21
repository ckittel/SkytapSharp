using System.Collections.Generic;
using System.Net;

namespace SkytapSharp.Models
{
    public class User
    {
        public User()
        {
            Templates = new List<Template>();
            Quotas = new List<Quota>();
            Assets = new List<Asset>();
        }

        /// <summary>
        /// Gets the unique identifier for the user.
        /// 
        /// This is RO in the API
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets the URL of the user
        /// 
        /// This is RO in the API
        /// </summary>
        public IPAddress Url { get; set; }

        /// <summary>
        /// Gets the user's login name
        /// 
        /// This is RO in the API
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// Gets or sets the user's first name
        /// 
        /// This is RW in the API
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the user's last name
        /// 
        /// This is RW in the API
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the e-mail addrss to which notifications may be sent.
        /// 
        /// This is RW in the API
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// Gets or sets additional information for the user
        /// 
        /// This is RW in the API
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Sets the users password
        /// 
        /// This field will always contain "**********"
        /// If this value is sent to the server, the server
        /// will ignore it and not change the password.
        /// 
        /// This is WO in the API
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the user's account role.
        /// 
        /// This is RW in the API
        /// </summary>
        /// <remarks>
        /// A user's account role defines their access to the full range
        /// of Skytap features and settings.  The four possible user
        /// roles are "restricted user," "standard user," "user manager,"
        /// and "admin."
        /// </remarks>
        public string AccountRole { get; set; }

        /// <summary>
        /// Gets or sets if the user can import VMs
        /// 
        /// This is RW in the API
        /// </summary>
        public bool? CanImport { get; set; }

        /// <summary>
        /// Gets or sets if the user can export VMs
        /// 
        /// This is RW in the API
        /// </summary>
        public bool? CanExport { get; set; }

        /// <summary>
        /// Gets or sets the amount of compression used to encode
        /// SRA data streams.  Higher values of compression can
        /// improve responsiveness of the SRA client but decrease
        /// visual quality.
        /// 
        /// Legal values are 1 through 7.
        /// 
        /// This is RW in the API
        /// </summary>
        public int SraCompression { get; set; }

        /// <summary>
        /// Gets or sets if this user is enabled for SSO
        /// 
        /// This is RW in the API
        /// </summary>
        public bool? SsoEnabled { get; set; }

        /// <summary>
        /// Gets a list of assets owned by this user
        /// </summary>
        public List<Asset> Assets { get; set; } 

        /// <summary>
        /// Gets the quotes in place for this user
        /// </summary>
        public List<Quota> Quotas { get; set; }

        /// <summary>
        /// Gets a list of templates owned by this user
        /// </summary>
        public List<Template> Templates { get; set; } 

    }
}
