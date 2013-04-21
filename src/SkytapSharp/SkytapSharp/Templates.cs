using System;
using System.Collections.Generic;
using RestSharp;
using SkytapSharp.Models;

namespace SkytapSharp
{
    public partial class SkytapClient
    {
        private const string TemplateResource = "templates";

        public IReadOnlyCollection<TemplateInfo> GetTemplates()
        {
            var request = new RestRequest { Resource = TemplateResource };

            return Execute<List<TemplateInfo>>(request);
        }

        public Template GetTemplate(string id)
        {
            var request = new RestRequest { Resource = TemplateResource + "/" + id };

            return Execute<Template>(request);
        }

        public bool DeleteTemplate(string id)
        {
            // DELETE
            throw new NotImplementedException();
        }

        public Template UpdateTempate(Template updatedTemplate)
        {
            // PUT
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the owner of the template to the indicated owner.  This operation
        /// will fail if the new owner does not have sufficient quota to accept
        /// the template.
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        public Template SetTemplateOwner(string templateId, string ownerId)
        {
            // PUT
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a template as a frozen copy of a configuration.  By default, any published URLs attached
        /// to a configuration are not saved when a template is made from the configuration.  To save published
        /// URLs as part of a template, you must indicate that here.
        /// </summary>
        /// <param name="configurationId"></param>
        /// <param name="savePublishedUrls"></param>
        /// <returns></returns>
        public Template CreateTemplateFromConfiguration(string configurationId, bool savePublishedUrls)
        {

            // POST configuration_id= --> URLS publish_sets=true
            throw new NotImplementedException();
        }

        public VirtualMachine GetTemplateVirtualMachine(string templateId, string virtualMachineId)
        {
            var request = new RestRequest { Resource = TemplateResource + "/" + templateId + "/" + VirtualMachineResource + "/" + virtualMachineId };

            return Execute<VirtualMachine>(request);
        }

        public void DeleteTempateVirtualMachine(string templateId, string virtualMachineId)
        {
            // DELETE
            throw new NotImplementedException();
        }

        public Network GetTemplateNetwork(string templateId, string networkId)
        {
            var request = new RestRequest { Resource = TemplateResource + "/networks/" + networkId };

            return Execute<Network>(request);
        }

        public Network UpdateTemplateNetwork(string templateId, Network network)
        {
            // PUT
            throw new NotImplementedException();
        }
    }
}
