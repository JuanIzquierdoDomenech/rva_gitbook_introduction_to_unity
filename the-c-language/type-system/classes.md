# Classes

* Supports inheritance, interface implementation, and abstract classes
* To inherit from a superclass, we use the **`:`** operator

```csharp
public class BallMovement : MonoBehaviour {}
```

* The `static` modifier is used to distinguish between instance and class variables
* Typical access modifiers

```csharp
public class ExampleClass : MonoBehaviour
{
    public int publicMember;         // Accesible from everywhere
    private string privateMember;    // Accesible only inside the class
    protected float protectedMember; // Accesible inside the class and subclasses
    
    static int classMember;

    // Constructor, but do not use with classes that inherit from Monobehaviour
    public ExampleClass()
    {
        publicMember = 1;
        privateMember = "Hello";
        protectedMember = 3.14f;
    }
}
```

{% hint style="warning" %}
For a member to be editable within the Unity Editor (e.g., the sphere speed), it must be:

* an instance variable
* `public`
* a serializable type (most of the types are serializable)
{% endhint %}
