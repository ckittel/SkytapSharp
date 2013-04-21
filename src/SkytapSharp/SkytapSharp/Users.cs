using System;
using System.Collections.Generic;
using RestSharp;
using SkytapSharp.Models;

namespace SkytapSharp
{
    public partial class SkytapClient
    {
        private const string UserResource = "users";

        public IReadOnlyCollection<User> GetUsers()
        {
            var request = new RestRequest { Resource = UserResource };

            return Execute<List<User>>(request).AsReadOnly();
        }

        public User GetUser(string id)
        {
            var request = new RestRequest {Resource = UserResource + "/" + id, Method = Method.GET};

            return Execute<User>(request);
        }

        /// <summary>
        /// Creates a new user.
        /// 
        /// When creating a new user, only the LoginName, Password, and EMail fields
        /// are required.
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public User CreateUser(User newUser)
        {
            // POST
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a list of quotas defined for the user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IReadOnlyCollection<Quota> GetUserQuotas(string userId)
        {
            var request = new RestRequest { Resource = UserResource + "/" + userId + "/quotas" };

            return Execute<List<Quota>>(request).AsReadOnly();
        }

        /// <summary>
        /// Creates a new user quota.  When creating a quota, the Type and Limit
        /// fields are required.  The Units and Usage fields are ignored.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="newQuota"></param>
        /// <returns></returns>
        public Quota CreateUserQuota(string userId, Quota newQuota)
        {
            // POST
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a user quota
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="quotaId"></param>
        /// <param name="newLimit"></param>
        /// <returns></returns>
        public Quota ChangeUserQuotaLimit(string userId, string quotaId, int newLimit)
        {
            // PUT
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a user-specific quota.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="quotaId"></param>
        public void DeleteUserQuota(string userId, string quotaId)
        {
            // DELETE
            throw new NotImplementedException();
        }
    }
}
