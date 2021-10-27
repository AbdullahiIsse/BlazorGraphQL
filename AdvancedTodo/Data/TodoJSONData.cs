using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AdvancedTodo.Models;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Common.Request;

namespace AdvancedTodo.Data
{
    public class TodoJsonData : ITodoData
    {
        private string todoFile = "todos.json";
        private IList<Todo> todos;

        public TodoJsonData()
        {
            if (!File.Exists(todoFile))
            {
                Seed();
                WriteTodossToFile();
            }
            else
            {
                string content = File.ReadAllText(todoFile);
                todos = JsonSerializer.Deserialize<List<Todo>>(content);
            }
        }

        private void Seed()
        {
            
        }


        public async Task<IList<Todo>> GetTodos()
        {
            using var client = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri("https://localhost:5001/graphql")
            });

            var request = new GraphQLRequest
            {
                Query = "query{todos {userId,todoId,title,isCompleted}}"
            };
            var response = await client.SendQueryAsync(request);

            IList<Todo> todos = response.GetDataFieldAs<IList<Todo>>("todos");
            

            return todos;
        }

        public void AddTodo(Todo todo)
        {
            int max = todos.Max(todo => todo.TodoId);
            todo.TodoId = (++max);
            todos.Add(todo);
            WriteTodossToFile();
        }

        public void RemoveTodo(int todoId)
        {
            Todo toRemove = todos.First(t => t.TodoId == todoId);
            todos.Remove(toRemove);
            WriteTodossToFile();
        }

        public void Update(Todo todo)
        {
            Todo toUpdate = todos.First(t => t.TodoId == todo.TodoId);
            toUpdate.IsCompleted = todo.IsCompleted;
            toUpdate.Title = todo.Title;
            WriteTodossToFile();
        }

        public Todo Get(int id)
        {
            return todos.FirstOrDefault(t => t.TodoId == id);
        }

        private void WriteTodossToFile()
        {
            string todosAsJson = JsonSerializer.Serialize(todos);
            File.WriteAllText(todoFile, todosAsJson);
        }
    }
}