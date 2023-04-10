using UnityEngine;

namespace Mirzipan.Bibliotheca.Modular
{
    public abstract class ModuleBehaviour : MonoBehaviour, IModule
    {
        protected abstract IModuleContainer Container { get; }

        IModuleContainer IModule.Container => Container;
    }
}