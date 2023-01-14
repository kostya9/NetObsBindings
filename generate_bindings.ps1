$config = "multi-file", "generate-file-scoped-namespaces", "generate-helper-types", "exclude-funcs-with-body", "generate-macro-bindings"
$replacements = "obs_data*=@void*", "gs_effect*=@void*", "obs_source*=@void*", "obs_missing_files*=@void*", "vec2=@System.Numerics.Vector2", "vec3=@System.Numerics.Vector3", "vec4=@System.Numerics.Vector4", "profiler_name_store*=@void*", "text_lookup*=@void*", "signal_handler*=@void*", "proc_handler*=@void*", "obs_data_array*=@void*", "input_subsystem*=@void*"

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

