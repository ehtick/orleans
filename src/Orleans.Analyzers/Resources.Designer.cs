﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orleans.Analyzers {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Orleans.Analyzers.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The member &quot;{0}&quot; is marked as {1} and therefore cannot be serialized.
        /// </summary>
        internal static string AbstractOrStaticMembersCannotBeSerializedMessageFormat {
            get {
                return ResourceManager.GetString("AbstractOrStaticMembersCannotBeSerializedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Members which are static or abstract cannot be serialized.
        /// </summary>
        internal static string AbstractOrStaticMembersCannotBeSerializedTitle {
            get {
                return ResourceManager.GetString("AbstractOrStaticMembersCannotBeSerializedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add [Alias] to specify well-known names that can be used to identify types or methods..
        /// </summary>
        internal static string AddAliasAttributesDescription {
            get {
                return ResourceManager.GetString("AddAliasAttributesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing [Alias].
        /// </summary>
        internal static string AddAliasAttributesTitle {
            get {
                return ResourceManager.GetString("AddAliasAttributesTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing [Alias].
        /// </summary>
        internal static string AddAliasMessageFormat {
            get {
                return ResourceManager.GetString("AddAliasMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add the [GenerateSerializer] attribute to serializable types in your application..
        /// </summary>
        internal static string AddGenerateSerializerAttributeDescription {
            get {
                return ResourceManager.GetString("AddGenerateSerializerAttributeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &quot;{0}&quot; has the [Serializable] attribute but not the [GenerateSerializer] attribute.
        /// </summary>
        internal static string AddGenerateSerializerAttributeMessageFormat {
            get {
                return ResourceManager.GetString("AddGenerateSerializerAttributeMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add the [GenerateSerializer] attribute.
        /// </summary>
        internal static string AddGenerateSerializerAttributesTitle {
            get {
                return ResourceManager.GetString("AddGenerateSerializerAttributesTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add attributes to properties and fields to direct serializer generation..
        /// </summary>
        internal static string AddSerializationAttributesDescription {
            get {
                return ResourceManager.GetString("AddSerializationAttributesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing serialization attributes.
        /// </summary>
        internal static string AddSerializationAttributesMessageFormat {
            get {
                return ResourceManager.GetString("AddSerializationAttributesMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add missing serialization attributes.
        /// </summary>
        internal static string AddSerializationAttributesTitle {
            get {
                return ResourceManager.GetString("AddSerializationAttributesTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The [Alias] attribute must be unique to the declaring type..
        /// </summary>
        internal static string AliasClashDetectedDescription {
            get {
                return ResourceManager.GetString("AliasClashDetectedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename duplicated [Alias].
        /// </summary>
        internal static string AliasClashDetectedMessageFormat {
            get {
                return ResourceManager.GetString("AliasClashDetectedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename duplicated [Alias].
        /// </summary>
        internal static string AliasClashDetectedTitle {
            get {
                return ResourceManager.GetString("AliasClashDetectedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A single type is not allowed to have multiple constructors annotated with the [OrleansConstructor] attribute.
        /// </summary>
        internal static string AtMostOneOrleansConstructorMessageFormat {
            get {
                return ResourceManager.GetString("AtMostOneOrleansConstructorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At most one constructor can be annotated with the [OrleansConstructor] attribute.
        /// </summary>
        internal static string AtMostOneOrleansConstructorTitle {
            get {
                return ResourceManager.GetString("AtMostOneOrleansConstructorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The [Id] attribute must be unique to each members of the declaring type..
        /// </summary>
        internal static string IdClashDetectedDescription {
            get {
                return ResourceManager.GetString("IdClashDetectedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Substitute duplicated [Id] value with the correct unique identity of this member.
        /// </summary>
        internal static string IdClashDetectedMessageFormat {
            get {
                return ResourceManager.GetString("IdClashDetectedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Substitute duplicated [Id] value with the correct unique identity of this member.
        /// </summary>
        internal static string IdClashDetectedTitle {
            get {
                return ResourceManager.GetString("IdClashDetectedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove attribute [{0}].
        /// </summary>
        internal static string IncorrectAttributeUseMessageFormat {
            get {
                return ResourceManager.GetString("IncorrectAttributeUseMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove attribute.
        /// </summary>
        internal static string IncorrectAttributeUseTitle {
            get {
                return ResourceManager.GetString("IncorrectAttributeUseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This attribute should not be used on grain implementations..
        /// </summary>
        internal static string IncorrectAttributeUseTitleDescription {
            get {
                return ResourceManager.GetString("IncorrectAttributeUseTitleDescription", resourceCulture);
            }
        }
    }
}
