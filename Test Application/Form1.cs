using Sres.Net.EEIP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Application
{
    /* Samples of this can be found at
     * http://eeip-library.de/codesamples/
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteDigitalOutput_Click(object sender, EventArgs e)
        {
            EEIPClient eeipClient = new EEIPClient();

            //Register Session (Wago-Device 750-352 IP-Address: 192.168.178.66) 
            //we use the Standard Port for Ethernet/IP TCP-connections 0xAF12
            eeipClient.RegisterSession("192.168.178.66");

            //We write an Output to the Wago-Device; According to the Manual of the Device
            //Instance 0x66 of the Assembly Object contains the Digital Output data
            //The Documentation can be found at: http://www.wago.de/download.esm?file=%5Cdownload%5C00368362_0.pdf&name=m07500352_xxxxxxxx_0en.pdf

            //We set the first output "High"
            eeipClient.AssemblyObject.setInstance(0x66, new byte[] { 0x01 });

            System.Threading.Thread.Sleep(1000);

            //We set the secoond output "High"
            eeipClient.AssemblyObject.setInstance(0x66, new byte[] { 0x02 });

            System.Threading.Thread.Sleep(1000);

            //We set the secoond output "High"
            eeipClient.AssemblyObject.setInstance(0x66, new byte[] { 0x03 });

            System.Threading.Thread.Sleep(1000);

            //We reset the outputs
            eeipClient.AssemblyObject.setInstance(0x66, new byte[] { 0x00 });

            //When done, we unregister the session
            eeipClient.UnRegisterSession();
        }

        private void AddResult(string result)
        {
            tbResults.Text += "\r\n" + result;
        }

        private void btnReadDI_Click(object sender, EventArgs e)
        {
            tbResults.Clear();
            
            EEIPClient eeipClient = new EEIPClient();

            //Register Session (Wago-Device 750-352 IP-Address: 192.168.178.66) 
            //we use the Standard Port for Ethernet/IP TCP-connections 0xAF12
            eeipClient.RegisterSession(tbIpAddress.Text, ushort.Parse(tbPort.Text));

            //Get the State of a digital Input According to the Manual
            //Instance 0x6C of the Assembly Object contains the Digital Input data
            //The Documentation can be found at: http://www.wago.de/download.esm?file=%5Cdownload%5C00368362_0.pdf&name=m07500352_xxxxxxxx_0en.pdf
            byte[] digitalInputs = eeipClient.AssemblyObject.getInstance(0x6c);

            AddResult("State of Digital Input 1: " + (EEIPClient.ToBool(digitalInputs[0], 0)));
            AddResult("State of Digital Input 2: " + (EEIPClient.ToBool(digitalInputs[0], 1)));
            AddResult("State of Digital Input 3: " + (EEIPClient.ToBool(digitalInputs[0], 2)));
            AddResult("State of Digital Input 4: " + (EEIPClient.ToBool(digitalInputs[0], 3)));
            AddResult("State of Digital Input 5: " + (EEIPClient.ToBool(digitalInputs[0], 4)));


            //When done, we unregister the session
            eeipClient.UnRegisterSession();
            Console.ReadKey();
        }

        private void btnWriteValues_Click(object sender, EventArgs e)
        {
            EEIPClient eeipClient = new EEIPClient();
            eeipClient.IPAddress = "192.168.0.123";
            eeipClient.RegisterSession();
            byte[] response = eeipClient.GetAttributeSingle(0x66, 1, 0x325);
            Console.WriteLine("Current Value Sensor 1: " + (response[1] * 255 + response[0]).ToString());
            response = eeipClient.GetAttributeSingle(0x66, 2, 0x325);
            Console.WriteLine("Current Value Sensor 2: " + (response[1] * 255 + response[0]).ToString());
            Console.WriteLine();
            Console.Write("Enter intensity for Sensor 1 [1..100]");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Set Light intensity Sensor 1 to " + value + "%");
            eeipClient.SetAttributeSingle(0x66, 1, 0x389, new byte[] { (byte)value, 0 });
            Console.Write("Enter intensity for Sensor 2 [1..100]");
            value = int.Parse(Console.ReadLine());
            Console.WriteLine("Set Light intensity Sensor 2 to " + value + "%");
            eeipClient.SetAttributeSingle(0x66, 2, 0x389, new byte[] { (byte)value, 0 });
            Console.WriteLine();
            Console.WriteLine("Read Values from device to approve the value");
            response = eeipClient.GetAttributeSingle(0x66, 1, 0x389);
            Console.WriteLine("Current light Intensity Sensor 1 in %: " + (response[1] * 255 + response[0]).ToString());
            response = eeipClient.GetAttributeSingle(0x66, 2, 0x389);
            Console.WriteLine("Current light Intensity Sensor 2 in %: " + (response[1] * 255 + response[0]).ToString());
            eeipClient.UnRegisterSession();
            Console.ReadKey();
        }

        private void btnDiscover_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            Sres.Net.EEIP.EEIPClient eipClient = new Sres.Net.EEIP.EEIPClient();
            List<Sres.Net.EEIP.Encapsulation.CIPIdentityItem> cipIdentityItem = eipClient.ListIdentity();

            for (int i = 0; i < cipIdentityItem.Count; i++)
            {
                //Console.WriteLine("Ethernet/IP Device Found:");
                //Console.WriteLine(cipIdentityItem[i].ProductName1);
                ListViewItem lvi = new ListViewItem(cipIdentityItem[i].ProductName1);
                //Console.WriteLine("IP-Address: " + Sres.Net.EEIP.Encapsulation.CIPIdentityItem.getIPAddress(cipIdentityItem[i].SocketAddress.SIN_Address));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, Sres.Net.EEIP.Encapsulation.CIPIdentityItem.getIPAddress(cipIdentityItem[i].SocketAddress.SIN_Address)));
                //Console.WriteLine("Port: " + cipIdentityItem[i].SocketAddress.SIN_port);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, cipIdentityItem[i].SocketAddress.SIN_port.ToString()));
                //Console.WriteLine("Vendor ID: " + cipIdentityItem[i].VendorID1);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, cipIdentityItem[i].VendorID1.ToString()));
                //Console.WriteLine("Product-code: " + cipIdentityItem[i].ProductCode1);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, cipIdentityItem[i].ProductCode1.ToString()));
                //Console.WriteLine("Type-Code: " + cipIdentityItem[i].ItemTypeCode);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, cipIdentityItem[i].ItemTypeCode.ToString()));
                //Console.WriteLine("Serial Number: " + cipIdentityItem[i].SerialNumber1);
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, cipIdentityItem[i].SerialNumber1.ToString()));
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                return;
            }
            tbIpAddress.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tbPort.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
