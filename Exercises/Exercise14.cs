using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
public class Insecure
{
    public static bytes[] getFile(String filename) 
    {
        if (filename.Contains(".."))
        {
            throw new ArgumentException("error");
        }
    
        String imageDir = "FILESHAREimages";
        filepath = Path.Combine(imageDir, filename);
        var ext = Path.GetExtension(filePath);
        return File.ReadAllBytes(filepath);
    }


    public static bytes[] fetchFile(String filename) 
    {
        if (filename.Contains("..")) {
            throw new ArgumentException("error");
        }

        if (string.IsNullOrEmpty(filename) || Path.GetFileName(filename) != filename)
        {
            throw new ArgumentNullException("error");
        }
        
        String filepath = Path.Combine("FILESHAREimages", filename);
        return File.ReadAllBytes(filepath);
    }
}
}