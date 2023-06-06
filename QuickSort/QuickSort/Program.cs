
var numbers = new[] { 100, 23, 54, 12, 43, 94, 5, 37, 36 };

Console.WriteLine(string.Join(',', numbers));

QuickSort(numbers, 0, numbers.Length - 1);

Console.WriteLine(string.Join(',', numbers));

Console.ReadKey();

T[] QuickSort<T>(T[] array, int left, int right)
    where T : IComparable<T>
{
    var i = left;
    var j = right;
    var pivot = array[left];

    while(i <= j)
    {
        while (array[i].CompareTo(pivot) < 0)
        {
            i++;
        }

        while (array[j].CompareTo(pivot) > 0)
        {
            j--;
        }

        if(i <= j)
        {
            (array[i], array[j]) = (array[j], array[i]);
            i++;
            j--;
        }
    }

    if (left < j)
    {
        QuickSort(array, left, j);
    }

    if (i < right)
    {
        QuickSort(array, i, right);
    }

    return array;
}