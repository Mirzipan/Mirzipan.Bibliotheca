# Changelog

## [1.3.1] - 2023-03-16

### Changed
- CompositeId drawer now shows prefixes in front of its parts

### Fixed
- CompositeId drawer now works again

## [1.3.0] - 2023-03-15

### Changed
- CompositeId now uses ulong directly as its serialized value, instead of OctoByte

### Removed
- Removed Colors and Colors32 (moved to Mirzipan.Extensions)

## [1.2.2] - 2023-03-13

### Added
- Colors32 with the same colors as Colors has

## [1.2.1] - 2023-03-09

### Fixed
- QuadByte, OctoByte, and CompositeId drawers overriding field names

## [1.2.0] - 2023-03-09

### Added
- QuadByte, OctoByte, and CompositeId as simple identifiers

## [1.1.0] - 2023-03-03

### Added
- CollectionDictionary and its variants (ListDictionary, HashSetDictionary, MultiDictionary)
- BitMasks (8-, 16-, and 32-bit variants)
- InputUtils for more convenient checking of modifier key status

## [1.0.3] - 2023-02-20

### Added
- IDisposerContainer interface
- IDisposable extension

## [1.0.2] - 2023-02-17

### Added
- Disposable subscriptions to UnityEvent

## [1.0.1] - 2023-02-11

### Changed
- Package name changed to net.mirzipan.bibliotheca

## [1.0.0] - 2023-02-11

### Added
- Singleton MonoBehaviour with auto-resolve
- Copy of some System.Reactive.Disposables (Anonymous, Boolean, Cancellation, Composite)