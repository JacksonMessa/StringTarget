string original, inverso = "";
Console.WriteLine("Digite uma frase:");
original = Console.ReadLine();
for(int i = original.Length-1; i >= 0; i--)
{
    inverso += original[i];
}
Console.WriteLine("String invertida: " + inverso);
