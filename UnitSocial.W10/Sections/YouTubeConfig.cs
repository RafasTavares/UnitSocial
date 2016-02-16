


using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.YouTube;
using AppStudio.Uwp.Actions;
using AppStudio.Uwp.Commands;
using AppStudio.Uwp.Navigation;
using AppStudio.Uwp;
using System.Linq;
using UnitSocial.Config;
using UnitSocial.ViewModels;

namespace UnitSocial.Sections
{
    public class YouTubeConfig : SectionConfigBase<YouTubeSchema>
    {
	    private readonly YouTubeDataProvider _dataProvider = new YouTubeDataProvider(new YouTubeOAuthTokens
        {
			ApiKey = "AIzaSyC8_cza0NBZ4EwH-T4cAdAHibU-2F6w0MQ"
        });

		public override Func<Task<IEnumerable<YouTubeSchema>>> LoadDataAsyncFunc
        {
            get
            {
                var config = new YouTubeDataConfig
                {
                    QueryType = YouTubeQueryType.Channels,
                    Query = @"unitmkt"
                };

                return () => _dataProvider.LoadDataAsync(config, MaxRecords);
            }
        }

        public override ListPageConfig<YouTubeSchema> ListPage
        {
            get 
            {
                return new ListPageConfig<YouTubeSchema>
                {
                    Title = "YouTube",

					PageTitle = "YouTube",

                    ListNavigationInfo = NavigationInfo.FromPage("YouTubeListPage"),

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title.ToSafeString();
                        viewModel.SubTitle = item.Summary.ToSafeString();
                        viewModel.Description = "";
                        viewModel.ImageUrl = ItemViewModel.LoadSafeUrl(item.ImageUrl.ToSafeString());
                    },
                    DetailNavigation = (item) =>
                    {
                        return NavigationInfo.FromPage("YouTubeDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<YouTubeSchema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, YouTubeSchema>>();
                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "Detail";
                    viewModel.Title = null;
                    viewModel.Description = item.Summary.ToSafeString();
                    viewModel.ImageUrl = ItemViewModel.LoadSafeUrl(null);
                    viewModel.Content = item.EmbedHtmlFragment;
                });

                var actions = new List<ActionConfig<YouTubeSchema>>
                {
                    ActionConfig<YouTubeSchema>.Link("Go To Source", (item) => item.ExternalUrl.ToSafeString()),
                };

                return new DetailPageConfig<YouTubeSchema>
                {
                    Title = "YouTube",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }
    }
}
