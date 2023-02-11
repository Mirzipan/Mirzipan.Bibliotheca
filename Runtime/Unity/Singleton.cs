using UnityEngine;

namespace Mirzipan.Bibliotheca.Unity
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        private static T _instance;
        public static T Instance => _instance ??= EnsureInstance();

        #region Lifecycle

        protected virtual void Awake()
        {
            if (!_instance)
            {
                _instance = this as T;
                DontDestroyOnLoad(gameObject);
                return;
            }
            
            Destroy(gameObject);
        }

        #endregion Lifecycle
        
        #region Private

        private static T EnsureInstance()
        {
            T result = FindObjectOfType<T>();
            if (result)
            {
                return result;
            }

            GameObject go = new GameObject
            {
                name = typeof(T).Name
            };
            return go.AddComponent<T>();
        }

        #endregion Private
    }
}