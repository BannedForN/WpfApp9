using Newtonsoft.Json;

namespace SerLib
{
    public class Class1
    {
        public static void MySerialize<T>(T humans, string filename)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string json = JsonConvert.SerializeObject(humans);
            File.WriteAllText(desktop + "\\" + filename, json);
        }

        public static T MyDeserialize<T>(string filename)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string json = File.ReadAllText(desktop + "\\" + filename);
            T humans = JsonConvert.DeserializeObject<T>(json);
            return humans;
        }
    }
}