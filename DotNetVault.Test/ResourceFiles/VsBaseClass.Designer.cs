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
    internal class VsBaseClass {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal VsBaseClass() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetVault.Test.ResourceFiles.VsBaseClass", typeof(VsBaseClass).Assembly);
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
        ///   Looks up a localized string similar to 
        ///using System;
        ///using System.Text;
        ///using DotNetVault.Attributes;
        ///
        ///namespace DotNetVault.Test.TestCases
        ///{
        ///    class NotVsException : Exception
        ///    {
        ///        public sealed override string Message =&gt; _sb.ToString();
        ///
        ///        private readonly StringBuilder _sb = new StringBuilder();
        ///    }
        ///    [VaultSafe]
        ///    sealed class NotVsBcBase : NotVsException
        ///    {
        ///
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string NotVsException {
            get {
                return ResourceManager.GetString("NotVsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///using System;
        ///using DotNetVault.Attributes;
        ///using DotNetVault.TestCaseHelpers;
        ///using JetBrains.Annotations;
        ///
        ///namespace DotNetVault.Test.TestCases
        ///{
        ///    [VaultSafe]
        ///    public sealed class TestBaseClassWbVsIfSealed  : WouldBeVaultSafeIfSealed
        ///    {
        ///        public Guid Id { get; }
        ///        public TestBaseClassWbVsIfSealed([NotNull] string name, int age) : base(name, age) =&gt;
        ///            Id = Guid.NewGuid();
        ///
        ///
        ///        protected override WouldBeVaultSafeIfSealed WithNewName(string name) =&gt;
        ///      [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestBaseClassWbVsIfSealed {
            get {
                return ResourceManager.GetString("TestBaseClassWbVsIfSealed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using DotNetVault.Attributes;
        ///using DotNetVault.TestCaseHelpers;
        ///using JetBrains.Annotations;
        ///
        ///namespace DotNetVault.Test.TestCases
        ///{
        ///    [VaultSafe]
        ///    class TestNotVsBadBase : NotVaultSafeEvenIfSealed
        ///    {
        ///        public Guid Id { get; }
        ///
        ///        public TestNotVsBadBase([NotNull] string name, int age) : 
        ///            base(name, age) =&gt; Id = Guid.NewGuid();
        ///
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string TestNotVsBadBase {
            get {
                return ResourceManager.GetString("TestNotVsBadBase", resourceCulture);
            }
        }
    }
}