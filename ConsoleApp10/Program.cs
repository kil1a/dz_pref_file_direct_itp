//ЗАДАНИЕ 1-----------------------------------------------------------------------
 string FindCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
        return "";

    string prefix = strs[0];

    for (int i = 1; i < strs.Length; i++)
    {
        while (strs[i].IndexOf(prefix) != 0)
        {
            prefix = prefix.Substring(0, prefix.Length - 1);
            if (prefix == "")
                return "";
        }
    }

    return prefix;
}
//ЗАДАНИЕ 2-----------------------------------------------------------------------
void CreateFile(string directory, string fileName)
{
    string filePath = Path.Combine(directory, fileName);

    if (File.Exists(filePath))
    {
        Console.WriteLine("файл уже существует");
        return;
    }

    File.Create(filePath);
    Console.WriteLine("файл создан");
}
//ЗАДАНИЕ 3-----------------------------------------------------------------------
void CreateDirectory(string path)
{
    if (Directory.Exists(path))
    {
        Console.WriteLine("каталог уже существует");
        return;
    }

    Directory.CreateDirectory(path);
    Console.WriteLine("каталог создан");
}
//ЗАДАНИЕ 4-----------------------------------------------------------------------
void ListFiles(string directory)
{
    foreach (string file in Directory.GetFiles(directory))
    {
        Console.WriteLine(file);
    }

    foreach (string subdirectory in Directory.GetDirectories(directory))
    {
        ListFiles(subdirectory);
    }
}



    static void Main(string[] args)
    {
        // Проверка функции FindCommonPrefix
        string[] strs = { "flower", "flow", "flight" };
        string commonPrefix = FindCommonPrefix(strs);
        Console.WriteLine("Общий префикс: " + commonPrefix);

        // Проверка функции CreateFile
        string directory = "C:/Temp";
        string fileName = "test.txt";
        CreateFile(directory, fileName);

        // Проверка функции CreateDirectory
        string path = "C:/Temp/NewDirectory";
        CreateDirectory(path);

        // Проверка функции ListFiles
        string directoryToScan = "C:/Temp";
        ListFiles(directoryToScan);

        Console.ReadLine();
    }
