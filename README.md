# WinTweakToolkit

WTTk is the lightweight, feature-complete tool kit for common Windows tweaking that would otherwise require having to dive into the registry or other unfriendly places.

![wttk](https://github.com/markski1/WinTweakTool/assets/22557859/5dd1b862-e7a4-4f9b-b5d1-a86dd0133dc9)

### Download

Check the [releases](https://github.com/markski1/WinTweakTool/releases) page and download the lattest version.

### Build it

WTTk is a .NET Framework 4.8 application with no 3rd party dependencies, thus building it is trivial. Simply open the solution file and compile it.

The release executable is compiled with the following dotnet publish command
```
dotnet publish WinTweakToolApp --no-self-contained --runtime win-x86 -p:PublishReadyToRun=true -c Release
```

### Collaborate

WTTk is heavily in-development. You can collaborate by opening issues with suggestions or bug reports, or by writing code and opening a pull request.

If you find WTTk useful, you can throw a small donation [this way](https://markski.ar/donate).
