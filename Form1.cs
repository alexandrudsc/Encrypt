﻿using Encryption.ui;
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
                    SimpleInput simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    { 
                        txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.GREEK, new object[] { simpleInput.txtKey.Text });
                    }
                    break;
                case "Caesar":
                    simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.CAESAR, new object[] { simpleInput.txtKey.Text });
                    }
                    break;

                case "Playfair":
                    simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.PLAYFAIR, new object[] { simpleInput.txtKey.Text });
                    }
                    break;

                case "ADFGVX":
                    DoubleInput doubleInput = new DoubleInput();
                    if (doubleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.ADFGVX, new object[] { doubleInput.txtKey1.Text, doubleInput.txtKey2.Text });
                    }
                    break;

                case "Homophonic":
                    txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.HOMOPHONIC, new object[] { });
                    break;
                case "Enigma":
                    simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.ENIGMA, new object[] { simpleInput.txtKey.Text });
                    }
                    break;

                case "DES":
                    simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.DES, new object[] { simpleInput.txtKey.Text });
                    }
                    break;
                case "RSA":
                    MessageBox.Show("In the next dialog, select number of bits for the key.");
                    simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtEncrypt.Text = EncryptionHelper.Encrypt(txtNormal.Text, EncryptionHelper.EncryptionMode.RSA, new object[] { simpleInput.txtKey.Text });
                    }
                    break;
                default:
                    MessageBox.Show("Select encryption mode from menu.");
                    break;
            }

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            switch (criptareToolStripMenuItem.Text)
            {
                case "Greek":
                    SimpleInput simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.GREEK, new object[] { simpleInput.txtKey.Text });
                    }
                    break;
                case "Caesar":
                    simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.CAESAR, new object[] { simpleInput.txtKey.Text });
                    }
                    break;

                case "Playfair":
                    simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.PLAYFAIR, new object[] { simpleInput.txtKey.Text });
                    }
                    break;

                case "ADFGVX":
                    DoubleInput doubleInput = new DoubleInput();
                    if (doubleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.ADFGVX, new object[] { doubleInput.txtKey1.Text, doubleInput.txtKey2.Text });
                    }
                    break;
                case "Homophonic":
                    txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.HOMOPHONIC, new object[] { });
                    break;
                case "Enigma":
                    simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                    {
                        txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.ENIGMA, new object[] { simpleInput.txtKey.Text });
                    }
                    break;
                    // TODO: add message for DES
                case "RSA":
                    MessageBox.Show("In the next dialog, select number of bits for the key.");
                    simpleInput = new SimpleInput();
                    if (simpleInput.ShowDialog() == DialogResult.OK)
                        txtNormal.Text = EncryptionHelper.Decrypt(txtEncrypt.Text, EncryptionHelper.EncryptionMode.RSA, new object[] { simpleInput.txtKey.Text });
                    break;

                default:
                    MessageBox.Show("Select encryption mode from menu.");
                    break;
            }
        }
    }
}
