using XamarinListView.ViewModels;

namespace XamarinListView.Interfaces
{
    class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }

        #endregion

        #region Constructors

        public InstanceLocator()
        {
            this.Main = new MainViewModel();

        }
        #endregion
    }
}
