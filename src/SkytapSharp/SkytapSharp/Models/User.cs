using System.Collections.Generic;

namespace SkytapSharp.Models
{
    public class User
    {
        public User()
        {
            Templates = new List<object>();
            Quotas = new List<Quota>();
            Assets = new List<object>();
        }

        public string Id { get; set; }
        public string Url { get; set; }
        public string LoginName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the e-mail addrss to which notifications may be sent.
        /// </summary>
        public string EMail { get; set; }

        public string Title { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the user's account role.
        /// </summary>
        /// <remarks>
        /// A user's account role defines their access to the full range
        /// of Skytap features and settings.  The four possible user
        /// roles are "restricted user," "standard user," "user manager,"
        /// and "admin."
        /// </remarks>
        public string AccountRole { get; set; }

        public bool? CanImport { get; set; }
        public bool? CanExport { get; set; }


        public bool? SsoEnabled { get; set; }

        public List<object> Assets { get; set; } 
        public List<Quota> Quotas { get; set; }
        public List<object> Templates { get; set; } 

    }
}
