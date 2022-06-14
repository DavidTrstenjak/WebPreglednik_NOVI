using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using EasyTabs;

namespace webPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitChromium();
        }
        public ChromiumWebBrowser c;
        public void InitChromium()
        {
            if (!Cef.IsInitialized)
            {
                Cef.Initialize(new CefSettings());
            }

            c = new ChromiumWebBrowser("https://www.google.com/");
            c.AddressChanged += C_AddressChanged;
            c.TitleChanged += C_TitleChanged;
            this.panel1.Controls.Add(c);
            CheckForIllegalCrossThreadCalls = false;
        }

        private void C_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Text = e.Title;
        }

        private void C_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            textBox1.Text = e.Address.ToString();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            c.Back();
        }

        private void naprijed_Click(object sender, EventArgs e)
        {
            c.Forward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.Load(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.Load("https://chrome://bookmarks/");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}