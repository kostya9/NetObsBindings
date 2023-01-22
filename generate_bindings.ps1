$config = "multi-file", "generate-file-scoped-namespaces", "generate-helper-types", "exclude-funcs-with-body", "generate-macro-bindings"
$replacements = "vec2=@System.Numerics.Vector2", "vec3=@System.Numerics.Vector3", "vec4=@System.Numerics.Vector4"

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\obs-source.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsSource <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\media-io\audio-io.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsAudio <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\obs.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName Obs <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\media-io\video-io.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsVideo <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements


ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\media-io\frame-rate.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsFrameRate <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\graphics\graphics.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsGraphics <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\obs-interaction.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsInteraction <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\obs-encoder.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsEncoder <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\obs-service.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsService <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements


ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\util\base.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsUtilBase <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements


ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\obs-properties.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsProperties <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\obs-data.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsData <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements


ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\UI\obs-frontend-api\obs-frontend-api.h <# file we want to generate bindings for #>  `
    --file .\obs-studio\libobs\util\darray.h  `
    --include-directory .\obs-studio\libobs `
    --include-directory .\obs-studio\libobs\util `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsFrontendApi <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\util\text-lookup.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsTextLookup <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\util\profiler.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsProfiler <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\callback\proc.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsProc <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\callback\signal.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsSignal <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\obs-missing-files.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsMissingFiles <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\callback\calldata.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsCalldata <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements

ClangSharpPInvokeGenerator `
    -c $config `
    --file .\obs-studio\libobs\obs-module.h <# file we want to generate bindings for #>  `
    --traverse .\obs-studio\libobs\graphics\input.h `
    -n ObsInterop <# namespace of the bindings #> `
    --methodClassName ObsInput <# class name where to put methods #> `
    --libraryPath obs <# name of the DLL #> `
    -o .\NetObsBindings\ObsInterop <# output folder #> `
    -r $replacements