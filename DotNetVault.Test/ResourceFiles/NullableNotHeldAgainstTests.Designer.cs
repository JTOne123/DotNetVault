﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetVault.Test.ResourceFiles {
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
    internal class NullableNotHeldAgainstTests {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NullableNotHeldAgainstTests() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetVault.Test.ResourceFiles.NullableNotHeldAgainstTests", typeof(NullableNotHeldAgainstTests).Assembly);
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
        ///   Looks up a localized string similar to using System;
        ///using DotNetVault.Attributes;
        ///
        ///namespace DotNetVault.Test.TestCases
        ///{
        ///    [VaultSafe]
        ///    public sealed class EventArgsOkTest : EventArgs
        ///    {
        ///        public EventArgsOkTest(DateTime? ts) =&gt; _ts = ts;
        ///
        ///        public override string ToString() =&gt; $&quot;Timestamp: [{_ts?.ToString(&quot;O&quot;) ?? &quot;NONE&quot;}].&quot;;
        ///        
        ///
        ///        private readonly DateTime? _ts;
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string EventArgsOkTest {
            get {
                return ResourceManager.GetString("EventArgsOkTest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using DotNetVault.Attributes;
        ///
        ///namespace DotNetVault.Test.TestCases
        ///{
        ///    [VaultSafe]
        ///    public sealed class NullableNotHeldAgainstMe
        ///    {
        ///        public bool HasTs =&gt; _ts != null;
        ///        public NullableNotHeldAgainstMe(DateTime? ts) =&gt; _ts = ts;
        ///        public override string ToString() =&gt; $&quot;Timestamp: [{_ts?.ToString(&quot;O&quot;) ?? &quot;NONE&quot;}].&quot;;
        ///        
        ///
        ///        private readonly DateTime? _ts;
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string NullableNotHeldAgainstTest {
            get {
                return ResourceManager.GetString("NullableNotHeldAgainstTest", resourceCulture);
            }
        }
    }
}
