using System.Xml.Serialization;

namespace trim_xml_serialization;
public class ExampleClass
{
    private readonly int value;

    internal ExampleClass(int v) => value = v;

    public static void NewXmlSerializer(Stream stream)
    {
        /**
Using member 'System.Xml.Serialization.XmlSerializer.XmlSerializer(System.Type)' which has 'RequiresUnreferencedCodeAttribute' can break functionality when trimming application code. Members from serialized types may be trimmed if not referenced directly. [trim-xml-serialization]csharp(IL2026)
Using member 'System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.Stream)' which has 'RequiresUnreferencedCodeAttribute' can break functionality when trimming application code. Members from deserialized types may be trimmed if not referenced directly. [trim-xml-serialization]csharp(IL2026)
Dereference of a possibly null reference. [trim-xml-serialization]csharp(CS8602)

Recommended Actions:
Add RequiresUnreferencedCode attribute to parent method

        */
        Console.WriteLine((
            new XmlSerializer(
                typeof(ExampleClass)
            ).Deserialize(stream)
         as ExampleClass).value.ToString());
    }

}
