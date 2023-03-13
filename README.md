[![openupm](https://img.shields.io/npm/v/net.mirzipan.bibliotheca?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/net.mirzipan.bibliotheca/) ![GitHub](https://img.shields.io/github/license/Mirzipan/Mirzipan.Bibliotheca)

# Mirzipan.Bibliotheca

A collection of basic utilities for Unity. As an added value, now, when someone would ask you "Donde esta la biblioteca?", you can just point them here.

## General Utilities

### BitMask

Multiple variants of a BitMask, namely 8-bit, 16-bit, and 32-bit versions.
Usable for most of your bit masking and flagging needs.

### Collection Dictionaries

If you are tired of always having to manage collections when using a dictionary with collections as values, then this might be for you.
There are multiple variants, all of which use some form of pooling for the collections.

Available variants:
* **HashSetDictionary** - dictionary with HashSet values, accepts custom value comparers 
* **ListDictionary** - dictionary with List values 
* **MultiDictionary** - dictionary with Dictionary values, accepts custom inner key comparers

If none of the variants cover your needs, you may always just inherit from `CollectionDictionary` and make it use your custom `ICollection<T>`.

### Disposables

Slightly modified copies of official `System.Reactive.Disposables`, since they are not available in Unity.
The namespace is chosen not to clash with the official one, in order to avoid clashes if and when the official library becomes accessible in Unity.

For more info, see [Microsoft Documentation](https://learn.microsoft.com/en-us/previous-versions/dotnet/reactive-extensions/hh229090(v=vs.103))

### IDisposerContainer

Interface that includes a `CompositeDisposable` property.

### Identifiers

Simple identifiers that combine the performance of an integer type with the convenience of a string.

Available variants:
* **QuadByte** - an identifier backed by `uint`
* **OctoByte** - an identifier backed by `ulong`
* **CompositeId** - an identifier backed by `OctoByte` with a primary and a secondary `QuadByte`

## Unity Utilities

### Colors

Collection of 141 pre-defined commonly used colors with a variant for `Color` and `Color32`.

For more info, see [Microsoft Documentation](https://learn.microsoft.com/en-us/dotnet/api/system.windows.media.colors?view=windowsdesktop-7.0)

### InputUtils

Simple checks for state of modifier keys (Alt, Ctrl, Shift, Meta).

The states:
* **Up** - is not pressed
* **Pressed** - key was pressed right now
* **Down** - key was pressed and is still being pressed
* **Released** - key was released right now

### Singleton

A `MonoBehaviour` that will ensure it does exist and that it is the only one of its kind. While overwhelming usage of singletons is advised against, they can be quite enjoyable in moderation.

### UnityEvent Subscriptions

Subscribe to all types of UnityEvent, and unsubscribe simply by disposing of the `IDisposable` that `Subscribe` returns.
