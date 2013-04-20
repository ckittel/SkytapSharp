using System.Globalization;
using System.Reflection;
using System.Text;
using RestSharp;
using RestSharp.Extensions;

namespace SkytapSharp
{

    /// <summary>
    /// REST API wrapper for API version 1.14
    /// </summary>
    public partial class SkytapClient
    {
        private readonly RestClient _client;

        /// <summary>
        /// Initializes a new client with the specified credentials.
        /// </summary>
        public SkytapClient(string accountName, string apiKey)
        {
            _client = new RestClient("https://cloud.skytap.com")
                          {
                              UserAgent = GetUserAgent(),
                              Authenticator = new HttpBasicAuthenticator(accountName, apiKey)
                              
                          };
        }

        private static string GetUserAgent()
        {
            // Get the version of the assembly
            var assemblyVersion = new AssemblyName(Assembly.GetExecutingAssembly().FullName).Version;

            return "SkytapSharp/" + assemblyVersion;
        }


        public virtual T Execute<T>(RestRequest request) where T : new()
        {
            request.OnBeforeDeserialization = response =>
                                                  {
                                                      // for individual resources where there is an error make sure that
                                                      // RestException properties are populated

                                                      // known response errors:
                                                      // 401 Not authorized
                                                      // 404 Not found
                                                      // 422 Invalid parameter
                                                      // 423 Stale Object reference
                                                      // 500 System error
                                                      if (((int) response.StatusCode) < 400) return;

                                                      const string restException = "{{ \"RestException\" : {0} }}";
                                                      var content = response.RawBytes.AsString();
                                                      // get the response content
                                                      var newJson = string.Format(restException, content);

                                                      response.Content = null;
                                                      response.RawBytes = Encoding.UTF8.GetBytes(newJson.ToString(CultureInfo.InvariantCulture));
                                                  };
            
            return _client.Execute<T>(request).Data;
        }

        public virtual IRestResponse Execute(IRestRequest request)
        {
            return _client.Execute(request);
        }
    }
}
