# Casting

Unity provides the typical coercion mechanisms found in polymorphic languages:

#### Coercion (implicit conversion):

```csharp
int intValue = 123;
long longValue = intValue;  // OK
        
long x = 123456;
int y = x;                  // Error, data loss
```

***

#### Casting (explicit conversion)

```csharp
long longValue = 332L; 
int valor = (int) longValue;   
      
short z = (short)342; 	   	
        
double d = 1.2345678901234;
float f = (float)d;		
long l = (long)d;
```

<table><thead><tr><th width="122.62109375">Type</th><th>Secure conversion to...</th></tr></thead><tbody><tr><td>byte</td><td>short, ushort, int, uint, long, ulong, float, double, decimal</td></tr><tr><td>sbyte</td><td>short, int, long, float, double, decimal</td></tr><tr><td>short</td><td>int, long, float, double, decimal</td></tr><tr><td>ushort</td><td>int, uint, long, ulong, float, double, decimal</td></tr><tr><td>int</td><td>long, float, double, decimal</td></tr><tr><td>uint</td><td>long, ulong, float, double, decimal</td></tr><tr><td>long</td><td>float, double, decimal</td></tr><tr><td>ulong</td><td>float, double, decimal</td></tr><tr><td>float</td><td>double</td></tr><tr><td>char</td><td>ushort, int, uint, long, ulong, float, double, decimal</td></tr></tbody></table>
