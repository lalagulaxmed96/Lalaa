using Eflyer.Business.Exceptions;
using Eflyer.Core.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eflyer.Business.Extensions;

public class Helper
{
    public static string SaveFile(string rootPath, string folder, IFormFile formFile)
    {

        if (!formFile.ContentType.Contains("image/"))
            throw new FileContentTypeException(nameof(formFile), "ImageFile content type is not correct!");

        if (formFile.Length > 2097152)
            throw new FileSizeException(nameof(formFile), "Image file size must be lower than 2mb!");

        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(formFile.FileName);

        string path = rootPath + @$"\{folder}\" + fileName;

        using (FileStream filestream = new FileStream(path, FileMode.Create))
        {
            formFile.CopyTo(filestream);
        }
        return fileName;
    }

    public static void DeleteFile(string rootPath, string folder, string fileName)
    {
        string existImageUrlPath = rootPath + @$"\{folder}\" + fileName;
        if (!File.Exists(existImageUrlPath))
            throw new EntityFileNotFoundException("", "File not found!");

        File.Delete(existImageUrlPath);
    }

    internal static void DeleteFile(string webRootPath, string v, IFormFile? ımageFile)
    {
        throw new NotImplementedException();
    }
}
