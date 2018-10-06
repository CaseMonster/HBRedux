using System;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace HBRedux
{
    public partial class MainWindow : Form
    {
        string indexSelected = "null";

        public MainWindow()
        {
            InitializeComponent();

            //toolStripStatusLabel1.Text = "Total Devices: " + deviceTotal;
            //toolStripStatusLabel2.Text = "Online: " + deviceOnline;
            //toolStripStatusLabel3.Text = "Offline: " + deviceOffline;

            InitListView();
        }

        private void DeviceNewMenu_Click(object sender, EventArgs e)
        {
            new AddDeviceWindow();
            InitListView();
        }

        private void DeviceEditMenu_Click(object sender, EventArgs e)
        {
            try
            {
                new EditDeviceWindow(((ObjectListView)sender).SelectedItem.Text);
                InitListView();
            }
            catch
            {
                Log.error("You need to select a device to edit.");
            }
        }

        private void DeviceDeleteMenu_Click(object sender, EventArgs e)
        {

        }

        private void FileExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpHomepageMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://google.com");
        }

        private void HelpAboutMenu_Click(object sender, EventArgs e)
        {
            new AboutWindow();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XML.test();
            InitListView();
        }

        private void removeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XML.test2();
            InitListView();
        }

        private void FileSettingsMenu_Click(object sender, EventArgs e)
        {
            new SettingsWindow();
        }

        private void InitListView()
        {
            //Display items from XML
            objectListView1.SetObjects(XML.ReadXML());
            objectListView1.Refresh();
        }

        private void objectListView1_ItemActivate(object sender, EventArgs e)
        {
            new EditDeviceWindow(((ObjectListView)sender).SelectedItem.Text);
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                indexSelected = ((ObjectListView)sender).SelectedItem.Text;
            }
            catch
            {

            };
        }
    }
}
