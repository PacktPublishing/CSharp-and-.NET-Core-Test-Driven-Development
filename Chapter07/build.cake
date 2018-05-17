//Arguments
var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var solution = "./Chapter7.sln";

// Define directories.
var buildDir = Directory("./LoanApplication.Core/bin") + Directory(configuration);

//Tasks
Task("Clean")
    .Does(() =>
{
    CleanDirectory(buildDir);
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
	Information("Restoring NuGet Packages");
    DotNetCoreRestore();
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{
	Information("Build Solution");
    DotNetCoreBuild(solution,
           new DotNetCoreBuildSettings()
                {
                    Configuration = configuration
                });
    
});

Task("Run-Tests")
    .IsDependentOn("Build")
    .Does(() =>
{
	 var testProjects = GetFiles("./LoanApplication.Tests.Unit/*.csproj");
		foreach(var project in testProjects)
        {
            DotNetCoreTool(
                projectPath: project.FullPath, 
                command: "xunit", 
                arguments: $"-configuration {configuration} -diagnostics -stoponfail"
            );
        }
        
});

Task("Default")
    .IsDependentOn("Run-Tests");

RunTarget(target);