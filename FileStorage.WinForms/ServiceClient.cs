﻿using FileStorage.Model;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FileStorage.WinForms
{
    public class ServiceClient
    {
        private readonly Guid _currentUserId;
        private readonly HttpClient _client = new HttpClient();

        public ServiceClient(string connectionString, Guid currentUserId)
        {
            _currentUserId = currentUserId;
            _client.BaseAddress = new Uri(connectionString);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public Comment[] GetFileComments(Guid id)
        {
            var response = _client.GetAsync($"files/{id}/comments").Result;
            if(response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<Comment[]>().Result;
                return result;
            }
            throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public File[] GetUserFiles()
        {
            var response = _client.GetAsync($"users/{_currentUserId}/files").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<File[]>().Result;
                return result;
            }
            throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public File[] GetUserAllowedFiles()
        {
            var response = _client.GetAsync($"users/{_currentUserId}/sharings").Result;
            if(response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<File[]>().Result;
                return result;
            }
            throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public Guid CreateFile(File file)
        {
            var response = _client.PostAsJsonAsync("files", file).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<File>().Result;
                return result.FileId;
            }
            throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public void UploadFileContent(Guid fileId, byte[] content)
        {
            using (var byteArrayContent = new ByteArrayContent(content))
            {
                var response = _client.PutAsync($"files/{fileId}/content", byteArrayContent).Result;
                if (!response.IsSuccessStatusCode)
                    throw new ServiceException("Error: {0}", response.StatusCode);
            }
        }

        public void DeleteFile(Guid fileId)
        {
            var response = _client.DeleteAsync($"files/{fileId}").Result;
            if (!response.IsSuccessStatusCode)
                throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public byte[] DownloadFile(Guid fileId)
        {
            var response = _client.GetAsync($"files/{fileId}/content").Result;
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsAsync<byte[]>().Result;
            throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public File GetFile(Guid fileId)
        {
            var response = _client.GetAsync($"files/{fileId}").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<File>().Result;
                return result;
            }
            throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public User GetUser()
        {
            var response = _client.GetAsync($"users/{_currentUserId}").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<User>().Result;
                return result;
            }
            throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public Guid CreateComment(Comment comment)
        {
            var response = _client.PostAsJsonAsync("comments", comment).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<Comment>().Result;
                return result.CommentId;
            }
            throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public void EditComment(Guid id, Comment comment)
        {
            var response = _client.PutAsJsonAsync($"comments/{id}", comment).Result;
            if (!response.IsSuccessStatusCode)
                throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public void DeleteComment(Guid commentId)
        {
            var response = _client.DeleteAsync($"comments/{commentId}").Result;
            if (!response.IsSuccessStatusCode)
                throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public void GiveAccessToFile(Guid fileId, Guid userId)
        {
            var response = _client.PutAsJsonAsync($"files/{fileId}/sharings", userId).Result;
            if (!response.IsSuccessStatusCode)
                throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public void DeleteAccessToFile(Guid fileId, Guid userId)
        {
            var response = _client.DeleteAsync($"files/{fileId}/sharings/{userId}").Result;
            if (!response.IsSuccessStatusCode)
                throw new ServiceException("Error: {0}", response.StatusCode);
        }

        public User[] GetAllowedUsers(Guid fileId)
        {
            var response = _client.GetAsync($"files/{fileId}/sharings").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsAsync<User[]>().Result;
                return result;
            }
            throw new ServiceException("Error: {0}", response.StatusCode);
        }
    }
}
