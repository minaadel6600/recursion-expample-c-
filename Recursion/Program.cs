
//static int FactorialNumber(int number)
//{
//    if (number <= 1)
//    {
//        return number;
//    }

//  return  number *FactorialNumber(number - 1);
//}


//Console.WriteLine(FactorialNumber(3));

printDirctoryFiles(@"D:\CV",1);

static void printDirctoryFiles(string dir,int level)
{
    foreach (var fileName in Directory.GetFiles(dir))
    {
        Console.WriteLine(new string("-- ") + new FileInfo(fileName).Name);
    }
    foreach (var dirName in Directory.GetDirectories(dir))
    {
        Console.WriteLine(new string("- ") + new DirectoryInfo(dirName).Name);
        printDirctoryFiles(dirName,level+1);
    }
}