using System;

namespace Mirzipan.Bibliotheca.Disposables
{
    public static class DisposableExtensions
    {
        /// <summary>
        /// Adds this <see cref="IDisposable"/> to the disposer.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="container">Object with disposer</param>
        /// <returns></returns>
        public static IDisposable DisposeWith(this IDisposable @this, IHaveDisposer container)
        {
            container.Disposer.Add(@this);
            return @this;
        }
    }
}