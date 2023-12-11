$major = (Select-String -Path obs-studio/libobs/obs-config.h -Pattern '#define LIBOBS_API_MAJOR_VER (\d+)').Matches.Groups[1].Value
$minor = (Select-String -Path obs-studio/libobs/obs-config.h -Pattern '#define LIBOBS_API_MINOR_VER (\d+)').Matches.Groups[1].Value
$build = (Select-String -Path obs-studio/libobs/obs-config.h -Pattern '#define LIBOBS_API_PATCH_VER (\d+)').Matches.Groups[1].Value

$obsVersionFile = @"
namespace ObsInterop;

public static partial class Obs
{
    public static readonly Version Version = new Version(${major}, ${minor}, ${build});
}
"@

Out-File -FilePath NetObsBindings/Obs.Version.cs -InputObject $obsVersionFile
