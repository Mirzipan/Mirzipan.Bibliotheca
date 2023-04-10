using System;

namespace Mirzipan.Bibliotheca.Modular
{
    public interface IModuleContainer
    {
        IModule Get(Type moduleType);
    }
}