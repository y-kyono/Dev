﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace JenkinsNotificationTool.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JenkinsNotificationTool.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
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
        ///   予期せぬエラーをキャッチしました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string DispatcherUnhandledExceptionMessage {
            get {
                return ResourceManager.GetString("DispatcherUnhandledExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   アプリケーションを終了します。よろしいですか？ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ExitConfirmMessage {
            get {
                return ResourceManager.GetString("ExitConfirmMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   共通の例外補足イベントハンドラで例外を補足しました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string FirstChanceExceptionMessage {
            get {
                return ResourceManager.GetString("FirstChanceExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   予期せぬエラーをキャッチしました。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnhandledExceptionMessage {
            get {
                return ResourceManager.GetString("UnhandledExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   予期せぬエラーをキャッチしました。システム管理者に問い合わせてください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UnhandledExceptionShowMessage {
            get {
                return ResourceManager.GetString("UnhandledExceptionShowMessage", resourceCulture);
            }
        }
    }
}
