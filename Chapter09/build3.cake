var configuration = Argument("Configuration", "Release");
Task("Execute-Restore")
    .Does(() =>
    {
        DotNetCoreRestore();
    });
Task("Execute-Build")
    .IsDependentOn("Execute-Restore")
    .Does(() =>
    {
	        DotNetCoreBuild("./LoanApplication.sln"
           new DotNetCoreBuildSettings()
                {
                    Configuration = configuration
                }
        );
    });
Task("Execute-Test")
    .IsDependentOn("Execute-Build")
    .Does(() =>
    {
        var testProjects =
GetFiles("./LoanApplication.Tests.Unit/*.csproj");
        foreach(var project in testProjects)
        {
            DotNetCoreTest(
                project.FullPath,
                new DotNetCoreTestSettings()
                {
                    Configuration = configuration,
                    NoBuild = true
                }
            );
        }
 });