function Get-ObsClassName {
    param ($ObsHeaderName)

    $moduleNameParts = [System.IO.Path]::GetFileNameWithoutExtension($ObsHeaderName).Replace("-io", "").Split("-")

    for ($i = 0; $i -lt $moduleNameParts.Length; $i++)
    {
        $moduleNameParts[$i] = (Get-Culture).TextInfo.ToTitleCase($moduleNameParts[$i])
    }

    $moduleName = -Join $moduleNameParts

    if (!$moduleName.StartsWith("Obs")) {
        $moduleName = "Obs" + $moduleName;
    }

    $moduleName
}

$config = "multi-file", "generate-file-scoped-namespaces", "generate-helper-types", "exclude-funcs-with-body", "generate-macro-bindings", "latest-codegen"
$replacements = "vec2=@System.Numerics.Vector2", "vec3=@System.Numerics.Vector3", "vec4=@System.Numerics.Vector4", "half=@Half", "__m128=@System.Runtime.Intrinsics.Vector128<Single>", "quat=@System.Numerics.Quaternion", "_iobuf*=@nint","stat*=@nint"
$excludes = @(
    "blogva", "blog", <# this method uses __arglist (variable argument list in C) but it is not fully supported in .NET (e.g. on Linux it just crashes) #>
    "ARCH_BITS", <# manually implemented for .NET #>
    "S__LINE__", "INT_CUR_LINE", "FILE_LINE" <# macroses for line and file in C, doesnt't work well in C# #>
    )

$obsModuleTracersals = @(
    ".\obs-studio\libobs\obs-source.h",
    ".\obs-studio\libobs\obs.h",
    ".\obs-studio\libobs\obs-missing-files.h",
    ".\obs-studio\libobs\obs-output.h",
    ".\obs-studio\libobs\obs-interaction.h",
    ".\obs-studio\libobs\obs-encoder.h",
    ".\obs-studio\libobs\obs-service.h",
    ".\obs-studio\libobs\obs-properties.h",
    ".\obs-studio\libobs\obs-data.h",
    ".\obs-studio\libobs\callback\proc.h",
    ".\obs-studio\libobs\callback\signal.h",
    ".\obs-studio\libobs\callback\calldata.h"
);

 foreach ($obsModuleTracersal in $obsModuleTracersals)
 {
    Write-Host "----Generating bindings for file ""$obsModuleTracersal"""

    $moduleName = Get-ObsClassName $obsModuleTracersal

     ClangSharpPInvokeGenerator `
        -c $config `
        --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
        --traverse $obsModuleTracersal <# file we want to generate bindings for #>  `
        -n ObsInterop <# namespace of the bindings #> `
        --methodClassName $moduleName <# class name where to put methods #> `
        --libraryPath obs <# name of the DLL #> `
        -o .\NetObsBindings\ObsInterop <# output folder #> `
        -r $replacements `
        --exclude $excludes
 }

 $mediaLibraries = @(
    ".\obs-studio\libobs\media-io\audio-io.h",
    ".\obs-studio\libobs\media-io\video-io.h",
    ".\obs-studio\libobs\media-io\frame-rate.h",
    ".\obs-studio\libobs\media-io\audio-resampler.h",
    ".\obs-studio\libobs\media-io\format-conversion.h",
    ".\obs-studio\libobs\media-io\media-remux.h",
    ".\obs-studio\libobs\media-io\video-frame.h",
    ".\obs-studio\libobs\media-io\video-scaler.h"
);

 foreach ($mediaLibrary in $mediaLibraries)
 {
    Write-Host "----Generating bindings for file ""$mediaLibrary"""

    $moduleName = Get-ObsClassName $mediaLibrary

     ClangSharpPInvokeGenerator `
        -c $config `
        --file .\generate\media-io\obs-media-io.h `
        --traverse $mediaLibrary <# file we want to generate bindings for #>  `
        --include-directory .\obs-studio\libobs `
        -n ObsInterop <# namespace of the bindings #> `
        --methodClassName $moduleName <# class name where to put methods #> `
        --libraryPath obs <# name of the DLL #> `
        -o .\NetObsBindings\ObsInterop <# output folder #> `
        -r $replacements `
        --exclude $excludes
 }

 $graphicsLibraries = @(
    ".\obs-studio\libobs\graphics\graphics.h",
    ".\obs-studio\libobs\graphics\input.h",
    ".\obs-studio\libobs\graphics\axisang.h",
    ".\obs-studio\libobs\graphics\bounds.h",
    ".\obs-studio\libobs\graphics\device-exports.h",
    ".\obs-studio\libobs\graphics\effect.h",
    ".\obs-studio\libobs\graphics\image-file.h",
    ".\obs-studio\libobs\graphics\math-defs.h",
    ".\obs-studio\libobs\graphics\math-extra.h",
    ".\obs-studio\libobs\graphics\matrix3.h",
    ".\obs-studio\libobs\graphics\matrix4.h",
    ".\obs-studio\libobs\graphics\plane.h",
    ".\obs-studio\libobs\graphics\srgb.h",
    ".\obs-studio\libobs\graphics\libnsgif\libnsgif.h"
 );

  foreach ($graphicsLibrary in $graphicsLibraries)
 {
    Write-Host "----Generating bindings for file ""$graphicsLibrary"""

    $moduleName = Get-ObsClassName $graphicsLibrary

     ClangSharpPInvokeGenerator `
        -c $config `
        --file .\generate\graphics\obs-graphics.h `
        --traverse $graphicsLibrary <# file we want to generate bindings for #>  `
        --include-directory .\obs-studio\libobs `
        -n ObsInterop <# namespace of the bindings #> `
        --methodClassName $moduleName <# class name where to put methods #> `
        --libraryPath obs <# name of the DLL #> `
        -o .\NetObsBindings\ObsInterop <# output folder #> `
        -r $replacements `
        --exclude $excludes
 }

$utilLibraries = @(
    ".\obs-studio\libobs\util\text-lookup.h",
    ".\obs-studio\libobs\util\profiler.h",
    ".\obs-studio\libobs\util\base.h",
    ".\obs-studio\libobs\util\bmem.h",
    ".\obs-studio\libobs\util\platform.h"
);

foreach ($utilLibrary in $utilLibraries)
{
    Write-Host "----Generating bindings for file ""$utilLibrary"""

    $moduleName = Get-ObsClassName $utilLibrary

    ClangSharpPInvokeGenerator `
        -c $config `
        --file .\generate\util\obs-util.h `
        --traverse $utilLibrary <# file we want to generate bindings for #>  `
        --include-directory .\obs-studio\libobs `
        -n ObsInterop <# namespace of the bindings #> `
        --methodClassName $moduleName <# class name where to put methods #> `
        --libraryPath obs <# name of the DLL #> `
        -o .\NetObsBindings\ObsInterop <# output folder #> `
        -r $replacements `
        --exclude $excludes
}

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\UI\obs-frontend-api\obs-frontend-api.h <# file we want to generate bindings for #>  `
    --file .\obs-studio\libobs\util\darray.h  `
    --include-directory .\obs-studio\libobs `
    --include-directory .\obs-studio\libobs\util `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsFrontendApi <# class name where to put methods #> `
    --libraryPath obs-frontend-api <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements `
    --exclude $excludes

rm .\NetObsBindings\ObsInterop\System.Numerics.Quaternion.cs <# This file is wrongly generated by ClangSharpGenerator #>