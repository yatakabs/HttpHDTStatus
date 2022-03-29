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
