namespace TodoApp
{
    public class Todo
    {
        // Auto-implemented properties
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCompleted { get; set; }

        public Todo(int id, string text, bool isCompleted)
        {
            Id = id;
            Text = text;
            IsCompleted = isCompleted;
        }

        public void ToggleCompletion()
        {
            IsCompleted = !IsCompleted;
        }

        public override string ToString()
        {
            string status = IsCompleted ? "[X]" : "[ ]";
            return $"{status} {Text}";
        }
    }
}