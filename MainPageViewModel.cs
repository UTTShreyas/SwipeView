using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SwipeViewSample
{
    public class MainPageViewModel
    {
        private ObservableCollection<Sample> _collectionData;
        public ObservableCollection<Sample> CollectionData
        {
            get
            {
                return _collectionData;
            }
            set
            {
                _collectionData = value;
            }
        }

        public ICommand Button1Command
        {
            get
            {
                return new Command(Button1Click);
            }
        }
        public ICommand Button2Command
        {
            get
            {
                return new Command(Button2Click);
            }
        }
        public ICommand Button3Command
        {
            get
            {
                return new Command(Button3Click);
            }
        }
        public ICommand Button4Command
        {
            get
            {
                return new Command(Button4Click);
            }
        }

        
        public MainPageViewModel()
        {
            CollectionData = new ObservableCollection<Sample>();

            for (int i = 1; i < 5; i++)
            {
                CollectionData.Add(new Sample() { SLNo = "X300" + i.ToString(), Name = "Collection" + i.ToString()});
            }
        }

        private void Button1Click(object obj)
        {
            Application.Current.MainPage.DisplayAlert("Alert", "Button 1 Clicked", "OK");
        }
        private void Button2Click(object obj)
        {
            Application.Current.MainPage.DisplayAlert("Alert", "Button 2 Clicked", "OK");
        }
        private void Button3Click(object obj)
        {
            Application.Current.MainPage.DisplayAlert("Alert", "Button 3 Clicked", "OK");
        }

        private void Button4Click(object obj)
        {
            Application.Current.MainPage.DisplayAlert("Alert", "Button 4 Clicked", "OK");
        }


    }

    public class Sample
    {
        public string Name { get; set; }

        public string SLNo { get; set; }
    }
}
