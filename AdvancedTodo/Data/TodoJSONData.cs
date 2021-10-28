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

        public async void AddTodo(Todo todo)
        {
            
            using var client = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri("https://localhost:5001/graphql")
            });
            
            
            var request = new GraphQLRequest
            {
                Query = "mutation ($userid: Int!,$title:String!)  {addTodo(userid: $userid, title: $title) {todoId,userId,title,isCompleted}}",
                Variables = new
                {
                    userid = todo.UserId,
                    title=todo.Title
                }
            };

            await client.SendMutationAsync(request);

        }

        public async void RemoveTodo(int todoId)
        {
            using var client = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri("https://localhost:5001/graphql")
            });
            
            
            var request = new GraphQLRequest
            {
                Query = "mutation($id:Int!) {deleteTodo(id:$id)}",
                Variables = new
                {
                    id = todoId
                  
                }
            };

            await client.SendMutationAsync(request);
        }

        public async void Update(Todo todo)
        {
            
            using var client = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri("https://localhost:5001/graphql")
            });
            
            
            var request = new GraphQLRequest
            {
                Query = "mutation($id:Int!,$userid:Int!,$title:String!){updateTodo(id:$id,userid:$userid,title:$title){todoId,userId,title}}",
                Variables = new
                {
                    id = todo.TodoId,
                    userid = todo.UserId,
                    title=todo.Title
                  
                }
            };

            await client.SendMutationAsync(request);
            
        }

        public async Task<Todo> Get(int id)
        {
            using var client = new GraphQLHttpClient(new GraphQLHttpClientOptions
            {
                EndPoint = new Uri("https://localhost:5001/graphql")
            });

            var request = new GraphQLRequest
            {
                Query = "query{todos(where:{todoId: {eq:1}}){todoId,title}}",
               
            };
            var response = await client.SendQueryAsync(request);

            return response.GetDataFieldAs<Todo>("todos");
        }

        
    }
}