# RectTransform

{% embed url="https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/class-RectTransform.html" %}

This component is the **equivalent of a Transform** in the **3D world**, but it is specifically designed for positioning and arranging **UI elements** on the screen.

Every GUI element in Unity includes a **`RectTransform`** component.

***

#### RectTransform Attributes

The **RectTransform** defines several key properties of a UI element:

* **Position** of the element on the screen.
* **Width and height** (size of the element).
* **Rotation** of the element.
* **Pivot point** — the reference point for transformations (by default, the center of the element).
* **Anchors** — define how the element behaves relative to the screen or its parent container (for responsive layouts).

<div><figure><img src="../.gitbook/assets/rect_transform_component.png" alt="" width="563"><figcaption></figcaption></figure> <figure><img src="../.gitbook/assets/recttransform_pivots.png" alt="" width="563"><figcaption></figcaption></figure></div>

***

#### Anchors

The **`RectTransform`** not only determines the position of a UI element but also **how it adapts** when the screen size or resolution changes.

Anchors make it possible to create **responsive interfaces**, maintaining consistent alignment and proportions across different devices.

There are two main types of anchors:

* <mark style="background-color:red;">**Red anchors**</mark>: define the **position** of the element.
* <mark style="background-color:blue;">**Blue anchors**</mark>: define the **size** or **stretch behavior** of the element.

<div><figure><img src="../.gitbook/assets/anchor_center_sample.png" alt="" width="563"><figcaption></figcaption></figure> <figure><img src="../.gitbook/assets/anchor_possibilities.png" alt="" width="375"><figcaption></figcaption></figure></div>

***

#### **Example 1**

Anchored to the **bottom of the screen**, spanning the entire available width:

<figure><img src="../.gitbook/assets/anchor_ex1.png" alt=""><figcaption></figcaption></figure>

{% hint style="info" %}
Useful for elements like toolbars or status bars.
{% endhint %}

**Example 2**

Occupying the **entire screen space**, both in width and height:

<figure><img src="../.gitbook/assets/anchor_ex2.png" alt=""><figcaption></figcaption></figure>

{% hint style="info" %}
Typically used for full-screen panels or background images.
{% endhint %}

**Example 3**

Anchored to the **top-left corner**, with a small margin, and **no stretch** applied.

<figure><img src="../.gitbook/assets/anchor_ex3.png" alt=""><figcaption></figcaption></figure>

{% hint style="info" %}
Common for fixed-position elements like icons, labels, or buttons.
{% endhint %}
