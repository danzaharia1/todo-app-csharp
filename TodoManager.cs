using System.Collections.Generic;
using System.Linq;

namespace TodoApp
{
    public class TodoManager
    {
        private List<Todo> Todos { get; set; }

        public TodoManager()
        {
            // Initial list of items (analogous to data.js).
            // The participant will need to modify these constructors to include the DueDate.
            Todos = new List<Todo>
            {
                new Todo(1, "Review new design mocks", false),
                new Todo(2, "Set up user research session for code prediction feature", false),
                new Todo(3, "Draft technical spec for new shopping cart API", true),
                new Todo(4, "Prepare performance review doc for 1:1 with Kate", false)
            };
        }

        public void ToggleCompletion(int id)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                todo.ToggleCompletion();
            }
        }
        
        public List<Todo> GetAllTodos()
        {
            return Todos;
        }
    }
}