# StringOrdinal.Core
Create ordinal string in c#

[![NuGet](https://img.shields.io/nuget/dt/StringOrdinal.Core.svg)](https://www.nuget.org/packages/StringOrdinal.Core) 
[![NuGet](https://img.shields.io/nuget/vpre/StringOrdinal.Core.svg)](https://www.nuget.org/packages/StringOrdinal.Core)
[![license](https://img.shields.io/github/license/bioyeneye/StringOrdinal.Core.svg)](https://github.com/bioyeneye/StringOrdinal.Core/blob/master/LICENSE)


### Install with nuget

```
Install-Package StringOrdinal.Core
```

### Install with .NET CLI
```
dotnet add package StringOrdinal.Core
```

#### Usage

```csharp
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(1.ConstructNumberToOrdinal());
        Console.WriteLine("34".ConvertToSuperScript());
    }
}
```

#### Result
```text
1ˢᵗ
³⁴
```
