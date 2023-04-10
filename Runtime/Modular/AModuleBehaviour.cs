using UnityEngine;

namespace Mirzipan.Bibliotheca.Modular
{
    public abstract class AModuleBehaviour : MonoBehaviour, IModule
    {
        protected abstract IModuleContainer Container { get; }

        IModuleContainer IModule.Container => Container;
    }
}