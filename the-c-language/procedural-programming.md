# Procedural programming

Methods, as in many typical languages, expose the **type and number of parameters** as well as the **return type**.

* If nothing is returned, `void` is specified.
* We can add access modifiers.
* They can be instance methods or class methods (`static`).

```csharp
public static void classMethod(int a, double d){ }

private double instanceMethod(){ return 0.0; }
```

### **Input Parameters**

* By default, arguments are passed **by value**:

```csharp
void f1() 
{
    int k = 6;
    f2(k);     // Passed by value, remains unchanged
    print(k);  // 6
}

void f2(int x) 
{
    x++;       // Original value not affected
}
```

* It is also possible to pass **by reference**, explicitly, using the `ref` keyword.
* The variable passed as an argument must be initialized:

```csharp
void f1() {
    int k = 6;       // MUST INITIALIZE
    f2(ref k);       // Pass by ref
    print(k);        // 7
}

void f2(ref int x) 
{
    x++;             // Original value affected!
}
```

#### Example in Unity

```csharp
using UnityEngine;

public class RefExample : MonoBehaviour
{
    void Start()
    {
        Vector3 position = new Vector3(1, 2, 3);
        Debug.Log("Before: " + position);  // Output: Before: (1.0, 2.0, 3.0)

        ModifyPosition(ref position);

        Debug.Log("After: " + position);   // Output: After: (2.0, 4.0, 6.0)
    }

    void ModifyPosition(ref Vector3 pos)
    {
        pos *= 2;
    }
}
```

***

### **Output Parameters**

* These are used to simulate **multiple return values**, by assigning a value to one or more parameters.
* They **do not need to be initialized**.
* We use the `out` keyword:

```csharp
void f1() { 
    if (f2(out int n))
        print(n);    // 255
}
    
bool f2(out int p) 
{
    p = 255;
    return true;
}
```
