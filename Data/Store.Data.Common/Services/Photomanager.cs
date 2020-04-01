using Microsoft.AspNetCore.Http;
using Store.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Store.Data.Common.Services
{
    public class PhotoManager
    {
        public List<Photo> CreatePhotos(List<IFormFile> files)
        {
            DirectoryManager dm = new DirectoryManager();
            List<Photo> photos = new List<Photo>();
            foreach (var file in files)
            {
                if (file.Length > 0 && file != null)
                {
                    var path = dm.GetFolderPath();

                    var fileName = FileNameManipulator.GenerateName();
                    var fullPath = Path.Combine(path, fileName);
                    var fileType = Path.GetExtension(file.FileName);

                    photos.Add(new Photo() { ImageType = fileType, PhotoDir = fullPath });

                    using (var str = new FileStream(fullPath + fileType, FileMode.Create))
                    {
                        file.CopyTo(str);
                    }
                }
            }
            return photos;
        }
    }
}
