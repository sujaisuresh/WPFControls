using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace SamplePrismModule
{
    public class SampleModule : IModule
    {
        private IRegionManager _regionManager;

        public SampleModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }


        public void OnInitialized(IContainerProvider containerProvider)
        {
            //containerProvider.Resolve(typeof(Views.SampleView), "MainRegion");
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.SampleView));
            //containerProvider.
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.Register(typeof(SampleModule), "MainRegion");
            //throw new NotImplementedException();
        }
    }
}
