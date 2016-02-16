using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStudio.Uwp;
using AppStudio.Uwp.Actions;
using AppStudio.Uwp.Commands;
using AppStudio.Uwp.Navigation;
using AppStudio.DataProviders;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using AppStudio.DataProviders.Facebook;
using AppStudio.DataProviders.Twitter;
using AppStudio.DataProviders.YouTube;
using AppStudio.DataProviders.Instagram;
using AppStudio.DataProviders.Flickr;
using AppStudio.DataProviders.LocalStorage;
using UnitSocial.Sections;


namespace UnitSocial.ViewModels
{
    public class MainViewModel : ObservableBase
    {
        #region MainViewModel
        public MainViewModel(int visibleItems) : base()
        {
            PageTitle = "Unit Social";
			this.SectionAd = new AdvertisingViewModel();
            Facebook = ListViewModel.CreateNew(Singleton<FacebookConfig>.Instance, visibleItems);
            Twitter = ListViewModel.CreateNew(Singleton<TwitterConfig>.Instance, visibleItems);
            YouTube = ListViewModel.CreateNew(Singleton<YouTubeConfig>.Instance, visibleItems);
            Instagram = ListViewModel.CreateNew(Singleton<InstagramConfig>.Instance, visibleItems);
            Flickr = ListViewModel.CreateNew(Singleton<FlickrConfig>.Instance, visibleItems);

            Actions = new List<ActionInfo>();

            if (GetViewModels().Any(vm => !vm.HasLocalData))
            {
                Actions.Add(new ActionInfo
                {
                    Command = new RelayCommand(Refresh),
                    Style = ActionKnownStyles.Refresh,
                    Name = "RefreshButton",
                    ActionType = ActionType.Primary
                });
            }
        }
        #endregion

        #region Variaveis
        public string PageTitle { get; set; }
        public ListViewModel Facebook { get; private set; }
        public ListViewModel Twitter { get; private set; }
        public ListViewModel YouTube { get; private set; }
        public ListViewModel Instagram { get; private set; }
        public ListViewModel Flickr { get; private set; }
		public AdvertisingViewModel SectionAd { get; set; }
        #endregion

        #region SectionHeaderClickCommand
        public RelayCommand<INavigable> SectionHeaderClickCommand
        {
            get
            {
                return new RelayCommand<INavigable>(item =>
                    {
                        NavigationService.NavigateTo(item);
                    });
            }
        }
        #endregion

        #region LastUpdated
        public DateTime? LastUpdated
        {
            get
            {
                return GetViewModels().Select(vm => vm.LastUpdated)
                            .OrderByDescending(d => d).FirstOrDefault();
            }
        }
        #endregion
        
        #region Actions
        public List<ActionInfo> Actions { get; private set; }

        public bool HasActions
        {
            get
            {
                return Actions != null && Actions.Count > 0;
            }
        }
        #endregion

        #region LoadDataAsync
        public async Task LoadDataAsync()
        {
            var loadDataTasks = GetViewModels().Select(vm => vm.LoadDataAsync());

            await Task.WhenAll(loadDataTasks);

            OnPropertyChanged("LastUpdated");
        }
        #endregion

        #region Refresh
        private async void Refresh()
        {
            var refreshDataTasks = GetViewModels()
                                        .Where(vm => !vm.HasLocalData).Select(vm => vm.LoadDataAsync(true));

            await Task.WhenAll(refreshDataTasks);

            OnPropertyChanged("LastUpdated");
        }
        #endregion

        #region GetViewModels
        private IEnumerable<ListViewModel> GetViewModels()
        {
            yield return Facebook;
            yield return Twitter;
            yield return YouTube;
            yield return Instagram;
            yield return Flickr;
        }
        #endregion
    }
}
