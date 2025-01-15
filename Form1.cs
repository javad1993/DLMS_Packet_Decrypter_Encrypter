using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLMS_Packet_Decrypter_Encrypter
{
    public enum Security
    {
        None = 0,
        Authentication = 0x10,
        Encryption = 0x20,
        AuthenticationEncryption = 0x30,
    }
    public partial class Form1 : Form
    {
        private const string EK_Path = "Encryption Keys.txt";
        private const string AK_Path = "Authentication Keys.txt";
        private const string SystemTitle_Path = "System Titles.txt";

        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckEK(ref string str)
        {
            if (cmbEK.Text == "")
                return false;
            if (!ExtractString(ref str, 32))
                return false;

            return true;
        }
        private bool CheckAK(ref string str)
        {
            if (str == "")
                return false;
            if (!ExtractString(ref str, 32))
                return false;

            return true;
        }
        private bool CheckSystemTitle(ref string str)
        {
            if (str == "")
                return false;
            if (!ExtractString(ref str, 16))
                return false;

            return true;
        }
        private bool CheckFrameCounter(ref string str)
        {
            if (str == "")
                return false;
            if (!ExtractString(ref str, 8))
                return false;

            return true;
        }
        private bool CheckTag(ref string str)
        {
            if (str == "")
                return false;
            if (!ExtractString(ref str, 24))
                return false;

            return true;
        }
        private bool CheckInputText(ref string str)
        {
            if (str == "")
                return false;
            if (!ExtractString(ref str, -1))
                return false;

            return true;
        }
        private bool ExtractString(ref string inStr, int len)
        {
            inStr = inStr.Replace(" ", "");
            inStr = inStr.Replace(",", "");
            inStr = inStr.Replace("0x", "");
            inStr = inStr.Replace("\r\n", "");

            if (len != -1)
            {
                if (inStr.Length != len)
                    return false;
            }

            inStr = inStr.ToUpper();

            foreach (char ch in inStr)
            {
                if ((ch < '0' || ch > '9') && (ch < 'A' || ch > 'F'))
                {
                    return false;
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDefaultEncryptionKeys();
            LoadDefaultAuthenticationKeys();
            LoadDefaultSystemTitles();

            rdbEandA.Enabled = false;
            rdbEncrypted.Enabled = false;
            rdbAuthenticated.Enabled = false;
            rdbDecryption.Checked = true;
        }

        private void LoadDefaultEncryptionKeys()
        {
            cmbEK.Items.Clear();
            if (!File.Exists(EK_Path))
            {
                // Create the file
                using (FileStream fs = File.Create(EK_Path)) ;
            }
            if (File.Exists(EK_Path))
            {
                using (StreamReader reader = new StreamReader(EK_Path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) // Read line by line
                    {
                        if (line != "")
                            cmbEK.Items.Add(line);
                    }
                    if (cmbEK.Items.Count > 0)
                        cmbEK.SelectedIndex = 0;
                }
            }
        }

        private void LoadDefaultAuthenticationKeys()
        {
            cmbAK.Items.Clear();
            if (!File.Exists(AK_Path))
            {
                // Create the file
                using (FileStream fs = File.Create(AK_Path)) ;
            }
            if (File.Exists(AK_Path))
            {
                using (StreamReader reader = new StreamReader(AK_Path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) // Read line by line
                    {
                        if (line != "")
                            cmbAK.Items.Add(line);
                    }
                    if (cmbAK.Items.Count > 0)
                        cmbAK.SelectedIndex = 0;
                }
            }
        }

        private void LoadDefaultSystemTitles()
        {
            cmbSystemTitle.Items.Clear();
            if (!File.Exists(SystemTitle_Path))
            {
                // Create the file
                using (FileStream fs = File.Create(SystemTitle_Path)) ;
            }
            if (File.Exists(SystemTitle_Path))
            {
                using (StreamReader reader = new StreamReader(SystemTitle_Path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null) // Read line by line
                    {
                        if (line != "")
                            cmbSystemTitle.Items.Add(line);
                    }
                    if (cmbSystemTitle.Items.Count > 0)
                        cmbSystemTitle.SelectedIndex = 0;
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            string EK_Text = cmbEK.Text;
            string AK_Text = cmbAK.Text;
            string SystemTitle_Text = cmbSystemTitle.Text;
            string FrameCounter_Text = txtFrameCounter.Text;
            string Tag_Text = txtTag.Text;
            string Cipher_Text = txtInputText.Text;

            if (!CheckEK(ref EK_Text))
            {
                MessageBox.Show("Encryption Key not Correct!!!");
                return;
            }
            if (!CheckAK(ref AK_Text))
            {
                MessageBox.Show("Authentication Key not Correct!!!");
                return;
            }
            if (!CheckSystemTitle(ref SystemTitle_Text))
            {
                MessageBox.Show("System Title not Correct!!!");
                return;
            }
            if (!CheckFrameCounter(ref FrameCounter_Text))
            {
                MessageBox.Show("Frame Counter not Correct!!!");
                return;
            }
            if (rdbDecryption.Checked == true)
            {
                if (!CheckTag(ref Tag_Text))
                {
                    MessageBox.Show("Tag not Correct!!!");
                    return;
                }
            }
            
            if (!CheckInputText(ref Cipher_Text))
            {
                MessageBox.Show("Input Text not Correct!!!");
                return;
            }

            // Convert the string into a byte array
            byte[] FrameCounter_Byte = Enumerable.Range(0, FrameCounter_Text.Length / 2)
                .Select(i => Convert.ToByte(FrameCounter_Text.Substring(i * 2, 2), 16))
                .ToArray();

            byte[] SystemTitle_Byte = Enumerable.Range(0, SystemTitle_Text.Length / 2)
                .Select(i => Convert.ToByte(SystemTitle_Text.Substring(i * 2, 2), 16))
                .ToArray();

            byte[] EK_Byte = Enumerable.Range(0, EK_Text.Length / 2)
                .Select(i => Convert.ToByte(EK_Text.Substring(i * 2, 2), 16))
                .ToArray();

            byte[] AK_Byte = Enumerable.Range(0, AK_Text.Length / 2)
                .Select(i => Convert.ToByte(AK_Text.Substring(i * 2, 2), 16))
                .ToArray();

            byte[] Tag_Byte = new byte[12];
            if (rdbDecryption.Checked == true)
            {
                //Tag_Text += "00000000";
                Tag_Byte = Enumerable.Range(0, Tag_Text.Length / 2)
                    .Select(i => Convert.ToByte(Tag_Text.Substring(i * 2, 2), 16))
                    .ToArray();
            }

            byte[] Cipher_Byte = Enumerable.Range(0, Cipher_Text.Length / 2)
                .Select(i => Convert.ToByte(Cipher_Text.Substring(i * 2, 2), 16))
                .ToArray();

            if (rdbDecryption.Checked == true)
            {
                Decrypt(Security.AuthenticationEncryption, FrameCounter_Byte
                                , SystemTitle_Byte
                                , EK_Byte
                                , Cipher_Byte
                                , Tag_Byte);
            }
            else if(rdbEncryption.Checked == true)
            {
                Encrypt(Security.AuthenticationEncryption, FrameCounter_Byte
                                , SystemTitle_Byte
                                , EK_Byte
                                , Cipher_Byte);
            }
        }
        private void Decrypt(Security security, byte[] frameCounter,
                            byte[] systemTitle, byte[] key, byte[] cipherText, byte[] tag)
        {
            byte[] IV = new byte[12];

            Buffer.BlockCopy(systemTitle, 0, IV, 0, 8);
            Buffer.BlockCopy(frameCounter, 0, IV, 8, 4);

            byte[] decrypted = DecryptAESGCM(key, IV, cipherText, tag);
            txtOutputText.Text = String.Join(" ", Array.ConvertAll(decrypted, byteValue => byteValue.ToString("X2"))); ;
        }

        public static byte[] DecryptAESGCM(byte[] key, byte[] iv, byte[] cipherText, byte[] tag)
        {
            // Combine ciphertext and tag as required by BouncyCastle
            byte[] combined = new byte[cipherText.Length + tag.Length];
            Array.Copy(cipherText, 0, combined, 0, cipherText.Length);
            Array.Copy(tag, 0, combined, cipherText.Length, tag.Length);

            // Set up decryption parameters
            var parameters = new AeadParameters(new KeyParameter(key), 96, iv, null);
            var cipher = new Org.BouncyCastle.Crypto.Modes.GcmBlockCipher(new Org.BouncyCastle.Crypto.Engines.AesEngine());
            cipher.Init(false, parameters); // false = decryption mode

            // Decrypt the data
            byte[] plainText = new byte[cipher.GetOutputSize(combined.Length)];
            int length = cipher.ProcessBytes(combined, 0, combined.Length, plainText, 0);
            //cipher.DoFinal(plainText, length);

            return plainText;
        }
        private void Encrypt(Security security, byte[] frameCounter,
                            byte[] systemTitle, byte[] key, byte[] plainText)
        {
            byte[] IV = new byte[12];

            Buffer.BlockCopy(systemTitle, 0, IV, 0, 8);
            Buffer.BlockCopy(frameCounter, 0, IV, 8, 4);

            var (cipherText, tag) = EncryptAESGCM(key, IV, plainText);

            txtOutputText.Text = String.Join(" ", Array.ConvertAll(cipherText, byteValue => byteValue.ToString("X2"))); ;
            txtTag.Text = String.Join(" ", Array.ConvertAll(tag, byteValue => byteValue.ToString("X2"))); ;
        }

        private static (byte[] cipherText, byte[] tag) EncryptAESGCM(byte[] key, byte[] iv, byte[] plainText)
        {
            var parameters = new AeadParameters(new KeyParameter(key), 96, iv, null);
            var cipher = new Org.BouncyCastle.Crypto.Modes.GcmBlockCipher(new Org.BouncyCastle.Crypto.Engines.AesEngine());
            cipher.Init(true, parameters); // true = encryption mode

            // Allocate buffer for ciphertext and authentication tag
            byte[] cipherText = new byte[cipher.GetOutputSize(plainText.Length)];
            int len = cipher.ProcessBytes(plainText, 0, plainText.Length, cipherText, 0);
            cipher.DoFinal(cipherText, len);

            // Extract the authentication tag (last 16 bytes of the output)
            int tagLength = 12; // Default tag length for AES-GCM
            byte[] tag = new byte[tagLength];
            Array.Copy(cipherText, cipherText.Length - tagLength, tag, 0, tagLength);

            // Return ciphertext without the tag and the extracted tag separately
            Array.Resize(ref cipherText, cipherText.Length - tagLength);
            return (cipherText, tag);
        }

        private void rdbEncrypted_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbEncrypted.Checked == true)
            {
                txtTag.Enabled = false;
                cmbAK.Enabled = false;
            }
        }

        private void rdbEandA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEandA.Checked == true)
            {
                txtTag.Enabled = true;
                cmbAK.Enabled = true;
            }
        }

        private void rdbDecryption_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbDecryption.Checked == true)
            {
                lblInputText.Text = "CipherText";
                txtTag.Enabled = true;
            }
        }

        private void rdbEncryption_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEncryption.Checked == true)
            {
                lblInputText.Text = "PlainText";
                txtTag.Enabled = false;
            }
        }

        private void lblRayatinLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rayatin.ir");
        }

        private void btnSaveEK_Click(object sender, EventArgs e)
        {
            if (File.Exists(EK_Path))
            {
                string fileContents = File.ReadAllText(EK_Path);

                if (!fileContents.Contains(cmbEK.Text))
                {
                    using (StreamWriter writer = new StreamWriter(EK_Path, append: true))
                    {
                        writer.WriteLine(cmbEK.Text);
                    }
                }
            }
            else
            {
                // If the file doesn't exist, create it and add the string
                using (StreamWriter writer = new StreamWriter(EK_Path))
                {
                    writer.WriteLine(cmbEK.Text);
                }
            }
            LoadDefaultEncryptionKeys();
            MessageBox.Show("Saved");
        }

        private void btnRemoveEK_Click(object sender, EventArgs e)
        {
            string path = EK_Path;
            if (File.Exists(path))
            {
                List<string> lines = new List<string>(File.ReadAllLines(path));
                bool lineRemoved = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains(cmbEK.Text))
                    {
                        lines.RemoveAt(i);
                        lineRemoved = true;
                        break;
                    }
                }

                if (lineRemoved)
                {
                    File.WriteAllLines(path, lines);
                }   
            }
            LoadDefaultEncryptionKeys();
            MessageBox.Show("Done");
        }

        private void btnSaveAK_Click(object sender, EventArgs e)
        {
            string path = AK_Path;

            if (File.Exists(path))
            {
                string fileContents = File.ReadAllText(path);

                if (!fileContents.Contains(cmbAK.Text))
                {
                    using (StreamWriter writer = new StreamWriter(path, append: true))
                    {
                        writer.WriteLine(cmbAK.Text);
                    }
                }
            }
            else
            {
                // If the file doesn't exist, create it and add the string
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(cmbAK.Text);
                }
            }
            LoadDefaultAuthenticationKeys();
            MessageBox.Show("Saved");
        }

        private void btnRemoveAK_Click(object sender, EventArgs e)
        {
            string path = AK_Path;
            if (File.Exists(path))
            {
                List<string> lines = new List<string>(File.ReadAllLines(path));
                bool lineRemoved = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains(cmbAK.Text))
                    {
                        lines.RemoveAt(i);
                        lineRemoved = true;
                        break;
                    }
                }

                if (lineRemoved)
                {
                    File.WriteAllLines(path, lines);
                }
            }
            LoadDefaultAuthenticationKeys();
            MessageBox.Show("Done");
        }

        private void btnSaveSystemTitle_Click(object sender, EventArgs e)
        {
            string path = SystemTitle_Path;

            if (File.Exists(path))
            {
                string fileContents = File.ReadAllText(path);

                if (!fileContents.Contains(cmbSystemTitle.Text))
                {
                    using (StreamWriter writer = new StreamWriter(path, append: true))
                    {
                        writer.WriteLine(cmbSystemTitle.Text);
                    }
                }
            }
            else
            {
                // If the file doesn't exist, create it and add the string
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(cmbSystemTitle.Text);
                }
            }
            LoadDefaultSystemTitles();
            MessageBox.Show("Saved");
        }

        private void btnRemoveSystemTitle_Click(object sender, EventArgs e)
        {
            string path = SystemTitle_Path;
            if (File.Exists(path))
            {
                List<string> lines = new List<string>(File.ReadAllLines(path));
                bool lineRemoved = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains(cmbSystemTitle.Text))
                    {
                        lines.RemoveAt(i);
                        lineRemoved = true;
                        break;
                    }
                }

                if (lineRemoved)
                {
                    File.WriteAllLines(path, lines);
                }
            }
            LoadDefaultSystemTitles();
            MessageBox.Show("Done");
        }
    }
}
