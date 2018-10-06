using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace HBRedux
{
    class XML
    {
        public static string DEVICE_FILE = "cfg\\devices.xml";
        public static string OFFLINE_FILE = "cfg\\offline.xml";
        public static string SETTINGS_FILE = "cfg\\settings.xml";

        public XML()
        {
        }

        public static void test()
        {
            AddDevice(new Device("test", "1.1.1.1", "just a test", "Text box"));
        }

        public static void test2()
        {
            //RemoveDevice(new Device("test", "1.1.1.1", "just a test"));
        }

        public static ArrayList ReadXML()
        {
            CheckXML();

            var doc = XDocument.Load(DEVICE_FILE);
            var list = from d in doc.Descendants("Device")
                          select new Device
                          (
                              (string)d.Element("ID"),
                              (string)d.Element("Name"),
                              (string)d.Element("IP"),
                              (string)d.Element("Description"),
                              (string)d.Element("Type")
                          );
            ArrayList array = new ArrayList();
            foreach(Device d in list)
                array.Add(d);
            return array;
        }


        public static void AddDevice(Device d)
        {
            CheckXML();

            var doc = XDocument.Load(DEVICE_FILE);
            XElement newDevice = new XElement("Device",
                new XElement("ID", d.id),
                new XElement("Name", d.name),
                new XElement("IP", d.ip),
                new XElement("Description", d.description),
                new XElement("Type", d.type)
            );
            doc.Root.Add(newDevice);
            doc.Save(DEVICE_FILE);
            Log.info(d, "Device Added");
        }

        public static void RemoveDevice(string id)
        {
            var doc = XDocument.Load(DEVICE_FILE);

            var del = (from xml in doc.Descendants("Device")
                       where xml.Element("ID").Value == id.ToString()
                           select xml).FirstOrDefault();
            try
            {
                del.Remove();
                Log.info("Device Removed");
            }
            catch
            {
                Log.error("There was a problem deleting the device.");
            }
            doc.Save(DEVICE_FILE);
        }

        public void EditDevice(Device d)
        {
            RemoveDevice(d.id);
            AddDevice(d);
        }



        public void AddOffline(Device d)
        {

                
        }

        public void ClearOffline(Device d)
        {


        }

        public void WriteSettings()
        {


        }

        public static void CheckXML()
        {
            //If file doesn't exist, recreate it
            if(!File.Exists(DEVICE_FILE))
            {
                Log.info("Device.xml does not exist, recreating it.");

                StreamWriter f = File.CreateText(DEVICE_FILE);
                f.Close();

                var doc = new XDocument
                (
                    new XElement
                    (
                        "HBRedux",
                        new XElement
                        (
                            "Device",
                            new XElement("ID", Device.GenKey()),
                            new XElement("Name", "Google DNS"),
                            new XElement("IP", "8.8.8.8"),
                            new XElement("Description", "Google's Primary DNS Server"),
                            new XElement("Type", "Internet Server")
                        ),
                        new XElement
                        (
                            "Device",
                            new XElement("ID", Device.GenKey()),
                            new XElement("Name", "Level 3 Anycast"),
                            new XElement("IP", "4.2.2.1"),
                            new XElement("Description", "Level 3 Communications Anycast Backbone IP"),
                            new XElement("Type", "Internet Router")
                        )
                    )
                );
                doc.Save(DEVICE_FILE);
            }

            //Check file, backup and recreate if broken
            try
            {
                var doc = XDocument.Load(DEVICE_FILE);
            }
            catch(Exception e)
            {
                Log.error("Device.xml appears to be corrupted, backing up and recreating it.");
                Log.info(e.ToString());
                if(File.Exists(DEVICE_FILE + ".backup"))
                    File.Delete(DEVICE_FILE + ".backup");
                File.Move(DEVICE_FILE, DEVICE_FILE + ".backup");
                CheckXML();
            }
        }
    }
}
