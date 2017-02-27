using Newtonsoft.Json;
using System.Xml;

namespace SharedLogic
{
    public static class WebUtils
    {
       public static string XmlToJson (string xmlInput)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xmlInput);

            } catch (XmlException)
            {
                return "Bad Xml format";
            }

            string jsonText = JsonConvert.SerializeXmlNode(doc);

            return jsonText;
        }
    }
}