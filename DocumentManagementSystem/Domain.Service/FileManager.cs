namespace Domain.Service
{
    using Domain.Model;
    using Interface;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Utilities;

    public class FileManager : IFileManager
    {
        private static readonly Logger logger = new Logger(typeof(FileManager));
        public List<Folder> GetFolders(string path)
        {
            List<Folder> folders = new List<Folder>();
            try
            {
                logger.Info($"Begin to get folders from {path}.");
                string[] dics = Directory.GetDirectories(path);
                foreach (var item in dics)
                {
                    var dic = new DirectoryInfo(item);
                    folders.Add(new Folder
                    {
                        Name = Path.GetFileName(item),
                        Path = item,
                        CreatedTime = dic.CreationTime
                    });
                }
            }
            catch (Exception ex)
            {
                logger.Error($"An error occurred when getting folders from: {path}, Reason: {ex}.");
            }
            
            return folders;
        }

        public List<LocalFile> GetFiles(string path)
        {
            List<LocalFile> files = new List<LocalFile>();
            try
            {
                logger.Info($"Begin to get files from {path}.");
                string[] fileDic = Directory.GetFiles(path);
                foreach (var item in fileDic)
                {
                    var fileInfo = new FileInfo(item);
                    if (fileInfo != null && fileInfo.Exists)
                    {
                        files.Add(new LocalFile
                        {
                            Name = Path.GetFileName(item),
                            CreatedBy = File.GetAccessControl(path).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString(),
                            Path = item,
                            CreatedTime = fileInfo.CreationTime,
                            Size = fileInfo.Length
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"An error occurred when getting files from: {path}, Reason: {ex}.");
            }
            return files;
        }

        public void ChangeFileNames(List<LocalFile> files)
        {
            foreach(var changeFile  in files)
            {
                FileInfo file = new FileInfo(changeFile.Path);
                if(file.Exists)
                {
                    file.MoveTo(Path.Combine(file.Directory.FullName, changeFile.NewFileName));
                }
            }
        }
    }
}
