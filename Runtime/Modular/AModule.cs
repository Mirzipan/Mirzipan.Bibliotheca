﻿namespace Mirzipan.Bibliotheca.Modular
{
    public abstract class AModule: IModule
    {
        protected abstract IModuleContainer Container { get; }

        IModuleContainer IModule.Container => Container;
    }
}