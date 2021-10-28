using System.Collections.Generic;
using AdvancedTodo.Models;

namespace AdvancedTodo.Data
{
    public class ResponseTodoCollectionType
    {
        public IList<Todo> Todos { get; set; }
    }
}