namespace Lab6.Http.Common;

public class TaskItem
{
    public TaskItem()
    {
    }

    public TaskItem(int id, string name, string description,int age)
    {
        Id = id;
        Name = name;
        Description = description;
        Age = age;
    }

    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int Age { get; set; }
}
