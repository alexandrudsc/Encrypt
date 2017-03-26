using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuSelectEncrypt(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            criptareToolStripMenuItem.Text = item.Text;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            switch (criptareToolStripMenuItem.Text)
            {
                case "Greek":
                    txtEncrypt.Text =  EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.GREEK, new object[] { 6 });
                    break;
                case "Caesar":
                    txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.CAESAR, new object[] { 4 });
                    break;
                case "ADFGVX":
                    txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.ADFGVX, new object[] { "orange", "water"});
                    break;
            }

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            switch (criptareToolStripMenuItem.Text)
            {
                case "Greek":
                    txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.GREEK, new object[] { 6 });
                    break;
                case "Caesar":
                    txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.CAESAR, new object[] { 4 });
                    break;
                case "ADFGVX":
                    txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.ADFGVX, new object[] { "orange", "water" });
                    break;
            }
        }
    }
}
