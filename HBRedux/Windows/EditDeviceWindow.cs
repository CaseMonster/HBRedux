
using System.Collections;

namespace HBRedux
{
    public partial class EditDeviceWindow : HBRedux.DeviceWindow
    {
        public EditDeviceWindow(string s)
        {
            //Find and retrieve edit device
            ArrayList array = XML.ReadXML();
            foreach (Device d in array)
            {
                if (d.id == s)
                {
                    //Populate boxes
                    NameTextBox.Text = d.name;
                    IPTextBox.Text = d.ip;
                    DeviceTypeTextBox.Text = d.type;
                    MiscTextBox.Text = d.type;
                };
            };
        }
    }
}
