namespace Mirzipan.Bibliotheca.Disposables
{
    /// <summary>
    /// A container with <see cref="CompositeDisposable"/> instance.
    /// </summary>
    public interface IDisposerContainer
    {
        /// <summary>
        /// Gets or sets the instance of <see cref="CompositeDisposable"/>.
        /// </summary>
        CompositeDisposable Disposer { get; set; }
    }
}