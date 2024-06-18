#### [DevFast.Net.Extensions](index.md 'index')
### [DevFast.Net.Extensions.Etc](DevFast.Net.Extensions.Etc.md 'DevFast.Net.Extensions.Etc')

## Errors Class

Extension methods to throw or consume various kind of exceptions.

```csharp
public static class Errors
```
- *Methods*
  - **[ThrowArgumentExceptionForNull&lt;T&gt;(this T, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception)')**
  - **[ThrowArgumentExceptionForNullOrOnPredicateFail&lt;T&gt;(this T, Func&lt;T,bool&gt;, string, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception)')**
  - **[ThrowArgumentExceptionForNullOrOnPredicateSuccess&lt;T&gt;(this T, Func&lt;T,bool&gt;, string, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception)')**
  - **[ThrowArgumentExceptionOnPredicateFail&lt;T&gt;(this T, Func&lt;T,bool&gt;, string, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception)')**
  - **[ThrowArgumentExceptionOnPredicateSuccess&lt;T&gt;(this T, Func&lt;T,bool&gt;, string, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception)')**
  - **[ThrowInvalidOperationExceptionIfFalse(this bool, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(this bool, string, System.Exception)')**
  - **[ThrowInvalidOperationExceptionIfTrue(this bool, string, Exception)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception) 'DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(this bool, string, System.Exception)')**
  - **[TryExecute&lt;T&gt;(this Action, Action&lt;ExceptionDispatchInfo,T&gt;, Action)](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action) 'DevFast.Net.Extensions.Etc.Errors.TryExecute<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action)')**

## Errors Class

Extension methods to throw or consume various kind of exceptions.

```csharp
public static class Errors
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Errors
### Methods

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionForNull<T>(this T, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').
Otherwise, returns the [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be '{argumentName} was null.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).argumentName') will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionForNull<T>(this T? value, string argumentName, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).T')

Value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument supplied as value

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull_T_(thisT,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNull<T>(this T, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, Func<T,bool>, string, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')
or if the [predicate](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicate') evaluates to [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, returns the [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be
'{argumentName} does not satisfy {predicateName ?? predicate}.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).argumentName') and/or [predicateName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicateName')
will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T? value, System.Func<T,bool> predicate, string argumentName, string? predicateName=null, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

Value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Predicate to evaluate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument supplied as value

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName'></a>

`predicateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the predicate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, Func<T,bool>, string, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null')
or if the [predicate](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicate') evaluates to [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, returns the [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be
'{argumentName} satisfied {predicateName ?? predicate}.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).argumentName') and/or [predicateName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicateName')
will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T? value, System.Func<T,bool> predicate, string argumentName, string? predicateName=null, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

Value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Predicate to evaluate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument supplied as value

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName'></a>

`predicateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the predicate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionForNullOrOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, Func<T,bool>, string, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [predicate](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicate') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, always returns [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be
'{argumentName} does not satisfy {predicateName ?? predicate}.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).argumentName') and [predicateName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicateName')
will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionOnPredicateFail<T>(this T value, System.Func<T,bool> predicate, string argumentName, string? predicateName=null, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

Value to evaluate predicate on

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Predicate lambda

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName'></a>

`predicateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the predicate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateFail<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception)'></a>

## Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, Func<T,bool>, string, string, Exception) Method

Throws an [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') if [predicate](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicate') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, always returns [value](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).value') for chaining purpose.

NOTE: If [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException') is thrown, the message will be
'{argumentName} satisfied {predicateName ?? predicate}.',
thus, a well-formed [argumentName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).argumentName') and [predicateName](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).predicateName')
will make more sense during debugging or log-analysis.

```csharp
public static T ThrowArgumentExceptionOnPredicateSuccess<T>(this T value, System.Func<T,bool> predicate, string argumentName, string? predicateName=null, System.Exception? innerException=null);
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T'></a>

`T`
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).value'></a>

`value` [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

Value to evaluate predicate on

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Predicate lambda

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).argumentName'></a>

`argumentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the argument

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).predicateName'></a>

`predicateName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the predicate

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')

#### Returns
[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess_T_(thisT,System.Func_T,bool_,string,string,System.Exception).T 'DevFast.Net.Extensions.Etc.Errors.ThrowArgumentExceptionOnPredicateSuccess<T>(this T, System.Func<T,bool>, string, string, System.Exception).T')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception)'></a>

## Errors.ThrowInvalidOperationExceptionIfFalse(this bool, string, Exception) Method

Throws an [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException') if [flag](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception).flag 'DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(this bool, string, System.Exception).flag') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, always returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') for chaining purpose.

```csharp
public static bool ThrowInvalidOperationExceptionIfFalse(this bool flag, string message, System.Exception? innerException=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Flag value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Message of the [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfFalse(thisbool,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception)'></a>

## Errors.ThrowInvalidOperationExceptionIfTrue(this bool, string, Exception) Method

Throws an [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException') if [flag](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception).flag 'DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(this bool, string, System.Exception).flag') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').
Otherwise, always returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') for chaining purpose.

```csharp
public static bool ThrowInvalidOperationExceptionIfTrue(this bool flag, string message, System.Exception? innerException=null);
```
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception).flag'></a>

`flag` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Flag value to check

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Message of the [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

<a name='DevFast.Net.Extensions.Etc.Errors.ThrowInvalidOperationExceptionIfTrue(thisbool,string,System.Exception).innerException'></a>

`innerException` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Inner exceptions of the [System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action)'></a>

## Errors.TryExecute<T>(this Action, Action<ExceptionDispatchInfo,T>, Action) Method

Executes [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.TryExecute<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).lambda') inside try-catch-finally block.
If any exception of type [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.TryExecute<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).T') (or
derived from [T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.TryExecute<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).T')) occurs during [lambda](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).lambda 'DevFast.Net.Extensions.Etc.Errors.TryExecute<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).lambda')
execution, relevant information is passed to [errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.TryExecute<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).errorHandler').
If any [finallyClause](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).finallyClause 'DevFast.Net.Extensions.Etc.Errors.TryExecute<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).finallyClause') is provided, it will be executed.

NOTE: The code itself will NOT re-throw caught exception, but,
[errorHandler](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).errorHandler 'DevFast.Net.Extensions.Etc.Errors.TryExecute<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).errorHandler') may itself re-throw those, if needed.

```csharp
public static void TryExecute<T>(this System.Action lambda, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T> errorHandler, System.Action? finallyClause=null)
    where T : System.Exception;
```
#### Type parameters

<a name='DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).T'></a>

`T`

Exception type
#### Parameters

<a name='DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).lambda'></a>

`lambda` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Lambda to execute inside try clause

<a name='DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).errorHandler'></a>

`errorHandler` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[System.Runtime.ExceptionServices.ExceptionDispatchInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.ExceptionServices.ExceptionDispatchInfo 'System.Runtime.ExceptionServices.ExceptionDispatchInfo')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T](DevFast.Net.Extensions.Etc.Errors.md#DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).T 'DevFast.Net.Extensions.Etc.Errors.TryExecute<T>(this System.Action, System.Action<System.Runtime.ExceptionServices.ExceptionDispatchInfo,T>, System.Action).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

Error handler to invoke inside catch clause

<a name='DevFast.Net.Extensions.Etc.Errors.TryExecute_T_(thisSystem.Action,System.Action_System.Runtime.ExceptionServices.ExceptionDispatchInfo,T_,System.Action).finallyClause'></a>

`finallyClause` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

Code to run inside finally clause