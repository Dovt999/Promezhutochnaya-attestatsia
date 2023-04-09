1)Сначала инициализировал и задал 2 массива строк. Один с изначальными данными, второй изменённый

string[] array, array1;
array = new string[5]{"123", "COmplete", "lol", "Geek", "bro"};

2)Далее при помощи цикла for нашёл строки, в которых не более 3-х символов и переместил их во второй массив.
for(int i = 0;i < 5; i++)
{
    if (array[i].Length <= 3)
    {
        array1[j] = array[i];
        j++;
    }
}

3)Теперь выводим массив
for (int k = 0; k < j + 1; k++)
{
    Console.WriteLine(array1[k]);
}
