
using System.Collections.Generic;
using System.Threading.Tasks;
using AdvancedTodo.Models;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;


namespace AdvancedTodo.Data
{
    public class TodoJsonData : ITodoData
    {
        public async Task<IList<Todo>> GetTodos()
        {
            using var client = new GraphQLHttpClient("https://localhost:5001/graphql"
                , new NewtonsoftJsonSerializer());

            var request = new GraphQLRequest
            {
                Query = "query{todos {userId,todoId,title,isCompleted}}"
            };
            var response = await client.SendQueryAsync<ResponseTodoCollectionType>(request);

           


            return response.Data.Todos;
        }

        public async void AddTodo(Todo todo)
        {
            using var client = new GraphQLHttpClient("https://localhost:5001/graphql"
                , new NewtonsoftJsonSerializer());


            var request = new GraphQLRequest
            {
                Query =
                    "mutation ($userid: Int!,$title:String!)  {addTodo(userid: $userid, title: $title) {todoId,userId,title,isCompleted}}",
                Variables = new
                {
                    userid = todo.UserId,
                    title = todo.Title
                }
            };

            await client.SendMutationAsync<ResponseTodoType>(request);
        }

        public async void RemoveTodo(int todoId)
        {
            using var client = new GraphQLHttpClient("https://localhost:5001/graphql"
                , new NewtonsoftJsonSerializer());


            var request = new GraphQLRequest
            {
                Query = "mutation($id:Int!) {deleteTodo(id:$id)}",
                Variables = new
                {
                    id = todoId
                }
            };

            await client.SendMutationAsync<ResponseTodoType>(request);
        }

        public async void Update(Todo todo)
        {
            using var client = new GraphQLHttpClient("https://localhost:5001/graphql"
                ,new NewtonsoftJsonSerializer() );


            var request = new GraphQLRequest
            {
                Query =
                    "mutation($id:Int!,$userid:Int!,$title:String!){updateTodo(id:$id,userid:$userid,title:$title){todoId,userId,title}}",
                Variables = new
                {
                    id = todo.TodoId,
                    userid = todo.UserId,
                    title = todo.Title
                }
            };

            await client.SendMutationAsync<ResponseTodoType>(request);
        }

        public async Task<Todo> Get(int todoId)
        {
            using var client = new GraphQLHttpClient("https://localhost:5001/graphql"
                ,new NewtonsoftJsonSerializer());

            var request = new GraphQLRequest
            {
                Query = "query($id:Int!){todosById(id:$id){userId,todoId,title,isCompleted}}",
                Variables = new
                {
                    id = todoId
                }
            };
            
            
            
            var response =  await client.SendQueryAsync<ResponseTodoType>(request);
            return response.Data.Todo;
        }
    }
}