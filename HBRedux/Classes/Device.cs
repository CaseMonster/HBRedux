using System;

namespace HBRedux
{
    class Device
    {
        public string id = "null";
        public string name = "null";
        public string ip = "null";
        public string description = "null";
        public string type = "null";
        public bool online = false;
        public DateTime lastseen = DateTime.Now;

        public Device (string a, string b, string c, string d, string e)
        {
            id = a;
            name = b;
            ip = c;
            description = d;
            type = e;
        }

        public Device(string a, string b, string c, string d)
        {
            id = GenKey();
            name = a;
            ip = b;
            description = c;
            type = d;
        }

        public static string GenKey()
        {
            byte[] random = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            System.Security.Cryptography.RNGCryptoServiceProvider prov = new System.Security.Cryptography.RNGCryptoServiceProvider();
            prov.GetBytes(random);
            int i = BitConverter.ToInt32(random, 0);

            if (i < 0) i = i * (-1);
            return i.ToString();
        }
    }
}
