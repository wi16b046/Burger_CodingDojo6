using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;

namespace Burger_CodingDojo6.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand OverviewBtnClicked { get; set; }
        public RelayCommand MyToysBtnClicked { get; set; }

        private ViewModelBase currentVm;

        public ViewModelBase CurrentVm
        {
            get { return currentVm; }
            set { currentVm = value; RaisePropertyChanged(); }
        }


        public MainViewModel()
        {
            OverviewBtnClicked = new RelayCommand(() =>
            { CurrentVm = SimpleIoc.Default.GetInstance<OverviewVM>(); });

            MyToysBtnClicked = new RelayCommand(() =>
            { CurrentVm = SimpleIoc.Default.GetInstance<MyToysVM>(); });
        }

        
    }
}