# Scripts

As we’ve seen so far, our **own scripts** can also be added as **components** to **GameObjects**.

This is one of the most powerful features of Unity, because it allows us to define **custom behavior** and logic that extend the engine’s built-in functionality.

#### Requirements

For a script to be attached as a component, it must meet two essential conditions:

1. The **class name** and the **file name** must be **identical**.

For example, if the file is named `PlayerMovement.cs`, the class must be declared as:

```csharp
public class PlayerMovement : MonoBehaviour
```

{% hint style="danger" %}
If the names don’t match, Unity will not recognize the script as a valid component.
{% endhint %}

2. The class must inherit from `MonoBehaviour`, which is the base class for all Unity scripts that interact with GameObjects. By inheriting from `MonoBehaviour`, the script gains access to Unity’s event-driven lifecycle and can use special methods such as:

```csharp
Start() // called once when the GameObject is initialized.
Update() // called once per frame, ideal for continuous behavior like movement.
FixedUpdate() // used for physics-based updates.
OnCollisionEnter() and OnTriggerEnter() // handle collision events.
OnDestroy() // called when the GameObject is destroyed.
```

If these two requirements are met, we need to attach the script to a GameObject in order to be executed.
