# Practical Test-Driven Development using C# 7
This is the code repository for [Practical Test-Driven Development using C# 7](https://www.packtpub.com/web-development/practical-test-driven-development-using-c-7?utm_source=github&utm_medium=repository&utm_campaign=9781788398787), published by [Packt](https://www.packtpub.com/?utm_source=github). It contains all the supporting project files necessary to work through the book from start to finish.
## About the Book
This book guides developers to create robust, production-ready C# 7 and .NET Core applications through the practice of test-driven development process.

In C# and .NET Core Test-Driven Development, you will learn the different stages of the TDD life cycle, basics of TDD, best practices, and anti-patterns. It will teach you how to create an ASP.NET Core MVC sample application, write testable code with SOLID principles and set up a dependency injection for your sample application. Next, you will learn the xUnit testing framework and learn how to use its attributes and assertions. You’ll see how to create data-driven unit tests and mock dependencies in your code. You will understand the difference between running and debugging your tests on .NET Core on LINUX versus Windows and Visual Studio. As you move forward, you will be able to create a healthy continuous integration process for your sample application using GitHub, TeamCity, Cake, and Microsoft VSTS.

By the end of this book, you will have learned how to write clean and robust code through the effective practice of TDD, set up CI build steps to test and build applications as well as how to package application for deployment on NuGet.
## Instructions and Navigation
All of the code is organized into folders. Each folder starts with a number followed by the application name. For example, Chapter02.



The code will look like the following:
```
public class SMTPGateway
{
    private static SMTPGateway smtpGateway=null;
    private static object lockObject= new object();

    private SMTPGateway()
    {
    }

    public static SMTPGateway SMTPGatewayObject
    {
        get
        {
            lock (lockObject)
            {
                if (smtpGateway==null)
                {
                    smtpGateway = new SMTPGateway();
                }
            }
            return smtpGateway;
        }
    }
}
```



## Related Products
* [C# 7 and .NET Core 2.0 High Performance](https://www.packtpub.com/application-development/c-7-and-net-core-20-high-performance?utm_source=github&utm_medium=repository&utm_campaign=9781788470049)

* [Introducing Test Driven Development in C# [Video]](https://www.packtpub.com/application-development/introducing-test-driven-development-c-video?utm_source=github&utm_medium=repository&utm_campaign=9781788292092)

* [Beginning Modern C# and .NET Development](https://www.packtpub.com/application-development/beginning-modern-c-and-net-development-elearning-video?utm_source=github&utm_medium=repository&utm_campaign=9781789137705)

### Suggestions and Feedback
[Click here](https://docs.google.com/forms/d/e/1FAIpQLSe5qwunkGf6PUvzPirPDtuy1Du5Rlzew23UBp2S-P3wB-GcwQ/viewform) if you have any feedback or suggestions.
