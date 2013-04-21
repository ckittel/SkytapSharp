using System;
using System.Collections.Generic;
using RestSharp;
using SkytapSharp.Models;

namespace SkytapSharp
{
    public partial class SkytapClient
    {
        private const string AssetResource = "assets";

        /// <summary>
        /// Gets a list of assets
        /// </summary>
        public IReadOnlyCollection<Asset> GetAssets()
        {
            var request = new RestRequest { Resource = AssetResource };

            return Execute<List<Asset>>(request).AsReadOnly();
        }

        /// <summary>
        /// Gets the requested asset
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Asset GetAsset(string id)
        {
            var request = new RestRequest { Resource = AssetResource + "/" + id};

            return Execute<Asset>(request);            
        }

        public Asset ChangeAssetOwner(string assetId, string ownerId)
        {
            // PUT
            throw new NotImplementedException();
        }
    }
}
