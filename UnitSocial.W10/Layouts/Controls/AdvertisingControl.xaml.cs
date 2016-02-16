using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UnitSocial.Layouts.Controls
{
    public sealed partial class AdvertisingControl : UserControl
    {
        #region BannerWidth
        public double BannerWidth
        {
            get
            {
                if (Window.Current.Bounds.Width >= 500)
                    return 728;

                return 300;
            }
        }
        #endregion

        #region BannerHeight
        public double BannerHeight
        {
            get
            {
                if (Window.Current.Bounds.Width >= 500)
                    return 90;

                return 50;
            }
        }
        #endregion

        #region AdvertisingControl
        public AdvertisingControl()
        {
            this.InitializeComponent();
        }
        #endregion
    }
}
