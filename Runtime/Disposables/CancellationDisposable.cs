﻿// Slightly modified copy of official System.Reactive.Disposables.CancellationDisposable

using System;
using System.Threading;

namespace Mirzipan.Bibliotheca.Disposables
{
    /// <summary>
    /// Represents a disposable resource that has an associated <seealso cref="CancellationToken"/> that will be set to the cancellation requested state upon disposal.
    /// </summary>
    public sealed class CancellationDisposable : ICancelable
    {
        private readonly CancellationTokenSource _cts;

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationDisposable"/> class that uses an existing <seealso cref="CancellationTokenSource"/>.
        /// </summary>
        /// <param name="cts"><seealso cref="CancellationTokenSource"/> used for cancellation.</param>
        /// <exception cref="ArgumentNullException"><paramref name="cts"/> is <c>null</c>.</exception>
        public CancellationDisposable(CancellationTokenSource cts)
        {
            _cts = cts ?? throw new ArgumentNullException(nameof(cts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationDisposable"/> class that uses a new <seealso cref="CancellationTokenSource"/>.
        /// </summary>
        public CancellationDisposable()
            : this(new CancellationTokenSource())
        {
        }

        /// <summary>
        /// Gets the <see cref="CancellationToken"/> used by this <see cref="CancellationDisposable"/>.
        /// </summary>
        public CancellationToken Token => _cts.Token;

        /// <summary>
        /// Cancels the underlying <seealso cref="CancellationTokenSource"/>.
        /// </summary>
        public void Dispose() => _cts.Cancel();

        /// <summary>
        /// Gets a value that indicates whether the object is disposed.
        /// </summary>
        public bool IsDisposed => _cts.IsCancellationRequested;
    }
}