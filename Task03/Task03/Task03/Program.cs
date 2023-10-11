///////////////////////////////////////////////პირველი დავალება
//Console.WriteLine("Enter the size of an array");
//string count = Console.ReadLine();
//int countInt;
//int.TryParse(count, out countInt);
//int[] arr = new int[countInt];
//for (int i = 0; i < countInt; i++)
//{
//    Console.WriteLine("Enter the element of an array");
//    string input = Console.ReadLine();
//    int inputInt;
//    inputInt = int.Parse(input);
//    arr[i] = inputInt;
//}


//int CalculateSumOfIndex(params int[] arr)
//{
//    Console.WriteLine("Enter the index");
//    string index = Console.ReadLine();
//    int indexInt;
//    int.TryParse(index, out indexInt);
//    int number = arr[indexInt];
//    int sum = 0;

//    while (number != 0)
//    {
//        int digit = number % 10;
//        sum += digit;
//        number /= 10;
//    }
//    Console.WriteLine(sum);
//    return sum;
//}
//CalculateSumOfIndex(arr);

//////////////////////////////////////////მეორე დავალება
Console.WriteLine("Enter the size of an array");
string count = Console.ReadLine();
int countInt;
int.TryParse(count, out countInt);
char[] arr = new char[countInt];
for (int i = 0; i < countInt; i++)
{
    Console.WriteLine("Enter the element of an array");
    string input = Console.ReadLine();
    arr[i]= char.Parse(input);
  
}
Console.WriteLine("Enter the char to find");
string toFind = Console.ReadLine();
char toFindChar = char.Parse(toFind);
int ReturnChars() {
    int count = 0;
    foreach (char x in arr)
    {
        if (toFindChar == x)
        {
            count++;
        }
    }
    Console.WriteLine("There is "+count+" "+toFindChar);
    return count;
}
ReturnChars();