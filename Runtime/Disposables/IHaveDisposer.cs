namespace Mirzipan.Bibliotheca.Disposables
{
    /// <summary>
    /// A container with composite disposable.
    /// </summary>
    public interface IHaveDisposer
    {
        /// <summary>
        /// Gets or sets the instance of composite disposable.
        /// </summary>
        CompositeDisposable Disposer { get; set; }
    }
}