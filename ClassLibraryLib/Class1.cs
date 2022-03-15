using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Threading;

namespace ClassLibraryLib
{
    public static class LibraryReader
    {

        public static void ReadLibrary(string  path) {
            Console.WriteLine("hi");
            XmlSerializer serializer = new XmlSerializer(typeof(Library.library));
            FileStream fs = new FileStream(path, FileMode.Open);
            // Declare an object variable of the type to be deserialized.
            Library.library po;

            /* Use the Deserialize method to restore the object's state with
            data from the XML document. */
            po = (Library.library)serializer.Deserialize(fs);

            foreach (var b in po.Items[0].author[0].name)
            {
                
                    Console.WriteLine(b.Value);
                
            }

           // Console.WriteLine("LIB: " + po.Items[0].author[0].name[0].Value);

            Console.WriteLine("hi");
            fs.Close();
            Thread.Sleep(3000);
        }
    }
}
