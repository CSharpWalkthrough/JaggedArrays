# Jagged Arrays

## One dimensional arrays review

In C#, an array consists of elements of the same type. For example:

```c#
  int[] arrOne = new int[] { 5, 6, 10, -25 };
  string[] arrTwo = new string[] { "This", "is", "an", "array" };
```

and even use classes:

```c#
  public class Person {
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
      this.Name = name;
      this.Age = age;
    }
  }

  // ** code omitted for simplicity **

  Person jack = new Person("Jack", 23);
  Person alice = new Person("Alice", 18);
  Person[] people = new Person[] { jack, alice };
```

## Introduction to jagged arrays

Now what if this time, we wanted to have an array of... arrays!?

Our code would look something like this:

```c#
  // The following array will have two rows
  int[][] jaggedArray = new int[2][];
  jaggedArray[0] = new int[2];
  jaggedArray[1] = new int[] { 3, 4, 5, 6 };

  //Visually our array looks like this:
  // 0 0
  // 3 4 5
```

or like so:

```c#
  int[][] jaggedArrayTwo = new int[][]
  {
    new int[2],
    new int[] { 3, 4, 5, 6 }
  };
```

If we take a look closely, you'll notice that the two arrays inside our main
array have differents lengths! (This is not always the case but is possible like
seen in the example above).

This is the reason why we can NOT initialize a jagged array like follows:

```c#
  // This code will not compile
  int[][] arr = new int[2][3];
```

## Accessing values inside a jagged array

```c#
  int[][] numbers =
  {
      new int[] { 1, 3, 5, 7, 9 },
      new int[] { 0, 2, 4, 6 },
      new int[] { 11, 22 }
  };

  // Retrieves values from jagged array
  Console.WriteLine("Row 0, Column 0: " + numbers[0][0]); // 1
  Console.WriteLine("Row 1, Column 2: " + numbers[1][2]); // 4
  Console.WriteLine("Row 2, Column 1: " + numbers[2][1]); // 22

  Console.WriteLine();

  // Sets values to jagged array
  numbers[0][0] = 20;
  numbers[1][2] = -10;

  Console.WriteLine("Row 0, Column 0: " + numbers[0][0]); // 20
  Console.WriteLine("Row 1, Column 2: " + numbers[1][2]); // -10
```

### Resources

[Jagged Arrays - Microsoft docs](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays)

[Jagged Arrays vs Multidimensional Arrays - Stack Overflow](https://stackoverflow.com/q/4648914/13358772)
