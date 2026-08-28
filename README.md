[![](https://img.shields.io/nuget/v/soenneker.gen.razor.imageoptimizer.webp.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.gen.razor.imageoptimizer.webp/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.gen.razor.imageoptimizer.webp/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.gen.razor.imageoptimizer.webp/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.gen.razor.imageoptimizer.webp.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.gen.razor.imageoptimizer.webp/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Gen.Razor.ImageOptimizer.Webp

### Build-time WebP image optimization for Razor applications using the bundled libvips command-line distributions.

## Quick start

Install the package in a Razor or Blazor project:

```bash
dotnet add package Soenneker.Gen.Razor.ImageOptimizer.Webp
```

Build the project. PNG and JPEG files beneath `wwwroot` produce adjacent `.webp` files automatically. Source images remain unchanged.

```text
wwwroot/images/photo.jpg
wwwroot/images/photo.webp
```

## Configuration

The defaults work without configuration. Override them in the consuming project when needed:

```xml
<PropertyGroup>
  <ImageOptimizerWebpEnabled>true</ImageOptimizerWebpEnabled>
  <ImageOptimizerWebpWwwRootPath>$(ProjectDir)wwwroot</ImageOptimizerWebpWwwRootPath>
  <ImageOptimizerWebpSourceExtensions>png;jpg;jpeg</ImageOptimizerWebpSourceExtensions>
  <ImageOptimizerWebpQuality>80</ImageOptimizerWebpQuality>
  <ImageOptimizerWebpEffort>4</ImageOptimizerWebpEffort>
  <ImageOptimizerWebpLossless>false</ImageOptimizerWebpLossless>
  <ImageOptimizerWebpStripMetadata>true</ImageOptimizerWebpStripMetadata>
  <ImageOptimizerWebpForce>false</ImageOptimizerWebpForce>
  <ImageOptimizerWebpFailOnError>true</ImageOptimizerWebpFailOnError>
</PropertyGroup>
```

| Property | Default | Description |
| --- | ---: | --- |
| `ImageOptimizerWebpEnabled` | `true` | Enables generation during builds. |
| `ImageOptimizerWebpWwwRootPath` | `$(ProjectDir)wwwroot` | Directory scanned recursively for source images. |
| `ImageOptimizerWebpSourceExtensions` | `png;jpg;jpeg` | Semicolon- or comma-separated source extensions. |
| `ImageOptimizerWebpQuality` | `80` | WebP quality from `1` through `100`. |
| `ImageOptimizerWebpEffort` | `4` | Encoder effort from `0` (fastest) through `6` (slowest). |
| `ImageOptimizerWebpLossless` | `false` | Enables lossless WebP encoding. |
| `ImageOptimizerWebpStripMetadata` | `true` | Removes image metadata from generated output. |
| `ImageOptimizerWebpForce` | `false` | Regenerates outputs even when they are up to date. |
| `ImageOptimizerWebpFailOnError` | `true` | Fails the build when an image cannot be processed. |

Set `ImageOptimizerWebpOutputPath` to write generated files elsewhere. Relative paths are resolved from the project directory, and the directory structure beneath `wwwroot` is preserved.

```xml
<PropertyGroup>
  <ImageOptimizerWebpOutputPath>$(ProjectDir)optimized</ImageOptimizerWebpOutputPath>
</PropertyGroup>
```

## Build behavior

- Missing `wwwroot` directories are skipped successfully.
- Outputs newer than their source are skipped unless `ImageOptimizerWebpForce` is `true`.
- Output directories are created automatically.
- Conflicting source names are detected before an output is overwritten.
- Design-time and cross-targeting builds do not run the optimizer.
- Windows x64 and Linux x64 libvips tools are bundled through `Soenneker.Libvips.Util`.

If `Soenneker.Gen.Razor.ImageOptimizer` is also installed, remove `webp` from its `ImageOptimizerFormats` setting so only this package owns WebP output.
