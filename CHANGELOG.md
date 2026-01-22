# [6.0.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v5.2.0...v6.0.0) (2026-01-22)


### Features

* Updating Reactor Request objects ([6d15b6c](https://github.com/Basis-Theory/dotnet-sdk/commit/6d15b6c8b8a26ce38a57d39e9e25e337ddeadc41))


### BREAKING CHANGES

* This version removes the existing Reactors Request objects for Reactors and Reactors Async, allowing the use of dynamic objects

# [5.2.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v5.1.0...v5.2.0) (2025-12-09)


### Features

* Change Reactor Runtime to object ([f8f64ef](https://github.com/Basis-Theory/dotnet-sdk/commit/f8f64efe9f2ea3ec987e9f945de1991349211a86))

# [5.1.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v5.0.0...v5.1.0) (2025-12-02)


### Features

* supporting new environments ([23917f1](https://github.com/Basis-Theory/dotnet-sdk/commit/23917f15c3ae8bf4964c203428fce2a2d5847a17))

# [5.0.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v4.1.0...v5.0.0) (2025-10-30)


### Features

* renaming keys endpoint properties, and removing get tokens v1  ([#93](https://github.com/Basis-Theory/dotnet-sdk/issues/93)) ([e40bc87](https://github.com/Basis-Theory/dotnet-sdk/commit/e40bc870ec1a54d8942775512a486217fc7bcf47))


### BREAKING CHANGES

* The get tokens v1 endpoint was removed, and the properties of the keys endpoint were renamed

# [4.1.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v4.0.0...v4.1.0) (2025-08-22)


### Features

* Add DELETE endpoint for ApplePay ([303c605](https://github.com/Basis-Theory/dotnet-sdk/commit/303c6052d46ae4d66d3fd780548c4b9c9b947c66))

# [4.0.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v3.3.0...v4.0.0) (2025-08-14)


### Features

* Add Google Pay endpoints ([fa37c69](https://github.com/Basis-Theory/dotnet-sdk/commit/fa37c6994339839029ba2ffb37ad69e4955532fe))


### BREAKING CHANGES

* Updated Token Usage response and removes expires_at from Applications

# [3.3.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v3.2.0...v3.3.0) (2025-08-11)


### Features

* Better support for downloading document data ([#85](https://github.com/Basis-Theory/dotnet-sdk/issues/85)) ([cfbaa44](https://github.com/Basis-Theory/dotnet-sdk/commit/cfbaa44bbbeff05b6cd456200fb24ce7ff1ec71e))

# [3.2.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v3.1.0...v3.2.0) (2025-07-22)


### Features

* Add documents ([#77](https://github.com/Basis-Theory/dotnet-sdk/issues/77)) ([a24e7f8](https://github.com/Basis-Theory/dotnet-sdk/commit/a24e7f81ff601a83ef9f7550b5f75a85ad26f2ca))

# [3.1.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v3.0.0...v3.1.0) (2025-06-04)


### Features

* Add Apple Pay unlink support ([6de68ab](https://github.com/Basis-Theory/dotnet-sdk/commit/6de68ab2750e080c10edc151bc0ac008f5910db3))

# [3.0.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v2.6.0...v3.0.0) (2025-05-20)


### Features

* Add Apple Pay Token support ([2e5fe6a](https://github.com/Basis-Theory/dotnet-sdk/commit/2e5fe6ae8acb89219f5a018f12f01e8c3bf61f99))


### BREAKING CHANGES

* The old methods for using Apple Pay and Token Intents have moved to the "connection" namespace.

# [2.6.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v2.5.0...v2.6.0) (2025-05-07)


### Features

* add network tokens and 3ds co-badged cards props ([f9e951b](https://github.com/Basis-Theory/dotnet-sdk/commit/f9e951beea3ed2a3ce6b37f0d136a3c5097a9ec2))

# [2.5.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v2.4.0...v2.5.0) (2025-05-05)


### Features

* adds account updater endpoints ([#59](https://github.com/Basis-Theory/dotnet-sdk/issues/59)) ([a47c82a](https://github.com/Basis-Theory/dotnet-sdk/commit/a47c82a22891d0a2d8d521ab584ad9b5e267a35c))

# [2.4.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v2.3.0...v2.4.0) (2025-04-29)


### Features

* update version of GH action ([#57](https://github.com/Basis-Theory/dotnet-sdk/issues/57)) ([50e6ff5](https://github.com/Basis-Theory/dotnet-sdk/commit/50e6ff530fe6b1b0c26925f1ea167cf20c41d870))

# [2.3.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v2.2.0...v2.3.0) (2025-04-01)


### Features

* Add registerAll to Apple Pay Domains and network token create ([4d98ee4](https://github.com/Basis-Theory/dotnet-sdk/commit/4d98ee4ea52d494bca63753698f37d67e040e0f4))

# [2.2.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v2.1.0...v2.2.0) (2025-03-28)


### Features

* trigger release for previous threeds updates ([#51](https://github.com/Basis-Theory/dotnet-sdk/issues/51)) ([b513bd2](https://github.com/Basis-Theory/dotnet-sdk/commit/b513bd22d912463b03786b57e6bf7f7f14d77fd9))

# [2.1.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v2.0.0...v2.1.0) (2025-03-28)


### Features

* update threeds authentication props ([70e756c](https://github.com/Basis-Theory/dotnet-sdk/commit/70e756c8e16ad641b59cac84103026a3adc167a5))

# [2.0.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v1.1.0...v2.0.0) (2025-03-19)


### Features

* Reworked Client ([2cebcbe](https://github.com/Basis-Theory/dotnet-sdk/commit/2cebcbef4cdef93d8bb6551190f59677b70aed8a))


### BREAKING CHANGES

* Endpoints that use the `Pager` are now required to be `await`ed.

Example:
`var tokens = client.Tokens.ListV2Async(...)`

becomes

`var tokens = await client.Tokens.ListV2Async(...);`

# [1.1.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v1.0.1...v1.1.0) (2025-03-18)


### Features

* Apple Pay support ([009abc0](https://github.com/Basis-Theory/dotnet-sdk/commit/009abc01e426e4c64f66fd357acf122777f910d8))

## [1.0.1](https://github.com/Basis-Theory/dotnet-sdk/compare/v1.0.0...v1.0.1) (2025-03-18)


### Bug Fixes

* Fix tests ([#41](https://github.com/Basis-Theory/dotnet-sdk/issues/41)) ([5f795f0](https://github.com/Basis-Theory/dotnet-sdk/commit/5f795f08fe0a650edb90342303d369d18a3a6ad5))

# [1.0.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.3.1...v1.0.0) (2025-03-05)


### Features

* adding get token intents ([ecd328c](https://github.com/Basis-Theory/dotnet-sdk/commit/ecd328cc4c7889ee8328fd3f92228e79e605c545))


### BREAKING CHANGES

* Updated Token Usage response and removes expires_at from Applications

## [0.3.1](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.3.0...v0.3.1) (2025-01-31)


### Bug Fixes

* Add `network_token` to token intents ([ae1fe7a](https://github.com/Basis-Theory/dotnet-sdk/commit/ae1fe7acb8f1e40ae53d3a53203458b469b443c7))

# [0.3.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.2.0...v0.3.0) (2025-01-30)


### Features

* Add Google Pay Tokenization ([a824fe5](https://github.com/Basis-Theory/dotnet-sdk/commit/a824fe556df9fb541286cdcf6a1b014fc39260f6))

# [0.2.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.1.5...v0.2.0) (2025-01-27)


### Features

* Google Pay ([1192781](https://github.com/Basis-Theory/dotnet-sdk/commit/11927817cfc6c073c64db19e6baaeec6e704872e))

## [0.1.5](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.1.4...v0.1.5) (2024-11-20)


### Bug Fixes

* Add token-intents ([#28](https://github.com/Basis-Theory/dotnet-sdk/issues/28)) ([7c17942](https://github.com/Basis-Theory/dotnet-sdk/commit/7c17942da3d1d9c902de8f1ee45b6493fd777f65))

## [0.1.4](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.1.3...v0.1.4) (2024-11-20)


### Bug Fixes

* Update to latest specs ([#27](https://github.com/Basis-Theory/dotnet-sdk/issues/27)) ([81cc857](https://github.com/Basis-Theory/dotnet-sdk/commit/81cc857db3d36d2d5f6ab0617b3112a1a1e47d3f))

## [0.1.3](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.1.2...v0.1.3) (2024-11-20)


### Bug Fixes

* Support auto-pagination ([#23](https://github.com/Basis-Theory/dotnet-sdk/issues/23)) ([c78071f](https://github.com/Basis-Theory/dotnet-sdk/commit/c78071fe60c4bae731613eb5ba81451f2a341623))

## [0.1.2](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.1.1...v0.1.2) (2024-11-19)


### Bug Fixes

* permissions.list method ([#22](https://github.com/Basis-Theory/dotnet-sdk/issues/22)) ([3f48fda](https://github.com/Basis-Theory/dotnet-sdk/commit/3f48fda2a18a56376669c162ad0307e2611e4206))

## [0.1.1](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.1.0...v0.1.1) (2024-11-19)


### Bug Fixes

* Upgrade to latest specs ([#21](https://github.com/Basis-Theory/dotnet-sdk/issues/21)) ([5591ef1](https://github.com/Basis-Theory/dotnet-sdk/commit/5591ef1a68f814a8f7a5f9399c1af5e5e1b40381))

# [0.1.0](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.0.4...v0.1.0) (2024-11-18)


### Features

* Add support for Idenpotency Key and PATCH methods ([#18](https://github.com/Basis-Theory/dotnet-sdk/issues/18)) ([873287e](https://github.com/Basis-Theory/dotnet-sdk/commit/873287e30ece92bed440a1061510289fd60993da))

## [0.0.4](https://github.com/Basis-Theory/dotnet-sdk/compare/v0.0.3...v0.0.4) (2024-11-05)


### Bug Fixes

* Reorganizes 3DS, Tenant Owner, and Enrichments ([#12](https://github.com/Basis-Theory/dotnet-sdk/issues/12)) ([a0f6e5f](https://github.com/Basis-Theory/dotnet-sdk/commit/a0f6e5f83a9098137139059b9ac36f58dac53af4))
