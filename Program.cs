using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static void DisplayHeader(TodoManager manager)
        {
            Console.WriteLine("\n--- To-Do List ---");
            Console.WriteLine("A simple to-do tool for the UX Team.");
            Console.WriteLine("-------------------------");
        }

        static void DisplayTodos(List<Todo> todos)
        {
            Console.WriteLine("--- Tasks ---");
            foreach (var todo in todos)
            {
                Console.WriteLine(todo);
            }
        }

        static void Main(string[] args)
        {
            var manager = new TodoManager();
            
            // Initial display
            DisplayHeader(manager);
            DisplayTodos(manager.GetAllTodos());

            // Example of simple state change logic
            Console.WriteLine("\n--- Toggling Todo #1 ---");
            manager.ToggleCompletion(1);
            
            // Final display
            DisplayHeader(manager);
            DisplayTodos(manager.GetAllTodos());
        }
    }
}