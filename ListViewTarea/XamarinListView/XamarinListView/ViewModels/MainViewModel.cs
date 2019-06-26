using System;
using System.Collections.Generic;
using System.Text;
using XamarinListView.Models;

namespace XamarinListView.ViewModels
{
    class MainViewModel
    {
        #region Properties
        public TokenResponse Token
        {
            get; set;
        }

        #endregion

        #region ViewModels
        public PaisesViewModel Login
        {
            get; set;
        }
        public PaisesViewModel Paises
        {
            get; set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new PaisesViewModel();

        }
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();

            }
            return instance;
        }

        #endregion
    }
}
