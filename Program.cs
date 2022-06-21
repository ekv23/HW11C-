// Дополнить решение домашней задачи прошлого семинара, добавив возможность ввода массивов
// info и data пользователем.
// Проработать возможные частные случаи несоответствия данных в этих массивах.

int[] ResultArrayF (int[] data, int[] info)
{
    int [] resultArray = new int [info.Length];
    int dataIndex = 0;
    for (int infoIndex = 0; infoIndex < info.Length; infoIndex++)
    {
        int result = 0;
        int count = 0;
        for (int i = info[infoIndex]-1; i >= 0; i--)
        {
            result = result + data[dataIndex + i] * (int)Math.Pow(2, count);
            //Для перевода двоичного числа в десятичное необходимо это число представить в 
            //виде суммы произведений степеней основания двоичной системы счисления на соответствующие 
            //цифры в разрядах двоичного числа.
            count++;
        }
        dataIndex = dataIndex + info[infoIndex];
        resultArray[infoIndex] = result;
    }
    return resultArray;
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] UserDataA (int length)
{
    int [] userDataArray = new int [length];
    for (int i = 0; i < userDataArray.Length; i++)
    {
        Console.WriteLine("Введите элемент массива data (состоит из 1 и 0): ");
        int elementData = Convert.ToInt32(Console.ReadLine());
        if (elementData == 0 || elementData == 1) userDataArray[i] = elementData;
        else Console.WriteLine("Введите только числа 1 или 0");
    }
    return userDataArray;
}

int[] UserInfo (int length)
{
    int [] userInfoArray = new int [length];
    for (int i = 0; i < userInfoArray.Length; i++)
    {
        Console.WriteLine("Введите элемент массива info: ");
        int elementInfo = Convert.ToInt32(Console.ReadLine());
        userInfoArray[i] = elementInfo;
    }
    return userInfoArray;
}

int DataArrayLength (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите количество элементов массива info: ");
int infoLength = Convert.ToInt32(Console.ReadLine());

int[] infoArray = UserInfo(infoLength);

int[] dataArray = UserDataA (DataArrayLength(infoArray));

int[] resultArray = ResultArrayF (dataArray,infoArray);

Console.WriteLine("Mассив info:");
PrintArray(infoArray);
Console.WriteLine("Mассив data:");
PrintArray(dataArray);
Console.WriteLine("Результат:");
PrintArray(resultArray);


