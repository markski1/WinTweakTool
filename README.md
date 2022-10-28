# WinTweakToolkit

WTTk is the lightweight, feature-complete tool kit for common Windows tweaking that would otherwise require having to dive into the registry or other unfriendly places.

![WTTk](https://user-images.githubusercontent.com/22557859/198531354-e0bb4361-595e-4b47-8359-dc38de73bbce.png)

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

### TODO
Things I plan to do and which I believe should be in place for v1.0:

- More in-depth desktop tweaks
- Whatever else gets suggested
- Clear separation between UI code and Business code - While Visual Studio 2022 does a good job at keeping these two apart in practice, people who (for whatever god forsaken reason) use a C# IDE other than VS22 might have a hard time browsing through it.
