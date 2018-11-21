using System;
using Windows.UI.Xaml.Controls;

namespace CaliburnApp3.Views
{
    public sealed partial class UserCtrlView
    {
        public UserCtrlView()
        {
            this.InitializeComponent();
            string guid = Guid.NewGuid().ToString();
            SearchFor1.GroupName = guid;
            SearchFor2.GroupName = guid;
            SearchFor3.GroupName = guid;
            SearchFor4.GroupName = guid;
        }
    }
}
