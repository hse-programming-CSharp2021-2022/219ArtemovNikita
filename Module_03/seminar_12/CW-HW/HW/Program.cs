using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

[Serializable]
public class Human
{
    public string Name { get; set; }
    public Human()
    {
    }
    public Human(string name)
    {
        Name = name;
    }
}

[Serializable]
public class Professor : Human
{
    public Professor(string name) : base(name){}
    public Professor(){}
}

[Serializable]
[XmlInclude(typeof(Professor))]
[XmlInclude(typeof(Human))]
public class Department
{
    public Department(){}
    public string Name { get; set; }
    public List<Human> Humans { get; set; }

    public Department(List<Human> hs, string name)
    {
        Name = name;
        Humans = hs.ToList();
    }
}

[Serializable]
[XmlInclude(typeof(Professor))]
[XmlInclude(typeof(Human))]
[XmlInclude(typeof(Department))]
public class University
{
    public string Name { get; set; }
    public  List<Department> Departments { get; set; }
    public University(){}

    public University(List<Department> departments, string name)
    {
        Name = name;
        Departments = departments;
    }
}

class Program
{
    static async Task Main()
    {
        var humans = new List<Human>()
        {
            new Human("first"), new Professor("first"), new Professor("second"),
            new Human("second"), new Human("third"), new Human("fourth")
        };
        var d1 = new Department(humans, "d1");
        var d2 = new Department(humans, "d2");
        var d = new List<Department> {d1, d2};
        var uni1 = new University(d, "u1");
        var uni2 = new University(d, "u2");
        var unis = new List<University>() {uni1, uni2};
        
        using (var fs = new FileStream("note.json", FileMode.OpenOrCreate))
        {
            await JsonSerializer.SerializeAsync(fs, unis);
            Console.WriteLine("Объект сериализован");
        }

        await Task.Delay(1000);
        
        using (var fs = new FileStream("note.json", FileMode.OpenOrCreate))
        {
            var g = await JsonSerializer.DeserializeAsync<List<University>>(fs);
            Console.WriteLine("Объект десериализован");
        }
        
        await Task.Delay(1000);
        
        var formatter = new XmlSerializer(typeof(List<University>));
        
        using (var fs = new FileStream("note2.xml", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, unis);
            Console.WriteLine("Объект сериализован");
        }
 
        await Task.Delay(1000);
        
        using (var fs = new FileStream("note2.xml", FileMode.OpenOrCreate))
        {
            var newGroup = (List<University>)formatter.Deserialize(fs);
            Console.WriteLine("Объект десериализован");
        }
        
        var formater = new BinaryFormatter();

        await Task.Delay(1000);
        
        using (var fs = new FileStream("note3.dat", FileMode.OpenOrCreate))
        {
            formater.Serialize(fs, unis);
            Console.WriteLine("Объект сериализован");
        }
        
        await Task.Delay(1000);
        
        using (var fs = new FileStream("note3.dat", FileMode.OpenOrCreate))
        {
            var newUni = (List<University>)formater.Deserialize(fs);
            Console.WriteLine("Объект десериализован");
        }
    }
}
