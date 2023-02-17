using System;
using Mirzipan.Bibliotheca.Disposables;
using UnityEngine.Events;

namespace Mirzipan.Bibliotheca.Unity
{
    public static class EventsExtensions
    {
        public static IDisposable Subscribe(
            this UnityEvent @this, 
            UnityAction action)
        {
            @this.AddListener(action);
            return Disposable.Create(() => { @this.RemoveListener(action); });
        }

        public static IDisposable Subscribe<T0>(
            this UnityEvent<T0> @this, 
            UnityAction<T0> action)
        {
            @this.AddListener(action);
            return Disposable.Create(() => { @this.RemoveListener(action); });
        }

        public static IDisposable Subscribe<T0, T1>(
            this UnityEvent<T0, T1> @this, 
            UnityAction<T0, T1> action)
        {
            @this.AddListener(action);
            return Disposable.Create(() => { @this.RemoveListener(action); });
        }

        public static IDisposable Subscribe<T0, T1, T2>(
            this UnityEvent<T0, T1, T2> @this, 
            UnityAction<T0, T1, T2> action)
        {
            @this.AddListener(action);
            return Disposable.Create(() => { @this.RemoveListener(action); });
        }

        public static IDisposable Subscribe<T0, T1, T2, T3>(
            this UnityEvent<T0, T1, T2, T3> @this,
            UnityAction<T0, T1, T2, T3> action)
        {
            @this.AddListener(action);
            return Disposable.Create(() => { @this.RemoveListener(action); });
        }
    }
}