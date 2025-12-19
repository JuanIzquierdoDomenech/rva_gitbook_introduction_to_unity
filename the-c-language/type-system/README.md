# Type system

* In C#, **everything is an OBJECT**, including primitive types.
* C# has a **CTS (Common Type System)** with two families of types: **value** and **reference**.
  * As in Java, a variable of a value/primitive type is stored on the **stack**, while for a reference type variable, the stack holds the reference to where the object is stored in the **heap**.
  * Since C# is **garbage collected**, we don’t need to worry about manually freeing dynamic memory (unlike in C++).

{% hint style="info" %}
The CTS allows interoperability between the different languages of the .NET family.

An **int** in C# and an **Integer** in Visual Basic are both translated into an **Int32** by the CTS.
{% endhint %}

<figure><img src="../../.gitbook/assets/type_system.png" alt=""><figcaption></figcaption></figure>

```csharp
// Line comment
/*
Block comment
*/
using System.Collections.Generic;    // Imports

int a = 123;                         // Value types
float f = 231.443f;

object o = new System.Object();      // use new for Reference types
string s = "Hola";                   // with strings no need to use new
string s2 = $"Adios {a+f}";          // String interpolation

GameObject[] gameObjectArray = new GameObject[10];
List<GameObject> gameObjectList = new List<GameObject>();
Dictionary<int, string> myDict = new Dictionary<int, string>();
```
