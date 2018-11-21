using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnApp3.ViewModels
{
    public class Page2ViewModel : Screen
    {
        public UserCtrlViewModel UserCtrlView1 { get; set; } = new UserCtrlViewModel();
        public UserCtrlViewModel UserCtrlView2 { get; set; } = new UserCtrlViewModel();

        private readonly INavigationService navigationService;
        public Page2ViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
        string _ToastMessage;
        public string ToastMessage
        {
            get { return _ToastMessage; }
            set
            {
                _ToastMessage = value;
                Debug.WriteLine(value);
                NotifyOfPropertyChange(() => ToastMessage);
            }
        }

        public void SetRadio11()
        {
            UserCtrlView1.SearchFor1 = true;
            UserCtrlView1.NotifyOfPropertyChange(() => UserCtrlView1.SearchFor1);
        }
        public void SetRadio12()
        {
            UserCtrlView1.SearchFor2 = true;
            UserCtrlView1.NotifyOfPropertyChange(() => UserCtrlView1.SearchFor2);
        }
        public void SetRadio13()
        {
            UserCtrlView1.SearchFor3 = true;
            UserCtrlView1.NotifyOfPropertyChange(() => UserCtrlView1.SearchFor3);
        }
        public void SetRadio14()
        {
            UserCtrlView1.SearchFor4 = true;
            UserCtrlView1.NotifyOfPropertyChange(() => UserCtrlView1.SearchFor4);
        }

        public void SetRadio21()
        {
            UserCtrlView2.SearchFor1 = true;
            UserCtrlView2.NotifyOfPropertyChange(() => UserCtrlView2.SearchFor1);
        }
        public void SetRadio22()
        {
            UserCtrlView2.SearchFor2 = true;
            UserCtrlView2.NotifyOfPropertyChange(() => UserCtrlView2.SearchFor2);
        }
        public void SetRadio23()
        {
            UserCtrlView2.SearchFor3 = true;
            UserCtrlView2.NotifyOfPropertyChange(() => UserCtrlView2.SearchFor3);
        }
        public void SetRadio24()
        {
            UserCtrlView2.SearchFor4 = true;
            UserCtrlView2.NotifyOfPropertyChange(() => UserCtrlView2.SearchFor4);
        }

        public void BackPage()
        {
            this.navigationService.GoBack();
        }
    }
}
