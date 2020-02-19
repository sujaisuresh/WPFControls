using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Modularity;
using Prism.Unity;

namespace MVVMWithPrism
{
    public class BootStrapper : UnityBootstrapper
    {
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window) Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog(); //Use this once module is created

            Type sampleModuleType = typeof(SamplePrismModule.SampleModule);
            ModuleCatalog.AddModule(new ModuleInfo()
            { ModuleName = sampleModuleType.Name, ModuleType = sampleModuleType.AssemblyQualifiedName });
        }
    }
}
