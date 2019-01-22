using System.IO;
using System.Xml.Serialization;

namespace Helper
{
    public static class Serialization
    {
        public static void Serialize<T>(string filePath, object obj)
            where T : class
        {
            var ext = Path.GetExtension(filePath);
            switch (ext)
            {
                default:
                    var xs = new XmlSerializer(typeof(T));
                    using (var sw = new StreamWriter(filePath))
                        xs.Serialize(sw, obj);
                    return;
            }
        }

        public static T Deserialize<T>(string filePath)
            where T : class
        {
            var ext = Path.GetExtension(filePath);
            switch (ext)
            {
                default:
                    var xs = new XmlSerializer(typeof(T));
                    using (var sr = new StreamReader(filePath))
                        return (T)xs.Deserialize(sr);
            }
        }
    }
}