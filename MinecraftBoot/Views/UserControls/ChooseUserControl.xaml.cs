using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using CommunityToolkit.WinUI.Controls;
using MinecraftBoot.Views.UserControls.ChooseUserControlPage;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MinecraftBoot.Views.UserControls
{
    public sealed partial class ChooseUserControl : UserControl
    {
        public ChooseUserControl()
        {
            this.InitializeComponent();
        }

        private void CUCFrame_Navigated(object sender, NavigationEventArgs e) {}

        private void Segmented_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ClickSegmentedItem = (SegmentedItem)sender;
            var ItemTag = (string)ClickSegmentedItem.Tag;
            if (ItemTag != null)
            {
                if (ItemTag == "Microsoft")
                {
                    App.Current.JsonNavigationViewService.NavigateTo(typeof(MicrosoftView));
                }
                else if (ItemTag == "Other")
                {
                    App.Current.JsonNavigationViewService.NavigateTo(typeof(OtherView));
                }
                else if (ItemTag =="Offline")
                {
                    App.Current.JsonNavigationViewService.NavigateTo(typeof(OfflineView));
                }
            }
        }
    }
}
