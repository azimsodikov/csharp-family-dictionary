using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

        myFamily.Add("qoshnim", new Dictionary<string, string>(){ 
            {"name", "Hoshim"},
            {"age", "40"}
        });
        myFamily.Add("sister", new Dictionary<string, string>(){ 
            {"name", "Koshim"},
            {"age", "29"}
        });
        myFamily.Add("friend", new Dictionary<string, string>(){ 
            {"name", "Chomich"},
            {"age", "42"}
        });
        myFamily.Add("buddy", new Dictionary<string, string>(){ 
            {"name", "Chelak"},
            {"age", "49"}
        });
        myFamily.Add("dude", new Dictionary<string, string>(){ 
            {"name", "Paqir"},
            {"age", "44"}
        });
        myFamily.Add("jerom", new Dictionary<string, string>(){ 
            {"name", "Talinka"},
            {"age", "32"}
        });
        // Next, iterate over eac

            foreach (var item in myFamily)
            {
                Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]} years old");
            }
        }
    }
}
