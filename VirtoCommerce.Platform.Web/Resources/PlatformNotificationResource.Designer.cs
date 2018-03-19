﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtoCommerce.Platform.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class PlatformNotificationResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PlatformNotificationResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VirtoCommerce.Platform.Web.Resources.PlatformNotificationResource", typeof(PlatformNotificationResource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your user name - {{ user_name }}..
        /// </summary>
        public static string ForgotUserNameNotificationBody {
            get {
                return ResourceManager.GetString("ForgotUserNameNotificationBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User name.
        /// </summary>
        public static string ForgotUserNameNotificationSubject {
            get {
                return ResourceManager.GetString("ForgotUserNameNotificationSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thank you for registration {{ first_name }} {{ last_name }}!!!.
        /// </summary>
        public static string RegistrationNotificationBody {
            get {
                return ResourceManager.GetString("RegistrationNotificationBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your login - {{ login }}..
        /// </summary>
        public static string RegistrationNotificationSubject {
            get {
                return ResourceManager.GetString("RegistrationNotificationSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please reset your password by clicking &lt;strong&gt;&lt;a href=&quot;{{ url }}&quot;&gt;here&lt;/a&gt;&lt;/strong&gt;.
        /// </summary>
        public static string ResetPasswordNotificationBody {
            get {
                return ResourceManager.GetString("ResetPasswordNotificationBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset password link.
        /// </summary>
        public static string ResetPasswordNotificationSubject {
            get {
                return ResourceManager.GetString("ResetPasswordNotificationSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your security code is {{ token }}.
        /// </summary>
        public static string TwoFactorNotificationBody {
            get {
                return ResourceManager.GetString("TwoFactorNotificationBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Security Code.
        /// </summary>
        public static string TwoFactorNotificationSubject {
            get {
                return ResourceManager.GetString("TwoFactorNotificationSubject", resourceCulture);
            }
        }
    }
}
