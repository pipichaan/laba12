Console.WriteLine("укажите путь"); //E:\\DOCUMENT\\12.txt
string path = Console.ReadLine();
string path1 = Directory.GetCurrentDirectory();
if (File.Exists(path1))
{
    string a = File.ReadAllText(path);
    File.WriteAllText(path1 + "\\12.txt", a);
    Console.WriteLine(path1 + "\\12.txt");
}
else
{
    Console.WriteLine("ошибка");
}