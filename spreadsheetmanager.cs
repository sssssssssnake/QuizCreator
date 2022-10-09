using System;
using Gtk;
using System.IO;

class spreadsheetmanager
{
    public static string makeFile(string fileName, string folderName) {
        string folderPath = Path.Combine(Directory.GetCurrentDirectory(), folderName);
        Directory.CreateDirectory(folderPath);
        if(!File.Exists(fileName)) {
            File.Create(Path.Combine(folderPath, fileName));
        } else {
            alreadyExists(Path.Combine(folderPath, fileName));
        }
        return Path.Combine(folderPath, fileName);
    }
    public static void alreadyExists(string pathToFile) {

    }
}