using System.IO;
using Microsoft.Maui.Storage;

namespace Project2.Data;

using System.IO;
using Microsoft.Maui.Storage;

public static class DatabasePath
{
    public static string GetPath(string dbName = "app.db")
        => Path.Combine(FileSystem.AppDataDirectory, dbName);
}
