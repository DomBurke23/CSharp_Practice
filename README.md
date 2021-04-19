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
