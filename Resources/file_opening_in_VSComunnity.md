# Notes of file opening in VSComunnity

An "easy" way (i found) to write relative paths that are actually root paths:


```
using System;
using System.Reflection;

namespace Testing
{
    public static class Lesson_X
    {
        static void Main(string[] args)
        {
			string lesson = "Lesson_X";
			string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Remove(0,6);
			rootPath = rootPath.Remove(rootPath.IndexOf("Lesson_"));
			rootPath = Path.Combine(rootPath, $"{lesson}\\{lesson}\\");
			// Console.WriteLine(rootPath);

			string sourcePath = Path.Combine(rootPath, "Files\\file01.txt"); // Relative path to the main directory in the second argument.
			// Console.WriteLine(sourcePath);
			string targetPath = Path.Combine(rootPath, "Files\\file02.txt"); // Relative path to the main directory in the second argument.
			// Console.WriteLine(targetPath);
        }
    }
}
```

Of course this is considering the way I'm writing my files/creating my projects in this repository.