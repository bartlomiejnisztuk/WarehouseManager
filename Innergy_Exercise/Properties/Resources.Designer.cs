﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Innergy_Exercise.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Innergy_Exercise.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to # Material inventory initial state as of Jan 01 2018
        ///# New materials
        ///Cherry Hardwood Arched Door -PS; COM - 100001; WH - A,5 | WH - B,10
        ///Maple Dovetail Drawerbox; COM - 124047; WH - A,15
        ///Generic Wire Pull; COM - 123906c; WH - A,10 | WH - B,6 | WH - C,2
        ///Yankee Hardware 110 Deg.Hinge; COM - 123908; WH - A,10 | WH - B,11
        ///# Existing materials, restocked
        ///
        ///Hdw Accuride CB0115 - CASSRC - Locking Handle Kit -Black; CB0115 - CASSRC; WH - C,13 | WH - B,5
        ///
        ///Veneer - Charter Industries - 3M Adhesive Backed -Ch [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Data {
            get {
                return ResourceManager.GetString("Data", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid line detected;.
        /// </summary>
        internal static string InputReaderProcessor_Run_Invalid_line_detected_ {
            get {
                return ResourceManager.GetString("InputReaderProcessor_Run_Invalid_line_detected_", resourceCulture);
            }
        }
    }
}