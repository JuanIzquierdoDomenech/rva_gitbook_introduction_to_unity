---
icon: apple
---

# Executing in iOS

In a similar way, we can deploy this app on iOS devices.

{% hint style="info" %}
To run the project on an **iOS device** (iPhone or iPad), you need:

* A **Mac**
* **Xcode** installed
* An [**Apple Developer Account**](https://developer.apple.com/)
{% endhint %}

The first thing you have to do (if the iOS module is installed), is to **switch the platform** to iOS:

<figure><img src=".gitbook/assets/ios_switch.png" alt=""><figcaption></figcaption></figure>

* Clicking the **Build** button will generate an **Xcode project,** open it and configure the **Signing & Capabilities**:

<figure><img src=".gitbook/assets/xcode.png" alt=""><figcaption></figcaption></figure>

The first time you execute the app, your phone won't trust the app, so you have to manually trust the developer (you) to execute the app:

<figure><img src=".gitbook/assets/no_trust.png" alt="" width="375"><figcaption></figcaption></figure>

* Go to **Settings&#x20;**_**→**_**&#x20;General&#x20;**_**→**_**&#x20;VPN & Device Management** and trust yourself:

<div><figure><img src=".gitbook/assets/second_trust.png" alt="" width="375"><figcaption></figcaption></figure> <figure><img src=".gitbook/assets/first_trust.png" alt="" width="375"><figcaption></figcaption></figure></div>
