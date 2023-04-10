namespace Mirzipan.Bibliotheca.Modular
{
    public abstract class Module: IModule
    {
        protected abstract IModuleContainer Container { get; }

        IModuleContainer IModule.Container => Container;
    }
}