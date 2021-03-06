/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Cellenzapp.Core"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using Cellenzapp.Core.Data;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Cellenzapp.Core.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public abstract class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);


			SimpleIoc.Default.Register<IDataService, DesignDataService>();


            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SettingsViewModel>();
            SimpleIoc.Default.Register<CellExpertsViewModel>();
            SimpleIoc.Default.Register<CellExpertViewModel>();
            SimpleIoc.Default.Register<NavigationViewModel>();
        }

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();
        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();
        public CellExpertsViewModel CellExpertsViewModel => ServiceLocator.Current.GetInstance<CellExpertsViewModel>();
        public CellExpertViewModel CellExpertViewModel => ServiceLocator.Current.GetInstance<CellExpertViewModel>();
        public NavigationViewModel NavigationViewModel => ServiceLocator.Current.GetInstance<NavigationViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}