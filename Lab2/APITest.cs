using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab2
{
    public class APITest
    {
        public HttpClient client;
        public async Task GetData()
        {
            //client = new HttpClient();
            //string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            //string response = await client.GetStringAsync(call);
            //List<Student> students = JsonSerializer.Deserialize<List<Student>>(response);
            //foreach (var student in students) Console.WriteLine(student.ToString());
            client = new HttpClient();
            string call = "https://pokeapi.co/api/v2/pokemon-species/413/"; // może być bez ostatniego /
            string response = await client.GetStringAsync(call);
            //List<Student> students = JsonSerializer.Deserialize<List<Student>>(response);
            //dynamic var = JsonSerializer.Deserialize<dynamic>(response);
            dynamic var = JObject.Parse(response);
            Console.WriteLine(var.name);
            //JsonConverter.DeserializeObject(response);
            //JsonSerializer.Deserialize(response, typeof(dynamic));
            //foreach (var student in students) Console.WriteLine(student.ToString());
        }

    }
}
