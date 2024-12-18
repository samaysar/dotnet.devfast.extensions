# Part of [dotnet.devfast](https://github.com/samaysar/dotnet.devfast) project.

## DevFast.Net.Extensions [![Build status](https://ci.appveyor.com/api/projects/status/7naggm2lvjcikgn2?svg=true)](https://ci.appveyor.com/project/samaysar/devfast-dotnet-extensions) [![codecov](https://codecov.io/gh/samaysar/dotnet.devfast.extensions/graph/badge.svg?token=7DXJsSSBLm)](https://codecov.io/gh/samaysar/dotnet.devfast.extensions) [![NuGet](https://img.shields.io/nuget/dt/DevFast.Net.Extensions)](https://www.nuget.org/packages/DevFast.Net.Extensions)
[Developer Documentation](https://github.com/samaysar/dotnet.devfast.extensions/blob/master/docs/index.md 'index'), [Release Notes](https://raw.githubusercontent.com/samaysar/dotnet.devfast.extensions/master/ReleaseNotes.txt)

This project contains well-tested, self-explained &amp; easy to use extension methods to achieve optimized runtime performance with improved readability of the code.

### Examples
#### String Parsing
String parsing becomes as easy as stringValue.TryTo(out &lt;T&gt; ...) (where T can be bool, Guid, int, double, decimal, DateOnly, DateTime, TimeOnly etc...):
 - "123".TryTo(out int parsedInt) should return true with parsedInt as 123.

Similar ".TryTo" also exists on ReadOnlySpan&lt;char&gt; and ReadOnlySpan&lt;byte&gt;

#### Avoid NullReferenceException on String
 - possibleNullString?.Trim() ?? string.Empty Becomes possibleNullString.TrimSafeOrEmpty()
 - possibleNullString?.Trim().ToUpper() ?? string.Empty Becomes possibleNullString.TrimSafeAndUpper() (same for Upper and more...)

#### Working on Byte Arrays (byte[])
 - myByteArray.LiftNCopySafe(...) moves bytes with-in Arrays
 - myByteArray.DoubleByteCapacity() returns new array with initial bytes but twice the capacity
 - myByteArray.CopyToSafe(...) copies bytes to targeted array
 
#### IEnumerable &amp; IAsyncEnumerable with Token All the Way
 - ForEach, ForEachAsync, ToBlockingEnumerable with Token
 - Token support for SelectAsync, SkipAsync, TakeAsync, WhereAsync, CountAsync, ToChunksAsync etc.