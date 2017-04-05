using System;
using System.Windows.Forms;

namespace Encrypted_messager
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkToTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void About_Load(object sender, EventArgs e)
        {
            linkToTwitter.Links.Add(0, linkToTwitter.Text.Length, "https://twitter.com/boomtnt46");
            linkToGithub.Links.Add(0, linkToGithub.Text.Length, "https://github.com/boomtnt46/easycrypt");
        }

        private void linkToGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void pgpsharplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
