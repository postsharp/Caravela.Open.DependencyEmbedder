﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Caravela.Open.DependencyEmbedder.Weaver {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Caravela.Open.DependencyEmbedder.Weaver.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to ﻿using System;
        ///using System.Collections.Generic;
        ///using System.Diagnostics;
        ///using System.Globalization;
        ///using System.IO;
        ///using System.IO.Compression;
        ///using System.Reflection;
        ///using System.Runtime.InteropServices;
        ///using System.Security.Cryptography;
        ///using System.Text;
        ///using System.Threading;
        ///
        ///// ReSharper disable CommentTypo
        ///
        ///namespace Caravela.Open.DependencyEmbedder.Weaver.Templates
        ///{
        ///    internal static class Common
        ///    {
        ///        [DllImport(&quot;kernel32&quot;, SetLastError = true, CharSet = CharSet.Unicode)]
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Common {
            get {
                return ResourceManager.GetString("Common", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Runtime.CompilerServices;
        ///
        ///namespace System.Runtime.CompilerServices
        ///{
        ///    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
        ///    public sealed class ModuleInitializerAttribute : Attribute { }
        ///}
        ///
        ///namespace Caravela.Open.DependencyEmbedder.Weaver.Templates
        ///{
        ///    static class ModuleInitializer
        ///    {
        ///        [ModuleInitializer]
        ///        internal static void Initialize()
        ///        {
        ///            TEMPLATE.Attach();
        ///        }
        ///    }
        ///}.
        /// </summary>
        internal static string ModuleInitializer {
            get {
                return ResourceManager.GetString("ModuleInitializer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ﻿using System;
        ///using System.Collections.Generic;
        ///using System.Reflection;
        ///using System.Threading;
        ///
        ///namespace Caravela.Open.DependencyEmbedder.Weaver.Templates
        ///{
        ///    internal static class Template
        ///    {
        ///        static object nullCacheLock = new object();
        ///        static Dictionary&lt;string, bool&gt; nullCache = new Dictionary&lt;string, bool&gt;();
        ///
        ///        static Dictionary&lt;string, string&gt; assemblyNames = new Dictionary&lt;string, string&gt;();
        ///        static Dictionary&lt;string, string&gt; symbolNames = new Dictionary&lt;string, string&gt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Template {
            get {
                return ResourceManager.GetString("Template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ﻿using System;
        ///using System.Collections.Generic;
        ///using System.IO;
        ///using System.Reflection;
        ///using System.Threading;
        ///
        ///namespace Caravela.Open.DependencyEmbedder.Weaver.Templates
        ///{
        ///    internal static class TemplateWithTempAssembly
        ///    {
        ///        static object nullCacheLock = new object();
        ///        static Dictionary&lt;string, bool&gt; nullCache = new Dictionary&lt;string, bool&gt;();
        ///
        ///        static string tempBasePath;
        ///
        ///        static List&lt;string&gt; preloadList = new List&lt;string&gt;();
        ///        static List&lt;string&gt; preload32List = [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TemplateWithTempAssembly {
            get {
                return ResourceManager.GetString("TemplateWithTempAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.IO;
        ///using System.Reflection;
        ///using System.Threading;
        ///
        ///namespace Caravela.Open.DependencyEmbedder.Weaver.Templates
        ///{
        ///    internal static class TemplateWithUnmanagedHandler
        ///    {
        ///        static object nullCacheLock = new object();
        ///        static Dictionary&lt;string, bool&gt; nullCache = new Dictionary&lt;string, bool&gt;();
        ///
        ///        static string tempBasePath;
        ///
        ///        static Dictionary&lt;string, string&gt; assemblyNames = new Dictionary&lt;string, string&gt;();
        ///        st [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TemplateWithUnmanagedHandler {
            get {
                return ResourceManager.GetString("TemplateWithUnmanagedHandler", resourceCulture);
            }
        }
    }
}
