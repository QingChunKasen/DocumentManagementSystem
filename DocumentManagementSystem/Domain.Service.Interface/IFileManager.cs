namespace Domain.Service.Interface
{
    using Domain.Model;
    using System;
    using System.Collections.Generic;
    public interface IFileManager
    {
        List<Folder> GetFolders(String path);

        List<LocalFile> GetFiles(String path);

        void ChangeFileNames(List<LocalFile> files);
    }
}
