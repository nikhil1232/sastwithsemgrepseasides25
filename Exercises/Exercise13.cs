using System;
using System.Xml;

[ApiController]
[Route("api/[controller]")]
public class YourController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetRequest([FromQuery] string xmlFilePath)    
    {

        XmlReaderSettings settings = new XmlReaderSettings
        {
            DtdProcessing = DtdProcessing.Parse,
        };


        // Create the XmlReader using the settings
        using (XmlReader reader = XmlReader.Create(xmlFilePath, settings))
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    Console.WriteLine("Element: " + reader.Name);
                }
            }
        }
    }

}