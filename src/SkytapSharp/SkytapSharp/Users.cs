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
    }
}
