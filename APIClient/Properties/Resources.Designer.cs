﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIClient.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
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
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("APIClient.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 {0:&quot;成功&quot;,&quot;-1&quot;:&quot;用户名和密码验证失败&quot;,&quot;-2&quot;:&quot;备用&quot;,&quot;-3&quot;:&quot;用户未激活（调用init接口）&quot;,&quot;-4&quot;:&quot;COOKIE中未找到host_key&amp;user_key（或BDUSS）&quot;,&quot;-5&quot;:&quot;host_key和user_key无效&quot;,&quot;-6&quot;:&apos;登录失败，请重新登录&apos;,&quot;-7&quot;:&quot;文件或目录名错误或无权访问&quot;,&quot;-8&quot;:&quot;该目录下已存在此文件&quot;,&quot;-9&quot;:&quot;文件被所有者删除，操作失败&quot;,&quot;-11&quot;:&quot;父目录不存在&quot;,&quot;-12&quot;:&quot;设备尚未注册&quot;,&quot;-13&quot;:&quot;设备已经被绑定&quot;,&quot;-14&quot;:&quot;帐号已经初始化&quot;,&quot;-21&quot;:&quot;预置文件无法进行相关操作&quot;,&quot;-22&quot;:&quot;被分享的文件无法重命名，移动等操作&quot;,&quot;-23&quot;:&quot;数据库操作失败，请联系netdisk管理员&quot;,&quot;-24&quot;:&quot;要取消的文件列表中含有不允许取消public的文件。&quot;,&quot;-25&quot;:&quot;非公测用户&quot;,&quot;-26&quot;:&quot;邀请码失效&quot;,&quot;-102&quot;:&quot;云冲印文件7日内无法删除&quot;,1:&quot;服务器错误 &quot;,2:&quot;接口请求错误，请稍候重试&quot;,3:&quot;一次操作文件不可超过100个&quot;,4:&quot;新文件名错误&quot;,5:&quot;目标目录非法&quot;,6:&quot;备用&quot;,7:&quot;NS [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string ErrnoDescriptionJson {
            get {
                return ResourceManager.GetString("ErrnoDescriptionJson", resourceCulture);
            }
        }
    }
}
