# .Net / C# guide

This is a summary result of the exercises propouses by microsoft tutorials. The progress for each topics can be reviewed in each commit.

## Pre requisites
* Install .Net SDK. For more information see https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install
* Check everthing installed correctly. Open a new command prompt and run the following command

~~~
dotnet
~~~

If the command runs, printing out information about how to use dotnet, you're good to go.

## Create a Console Project
Open a new command prompt and run the following command
~~~
dotnet new console -o <app name>
~~~

The dotnet command creates a new application of type console for you. The -o parameter creates a directory named myApp where your app is stored, and populates it with the required files. The cd myApp command puts you into the newly created app directory.

## Run your App
Enter in your project at command prompt and run the following command
~~~
docker run
~~~

## Working with numbers
### Integers
The int type represents an integer, a zero, positive, or negative whole number. You use the + symbol for addition. Other common mathematical operations for integers include:

* \- for subtraction
* \* for multiplication
* \/ for division

The C# language defines the precedence of different mathematics operations with rules consistent with the rules you learned in mathematics. Multiplication and division take precedence over addition and subtraction.
However, in C#, Integers division always produces an integer result. Integer division truncates the result.

#### Integers limits and precision
The C# integer type differs from mathematical integers in one other way: the int type has minimum and maximum limits.
With the next line we can found this limits:

~~~
int min = int.MinValue;
int max = int.MaxValue;

// Show limits for int type
Console.WriteLine($"The range of integers is {min} to {max}");
~~~
Result
~~~
The range of integers is -2147483648 to 2147483647
~~~

If a calculation produces a value that exceeds those limits, you have an underflow or overflow condition. The answer appears to wrap from one limit to the other.
