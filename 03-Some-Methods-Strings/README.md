# <span style="color:#FFD700"> Methods with strings </span>

Strings in C# are used to store and manipulate textual data. They are a sequence of characters enclosed in double quotation marks. Here are some fundamentals concepts about strings in C#:

1. <span style="color:#B0E0E6"> To declare a string value, you use the 'string' keyword followed by the variable name: </span>

```
string message;
```

2. <span style="color:#B0E0E6"> You can initialize a string variable with a value at the time of declaration: </span>

```
string greeting = "Hello";
```

3. <span style="color:#B0E0E6"> You can concatenate two or more strings using the ' + ' operator: </span>

```
string firsName = "Marc";
string lastName = "Mat";
string fullName = firstName + " " + lastName;
```

4. <span style="color:#B0E0E6"> You can obtain the length of a string using the 'Length' property: </span>

```
string text = "Rocky";
int length = text.Length;
```

5. <span style="color:#B0E0E6"> You can embed variables or expressions within a string using string interpolation. It uses the '$' symbol and curly braces '{}': </span>

```
string name = "Rocky";
int age = 7;
string message = $ "My name is {name} and I am {age} years old.";
```

6. <span style="color:#B0E0E6"> Strings have various useful methods, such as 'ToUpper()', 'ToLower()', 'Substring()', 'IndexOf', many more. </span>