﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1dv402_hn222fi_1_1_vaxelpengar {
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
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("_1dv402_hn222fi_1_1_vaxelpengar.Resource1", typeof(Resource1).Assembly);
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
        ///   Looks up a localized string similar to Ange erhållet belopp:.
        /// </summary>
        internal static string Cash_Prompt {
            get {
                return ResourceManager.GetString("Cash_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tillbaka      :{0,13} kr.
        /// </summary>
        internal static string Change_Prompt {
            get {
                return ResourceManager.GetString("Change_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ange totalsumman:.
        /// </summary>
        internal static string Cost_Prompt {
            get {
                return ResourceManager.GetString("Cost_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  {0,3}-lappar   : {1,1}.
        /// </summary>
        internal static string Denominations_Prompt {
            get {
                return ResourceManager.GetString("Denominations_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tryck på tangent för ny beräkning - Esc avslutar..
        /// </summary>
        internal static string EndQuestion_Prompt {
            get {
                return ResourceManager.GetString("EndQuestion_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kvitto.
        /// </summary>
        internal static string Receipt_Prompt {
            get {
                return ResourceManager.GetString("Receipt_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kontant       :{0,13} kr.
        /// </summary>
        internal static string ReceivedAmount_Prompt {
            get {
                return ResourceManager.GetString("ReceivedAmount_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Öresavrundning:{0,13:f2} kr.
        /// </summary>
        internal static string RoundingOffAmount_Prompt {
            get {
                return ResourceManager.GetString("RoundingOffAmount_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Totalt        :{0,13:f2} kr.
        /// </summary>
        internal static string Total_Prompt {
            get {
                return ResourceManager.GetString("Total_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Att betala    :{0,13} kr.
        /// </summary>
        internal static string TotalCost_Prompt {
            get {
                return ResourceManager.GetString("TotalCost_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fel! {0} kan inte tolkas som en giltig summa pengar..
        /// </summary>
        internal static string WrongDouble_Prompt {
            get {
                return ResourceManager.GetString("WrongDouble_Prompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fel! {0}  är inte ett värde mindre än {1} eller ett heltal.
        /// </summary>
        internal static string WrongInt_Prompt {
            get {
                return ResourceManager.GetString("WrongInt_Prompt", resourceCulture);
            }
        }
    }
}
