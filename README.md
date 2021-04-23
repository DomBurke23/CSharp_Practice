# CSharp_Practice

implicit conversion: happens automatically if no data will be lost in the conversion. That’s why it’s possible to convert an int (which can hold less data) to a double (which can hold more), but not the other way around.
explicit conversion: requires a cast operator to convert a data type into another one. So if we do want to convert a double to an int, we could use the operator (int).

There are several built-in methods that we can use to manipulate numerical data and perform more complex mathematical calculations. Here are a few:
- Math.Abs()—will find the absolute value of a number. Example: Math.Abs(-5) returns 5.
- Math.Sqrt()—will find the square root of a number. Example: Math.Sqrt(16) returns 4.
- Math.Floor()—will round the given double or decimal down to the nearest whole number. Example: Math.Floor(8.65) returns 8.
- Math.Min()—returns the smaller of two numbers. Example: Math.Min(39, 12) returns 12.

.Substring() grabs part of a string using the specified character position and continues until the end of the string and returns a new string. 
.IndexOf() is usually used first to get the specific character position.

methods - A method is a reusable set of instructions that perform a specific task.

method overloading -  is useful if you want the same method to have different behavior based on its inputs.

expression-bodied definitions and lambda expressions. “These are shortcuts for defining methods!” 
expression-bodied definitions can only be used when a method contains one expression. 
lambda expressions, are great for situations when you need to pass a method as an argument.

Data structures are formats designed to store larger amounts of information in an organized fashion. An array is one very basic data structure. 
Array.Sort() - sorts the array. If it is an array of integer values, it will sort them into ascending values (lowest to highest). If it’s an array of string values, they would be sorted alphabetically.
Array.IndexOf() - takes a value and returns its index. IndexOf() works best when you have a specific value and need to know where it’s located in the array (or if it even exists!). IndexOf() typically takes two parameters: the first is the array and the second is the value whose index we’re locating. IndexOf() also has several overloads that allow you to search for a specific range of the array. If the value appears more than once in an array, it returns only the first occurrence within the specified range. If it cannot find the value, it returns the lower bound of the array, minus 1 (since most arrays start at 0, it’s usually -1).
Array.Find() - searches a one-dimensional array for a specific value or set of values that match a certain condition and returns the first occurrence in the array. Find() takes two parameters: the first is the array and the second is a predicate that defines what we’re looking for. A predicate is a method that takes one input and outputs a boolean. Unlike IndexOf(), Find() returns the actual values that match the condition, instead of their index. It’s customary to use a lambda function for the predicate to determine if the value meets the necessary criteria. 
Array.Copy() copies a range of elements from one array to a second array. It takes three parameters: the name of the array to be copied, the new array, and the length of the array elements.
Array.Reverse() will switch the order of elements in an entire array. It can also reverse them in a portion of an array.
Array.Clear() sets a range of elements in an array to the default value. It takes three parameters: the name of the array, the starting index of the range to clear, and the number of elements to clear. To clear an entire array, set the index to 0 (if it is zero-indexed) and then pass in the length of the array for the third parameter.

while loops are good when you know your stopping condition, but not when you know how many times you want a program to loop or if you have a specific collection to loop through.
do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.
for loops are best if you want something to run a specific number of times, rather than given a certain condition.
foreach loops are the best way to loop over an array, or any other collection.
At any point within a loop block, you can end it by using the break keyword.
The continue keyword is used to bypass portions of code. It will ignore whatever comes after it in the loop and then will go back to the top and start the loop again.
The return keyword is another way to exit a loop, specifically loops that are used within a method. When a return is used within such a loop, it breaks out of the loop and returns control to the point in the program where the method was called.

In C#, a custom data type is defined with a class, and each instance of this type is an object. 
A custom data type is defined by a class.
An instance of a class is called an object. Multiple, unique objects can be instantiated from one class.
This process of bundling related data and methods into a type is called encapsulation, and it makes code easier to organize and reuse.
