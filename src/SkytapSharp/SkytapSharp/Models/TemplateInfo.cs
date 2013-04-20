namespace SkytapSharp.Models
{

    /// <summary>
    /// A template is a specification of one or more vitual machine images,
    /// plus associated resources such as network configurations, as well as
    /// metadata such as notes and tags.  This class represents the data
    /// returns when asking Skytap for a list of templates.
    /// </summary>
    /// <remarks>
    /// The purpose of a template is to serve as a blueprint from which any
    /// number of runnable configurations can be created.  As such, a template
    /// is not directly runnable, and there are constraints on the ways a
    /// template can be modified once created.
    /// </remarks>
    public class TemplateInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}