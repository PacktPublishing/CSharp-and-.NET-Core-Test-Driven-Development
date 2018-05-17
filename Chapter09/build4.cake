var configuration = Argument("Configuration", "Release");
Task("Execute-Test")
    .Does(() =>
    {
        var testProjects =
GetFiles("./LoanApplication.Tests.Unit/*.csproj");
        foreach(var testProject in testProjects)
        {
            DotNetCoreTool(
                projectPath: testProject.FullPath,
				                command: "xunit",
                arguments: $"-configuration {configuration} -diagnostics -
stoponfail"
            );
        }
    });