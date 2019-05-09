using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TcpServer
{
    class Proto
    {
        public static string parseJson(string json_str) {
            if (json_str == "")
                return "";
            string content = "";

            try
            {
                JObject obj  = JObject.Parse(json_str);
                foreach (var x in obj)
                {
                    content += (x.Key + " : " + x.Value + "\n");
                }
            }
            catch (Exception e)
            {
                return "";
            }
            return content; 
        }

        private static string implParseJson() {
            return "";

        }

        public static string parseXML(string xml_str) {
            try
            {

                XmlDocument xmlDoc = new XmlDocument();//初始化一个xml实例
                xmlDoc.LoadXml(xml_str);
                XmlNode root = xmlDoc.SelectSingleNode("/");
                XmlNodeList childlist = root.ChildNodes;
                return implParseXML(childlist);
            }
            catch (Exception e) {
                return "";
            }
        }
        private static string implParseXML(XmlNodeList childlist)
        {
            string content = "";
            foreach (XmlNode xn in childlist)
            {
                if (xn.GetType() == typeof(System.Xml.XmlDeclaration))
                {
                    continue;
                }
                XmlElement xe = (XmlElement)xn;
                XmlNodeList subList = xn.ChildNodes;
                if (subList.Count == 1)
                {
                    content += xe.Name + " : " + xe.InnerText + "\n";
                }
                else
                {
                    content += implParseXML(subList);
                }

            }
            return content;

        }
    }
}
