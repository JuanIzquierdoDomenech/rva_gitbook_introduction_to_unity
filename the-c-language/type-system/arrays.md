# Arrays

Arrays allow us to store a set of elements of the same type in consecutive positions in memory:

* Reference types derived from [`System.Array`](https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-8.0)
* Their index starts at **0**
* They can be serialized to be edited from the editor

***

#### Properties

* **Rank:** Number of dimensions
* **Length**
* **GetLength(dim):** Length of the specified dimension
* ...

```csharp
// ----------------------------------------- 1 Dimension
string[] arr;   // Not initialized
string[] arr2 = new string[10]; // 10 elements
string[] arr3 = { "str1", "str2", "str3" }; // initialized with values
        
print(arr3[0]); // "str1"

foreach (string s in arr3)
{
    ... 
}
   
// ----------------------------------------- 2 or + Dimensions     
string[,] strMat =
{
    {"perro","conejo", "zorro"}, 
    {"gato","caballo", "mariposa"},
    {"loro", "unicornio", "tarantula"}
};
double[,] doubleMat = new double[12,32];    
        
print(strMat[0,1]);          // "conejo"
print(strMat.Length);        // 9
print(strMat.Rank);          // 2
print(strMat.GetLength(1));  // 3

foreach (string s in strMat)
{
    print(s);
}

for (int i = 0; i < strMat.GetLength(0); ++i)
{
    for (int j = 0; j < strMat.GetLength(1); ++j)
    {
        print(strMat[i,j]);
    }
}
```
