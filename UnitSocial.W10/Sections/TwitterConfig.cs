


using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.Twitter;
using AppStudio.Uwp.Actions;
using AppStudio.Uwp.Commands;
using AppStudio.Uwp.Navigation;
using AppStudio.Uwp;
using System.Linq;
using UnitSocial.Config;
using UnitSocial.ViewModels;

namespace UnitSocial.Sections
{
    public class TwitterConfig : SectionConfigBase<TwitterSchema>
    {
		private readonly TwitterDataProvider _dataProvider = new TwitterDataProvider(new TwitterOAuthTokens
        {
			ConsumerKey = "4ly6DW82Lcm5tnCXS0Bauo1Ku",
                    ConsumerSecret = "GAXIzGKBFDvj2LawOLZFCQfj2YNdpJJBYKnfjiwjPpeUfqA0vS",
                    AccessToken = "398047744-si08RXoENW51ShM037OrMNznJcyQhOsbZ6AZMoIL",
                    AccessTokenSecret = "jodQ9ymRy3Su9tRLA7xjaPyy8wjwR55aIALNDLYmFMxYm"
        });

		public override Func<Task<IEnumerable<TwitterSchema>>> LoadDataAsyncFunc
        {
            get
            {
                var config = new TwitterDataConfig
                {
                    QueryType = TwitterQueryType.User,
                    Query = @"@_Unit_"
                };

                return () => _dataProvider.LoadDataAsync(config, MaxRecords);
            }
        }

        public override ListPageConfig<TwitterSchema> ListPage
        {
            get 
            {
                return new ListPageConfig<TwitterSchema>
                {
                    Title = "Twitter",

					PageTitle = "Twitter",

                    ListNavigationInfo = NavigationInfo.FromPage("TwitterListPage"),

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.UserName.ToSafeString();
                        viewModel.SubTitle = item.Text.ToSafeString();
                        viewModel.Description = "";
                        viewModel.ImageUrl = ItemViewModel.LoadSafeUrl(item.UserProfileImageUrl.ToSafeString());
                    },
                    DetailNavigation = (item) =>
                    {
                        return new NavigationInfo
                        {
                            NavigationType = NavigationType.DeepLink,
                            TargetUri = new Uri(item.Url)
                        };
                    }
                };
            }
        }

        public override DetailPageConfig<TwitterSchema> DetailPage
        {
            get { return null; }
        }
    }
}
