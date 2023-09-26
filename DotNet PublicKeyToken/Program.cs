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
27/09/2023  06:13 am               596 KulpotKey.key
27/09/2023  06:14 am               160 KulpotPublicKey.key
27/09/2023  06:08 am    <DIR>          obj
27/09/2023  06:14 am             2,332 Program.cs
27/09/2023  06:08 am    <DIR>          Properties
               5 File(s)          5,669 bytes
               5 Dir(s)  488,676,622,336 bytes free

 
 
 
 
 * 
 */




[assembly: AssemblyVersion("1.0.0.0")]

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("I am good moo code");
    }
}