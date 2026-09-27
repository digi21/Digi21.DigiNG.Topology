[![NuGet](https://img.shields.io/nuget/v/Digi21.DigiNG.Topology?style=flat)](https://www.nuget.org/packages/Digi21.DigiNG.Topology/)

# Digi21.DigiNG.Topology

This repository contains the source code of the reference assembly: Digi21.DigiNG.IO.Shp that is distributed through NuGet package for  geometric and topological analysis with Digi3D.AI.

## Publishing

Push a tag `v<version>` whose version matches `<version>` in the `.nuspec` of the `NuGet` folder. The *Release* workflow builds the reference assembly, packs it and publishes it to nuget.org with trusted publishing (repository secret `NUGET_USER`, the nuget.org profile name). The packages are not author-signed; the reference assembly is public-signed with `Digi21.PublicKey.snk`, which contains only the public key.
