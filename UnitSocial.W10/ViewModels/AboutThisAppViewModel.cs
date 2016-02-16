using System;
using AppStudio.Uwp;
using Windows.ApplicationModel;
using Windows.UI.Xaml.Media.Imaging;
using Windows.ApplicationModel.Resources;

namespace UnitSocial.ViewModels
{
    public class AboutThisAppViewModel : ObservableBase
    {
        private ResourceLoader _resourceLoader;

        #region ResourceLoader
        private ResourceLoader ResourceLoader
        {
            get
            {
                if (_resourceLoader == null)
                {
                    _resourceLoader = new ResourceLoader();
                }
                return _resourceLoader;
            }
        }
        #endregion

        #region PageTitle
        public string PageTitle
        {
            get
            {
                return ResourceLoader.GetString("NavigationPaneAbout");
            }
        }
        #endregion

        #region Publisher 
        public string Publisher
        {
            get
            {
                return "Rafael Tavares";
            }
        }
        #endregion

        #region AppVersion
        public string AppVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build, Package.Current.Id.Version.Revision);
            }
        }
        #endregion

        #region AboutText
        public string AboutText
        {
            get
            {
                return "Cansado de perder alguma noticia sobre a Unit?! eu também estava, por isso criei " +
    "esse aplicativo que reune todas as principais redes sociais da universidade cent" +
    "ralizando em um só aplicativo. Nunca mais fico por fora de alguma notícia.";
            }
        }
        #endregion

        #region AppName
        public string AppName
        {
            get
            {
                return "Unit Social";
            }
        }
        #endregion

        #region PrivacyUrl
        public string PrivacyUrl
        {
            //http://appstudio.windows.com/home/appprivacyterms
            get
            {
                return "#"; 
            }
        }
        #endregion

        #region AppLogo
        public BitmapImage AppLogo
        {
            get
            {
                return new BitmapImage(new Uri("ms-appx:///Assets/ApplicationLogo.png"));
            }
        }
        #endregion
    }
}

