﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Data.Marten {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MartenDataResources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MartenDataResources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("HotChocolate.Data.Marten.MartenDataResources", typeof(MartenDataResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string Filtering_MartenQueryableCombinator_InvalidCombinator {
            get {
                return ResourceManager.GetString("Filtering_MartenQueryableCombinator_InvalidCombinator", resourceCulture);
            }
        }
        
        internal static string ErrorHelper_CreateNonNullError {
            get {
                return ResourceManager.GetString("ErrorHelper_CreateNonNullError", resourceCulture);
            }
        }
        
        internal static string Sorting_InvalidState_ParentIsNoFieldSelector {
            get {
                return ResourceManager.GetString("Sorting_InvalidState_ParentIsNoFieldSelector", resourceCulture);
            }
        }
        
        internal static string QueryableSorting_ExpressionParameterInvalid {
            get {
                return ResourceManager.GetString("QueryableSorting_ExpressionParameterInvalid", resourceCulture);
            }
        }
        
        internal static string QueryableSorting_MemberInvalid {
            get {
                return ResourceManager.GetString("QueryableSorting_MemberInvalid", resourceCulture);
            }
        }
        
        internal static string QueryableSorting_NoMemberDeclared {
            get {
                return ResourceManager.GetString("QueryableSorting_NoMemberDeclared", resourceCulture);
            }
        }
        
        internal static string Filtering_CouldNotParseValue {
            get {
                return ResourceManager.GetString("Filtering_CouldNotParseValue", resourceCulture);
            }
        }
    }
}