using System;
using System.Collections.Generic;

namespace SkytapSharp.Models
{
    /// <summary>
    /// This class represents a Skytap virtual machine.  A virutal machine
    /// is an image of a single virtual computer.  VMs do not exist outside
    /// of configurations or templates, but a configuration or template can
    /// have multiple virtual machines.
    /// </summary>
    /// <remarks>
    /// vm-ref :== [template-ref]/vms/vm-id
    /// vm-ref :== [configuration-ref/vms/vm-id
    /// </remarks>
    public class VirtualMachine
    {
        public VirtualMachine()
        {
            Credentials = new List<object>();
            NetworkInterfaces = new List<object>();
            Labels = new List<Label>();
            Notes = new List<object>();
        }

        /// <summary>
        /// Gets the identifier of the VM.
        /// 
        /// This is RO in the API
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets the human-readable name of the VM
        /// 
        /// This is RW in the API.  Max length is 100 chars.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sets the URI to the currently mounted ISO
        /// 
        /// Writing an asset URL to this field cases that asset to mount in
        /// the VM as a CD-ROM.  While it's possible to specify an asset that's
        /// not an ISO image, it will fail.
        /// 
        /// This field is write-only, it is always displayed as empty.
        /// 
        /// This is WO in the API
        /// </summary>
        public Uri AssetId { get; set; }

        /// <summary>
        /// Gets the hardware information for this VM.
        /// </summary>
        public Hardware Hardware { get; set; }

        public bool CanChangeObjectState { get; set; }
        public bool IsDesktopResizable { get; set; }
        public bool HasError { get; set; }
        public bool HasLocalMouseCursor { get; set; }

        /// <summary>
        /// Gets or sets the runstate of the VM.
        /// 
        /// Setting the runstate of a VM is ascynchronous.  The command will
        /// start the transition from one state to the next and will return
        /// 'busy' while the change is underway.  The client will need to poll
        /// to find out when the target state has been reached.
        /// 
        /// This is RW in the API.
        /// </summary>
        public string Runstate { get; set; }

        public List<object> Credentials { get; set; }
        
        /// <summary>
        /// Gets the list of Virtual Network interfaces
        /// </summary>
        public List<object> NetworkInterfaces { get; set; }
        public List<Label> Labels { get; set; }
        public List<object> Notes { get; set; } 
 
    }
}