# Structs

Apart from classes, C# also allows the definition of `structs`.

* Similar to a class, instances of this type (e.g., [`Vector3`](https://docs.unity3d.com/ScriptReference/Vector3.html)) are stored on the **stack**
* They can contain methods
* Since they are on the stack, access to them is faster, but they cannot have constructors, destructors, implement inheritance mechanisms, or be abstract

```csharp
struct MyVector3 { 
   float x, y, z;
}

// ...

MyVector3 v;
v.x = 3.0f; v.y = 1.0f; v.z = 0.0f; 
  
// Equivalente
v = new MyVector3(3.0f, 1.0f, 0.0f);
```
