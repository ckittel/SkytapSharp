using System.Collections.Generic;

namespace SkytapSharp.Models
{
    public class VirtualMachine
    {
        public VirtualMachine()
        {
            Credentials = new List<object>();
            Hardware = new List<object>();
            NetworkInterfaces = new List<object>();
            Labels = new List<Label>();
            Notes = new List<object>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string AssetId { get; set; }
        public bool CanChangeObjectState { get; set; }
        public bool IsDesktopResizable { get; set; }
        public bool HasError { get; set; }
        public bool HasLocalMouseCursor { get; set; }
        public string Runstate { get; set; }

        public List<object> Credentials { get; set; }
        public List<object> Hardware { get; set; }
        public List<object> NetworkInterfaces { get; set; }
        public List<Label> Labels { get; set; }
        public List<object> Notes { get; set; } 
 
    }
}