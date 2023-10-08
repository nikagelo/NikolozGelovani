//პირველი დავალება
Console.WriteLine("Enter the size of array");
string size = Console.ReadLine();
int sizeInt;
int.TryParse(size, out sizeInt);
int[] myArr1 = new int[sizeInt];

for (int i = 0; i < sizeInt; i++)
{
    Console.WriteLine("Enter the element of an array");
    string input = Console.ReadLine();
    int inputInt = int.Parse(input);
    myArr1[i] = inputInt;
   

}
int myArrLength = myArr1.Length;
bool swapped;
for (int i = 0; i < myArrLength - 1; i++)
{
    swapped = false;
    for (int j = 0; j < myArrLength - 1 - i; j++)
    {
        if (myArr1[j] > myArr1[j + 1])
        {
        
            int temp = myArr1[j];
            myArr1[j] = myArr1[j + 1];
            myArr1[j + 1] = temp;
            swapped = true;
        }
    }

    if (!swapped)
        break;
}
static void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item+" ");
    }
}
PrintArray(myArr1);
