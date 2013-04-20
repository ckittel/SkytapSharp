using System;
using RestSharp;
using SkytapSharp.Models;

namespace SkytapSharp
{
    public partial class SkytapClient
    {
        private const string VirtualMachineResource = "vms";

        public VirtualMachine GetTemplateVirtualMachine(string templateId, string virtualMachineId)
        {
            var request = new RestRequest { Resource = TemplateResource + "/" + templateId + "/" + VirtualMachineResource + "/" + virtualMachineId };

            return Execute<VirtualMachine>(request);
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

        public void DeleteTempateVirtualMachine(string templateId, string virtualMachineId)
        {
            // DELETE
            throw new NotImplementedException();
        }

        public void DeleteConfigurationVirtualMachine(string templateId, string virtualMachineId)
        {
            // DELETE
            throw new NotImplementedException();
        }

    }
}
