#region Finding the max and min value in array.

int[] numbersArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 4, 4, 4, 6, 3, 4, 5, 6, 7, 8, 9, 2 };

int maxNum = 0;

foreach (int item in numbersArr)
{
    if (item % 2 == 0 && item > maxNum)
    {
        maxNum = item;
    }
}

Console.WriteLine($"Maximum even number is {maxNum}.");

int minNum = numbersArr[numbersArr.Length - 1];

foreach (int item in numbersArr)
{
    if (item % 2 == 1 && item < minNum)
    {
        minNum = item;
    }
}

Console.WriteLine($"Maximum od number is {minNum}.");

#endregion

#region Finding the length of array

int lengthOfArray = 0;

for (int i = 0; i < numbersArr.Length; i++)
{
    lengthOfArray++;
}

Console.WriteLine(lengthOfArray);

#endregion

#region Finding the existence of given value in array

int givenValue = 4;
bool exists = false;

foreach (var item in numbersArr)
{
    if (givenValue == item)
    {
        exists = true;   
    }
}

if (exists)
{
    Console.WriteLine("Yes");
}else
{
    Console.WriteLine("No");
}

#endregion

#region Counting the occurrences of a given item in an array.

int givenValue2 = 4;
int lenghtOfGivenValue = 0;

foreach (int item in numbersArr)
{
    if (givenValue2 == item)
    {
        lenghtOfGivenValue++;
    }
}

Console.WriteLine(lenghtOfGivenValue);

#endregion