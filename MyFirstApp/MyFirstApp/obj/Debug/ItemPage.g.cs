﻿

#pragma checksum "C:\Users\just\documents\visual studio 2013\Projects\MyFirstApp\MyFirstApp\ItemPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E3EFF7B63348431D872174D83A50D1E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstApp
{
    partial class ItemPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 18 "..\..\ItemPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.OnNavigateToMedia;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 44 "..\..\ItemPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.OnPinRecipe;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 39 "..\..\ItemPage.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.OnCapturePhoto;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 40 "..\..\ItemPage.xaml"
                ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target)).Click += this.OnCaptureVideo;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


