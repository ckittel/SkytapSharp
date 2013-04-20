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
            var request = new RestRequest
                              {
                                  Resource = UserResource,
                                  Method = Method.GET
                              };

            return Execute<List<User>>(request).AsReadOnly();
        }

        public User GetUser(string id)
        {
            var request = new RestRequest {Resource = UserResource + "/" + id, Method = Method.GET};

            return Execute<User>(request);
        }
    }
}
