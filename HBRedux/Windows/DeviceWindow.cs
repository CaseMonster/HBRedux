using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HBRedux
{
    public partial class DeviceWindow : Form
    {
        public DeviceWindow()
        {
            InitializeComponent();
            this.Show();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string s = openFileDialog1.FileName;
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (IPTextBox.Text == "" || NameTextBox.Text == "")
            {
                Log.error("It appears as if the Name or IP box are empty, both of these are required.");
            }
            else
            {
                XML.AddDevice(new Device(NameTextBox.Text, IPTextBox.Text, MiscTextBox.Text, DeviceTypeTextBox.Text));
                this.Close();
            }
        }
    }
}
