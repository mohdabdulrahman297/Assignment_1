


/*
 
What type would you choose for these “numbers”?
A person’s telephone number: string
This is better than a numeric type because phone numbers can start with zero, include +, or have spaces and dashes. You usually do not do math with them.

A person’s height: double
Height often has decimal values, like 5.8 feet or 170.5 cm, so a decimal number type is useful.

A person’s age: int
Age is a whole number, so int is a simple and common choice.

A person’s gender: enum or string
If the values are fixed, like Male, Female, Prefer Not To Answer, then enum is a good choice. If you want more flexibility, use string.

A person’s salary: decimal
decimal is best for money because it gives better precision than float or double.

A book’s ISBN: string
ISBNs may contain hyphens, and they are identifiers, not values for calculation.

A book’s price: decimal
Money values should usually use decimal.

A book’s shipping weight: double or decimal
Both can work, but decimal is often preferred when you want accurate decimal values.

A country’s population: long
Population can be very large, so long is safer than int.

The number of stars in the universe: BigInteger or long
This number could be extremely large, so BigInteger is the safest choice if you want no limit. long may still be too small depending on the estimate.

Number of employees in small or medium businesses in the UK: int
Since the number is up to about 50,000, int is more than enough.
 
 */



/*
What are the difference between value type and reference type variables? What is
boxing and unboxing?

A value type stores the actual data directly in the variable.

Examples: int, double, bool, struct, enum

If you copy a value type variable, the new variable gets its own copy of the data

A reference type stores a reference to the actual object in memory.

Examples: class, string, arrays

If you copy a reference type variable, both variables can point to the same object

Boxing
Boxing means converting a value type into a reference type object.

Example:

int a = 10;
object obj = a;

Unboxing
Unboxing means converting that object back into the original value type.

Example:

object obj = 10;
int a = (int)obj;


 */


/*
 What is meant by the terms managed resource and unmanaged resource in .NET
A managed resource refers to any object or memory that the .NET runtime and its garbage collector automatically manage and clean up for you. These are typically everyday C# objects like strings, arrays, lists, or custom classes stored in the managed heap—when your code no longer references them, the garbage collector eventually frees their memory without any extra work from you. On the other hand, an unmanaged resource is anything outside the .NET runtime's direct control, such as operating system handles for files (like a FileStream), database connections, network sockets, or COM objects; these don't get automatically cleaned up by the garbage collector, so you must explicitly release them, usually by calling Dispose() or wrapping them in a using statement to avoid issues like resource leaks, locked files, or exhausted connections.
An unmanaged resource is anything outside the .NET runtime's direct control, such as operating system handles for files (like a FileStream), database connections, network sockets, or COM objects; these don't get automatically cleaned up by the garbage collector, so you must explicitly release them, usually by calling Dispose() or wrapping them in a using statement to avoid issues like resource leaks, locked files, or exhausted connections. 
 */

/*
 Whats the purpose of Garbage Collector in .NET?
The garbage collector manages the allocation and release of memory for an application. For developers working with managed code, this means that you don't have to write code to perform memory management tasks. Automatic memory management can eliminate common problems, such as forgetting to free an object and causing a memory leak or attempting to access memory for an object that's already been freed.
 */

/*Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
ulong, float, double, and decimal.

Refer UnderstandingTypes.cs file
 */


/*
 Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!
 
 Refer UnderstandingTypes.cs file
 */

//1.What happens when you divide an int by 0?
//If you divide an int by 0 in C#, the program throws a DivideByZeroException at runtime because integer division by zero is not allowed.
//​

//2. What happens when you divide a double by 0?
//If you divide a double by 0, the program does not crash in the same way as int. Instead, it gives special floating-point values like Infinity, -Infinity, or NaN, depending on the numbers involved.
//​

//3. What happens when an int overflows?
//When an int goes beyond its allowed range, it usually wraps around to the other end of the range unless overflow checking is turned on. For example, if you add 1 to int.MaxValue, it becomes int.MinValue.
//​

//4. What is the difference between x = y++; and x = ++y;?
//In x = y++;, the current value of y is assigned to x first, and then y is increased. In x = ++y;, y is increased first, and then the new value is assigned to x.
//​

//5.What is the difference between break, continue, and return inside a loop?
//break stops the loop completely and moves control outside the loop. continue skips the rest of the current iteration and moves to the next one, while return exits the entire method, not just the loop.
//​

//6. What are the three parts of a for statement, and which are required?
//A for loop has three parts: initialization, condition, and update. In C#, all three parts are optional, which means you can even write an infinite loop like for( ; ; ).
//​

//7. What is the difference between = and ==?
//The = operator is used for assignment, which means it gives a value to a variable. The == operator is used for comparison, which means it checks whether two values are equal.
//​

//8. Does this compile: for (; true;) ;
//Yes, it does compile because all parts of a for loop are optional in C#, and this creates an infinite loop with an empty body.
//​

//9. What does the underscore _ mean in a switch expression?
//In a switch expression, _ means “anything else.” It works like a default case and matches any value that was not matched earlier.

//10. What interface must an object implement to be used in foreach?
//The usual answer is IEnumerable or IEnumerable<T> because those are the standard interfaces used for enumeration in C#. More technically, C# can also use a type that has a suitable GetEnumerator() method, but for most class answers, IEnumerable is the expected one.

