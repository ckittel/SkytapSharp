using System;
using System.Collections.Generic;

namespace SkytapSharp.Models
{
    /// <summary>
    /// This class represents a configuration in Skytap.  Like a template, a configuration
    /// is a specification that describes one or more virutal machine images, associated
    /// resources, and metadata around ownership, composition, and resources.  Unlike a
    /// template, many more of the properties of a configuration may be modified.  More
    /// importantly, a configuration can be run.
    /// </summary>
    public class Configuration
    {
        public Configuration()
        {
            PublishSets = new List<object>();
            Networks = new List<Network>();
            Vms = new List<VirtualMachine>();
        }

        /// <summary>
        /// Gets the identifier for the configuration
        /// 
        /// This is RO in the API
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets the URL for the configuration
        /// 
        /// This is RO in the API
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the human-readable name of the configuration
        /// 
        /// This is RW in the API.  Max length is 255.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the a summary of the stats of the contained virtual
        /// machines, and it can be used to control the states of those virtual
        /// machines in parallel.
        /// 
        /// Because it can potentially respresent the stats of many contained
        /// virutal machines, Runstate is a computed value.  The individaul
        /// virutal machines in a configuration may have different states from
        /// one another; for instance, one could be running, one stopped, and one
        /// suspended.  Since this mixture of states cannot be represented accurately
        /// by a single field, the configuration runstate is determined by looking at
        /// the range of states and choosing a single 'representative' state.  The
        /// runstate results should be intepreted as follows:
        /// 
        /// * stopped = all virtual machines are stopped.
        /// * suspended = one or more virtual machines are suspended, others are stopped
        /// * running = one or more virtual machines are running
        /// 
        /// Setting the runstate to one of the legal target states initiates state transitions
        /// for all of the contained virtual machines.  Note also that not all transitions are
        /// valuid.  The following describles the possible runstate transitions:
        /// 
        /// Current     to  Running                 Stopped             Halted              Suspended
        /// Running         No Change               Graceful Shutdown   Forced Shutdown     Suspended
        /// Stopped         Running Configuration   No Change           No Change           [invalid]
        /// Suspended       Running Configuration   [invalid]           [invalid]           No Change
        /// 
        /// Note that 'halted' runstate does not appear as a starting state.  It is actually
        /// a pseudo-state; setting the runstate of a running configuration to 'halted' executes
        /// a forcilble transtion to the 'stopped' state.  This is typically faster than the
        /// 'stopped' transition, and is more robust in the case of errors in the guest VM.
        /// 
        /// Also note that some other states may appear from time to time, such as 'busy' or
        /// 'deploying.' Any state other than the states defined above should be interpreted as
        /// a sign of a configuration (or VM) in transtion.  In particular, these are not local
        /// target states.
        /// This is RW in the API
        /// </summary>
        public string Runstate { get; set; }

        /// <summary>
        /// Gets or sets the owner of the configuration.  Setting the configuration to have
        /// a new owner is subject to the permission and quota constraints of the new owner.
        /// 
        /// This is RW in the API
        /// </summary>
        public Uri Owner { get; set; }

        /// <summary>
        /// Gets or sets how many minutes the configuration must idle before
        /// it is automatically suspended
        /// 
        /// A configuration is deemed to be idel if there is no UI interaction with any of the
        /// VMs that comprise it.
        /// 
        /// This is RW in the API
        /// </summary>
        public int SuspendOnIdle { get; set; }

        /// <summary>
        /// Gets what region the configuration is housed.
        /// 
        /// Expect US-West or US-East.
        /// 
        /// This is RO in the API
        /// </summary>
        public string Regions { get; set; }

        /// <summary>
        /// Gets a list of published set resources providing anonymous access
        /// to VMs
        /// </summary>
        public List<object> PublishSets { get; set; }

        /// <summary>
        /// Gets a list of the virtual machines in the configuration
        /// </summary>
        public List<VirtualMachine> Vms { get; set; }

        /// <summary>
        /// Gets a list of virtual networks in the configuration
        /// </summary>
        public List<Network> Networks { get; set; } 


        // unoffical parts of the API
        public bool DisableInternet { get; set; }
        public bool Routable { get; set; }
        public bool UseSmartClient { get; set; }
    }
}
