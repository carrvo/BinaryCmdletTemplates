# Binary Cmdlet Templates

[Visual Studio templates](https://learn.microsoft.com/en-us/visualstudio/ide/how-to-create-project-templates?view=vs-2022) to help accelerate the creation and development of [binary cmdlets](https://learn.microsoft.com/en-us/powershell/scripting/developer/cmdlet/cmdlet-overview?view=powershell-7.4).
Binary cmdlets differ from script cmdlets in that they are written in C# and compiled first;
allowing them to leverage both compile-time type checking and the performance of compiled code.

## `$safeprojectname$`

This template is for writing a binary cmdlet!

## `$safeprojectname$.UnitTests`

This template is for writing [XUnit](https://xunit.net/) tests against your binary cmdlet.
As an added benefit, they demonstrate how your other C# applications
can use and take advantage of your binary cmdlets, without PowerShell involvement!

## `$safeprojectname$.Examples`

This template is for PowerShell example usage of your binary cmdlet.
As an added benefit, they can serve as functional tests written in [Pester](https://pester.dev/).
