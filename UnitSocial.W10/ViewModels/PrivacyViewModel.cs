using System;
using AppStudio.Uwp;

namespace UnitSocial.ViewModels
{
    public class PrivacyViewModel : ObservableBase
    {
        public Uri Url
        {
            get
            {
                return new Uri(UrlText, UriKind.RelativeOrAbsolute);
            }
        }
        public string UrlText
        {
            //http://appstudio.windows.com/home/appprivacyterms
            get
            {
                return "#";
            }
        }
    }
}

