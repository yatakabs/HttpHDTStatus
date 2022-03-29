using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace HttpHDTStatus.Installers
{
    public class HHSGameIstaller : Installer
    {
        public override void InstallBindings()
        {
            this.Container.BindInterfacesAndSelfTo<HttpHDTStatusController>().AsCached().NonLazy();
        }
    }
}
