#tool "nuget:?package=xunit.runner.console"
Task("Execute-Test")
    .Does(() =>
    {
        XUnit2(new []{
"./LoanApplication.Tests.Units/bin/Release/LoanApplication.Tests.Unit.dll"
,
        "./LoanApplication.Tests/bin/Release/LoanApplication.Tests.dll"
    });
    });