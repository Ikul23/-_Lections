// Создать метод для обхода всех папок и директори на компьюторе с помощью рекурсии


// string path = "C:/Users/ikul2/Desktop/Презентации/";
// DirectoryInfo di = new DirectoryInfo(path);

// Console.WriteLine($"Directory Creation Time: {di.CreationTime}");

// FileInfo[] fi = di.GetFiles();

// Console.WriteLine("Files in the directory:");
// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }


static void CatalogInfo(DirectoryInfo directory, string indent = "")
{
    DirectoryInfo[] subdirectories = directory.GetDirectories();
    foreach (var subdirectory in subdirectories)
    {
        Console.WriteLine($"{indent}{subdirectory.Name}");
        CatalogInfo(subdirectory, indent + " ");
    }

    FileInfo[] files = directory.GetFiles();
    foreach (var file in files)
    {
        Console.WriteLine($"{indent}{file.Name}");
    }
}
string path = @"C:/Users/ikul2/Desktop/Презентации/";
DirectoryInfo catalog = new DirectoryInfo(path);
CatalogInfo(catalog);

