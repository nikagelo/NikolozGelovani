/////////////////////////////////////////////////პირველი დავალება
//Console.WriteLine("Enter the size of array");
//string size = Console.ReadLine();
//int sizeInt;
//int.TryParse(size, out sizeInt);
//int[] myArr1 = new int[sizeInt];

//for (int i = 0; i < sizeInt; i++)
//{
//    Console.WriteLine("Enter the element of an array");
//    string input = Console.ReadLine();
//    int inputInt = int.Parse(input);
//    myArr1[i] = inputInt;


//}
//int myArrLength = myArr1.Length;
//bool swapped;
//for (int i = 0; i < myArrLength - 1; i++)
//{
//    swapped = false;
//    for (int j = 0; j < myArrLength - 1 - i; j++)
//    {
//        if (myArr1[j] > myArr1[j + 1])
//        {

//            int temp = myArr1[j];
//            myArr1[j] = myArr1[j + 1];
//            myArr1[j + 1] = temp;
//            swapped = true;
//        }
//    }

//    if (!swapped)
//        break;
//}
//static void PrintArray(int[] arr)
//{
//    foreach (int item in arr)
//    {
//        Console.Write(item+" ");
//    }
//}
//PrintArray(myArr1);

/////////////////////////////////////////////////მეორე დავალება 
///First array code
//Console.WriteLine("Enter the size of first array");
//string size = Console.ReadLine();
//int sizeInt;
//int.TryParse(size, out sizeInt);
//string[] myArr1 = new string[sizeInt];

//for (int i = 0; i < sizeInt; i++)
//{
//    Console.WriteLine("Enter the element of an array");
//    string input = Console.ReadLine();
//    myArr1[i] = input;
//}
///Second array code
//Console.WriteLine("Enter the size of second array");
//string size2 = Console.ReadLine();
//int size2Int;
//int.TryParse(size2, out size2Int);
//int[] myArr2 = new int[size2Int];
//for (int i = 0; i < size2Int; i++)
//{
//    Console.WriteLine("Enter the element of an array");
//    string input = Console.ReadLine();
//    int inputInt;
//    int.TryParse(input, out inputInt);
//    myArr2[i] = inputInt;
//}
//Print array
//int max;
//if (sizeInt > size2Int)
//{
//    max = sizeInt;
//}
//else
//{
//    max = size2Int;
//}
//for (int i = 0; i < max; i++)
//{
//    if (i < sizeInt)
//    {
//        Console.Write(myArr1[i] + " ");
//    }

//    if (i < size2Int)
//    {
//        Console.Write(myArr2[i] + " ");
//    }

//}

/////////////////////////////////////////////////მესამე დავალება
//Console.WriteLine("Enter the size of array");
//string size = Console.ReadLine();
//int sizeInt;
//int.TryParse(size, out sizeInt);
//int[] myArr3 = new int[sizeInt*sizeInt];

//if (sizeInt == 2)
//{
//    for (int i = 0; i < 4; i++)
//    {
//        Console.WriteLine("Enter the element of an array");

//          string input = Console.ReadLine();
//          int inputInt = int.Parse(input);
//          myArr3[i] = inputInt;

//    }
//}
//else if (sizeInt == 3) {
//    for (int i = 0; i < 9; i++)
//    {
//        Console.WriteLine("Enter the element of an array");
//        string input = Console.ReadLine();
//        int inputInt = int.Parse(input);
//        myArr3[i] = inputInt;
//    }
//}
//    int dev;
//int calcDev()
//{
//    if (sizeInt == 2) {
//        dev = myArr3[0] * myArr3[3] - myArr3[1] * myArr3[2];
//    }
//    else
//    {
//        dev = myArr3[0] * (myArr3[4] * myArr3[8] - myArr3[5] * myArr3[7]) - myArr3[1] * (myArr3[3] * myArr3[8] - myArr3[5] * myArr3[6]) + myArr3[2] * (myArr3[3] * myArr3[7] - myArr3[4] * myArr3[6]);
//    }
//    return dev;
//}

//calcDev();
//Console.WriteLine("Determinant: "+dev);