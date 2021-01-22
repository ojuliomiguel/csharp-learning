# Notas sobre meu aprendizado na linguagem C#

# Basic

## Tipos de referência

* reference types:

    Armazenam referências dos seus dados (objetos)

* values types
    Contém diretamente seus dados

    Uma variável que referência uma instância tem os valores da instância copiados para si. Desta forma, não afeta a variável de valor.

## Values types exemplo:

```csharp
using System;

public struct MutablePoint
{
    public int X;
    public int Y;

    public MutablePoint(int x, int y) => (X, Y) = (x, y);

    public override string ToString() => $"({X}, {Y})";
}

public class Program
{
    public static void Main()
    {
        var p1 = new MutablePoint(1,2);
        var p2 = p1;

        p2.Y = 200;

        Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
        Console.WriteLine($"{nameof(p2)}: {p2}");

        MutateAndDisplay(p2);
        Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
    }

    private static void MutateAndDisplay(MutablePoint p) 
    {
        p.X = 100;
        Console.WriteLine($"Point mutated in a method: {p}");
    }
}
// Expected output:
// p1 after p2 is modified: (1, 2)
// p2: (1, 200)
// Point mutated in a method: (100, 200)
// p2 after passing to a method: (1, 200)

```

# Obs: 

Se um value type contém um dado do tipo reference type, apenas a referência à instância do reference type é copiada quando uma instância do tipo valor é copiada.