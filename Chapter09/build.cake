#tool "nuget:?package=xunit.runner.console"
Task("Execute-Test")
    .Does(() =>
    {
        var assemblies =
GetFiles("./LoanApplication.Tests.Units/bin/Release/LoanApplication.Tests.Unit.dll");
        XUnit2(assemblies);
    });