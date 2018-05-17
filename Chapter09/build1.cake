#tool "nuget:?package=xunit.runner.console"
Task("Execute-Test")
    .Does(() =>
    {
        var assemblies =
GetFiles("./LoanApplication.Tests.Units/bin/Release/LoanApplication.Tests.Unit.dll");
        XUnit2(assemblies,
         new XUnit2Settings {
            Parallelism = ParallelismOption.All,
            HtmlReport = true,
            NoAppDomain = true,
            OutputDirectory = "./build"
        });
    });