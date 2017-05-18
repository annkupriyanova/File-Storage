using System;
using System.Collections.Generic;
using FileStorage.Model;

namespace FileStorage.DataAccess
{
    public interface IFilesRepository
    {
        File Add(File file);
        void Delete(Guid id);
        File GetFileInfo(Guid id);
        byte[] GetFileContent(Guid id);
        void UpdateContent(Guid id, byte[] content);

        IEnumerable<File> GetUserFiles(Guid userId);
        void GiveAccessToFile(Guid userId, Guid fileId);
        void DeleteAccessToFile(Guid userId, Guid fileId);
        IEnumerable<File> GetAllowedFiles(Guid userId);
    }
}
