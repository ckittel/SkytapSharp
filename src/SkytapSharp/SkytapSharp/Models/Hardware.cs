using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkytapSharp.Models
{
    public class Hardware
    {
        /// <summary>
        /// Gets or sets the number of CPUs
        /// 
        /// The valid range is 1 though 8, however MaxCpu
        /// could lower that.  This value can only be changed
        /// when the VM is stopped.
        /// 
        /// This is RW in the API.
        /// </summary>
        public int Cpus { get; set; }

        /// <summary>
        /// Gets or sets the amount of memory (in MB)
        /// 
        /// Must be between 256 and 32768.  Maximum limit
        /// depends on MaxRam.  This value can only be changed
        /// when the VM is stopped.
        /// 
        /// This is RW in the API.
        /// </summary>
        public int Ram { get; set; }

        /// <summary>
        /// Gets the number of SVMs used by this VM.
        /// 
        /// This is RO in the API.
        /// </summary>
        public int Svms { get; set; }

        /// <summary>
        /// Gets the max number of settable CPUs for this VM.
        /// 
        /// This is RO in the API.
        /// </summary>
        public int MaxCpu { get; set; }

        /// <summary>
        /// Gets the max amount of settable RAM for this VM.
        /// 
        /// This is RO in the API.
        /// </summary>
        public int MaxRam { get; set; }



    }
}
