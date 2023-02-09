[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-f4981d0f882b2a3f0472912d15f9806d57e124e0fc890972558857b51b24a6f9.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=9831602)

The nuget package has been published
(dotnet add package reinventing-the-wheel-Logan-Hipshier-Student --version 1.0.0)

The Utility NuGet package provides methods regarding Arrays Strings and Math that are nornally preloaded into these objects however without utilizing the built in methods.
The NuGet package was created to provide developers with functional methods that do not implement prebuilt 'out of the box' methods

String Utilis:
All StringUtils take one string as a parameter and return either a string or an int

StringUtils.ToUpper("banana"); --> BANANA
StringUtils.ToLower("BANANA"); --> banana
StringUtils.Length("Hello"); --> 5
StringUtils.Reverse("Hello") --> olleH
StringUtils.CountVowels("Hello") --> 2
StringUtils.CountConsonants("Hello") --> 3


MathUtils:
All MathUtils are overloaded and take 2 numbers as parameters excluding square root and absulote value

MathUtils.Power(4,3); --> 64
MathUtils.SquareRoot(16); --> 4
MathUtils.AbsoluteValue(-16); --> 16
MathUtils.Min(11,22); --> 11
MathUtils.Max(11,22); --> 22
MathUtils.Add(2,2); --> 4
MathUtils.Subtract(3,2); --> 1
MathUtils.Divide(4,2); --> 2
MathUtils.Divide(4,2); --> 8

ArrayUtils:
All ArrayUtils are overloaded and accept an array as parameters

int[] i {1,2,3}
ArrayUtils.Average(i) -->2
ArrayUtils.Max(i) --> 3
ArrayUtils.Min(i) --> 1
ArrayUtils.SortAscending(i) --> 1,2,3
ArrayUtils.SortDescending(i) --> 3,2,1
ArrayUtils.Sum(i) --> 6
ArrayUtils.Product(i) --> 6


