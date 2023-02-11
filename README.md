# Mirzipan.Bibliotheca

A collection of basic utilities for Unity. As an added value, now, when someone would ask you "Donde esta la biblioteca?", you can just point them here.

## General Utilities

### Disposables

Slightly modified copies of official `System.Reactive.Disposables`, since they are not available in Unity.
The namespace is chosen not to clash with the official one, in order to avoid clashes if and when the official library becomes accessible in Unity.

For documentation, see [Microsoft Documentation](https://learn.microsoft.com/en-us/previous-versions/dotnet/reactive-extensions/hh229090(v=vs.103))

## Unity Utilities

### Singleton

A `MonoBehaviour` that will ensure it does exist and that it is the only one of its kind. While overwhelming usage of singletons is advised against, they can be quite enjoyable in moderation.