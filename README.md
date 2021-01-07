## APICore.Utility.Templates
### Description
The Solution consists of three API templates on .NETCoreApp 3.1 framework.

Each API template provides connectivity to:
* Oracle DB
* SQL Server
* MondoDB

For each template an example model is created which can be used as a Code first approach model or scafoled as a database first approach
A controller with the standard methodes(verbs) is created.

In **_appsettings.json_** connection parameters have to be replaced (exp:Server=localhost; user id=xxxx, the values localhost and xxxx are the host input)

### Usage
Once installed the templates can be called as such(.NET CLI):

`dotnet new oracle`

`dotnet new sqlapi`

`dotnet new mongoapi`

### Installation:
`dotnet new --install APICore.Utility.Templates::1.0.1`
