﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Simple.OData.Client.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Simple.OData.Client.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;entry xmlns:d=&quot;http://schemas.microsoft.com/ado/2007/08/dataservices&quot; xmlns:m=&quot;http://schemas.microsoft.com/ado/2007/08/dataservices/metadata&quot; xmlns=&quot;http://www.w3.org/2005/Atom&quot;&gt;
        ///  &lt;title /&gt;
        ///  &lt;updated/&gt;
        ///  &lt;author&gt;
        ///    &lt;name /&gt;
        ///  &lt;/author&gt;
        ///  &lt;id /&gt;
        ///  &lt;content type=&quot;application/xml&quot;&gt;
        ///    &lt;m:properties/&gt;
        ///  &lt;/content&gt;
        ///  &lt;link rel=&quot;http://schemas.microsoft.com/ado/2007/08/dataservices/related/&quot; type=&quot;application/atom+xml;type=Entry&quot; /&gt;
        ///&lt;/entry&gt;.
        /// </summary>
        internal static string DataServicesAtomEntryXml {
            get {
                return ResourceManager.GetString("DataServicesAtomEntryXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;uri xmlns=&quot;http://schemas.microsoft.com/ado/2007/08/dataservices/metadata&quot;&gt;
        ///&lt;/uri&gt;.
        /// </summary>
        internal static string DataServicesMetadataEntryXml {
            get {
                return ResourceManager.GetString("DataServicesMetadataEntryXml", resourceCulture);
            }
        }
    }
}
