#region arr.Resize()

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

//int[] temp = new int[arr.Length + 1];

//for (int i = 0; i < arr.Length; i++)
//{
//    temp[i] = arr[i];
//}
//arr = temp;
//arr[8] = 123;

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}

#endregion


#region

int[] numbers = [4, 7, 2, 4, 9, 7];
int temp;
bool swapped;
for (int i = 0; i < numbers.Length - 1; i++)
{
    swapped = false;
    for (int j = 0; j < numbers.Length - 1 - i; j++)
    {
        if (numbers[j] > numbers[j+1])
        {
            temp = numbers[j];
            numbers[j] = numbers[j+1];
            numbers[j+1] = temp;
            swapped = true;
        }
    }

    if (swapped == false)
    {
        break;
    }
}

int biggest = 0;
for (int i = 0; i < numbers.Length; i++)
{
    biggest = biggest * 10 + numbers[numbers.Length-1 - i];
}

Console.WriteLine(biggest);

#endregion