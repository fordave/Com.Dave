using Prism.Ioc;
using Prism.Regions;
using Prism.RegionsDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prism.RegionsDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private IContainerExtension _container;
        private IRegionManager _regionManager;
        private IRegion _region;
        private UserControl _viewB;
        private UserControl _viewA;

        public MainWindow(IRegionManager regionManager) : this(null, regionManager)
        {

        }

        public MainWindow(IContainerExtension container, IRegionManager regionManager)
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            _container = container;
            _regionManager = regionManager;
            //view discovery
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(RegionA));
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewA = _container.Resolve<RegionA>();
            _viewB = _container.Resolve<RegionB>();

            _region = _regionManager.Regions["DeactivateActivateRegion"];

            _region.Add(_viewA);
            _region.Add(_viewB);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button button))
                return;

            switch (button.Name)
            {
                case "deactivateregionA":
                    _region.Deactivate(_viewA);
                    break;
                case "activateregionA":
                    _region.Activate(_viewA);
                    break;
                case "deactivateregionB":
                    _region.Deactivate(_viewB);
                    break;
                case "activateregionB":
                    _region.Activate(_viewB);
                    break;
                default:
                    AddViewToDynamicRegion();
                    break;
            }

        }

        private void AddViewToDynamicRegion()
        {
            // view inject 
            var view = _container.Resolve<RegionA>();
            IRegion region = _regionManager.Regions["DynamicRegion"];
            region.Add(view);
        }
    }
}
