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
Para que un miembro se pueda editar desde el editor de Unity (e.g., la velocidad X y Z de la esfera), ha de ser:

* Variable de instancia
* Modificador `public`
* Tipo serializable (la mayoría de tipos lo son, pero hay excepciones, como los diccionarios)
{% endhint %}
