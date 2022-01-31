using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    interface IProcessor<T> where T : class
    {
        Task<List<T>> LoadAllPosts();
        Task<string> SendPost(T post);
        Task<string> UpdatePost(T post);
        Task<string> DeletePost(int id);
        Task<string> GetById(int id);

    }
}
