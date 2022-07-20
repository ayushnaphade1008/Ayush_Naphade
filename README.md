# Ayush_Naphade
Compile time vs Runtime
Compile-time and Runtime are the two programming terms used in the software development.
Compile-time is the time at which the source code is converted into an executable code while
the run time is the time at which the executable code is started running. Both the compile-time
and runtime refer to different types of error.

Compile-time errors
Compile-time errors are the errors that occurred when we write the wrong syntax.
If we write the wrong syntax or semantics of any programming language,
then the compile-time errors will be thrown by the compiler.
The compiler will not allow to run the program until all the errors are removed from the program.
When all the errors are removed from the program, then the compiler will generate the executable file.

The compile-time errors can be:
Syntax errors:
When the programmer does not follow the syntax of any programming language, then the compiler will throw the syntax error.

For example,
int a, b:
The above declaration generates the compile-time error as in C, every statement ends with the semicolon,
but we put a colon (:) at the end of the statement.

Semantic errors
The semantic errors exist when the statements are not meaningful to the compiler.
For example,
a+b=c;
The above statement throws a compile-time errors. In the above statement, 
we are assigning the value of 'c' to the summation of 'a' and 'b' which is not
possible in C programming language as it can contain only one variable on the left
of the assignment operator while right of the assignment operator can contain more than one variable.

The above statement can be re-written as:

c=a+b;

Runtime errors
The runtime errors are the errors that occur during the execution and after compilation.
The examples of runtime errors are division by zero, etc.
These errors are not easy to detect as the compiler does not point to these errors.
