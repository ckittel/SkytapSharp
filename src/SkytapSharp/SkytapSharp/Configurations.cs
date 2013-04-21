using System;
using System.Collections.Generic;
using RestSharp;
using SkytapSharp.Models;

namespace SkytapSharp
{
    public partial class SkytapClient
    {
        private const string ConfigurationResource = "configurations";

        public IReadOnlyCollection<ConfigurationInfo> GetConfigurations()
        {
            var request = new RestRequest { Resource = ConfigurationResource };

            return Execute<List<ConfigurationInfo>>(request);
        }

        public Configuration GetConfiguration(string id)
        {
            var request = new RestRequest { Resource = ConfigurationResource + "/" + id };

            return Execute<Configuration>(request);
        }

        public bool DeleteConfiguration(string id)
        {
            // DELETE
            throw new NotImplementedException();
        }

        public Configuration UpdateConfiguration(Configuration updatedConfiguration)
        {
            // PUT
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the owner of the configuration to the indicated owner.  This operation
        /// will fail if the new owner does not have sufficient quota to accept
        /// the configuration.
        /// </summary>
        /// <param name="configurationId"></param>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        public Configuration SetConfigurationOwner(string configurationId, string ownerId)
        {
            // PUT
            throw new NotImplementedException();
        }

        public void SetConfigurationState(ConfigurationState state)
        {
            // PUT
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new configuration cloned from a template.
        /// </summary>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public Configuration CreateConfigurationFromTemplate(string templateId)
        {

            // POST template_id=
            throw new NotImplementedException();
        }

        /// <summary>
        /// When merging template A into configuration B, this operation has the effect of
        /// copying the machines out of template A and adding them to configuration B.
        /// Interfaces of virutal machines of template A are adjusted to the network in
        /// configuration B, and other elements of template A (network, metadata, etc) are
        /// discarded.
        /// </summary>
        /// <param name="configurationId"></param>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public Configuration MergeTemplateIntoConfiguration(string configurationId, string templateId)
        {
            // PUT config-id, template-id
            throw new NotImplementedException();
        }

        public VirtualMachine GetConfigurationVirtualMachine(string configurationId, string virtualMachineId)
        {
            var request = new RestRequest { Resource = ConfigurationResource + "/" + configurationId + "/" + VirtualMachineResource + "/" + virtualMachineId };

            return Execute<VirtualMachine>(request);
        }

        public VirtualMachine SetVirtualMachineState(string configurationId, VirutalMachineState state)
        {
            // PUT
            throw new NotImplementedException();
        }

        public VirtualMachine MountIso(string configurationId, Uri isoAssetUri)
        {
            // PUT
            throw new NotImplementedException();
        }

        public void DeleteConfigurationVirtualMachine(string templateId, string virtualMachineId)
        {
            // DELETE
            throw new NotImplementedException();
        }

        public Network GetConfigurationNetwork(string configurationId, string networkId)
        {
            var request = new RestRequest { Resource = ConfigurationResource + "/networks/" + networkId };

            return Execute<Network>(request);
        }

        public Network UpdateConfigurationNetwork(string configurationId, Network network)
        {
            // PUT
            throw new NotImplementedException();
        }
    }
}
