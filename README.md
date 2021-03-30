# Multi-Factor Authentication for Microsoft ADFS 2019/2016/2012r2 (with biometric authentication)
___

This project can help you to implement multi-factor authentication without requiring any additional provider.

You can download a fully functional solution or modify the source code to build your own solution.

MFA helps secure user sign-ins for on-premise or cloud services beyond just a single password. With MFA, users are required to enter a confirmation code, which is send to their phones, email account or via an authenticator application (Microsoft authentication, Google Authentication)after correctly entering their passwords.

**What I Know (password) and What I Hold (device) or What I Am (biometrics) are the keys of MFA.**

For example, if you user password is compromised by a hacker, he can’t activate your application (business email) because **You have** the code that can grant access to the app.

This extension, allow to use second factor with secondary email code transmission, or TOTP code (Time-based One Time Password) compatible with the Google’s (and others) standard. 

This extension works with Active Directory or an SQL Server Database for storing secret keys.

## Installation & Documentation
* <https://github.com/neos-sdi/adfsmfa/wiki/Home>
## Downloads
* <https://github.com/neos-sdi/adfsmfa/releases>
* <https://github.com/neos-sdi/adfsmfa/releases/download/3.1/adfsmfa.3.1.2103.7.msi>

___
![Neos Logo](logo.png)

___
## Features
* Localized UI French/English/Spanish/Italian/German/Dutch/Portuguese/Polish/Swedish/Romanian/Russian/Danish/Japanese, Quebec
* TOTP, Email, Phone, Biometric, Azure Providers for MFA
* Run with ADFS 2012 R2, 2016 and 2019
* Secret Keys length (Guid, 128, 256, 384 & 512 bytes) RNG generator
* Secret Keys RSA asymmetric encryption length (2048 bytes) RSA
* Secret Keys AES symmetric encryption length (512/1024) AES128, AES256
* Secret Keys custom encryption (when implementing ISecretKeyManager and ISecretKeyManagerActivator)
* PowerShell cmdlets for managing MFA properies and MFA Users
* MMC Console for managing MFA properies and MFA Users
* Can use ADDS customizable attributes or SQL-Server Database, or develop a Custom Storage component
* Can send TOTP code by email (customizable template in resources)
* Can send TOTP code by sms (customizable and extensible with API (IExternalProvider interface))
* Can use TOTP code using Authenticator Apps like MS Authenticator, Google Authentication and more
* Biometric authentication (WebAuthN/FIDO2) (Anders Åberg, Alex Seigler and others <https://github.com/abergs/fido2-net-lib>)
* Enable self-registration
* Enable self-registration with QR code (George Mamaladze and his team <https://qrcodenet.codeplex.com>)
* Enable custom change password.
* Can work with ADDS multi-forests with trust relationships
* Can work with LDAP 3.0 Providers (ADFS2016/2019) when using SQL Storage mode
* Full sample for Azure MFA (additional configuration tasks and costs implied)
* Developers can easily extend this component for other verification modes (Azure MFA, RSA,…) with the IExternalProvider, ISecretKeyManager interfaces
* Developers can easily extend this component for other storages modes (AD & SQL by default)
* Full support for ADFS 2019 themes

## Remarks
* Due to security, Developers must sign their Visual Studio Solution with a certificate .pfx
* You must deploy the solution on each of your ADFS servers, not on Proxy Servers.
* To work with ADDS, the ADFS Service account must have read and write to users properties (or use the superaccount feature).
* To work with SQL Server Database, you must deploy the database on a separate SQL Server
* Working with ADFS Windows server 2012r2, 2016 and 2019
