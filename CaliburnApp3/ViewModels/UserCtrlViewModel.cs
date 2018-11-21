using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnApp3.ViewModels
{
    public class UserCtrlViewModel : Screen
    {

        bool _RadioButton1IsVisible = true;
        public bool RadioButton1IsVisible
        {
            get { return _RadioButton1IsVisible; }
            set
            {
                _RadioButton1IsVisible = value;
                NotifyOfPropertyChange(() => RadioButton1IsVisible);
            }
        }
        bool _RadioButton2IsVisible = true;
        public bool RadioButton2IsVisible
        {
            get { return _RadioButton2IsVisible; }
            set
            {
                _RadioButton2IsVisible = value;
                NotifyOfPropertyChange(() => RadioButton2IsVisible);
            }
        }
        bool _RadioButton3IsVisible = true;
        public bool RadioButton3IsVisible
        {
            get { return _RadioButton3IsVisible; }
            set
            {
                _RadioButton3IsVisible = value;
                NotifyOfPropertyChange(() => RadioButton3IsVisible);
            }
        }
        bool _RadioButton4IsVisible = true;
        public bool RadioButton4IsVisible
        {
            get { return _RadioButton4IsVisible; }
            set
            {
                _RadioButton4IsVisible = value;
                NotifyOfPropertyChange(() => RadioButton4IsVisible);
            }
        }

        bool _SearchFor1 = true;
        public bool SearchFor1
        {
            get { return _SearchFor1; }
            set
            {
                _SearchFor1 = value;
            }
        }

        bool _SearchFor2 = true;
        public bool SearchFor2
        {
            get { return _SearchFor2; }
            set
            {
                _SearchFor2 = value;
            }
        }

        bool _SearchFor3 = true;
        public bool SearchFor3
        {
            get { return _SearchFor3; }
            set
            {
                _SearchFor3 = value;
            }
        }

        bool _SearchFor4 = true;
        public bool SearchFor4
        {
            get { return _SearchFor4; }
            set
            {
                _SearchFor4 = value;
            }
        }


        public UserCtrlViewModel()
        {
        }
    }
}
