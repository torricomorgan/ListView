using XamarinListView.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamarinListView.Services;
using Xamarin.Forms;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace XamarinListView.ViewModels
{
    class PaisesViewModel : BaseViewModel
    {
        #region Services

        private ApiService apiService;
        #endregion


        #region Attributes

        private ObservableCollection<Paises> pais;
        private bool isRefreshing;
        #endregion


        #region Properties
        public ObservableCollection<Paises> Paises
        {
            get { return this.pais; }
            set { SetValue(ref this.pais, value); }
        }

        public bool IsRefreshing
        {
            get { return this.isRefreshing; }
            set { SetValue(ref this.isRefreshing, value); }
        }
        #endregion



        #region Constructors

        public PaisesViewModel()
        {
            this.apiService = new ApiService();
            this.LoadPaises();
        }

        #endregion


        #region Methods
        private async void LoadPaises()
        {
            this.IsRefreshing = true;
            var connection = await this.apiService.CheckConnection();
            if (!connection.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                   "Error", connection.Message,
                   "Aceptar");
                return;
                await Application.Current.MainPage.Navigation.PopAsync();
            }

            var response = await this.apiService.GetList<Paises>(
                "https://restcountries.eu/",
                "/rest",
                "/v2/all");
            if (!response.IsSuccess)
            {
                this.IsRefreshing = false;
                await Application.Current.MainPage.DisplayAlert(
                    "Error", response.Message,
                    "Aceptar");
                return;
            }
            var list = (List<Paises>)response.Result;
            this.Paises = new ObservableCollection<Paises>(list);
            this.IsRefreshing = false;
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(LoadPaises);

            }
        }
        #endregion
    }
}
