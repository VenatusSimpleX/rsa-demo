using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;

namespace RSADemo
{
    public partial class RSADemoMain : Form
    {
        public RSADemoMain()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs ea)
        {
            // Data validation
            // Check if primes are selected and different
            // p and q are already assigned if this checking is successful
            if (!int.TryParse(comboBoxP.Text, out int p) || !int.TryParse(comboBoxQ.Text, out int q) || p == q)
            {
                MessageBox.Show("Primes p and q must be selected and different");
                return;
            }

            // Step 1: Find the n and euler's totient (phi(n))
            int n = p * q;
            int phi = (p - 1) * (q - 1);

            textBoxN.Text = n.ToString();
            textBoxPhiN.Text = phi.ToString();
        }

        private void ButtonFindD_Click(object sender, EventArgs ea)
        {
            // Data validation
            // Make sure n was calculated first
            if (!int.TryParse(textBoxN.Text, out int _))
            {
                MessageBox.Show("Find n using settings above first");
                return;
            }

            // Step 2: Get e
            // Validate that e is an integer
            if (!int.TryParse(textBoxE.Text, out int e))
            {
                MessageBox.Show("e must be an integer");
                return;
            }

            // Validate that e is bigger than one, and smaller than phi(n)
            int.TryParse(textBoxPhiN.Text, out int phi);
            if(e <= 1 || e > phi)
            {
                MessageBox.Show("e must be bigger than 1, and smaller than phi(n)");
                return;
            }

            // Step 3: Find d based on e
            int d;
            for(int i = 1; i <= phi * 2; i++)
            {
                if((i * e) % phi == 1)
                {
                    d = i;

                    textBoxD.Text = d.ToString();
                    labelResults.Text = $"e = {e}; d = {d}";
                    labelResults.Visible = true;
                    buttonEncryptDecrypt.Enabled = true;
                    break;
                }

                labelResults.Visible = false;
            }

            // Check if d was found
            if (!labelResults.Visible)
            {
                textBoxD.Text = "Not found";
                textBoxCiphertext.Clear();
                textBoxCiphertextToPlaintext.Clear();
                buttonEncryptDecrypt.Enabled = false;
                return;
            }
        }

        private void ButtonAutoFindE_Click(object sender, EventArgs ea)
        {
            int.TryParse(textBoxPhiN.Text, out int phi);
            int e = 0; // Initialize as 0 first to check if e was found later

            for (int i = 2; i < phi; i++)
            {
                for (int j = 1; j <= phi * 2; j++)
                {
                    if ((j * i) % phi == 1)
                    {
                        e = i;
                        textBoxE.Text = e.ToString();
                        break;
                    }
                }

                if (e != 0)
                {
                    break;
                }
            }
        }

        private void ButtonEncryptDecrypt_Click(object sender, EventArgs ea)
        {
            // Data Validation
            int.TryParse(comboBoxP.Text, out int p);
            int.TryParse(comboBoxQ.Text, out int q);
            int.TryParse(textBoxD.Text, out int d);
            int.TryParse(textBoxE.Text, out int e);
            int.TryParse(textBoxN.Text, out int n);

            // Check if maths mode or ASCII mode
            if (radioButtonMathsMode.Checked)
            {
                // Validate if plaintext is only integer
                // plaintext is assigned if this checking is successful
                if (!int.TryParse(textBoxPlaintext.Text, out int plainText))
                {
                    MessageBox.Show("Only integer in plaintext form");
                    return;
                }

                // Validate if plaintext is smaller than n - 2 (limitation of algorithm)
                // Limitation: Algorithm will FAIL to encrypt and decrypt if message = m
                // Limitation 2: Algorithm will FAIL to decrypt if message = n - 1
                if (plainText > (p * q) - 2)
                {
                    MessageBox.Show($"Value must be smaller than n where n = p * q - 2 ({(p * q) - 2})");
                    return;
                }
            }
            else if (radioButtonASCIIMode.Checked)
            {
                // Ensure that n is above n = 257
                // Because ASCII uses number up to 255
                // And limitation of algorithm requires that message m < n - 1
                if ((p * q) - 2 < 255)
                {
                    MessageBox.Show("Value of n must be 257 or more");
                    return;
                }
            }

            // Encrypt and decrypt
            if (radioButtonMathsMode.Checked)
            {
                // Encrypt
                int.TryParse(textBoxPlaintext.Text, out int tempPlainText);
                BigInteger plainText = tempPlainText;
                BigInteger cipherText = BigInteger.Pow(plainText, e) % n;
                textBoxCiphertext.Text = cipherText.ToString();

                // Decrypt
                BigInteger decrypt = BigInteger.Pow(cipherText, d) % n;
                textBoxCiphertextToPlaintext.Text = decrypt.ToString();
            }
            else if (radioButtonASCIIMode.Checked)
            {
                // Convert text to ASCII
                List<BigInteger> asciis = new List<BigInteger>();
                foreach (char character in textBoxPlaintext.Text)
                {
                    asciis.Add(System.Convert.ToInt32(character));
                }
                textBoxPlaintext.Text += $"\r\n({String.Join(" ", asciis)})";

                // Encrypt
                List<BigInteger> cipherText = new List<BigInteger>();
                foreach (BigInteger ascii in asciis)
                {
                    cipherText.Add(BigInteger.Pow(ascii, e) % n);
                }
                textBoxCiphertext.Text = String.Join(" ", cipherText);

                // Decrypt
                List<BigInteger> decrypt = new List<BigInteger>();
                foreach (BigInteger cipher in cipherText)
                {
                    decrypt.Add(BigInteger.Pow(cipher, d) % n);
                }
                textBoxCiphertextToPlaintext.Text = $"({String.Join(" ", decrypt)})\r\n";

                // Convert the decrypted ASCII to string
                foreach (int decryptInt in decrypt)
                {
                    textBoxCiphertextToPlaintext.Text += ((char)decryptInt).ToString();
                }
            }
        }

        private void TextBoxE_TextChanged(object sender, EventArgs e)
        {
            textBoxD.Clear();
            textBoxCiphertext.Clear();
            textBoxCiphertextToPlaintext.Clear();
            labelResults.Visible = false;
            buttonEncryptDecrypt.Enabled = false;
        }
    }
}
