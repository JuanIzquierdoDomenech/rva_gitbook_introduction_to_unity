# Scene view

The **Scene view** is the main view in which we will edit "the world," the levels, the application screens...

{% hint style="warning" %}
A **Scene** will be composed of **GameObjects** with specific purposes (_cameras_, _lights_, _players_, _trees_, _buttons_, _texts_, _images_...). These **GameObjects** are generic (an element at a position, rotation, and scale in the world) and we will specialize them through **components**/scripts.

Additionally, a Scene in Unity is a serializable resource/asset (saved to disk) that we can use to store levels or screens of our game/application. This means that a 'Game' is made of different Scenes.
{% endhint %}

<figure><img src="../.gitbook/assets/scene_view.png" alt=""><figcaption><p>The 'default' scene has a directional light (i.e., sun) and a camera. We can see this through their gizmos/icons in the scene, and in the <strong>Hierarchy</strong> view</p></figcaption></figure>

### Moving ourselves inside the Scene view

It is possible to move within the **Scene** view to edit the current scene/level/screen.

To select the action to perform, we have a toolbar within the **Scene** view itself:

<figure><img src="../.gitbook/assets/scene_toolbar.png" alt=""><figcaption><p>Tools to move ourselves inside the <strong>Scene</strong> view, but also, the elements inside the scene</p></figcaption></figure>

{% tabs %}
{% tab title="View Tool" %}
**Shortcut**: **Q** Key&#x20;

This tool allows us to navigate through the scene.

* With _Click & Drag_ in the scene, we will move along the X/Y plane according to the camera's orientation,
* _Ctrl + Click & Drag_ we will zoom (also with the mouse wheel or trackpad)
* _Alt/Option + Click & Drag_ we will orbit around the origin, or around a selected GameObject (Double-click)

<figure><img src="../.gitbook/assets/view_tool.gif" alt=""><figcaption></figcaption></figure>
{% endtab %}

{% tab title="Move Tool" %}
**Shortcut**: **W** Key

After creating an object in the scene (Top Menu _GameObject_ → _3D Object_ → _Cube_),

Allows you to modify the object's position:

<figure><img src="../.gitbook/assets/move_tool.gif" alt=""><figcaption></figcaption></figure>
{% endtab %}

{% tab title="Rotate Tool" %}
**Shortcut**: **E** Key

After creating an object in the scene (Top Menu _GameObject_ → _3D Object_ → _Cube_),

Allows you to modify the object's rotation:

<figure><img src="../.gitbook/assets/rotate_tool.gif" alt=""><figcaption></figcaption></figure>
{% endtab %}

{% tab title="Scale Tool" %}
**Shortcut**: **R** Key

After creating an object in the scene (Top Menu _GameObject_ → _3D Object_ → _Cube_),

Allows you to modify the object's scale:

<figure><img src="../.gitbook/assets/scale_tool.gif" alt=""><figcaption></figcaption></figure>
{% endtab %}

{% tab title="Rect Tool" %}
**Shortcut**: **T** Key

This tool is specific for editing the GUI.

<figure><img src="../.gitbook/assets/gui_tool.png" alt=""><figcaption></figcaption></figure>
{% endtab %}
{% endtabs %}

### Swapping between _Perspective_ and _Isometric_ views

<figure><img src="../.gitbook/assets/iso_pers_comparison.gif" alt=""><figcaption></figcaption></figure>

In the **top-right corner** of the **Scene view**, there’s a **Gizmo** that we can use to:

* **Align the Scene camera** to a **specific axis**
* **Switch between** **Perspective** and **Isometric** view modes

This Gizmo is very useful for **navigating and orienting** yourself within the 3D scene, especially when working on **precise object placement** or **level design**.

<figure><img src="../.gitbook/assets/perspective_gizmo.png" alt=""><figcaption><p>The <strong>gizmo</strong> allows changing between a <strong>perspective</strong> and an <strong>orthographic</strong> view of the Scene view</p></figcaption></figure>

<figure><img src="../.gitbook/assets/perspective_gizmo_anim.gif" alt=""><figcaption></figcaption></figure>
