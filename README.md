# WinTweakToolkit

WTTk is the lightweight, feature-complete tool kit for common Windows tweaking that would otherwise require having to dive into the registry or other unfriendly places.

![wttk](https://user-images.githubusercontent.com/22557859/224830723-14a8f834-29db-4c32-9232-948849b8f27d.png)

### Download

Check the [releases](https://github.com/markski1/WinTweakTool/releases) page and download the lattest version.

### Build it

Building WTTk is trivial. Simply open the solution file and compile it. No 3rd party packages are used.

The release executable is compiled with the following dotnet publish command
```
dotnet publish WinTweakToolApp --no-self-contained --runtime win-x64 -p:PublishReadyToRun=true -p:PublishSingleFile=true -c Release
```

### Collaborate

WTTk is heavily in-development. You can collaborate by opening issues with suggestions or bug reports, or by writing code and opening a pull request.

If you find WTTk useful, you can throw a small donation [this way](https://markski.ar/donate).
