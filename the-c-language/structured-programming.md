# Structured programming

### Conditional structures

#### If, else-if

<pre class="language-csharp"><code class="lang-csharp">private enum Suit { Clubs, Hearts, Diamonds, Spades }

private string GetColor(Suit suit)
{
    string color;

<strong>    if (suit == Suit.Clubs)
</strong>        color = "Black";
<strong>    else if (suit == Suit.Hearts)
</strong>        color = "Red";
    else if (suit == Suit.Diamonds)
        color = "Red";
<strong>    else
</strong>        color = "Black";

    return color;
}
</code></pre>

#### Switch-case

<pre class="language-csharp"><code class="lang-csharp">private enum Suit { Clubs, Hearts, Diamonds, Spades}

private string getColor(Suit suit)
{
    string color;

<strong>    switch (suit)
</strong>    {
<strong>        case Suit.Clubs:
</strong>            color = "Black";
<strong>            break;
</strong>        case Suit.Hearts:
        case Suit.Diamonds:
            color = "Red";
            break;
<strong>        default:
</strong>            color = "Black";
            break;
    }

    return color;
}
</code></pre>

***

### Repetition structures

#### While, do-while, for and for-each

<pre class="language-csharp"><code class="lang-csharp"><strong>for (int i = 0; i &#x3C; 10; i++)
</strong>{
    print(i);
}

int i = 0;
<strong>while (i &#x3C; 10)
</strong>{
    print(i);
    i++;
}

int i = 0;
<strong>do
</strong>{
    print(i);
    i++;
<strong>} while (i &#x3C; 10);
</strong>
int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
<strong>foreach (int number in numbers)
</strong>{
    print(number);
}
</code></pre>
