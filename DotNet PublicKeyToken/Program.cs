using System;
using System.Reflection;

//ref link:https://www.youtube.com/watch?v=7OX3voZI-2w&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=18
//

//----4 Assembly IDENTIFYER---
// 1- Name
// 2- Version
// 3- Public Key    
// 4- Culture

/*
 * 
C:\Users\sunny\source\repos\DotNet PublicKeyToken>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet PublicKeyToken

27/09/2023  06:09 am    <DIR>          .
27/09/2023  06:09 am    <DIR>          ..
27/09/2023  06:11 am    <DIR>          DotNet PublicKeyToken
27/09/2023  06:09 am             1,169 DotNet PublicKeyToken.sln
               1 File(s)          1,169 bytes
               3 Dir(s)  488,678,232,064 bytes free

C:\Users\sunny\source\repos\DotNet PublicKeyToken>cd DotNet PublicKeyToken

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken

27/09/2023  06:11 am    <DIR>          .
27/09/2023  06:11 am    <DIR>          ..
27/09/2023  06:08 am               189 App.config
27/09/2023  06:08 am    <DIR>          bin
27/09/2023  06:09 am             2,392 DotNet PublicKeyToken.csproj
27/09/2023  06:08 am    <DIR>          obj
27/09/2023  06:11 am               413 Program.cs
27/09/2023  06:08 am    <DIR>          Properties
               3 File(s)          2,994 bytes
               5 Dir(s)  488,678,223,872 bytes free

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>sn -k KulpotKey.key

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Key pair written to KulpotKey.key

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>sn -p KulpotKey.key KulpotPublicKey.key

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Public key written to KulpotPublicKey.key

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken

27/09/2023  06:14 am    <DIR>          .
27/09/2023  06:14 am    <DIR>          ..
27/09/2023  06:08 am               189 App.config
27/09/2023  06:08 am    <DIR>          bin
27/09/2023  06:09 am             2,392 DotNet PublicKeyToken.csproj
27/09/2023  06:13 am               596 KulpotKey.key    <------------for assigning my assemblies
27/09/2023  06:14 am               160 KulpotPublicKey.key <-------------for public uses
27/09/2023  06:08 am    <DIR>          obj
27/09/2023  06:14 am             2,332 Program.cs
27/09/2023  06:08 am    <DIR>          Properties
               5 File(s)          5,669 bytes
               5 Dir(s)  488,676,622,336 bytes free

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>sn -tp KulpotPublicKey.key

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Public key (hash algorithm: sha1):
0024000004800000940000000602000000240000525341310004000001000100cdbeb20c4d3acb
2dd8acf692bca529ddcf1e115c4b8abf7705cbf01cf84a3b454611dcfc077ebdeb567cf3df70c1
e332cdd723a592888806b63cb3ff7cbfba21103743b21da43fa8c1fcbfa913de759516ba447ad6
9c96749b0418efb901b6daeb7fcd5bf43f40957d9331e1de7ca1d417e43bd15485ab5fe2ebe3ae
e0fd85f6

Public key token is 19c19275db557b25

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken

27/09/2023  06:18 am    <DIR>          .
27/09/2023  06:18 am    <DIR>          ..
27/09/2023  06:08 am               189 App.config
27/09/2023  06:08 am    <DIR>          bin
27/09/2023  06:09 am             2,392 DotNet PublicKeyToken.csproj
27/09/2023  06:13 am               596 KulpotKey.key
27/09/2023  06:14 am               160 KulpotPublicKey.key
27/09/2023  06:08 am    <DIR>          obj
27/09/2023  06:18 am             3,900 Program.cs
27/09/2023  06:08 am    <DIR>          Properties
               5 File(s)          7,237 bytes
               5 Dir(s)  488,679,002,112 bytes free

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>erase KulpotPublicKey.key

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>csc /keyfile:KulpotKey.key /out:Farm.dll /t:library Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken

27/09/2023  06:20 am    <DIR>          .
27/09/2023  06:20 am    <DIR>          ..
27/09/2023  06:08 am               189 App.config
27/09/2023  06:08 am    <DIR>          bin
27/09/2023  06:09 am             2,392 DotNet PublicKeyToken.csproj
27/09/2023  06:20 am             4,096 Farm.dll
27/09/2023  06:13 am               596 KulpotKey.key
27/09/2023  06:08 am    <DIR>          obj
27/09/2023  06:19 am             4,850 Program.cs
27/09/2023  06:08 am    <DIR>          Properties
               5 File(s)         12,123 bytes
               5 Dir(s)  488,678,268,928 bytes free

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>ildasm /out:meil.txt Farm.dll

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>meil.txt
---------------NOTEPAD: meil.txt------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Farm  <----------------The Manifest of Assembly Identifier
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .publickey = (00 24 00 00 04 80 00 00 94 00 00 00 06 02 00 00   // .$..............
                00 24 00 00 52 53 41 31 00 04 00 00 01 00 01 00   // .$..RSA1........
                CD BE B2 0C 4D 3A CB 2D D8 AC F6 92 BC A5 29 DD   // ....M:.-......).
                CF 1E 11 5C 4B 8A BF 77 05 CB F0 1C F8 4A 3B 45   // ...\K..w.....J;E
                46 11 DC FC 07 7E BD EB 56 7C F3 DF 70 C1 E3 32   // F....~..V|..p..2
                CD D7 23 A5 92 88 88 06 B6 3C B3 FF 7C BF BA 21   // ..#......<..|..!
                10 37 43 B2 1D A4 3F A8 C1 FC BF A9 13 DE 75 95   // .7C...?.......u.
                16 BA 44 7A D6 9C 96 74 9B 04 18 EF B9 01 B6 DA   // ..Dz...t........
                EB 7F CD 5B F4 3F 40 95 7D 93 31 E1 DE 7C A1 D4   // ...[.?@.}.1..|..
                17 E4 3B D1 54 85 AB 5F E2 EB E3 AE E0 FD 85 F6 ) // ..;.T.._........
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Farm.dll
// MVID: {CD892837-2735-4696-A2D5-5E13E90ADF74}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000009    //  ILONLY
// Image base: 0x06CB0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class public auto ansi beforefieldinit Cow
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Moo() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "I am good moo code"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method Cow::Moo

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Cow::.ctor

} // end of class Cow


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file meil.res


---------------NOTEPAD: meil.txt------------------------END

------------Created------------Program.exe r:Farm.dll-----------

//[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("I am good moo code");
//    }
//}

class MeMainClass
{
    static void Main()
    {
        Cow.Moo();
    }
}

-------------------------------------------
 
C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>csc /r:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken

27/09/2023  06:26 am    <DIR>          .
27/09/2023  06:26 am    <DIR>          ..
27/09/2023  06:08 am               189 App.config
27/09/2023  06:08 am    <DIR>          bin
27/09/2023  06:09 am             2,392 DotNet PublicKeyToken.csproj
27/09/2023  06:20 am             4,096 Farm.dll
27/09/2023  06:13 am               596 KulpotKey.key
27/09/2023  06:21 am               636 meil.res
27/09/2023  06:21 am             5,730 meil.txt
27/09/2023  06:08 am    <DIR>          obj
27/09/2023  06:25 am            12,511 Program.cs
27/09/2023  06:26 am             4,096 Program.exe
27/09/2023  06:08 am    <DIR>          Properties
               8 File(s)         30,246 bytes
               5 Dir(s)  488,671,748,096 bytes free

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>Program.exe
I am good moo code

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>ildasm /out:moo.txt Program.exe

C:\Users\sunny\source\repos\DotNet PublicKeyToken\DotNet PublicKeyToken>moo.txt
-----------------NOTEPAD: moo.txt--------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern Farm
{
  .publickeytoken = (19 C1 92 75 DB 55 7B 25 )                         // ...u.U{%
  .ver 1:0:0:0
}
.assembly Program
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Program.exe
// MVID: {1811CC7E-4109-4569-ACC7-4DF0209E83FD}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x069D0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit MeMainClass
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  call       void [Farm]Cow::Moo()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MeMainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MeMainClass::.ctor

} // end of class MeMainClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res


-----------------NOTEPAD: moo.txt--------------------------END

 
 
 
 * 
 */




//[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("I am good moo code");
//    }
//}

class MeMainClass
{
    static void Main()
    {
        Cow.Moo();
    }
}