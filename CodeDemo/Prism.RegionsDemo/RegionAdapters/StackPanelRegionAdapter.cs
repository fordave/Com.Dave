using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Prism.RegionsDemo.RegionAdapters
{
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>
    {
        public StackPanelRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            region.Views.CollectionChanged += (sendor, e) =>
            {
                switch (e.Action)
                {
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                        foreach (FrameworkElement element in e.NewItems)
                        {
                            regionTarget.Children.Add(element);
                        }
                        break;
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                        foreach (FrameworkElement element in e.OldItems)
                        {
                            regionTarget.Children.Remove(element);
                        }
                        break;
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                        break;
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                        break;
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                        break;
                    default:
                        break;
                }
            };

        }

        protected override IRegion CreateRegion()
        {
            return new AllActiveRegion();
        }
    }
}
