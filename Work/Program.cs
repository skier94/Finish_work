//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []
string[] a = new string[4] {"1234", "1567", "-2", "computer"};
string[] b = new string[a.Length];
void CreateAr(string[] a, string[] b)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
    if(a[i].Length <= 3)
        {
        b[count] = a[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CreateAr(a, b);
PrintArray(b);
