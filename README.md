# Part of [dotnet.devfast](https://github.com/samaysar/dotnet.devfast) project.

## DevFast.Net.Extensions [![Build status](https://ci.appveyor.com/api/projects/status/7naggm2lvjcikgn2?svg=true)](https://ci.appveyor.com/project/samaysar/devfast-dotnet-extensions) [![codecov](https://codecov.io/gh/samaysar/dotnet.devfast.extensions/graph/badge.svg?token=7DXJsSSBLm)](https://codecov.io/gh/samaysar/dotnet.devfast.extensions) [![NuGet](https://buildstats.info/nuget/DevFast.Net.Extensions)](https://www.nuget.org/packages/DevFast.Net.Extensions)
[Developer Documentation](https://github.com/samaysar/dotnet.devfast.extensions/blob/master/docs/index.md 'index'), [Release Notes](https://raw.githubusercontent.com/samaysar/dotnet.devfast.extensions/master/ReleaseNotes.txt)

This project contains well-tested, self-explained &amp; easy to use extension methods to achieve optimized runtime performance with improved readability of the code.

### Examples
String parsing becomes as easy as stringValue.TryTo(out <T> ...) (where T can be bool, Guid, int, double, decimal, DateOnly, DateTime, TimeOnly etc...):
 - "123".TryTo(out int parsedInt) should return true with parsedInt as 123.