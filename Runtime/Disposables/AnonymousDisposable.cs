// Copy of official System.Reactive.Disposables.AnonymousDisposable

using System;
using System.Threading;

namespace Mirzipan.Bibliotheca.Disposables
{
    /// <summary>
    /// Represents an Action-based disposable.
    /// </summary>
    public sealed class AnonymousDisposable : ICancelable
    {
        private volatile Action _dispose;

        /// <summary>
        /// Constructs a new disposable with the given action used for disposal.
        /// </summary>
        /// <param name="dispose">Disposal action which will be run upon calling Dispose.</param>
        public AnonymousDisposable(Action dispose)
        {
            _dispose = dispose;
        }

        /// <summary>
        /// Gets a value that indicates whether the object is disposed.
        /// </summary>
        public bool IsDisposed => _dispose == null;

        /// <summary>
        /// Calls the disposal action if and only if the current instance hasn't been disposed yet.
        /// </summary>
        public void Dispose()
        {
            Interlocked.Exchange(ref _dispose, null)?.Invoke();
        }
    }
    
    /// <summary>
    /// Represents a Action-based disposable that can hold onto some state.
    /// </summary>
    public sealed class AnonymousDisposable<TState> : ICancelable
    {
        private TState _state;
        private volatile Action<TState> _dispose;

        /// <summary>
        /// Constructs a new disposable with the given action used for disposal.
        /// </summary>
        /// <param name="state">The state to be passed to the disposal action.</param>
        /// <param name="dispose">Disposal action which will be run upon calling Dispose.</param>
        public AnonymousDisposable(TState state, Action<TState> dispose)
        {
            _state = state;
            _dispose = dispose;
        }

        /// <summary>
        /// Gets a value that indicates whether the object is disposed.
        /// </summary>
        public bool IsDisposed => _dispose == null;

        /// <summary>
        /// Calls the disposal action if and only if the current instance hasn't been disposed yet.
        /// </summary>
        public void Dispose()
        {
            Interlocked.Exchange(ref _dispose, null)?.Invoke(_state);
            _state = default!;
        }
    }
}