string[] array, array1;
array = new string[5]{"123", "COmplete", "lol", "Geek", "bro"};
array1 = new string [5];
int j = 0;
for(int i = 0;i < 5; i++)
{
    if (array[i].Length <= 3)
    {
        array1[j] = array[i];
        j++;
    }
}
    for (int k = 0; k < j + 1; k++)
{
    Console.WriteLine(array1[k]);
}