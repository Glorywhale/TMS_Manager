using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml;

namespace TMS_Manager
{
    public class XmlConfig
    {
        public string AppConfigRead(string keyName)
        {
            string strReturn;
            Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (currentConfig.AppSettings.Settings.AllKeys.Contains(keyName))
                strReturn = currentConfig.AppSettings.Settings[keyName].Value;
            else
                strReturn = ""; //키가없으면.
            return strReturn;
        }

        public bool AppConfigWrite(string keyName, string value)
        {
            Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (currentConfig.AppSettings.Settings.AllKeys.Contains(keyName)) //키가 있으면
                currentConfig.AppSettings.Settings[keyName].Value = value;
            else       //키가 없으면
                currentConfig.AppSettings.Settings.Add(keyName, value);
            currentConfig.Save();
            ConfigurationManager.RefreshSection("appSettings");   // 내용 갱신              
            return true;
        }
                
        public string XmlReadStr(string NodePath)
        {
            string strInnerText = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Config.xml");
                strInnerText = doc.SelectSingleNode(NodePath).InnerText;

                return strInnerText;
            }
            catch (Exception ex)
            {
                Console.WriteLine(NodePath + "/" + ex.ToString());
                return strInnerText;
            }
        }

        public int XmlReadInt(string NodePath)
        {
            int nInnerValue = 0;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Config.xml");
                nInnerValue = Convert.ToInt32(doc.SelectSingleNode(NodePath).InnerText);

                return nInnerValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(NodePath + "/" + ex.ToString());
                return nInnerValue;
            }
        }

        public void XmlWriteStr(string NodePath, string Value)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Config.xml");
                XmlNode node = doc.SelectSingleNode(NodePath);
                node.InnerText = Value;
                doc.Save("Config.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(NodePath + "/" + ex.ToString());
            }
        }

        public void XmlWriteInt(string NodePath, int Value)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Config.xml");
                XmlNode node = doc.SelectSingleNode(NodePath);
                node.InnerText = Value.ToString();
                doc.Save("Config.xml");
            }
            catch (Exception ex)
            {
                Console.WriteLine(NodePath + "/" + ex.ToString());
            }
        }
    }
}
