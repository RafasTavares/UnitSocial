


using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.Facebook;
using AppStudio.Uwp.Actions;
using AppStudio.Uwp.Commands;
using AppStudio.Uwp.Navigation;
using UnitSocial.Config;
using UnitSocial.ViewModels;

namespace UnitSocial.Sections
{
    public class FacebookConfig : SectionConfigBase<FacebookSchema>
    {
		private readonly FacebookDataProvider _dataProvider = new FacebookDataProvider(new FacebookOAuthTokens
        {
			AppId = "344607245733518",
                    AppSecret = "3665f04dff14479d1484088a895dbd62"
        });

		public override Func<Task<IEnumerable<FacebookSchema>>> LoadDataAsyncFunc
        {
            get
            {
                var config = new FacebookDataConfig
                {
                    UserId = "136543389724871"
                };

                return () => _dataProvider.LoadDataAsync(config, MaxRecords);
            }
        }

        public override ListPageConfig<FacebookSchema> ListPage
        {
            get 
            {
                return new ListPageConfig<FacebookSchema>
                {
                    Title = "Facebook",

					PageTitle = "Facebook",

                    ListNavigationInfo = NavigationInfo.FromPage("FacebookListPage"),

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title.ToSafeString();
                        viewModel.SubTitle = item.Summary.ToSafeString();
                        viewModel.Description = "";
                        viewModel.ImageUrl = ItemViewModel.LoadSafeUrl(item.ImageUrl.ToSafeString());
                    },
                    DetailNavigation = (item) =>
                    {
                        return NavigationInfo.FromPage("FacebookDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<FacebookSchema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, FacebookSchema>>();
                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = item.Title.ToSafeString();
                    viewModel.Title = item.Title.ToSafeString();
                    viewModel.Description = item.Content.ToSafeString();
                    viewModel.ImageUrl = ItemViewModel.LoadSafeUrl(item.ImageUrl.ToSafeString());
                    viewModel.Content = null;
                });

                var actions = new List<ActionConfig<FacebookSchema>>
                {
                    ActionConfig<FacebookSchema>.Link("Ver post original", (item) => item.FeedUrl.ToSafeString()),
                };

                return new DetailPageConfig<FacebookSchema>
                {
                    Title = "Facebook",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }
    }
}
