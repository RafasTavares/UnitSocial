﻿#pragma checksum "C:\Users\rafae\Downloads\UnitSocial\UnitSocial.W10\Pages\FlickrListPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CE18DAF1569E2E7B04CF1F62CD3EAEDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitSocial.Pages
{
    partial class FlickrListPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_AppStudio_Uwp_Actions_ActionsCommandBar_ActionsSource(global::AppStudio.Uwp.Actions.ActionsCommandBar obj, global::System.Collections.Generic.List<global::AppStudio.Uwp.Actions.ActionInfo> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.Generic.List<global::AppStudio.Uwp.Actions.ActionInfo>) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.Generic.List<global::AppStudio.Uwp.Actions.ActionInfo>), targetNullValue);
                }
                obj.ActionsSource = value;
            }
            public static void Set_AppStudio_Uwp_Actions_ActionsCommandBar_IsVisible(global::AppStudio.Uwp.Actions.ActionsCommandBar obj, global::System.Boolean value)
            {
                obj.IsVisible = value;
            }
            public static void Set_UnitSocial_Layouts_Controls_DataUpdateInformationControl_LastUpdateDateTime(global::UnitSocial.Layouts.Controls.DataUpdateInformationControl obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.LastUpdateDateTime = value ?? global::System.String.Empty;
            }
            public static void Set_UnitSocial_Layouts_Controls_DataUpdateInformationControl_HasLocalData(global::UnitSocial.Layouts.Controls.DataUpdateInformationControl obj, global::System.Boolean value)
            {
                obj.HasLocalData = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_AppStudio_Uwp_Controls_ErrorNotificationControl_ErrorVisibility(global::AppStudio.Uwp.Controls.ErrorNotificationControl obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.ErrorVisibility = value;
            }
            public static void Set_UnitSocial_Layouts_List_ListLayoutBase_ItemsSource(global::UnitSocial.Layouts.List.ListLayoutBase obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_UnitSocial_Layouts_List_ListLayoutBase_ItemClickCommand(global::UnitSocial.Layouts.List.ListLayoutBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.ItemClickCommand = value;
            }
        };

        private class FlickrListPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IFlickrListPage_Bindings
        {
            private global::UnitSocial.Pages.FlickrListPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::AppStudio.Uwp.Actions.ActionsCommandBar obj4;
            private global::UnitSocial.Layouts.Controls.DataUpdateInformationControl obj5;
            private global::Windows.UI.Xaml.Controls.ProgressBar obj6;
            private global::AppStudio.Uwp.Controls.ErrorNotificationControl obj7;
            private global::UnitSocial.Layouts.List.ListPhoto obj8;

            private FlickrListPage_obj1_BindingsTracking bindingsTracking;

            public FlickrListPage_obj1_Bindings()
            {
                this.bindingsTracking = new FlickrListPage_obj1_BindingsTracking(this);
            }

            ~FlickrListPage_obj1_Bindings()
            {
                StopTracking();
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4:
                        this.obj4 = (global::AppStudio.Uwp.Actions.ActionsCommandBar)target;
                        break;
                    case 5:
                        this.obj5 = (global::UnitSocial.Layouts.Controls.DataUpdateInformationControl)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        break;
                    case 7:
                        this.obj7 = (global::AppStudio.Uwp.Controls.ErrorNotificationControl)target;
                        break;
                    case 8:
                        this.obj8 = (global::UnitSocial.Layouts.List.ListPhoto)target;
                        break;
                    default:
                        break;
                }
            }

            // IFlickrListPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // FlickrListPage_obj1_Bindings

            public void SetDataRoot(global::UnitSocial.Pages.FlickrListPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::UnitSocial.Pages.FlickrListPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_ViewModel(phase);
                    }
                }
            }
            private void Update_ViewModel(global::UnitSocial.ViewModels.ListViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_PageTitle(obj.PageTitle, phase);
                        this.Update_ViewModel_Actions(obj.Actions, phase);
                        this.Update_ViewModel_HasActions(obj.HasActions, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_LastUpdated(obj.LastUpdated, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_HasLocalData(obj.HasLocalData, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_IsBusy(obj.IsBusy, phase);
                        this.Update_ViewModel_HasLoadDataErrors(obj.HasLoadDataErrors, phase);
                        this.Update_ViewModel_Items(obj.Items, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ItemClickCommand(obj.ItemClickCommand, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_ViewModel_IsBusy(phase);
                    }
                }
            }
            private void Update_ViewModel_PageTitle(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_ViewModel_Actions(global::System.Collections.Generic.List<global::AppStudio.Uwp.Actions.ActionInfo> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_AppStudio_Uwp_Actions_ActionsCommandBar_ActionsSource(this.obj4, obj, null);
                }
            }
            private void Update_ViewModel_HasActions(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_AppStudio_Uwp_Actions_ActionsCommandBar_IsVisible(this.obj4, obj);
                }
            }
            private void Update_ViewModel_LastUpdated(global::System.Nullable<global::System.DateTime> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_UnitSocial_Layouts_Controls_DataUpdateInformationControl_LastUpdateDateTime(this.obj5, obj.ToString(), null);
                }
            }
            private void Update_ViewModel_HasLocalData(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_UnitSocial_Layouts_Controls_DataUpdateInformationControl_HasLocalData(this.obj5, obj);
                }
            }
            private void Update_ViewModel_IsBusy(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj6, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("BoolToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                }
            }
            private void Update_ViewModel_HasLoadDataErrors(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_AppStudio_Uwp_Controls_ErrorNotificationControl_ErrorVisibility(this.obj7, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("BoolToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                }
            }
            private void Update_ViewModel_Items(global::System.Collections.ObjectModel.ObservableCollection<global::UnitSocial.ViewModels.ItemViewModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_UnitSocial_Layouts_List_ListLayoutBase_ItemsSource(this.obj8, obj, null);
                }
            }
            private void Update_ViewModel_ItemClickCommand(global::AppStudio.Uwp.Commands.RelayCommand<global::UnitSocial.ViewModels.ItemViewModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_UnitSocial_Layouts_List_ListLayoutBase_ItemClickCommand(this.obj8, obj, null);
                }
            }

            private void UpdateFallback_ViewModel(int phase)
            {
                this.UpdateFallback_ViewModel_IsBusy(phase);
            }

            private void UpdateFallback_ViewModel_IsBusy(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj6, (global::Windows.UI.Xaml.Visibility) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Visibility), "Collapsed"));
                }
            }

            private class FlickrListPage_obj1_BindingsTracking
            {
                global::System.WeakReference<FlickrListPage_obj1_Bindings> WeakRefToBindingObj; 

                public FlickrListPage_obj1_BindingsTracking(FlickrListPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<FlickrListPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    FlickrListPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::UnitSocial.ViewModels.ListViewModel obj = sender as global::UnitSocial.ViewModels.ListViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_ViewModel_LastUpdated(obj.LastUpdated, DATA_CHANGED);
                                    bindings.Update_ViewModel_IsBusy(obj.IsBusy, DATA_CHANGED);
                                    bindings.Update_ViewModel_HasLoadDataErrors(obj.HasLoadDataErrors, DATA_CHANGED);
                                    bindings.Update_ViewModel_Items(obj.Items, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_ViewModel_IsBusy(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "LastUpdated" :
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_LastUpdated(obj.LastUpdated, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsBusy" :
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_IsBusy(obj.IsBusy, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_ViewModel_IsBusy(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "HasLoadDataErrors" :
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_HasLoadDataErrors(obj.HasLoadDataErrors, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Items" :
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Items(obj.Items, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                private global::UnitSocial.ViewModels.ListViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::UnitSocial.ViewModels.ListViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Items(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    FlickrListPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::UnitSocial.ViewModels.ItemViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::UnitSocial.ViewModels.ItemViewModel>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
                public void CollectionChanged_ViewModel_Items(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    FlickrListPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::UnitSocial.ViewModels.ItemViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::UnitSocial.ViewModels.ItemViewModel>;
                    }
                    else
                    {
                        ReleaseAllListeners();
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.ResponsiveBehaviorsVBP = (global::AppStudio.Uwp.Controls.VisualBreakpoints)(target);
                }
                break;
            case 4:
                {
                    this.appBar = (global::AppStudio.Uwp.Actions.ActionsCommandBar)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    FlickrListPage_obj1_Bindings bindings = new FlickrListPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

