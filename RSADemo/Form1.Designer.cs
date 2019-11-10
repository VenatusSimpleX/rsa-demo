namespace RSADemo
{
    partial class RSADemoMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCiphertextToPlaintext = new System.Windows.Forms.GroupBox();
            this.textBoxCiphertextToPlaintext = new System.Windows.Forms.TextBox();
            this.groupBoxCiphertext = new System.Windows.Forms.GroupBox();
            this.textBoxCiphertext = new System.Windows.Forms.TextBox();
            this.groupBoxPlaintext = new System.Windows.Forms.GroupBox();
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.groupBoxAlgorithm = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxStep3 = new System.Windows.Forms.GroupBox();
            this.buttonEncryptDecrypt = new System.Windows.Forms.Button();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.groupBoxStep2 = new System.Windows.Forms.GroupBox();
            this.buttonAutoFindE = new System.Windows.Forms.Button();
            this.buttonFindD = new System.Windows.Forms.Button();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxStep1 = new System.Windows.Forms.GroupBox();
            this.textBoxPhiN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonMathsMode = new System.Windows.Forms.RadioButton();
            this.radioButtonASCIIMode = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxP = new System.Windows.Forms.ComboBox();
            this.comboBoxQ = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxCiphertextToPlaintext.SuspendLayout();
            this.groupBoxCiphertext.SuspendLayout();
            this.groupBoxPlaintext.SuspendLayout();
            this.groupBoxAlgorithm.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxStep3.SuspendLayout();
            this.groupBoxStep2.SuspendLayout();
            this.groupBoxStep1.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxCiphertextToPlaintext, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxCiphertext, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxPlaintext, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAlgorithm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSettings, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(755, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxCiphertextToPlaintext
            // 
            this.groupBoxCiphertextToPlaintext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCiphertextToPlaintext.Controls.Add(this.textBoxCiphertextToPlaintext);
            this.groupBoxCiphertextToPlaintext.Location = new System.Drawing.Point(380, 375);
            this.groupBoxCiphertextToPlaintext.Name = "groupBoxCiphertextToPlaintext";
            this.groupBoxCiphertextToPlaintext.Size = new System.Drawing.Size(372, 119);
            this.groupBoxCiphertextToPlaintext.TabIndex = 4;
            this.groupBoxCiphertextToPlaintext.TabStop = false;
            this.groupBoxCiphertextToPlaintext.Text = "Ciphertext -> Plaintext - M = C^d mod n";
            // 
            // textBoxCiphertextToPlaintext
            // 
            this.textBoxCiphertextToPlaintext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCiphertextToPlaintext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCiphertextToPlaintext.Location = new System.Drawing.Point(3, 16);
            this.textBoxCiphertextToPlaintext.Multiline = true;
            this.textBoxCiphertextToPlaintext.Name = "textBoxCiphertextToPlaintext";
            this.textBoxCiphertextToPlaintext.ReadOnly = true;
            this.textBoxCiphertextToPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCiphertextToPlaintext.Size = new System.Drawing.Size(366, 100);
            this.textBoxCiphertextToPlaintext.TabIndex = 1;
            // 
            // groupBoxCiphertext
            // 
            this.groupBoxCiphertext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCiphertext.Controls.Add(this.textBoxCiphertext);
            this.groupBoxCiphertext.Location = new System.Drawing.Point(3, 375);
            this.groupBoxCiphertext.Name = "groupBoxCiphertext";
            this.groupBoxCiphertext.Size = new System.Drawing.Size(371, 119);
            this.groupBoxCiphertext.TabIndex = 3;
            this.groupBoxCiphertext.TabStop = false;
            this.groupBoxCiphertext.Text = "Ciphertext - C = M^e mod n";
            // 
            // textBoxCiphertext
            // 
            this.textBoxCiphertext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCiphertext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCiphertext.Location = new System.Drawing.Point(3, 16);
            this.textBoxCiphertext.Multiline = true;
            this.textBoxCiphertext.Name = "textBoxCiphertext";
            this.textBoxCiphertext.ReadOnly = true;
            this.textBoxCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCiphertext.Size = new System.Drawing.Size(365, 100);
            this.textBoxCiphertext.TabIndex = 0;
            // 
            // groupBoxPlaintext
            // 
            this.groupBoxPlaintext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxPlaintext, 2);
            this.groupBoxPlaintext.Controls.Add(this.textBoxPlaintext);
            this.groupBoxPlaintext.Location = new System.Drawing.Point(3, 251);
            this.groupBoxPlaintext.Name = "groupBoxPlaintext";
            this.groupBoxPlaintext.Size = new System.Drawing.Size(749, 118);
            this.groupBoxPlaintext.TabIndex = 2;
            this.groupBoxPlaintext.TabStop = false;
            this.groupBoxPlaintext.Text = "Plaintext - M";
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPlaintext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPlaintext.Location = new System.Drawing.Point(3, 16);
            this.textBoxPlaintext.Multiline = true;
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPlaintext.Size = new System.Drawing.Size(743, 99);
            this.textBoxPlaintext.TabIndex = 1;
            // 
            // groupBoxAlgorithm
            // 
            this.groupBoxAlgorithm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxAlgorithm, 2);
            this.groupBoxAlgorithm.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxAlgorithm.Location = new System.Drawing.Point(3, 127);
            this.groupBoxAlgorithm.Name = "groupBoxAlgorithm";
            this.groupBoxAlgorithm.Size = new System.Drawing.Size(749, 118);
            this.groupBoxAlgorithm.TabIndex = 1;
            this.groupBoxAlgorithm.TabStop = false;
            this.groupBoxAlgorithm.Text = "Algorithm";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxStep3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxStep2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxStep1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(743, 99);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxStep3
            // 
            this.groupBoxStep3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStep3.Controls.Add(this.buttonEncryptDecrypt);
            this.groupBoxStep3.Controls.Add(this.textBoxD);
            this.groupBoxStep3.Controls.Add(this.label9);
            this.groupBoxStep3.Controls.Add(this.label8);
            this.groupBoxStep3.Controls.Add(this.labelResults);
            this.groupBoxStep3.Location = new System.Drawing.Point(497, 3);
            this.groupBoxStep3.Name = "groupBoxStep3";
            this.groupBoxStep3.Size = new System.Drawing.Size(243, 93);
            this.groupBoxStep3.TabIndex = 2;
            this.groupBoxStep3.TabStop = false;
            this.groupBoxStep3.Text = "Step 3 - Find d";
            // 
            // buttonEncryptDecrypt
            // 
            this.buttonEncryptDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncryptDecrypt.Enabled = false;
            this.buttonEncryptDecrypt.Location = new System.Drawing.Point(146, 67);
            this.buttonEncryptDecrypt.Name = "buttonEncryptDecrypt";
            this.buttonEncryptDecrypt.Size = new System.Drawing.Size(91, 23);
            this.buttonEncryptDecrypt.TabIndex = 11;
            this.buttonEncryptDecrypt.Text = "Encrypt/decrypt";
            this.buttonEncryptDecrypt.UseVisualStyleBackColor = true;
            this.buttonEncryptDecrypt.Click += new System.EventHandler(this.ButtonEncryptDecrypt_Click);
            // 
            // textBoxD
            // 
            this.textBoxD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxD.Location = new System.Drawing.Point(9, 46);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.ReadOnly = true;
            this.textBoxD.Size = new System.Drawing.Size(228, 20);
            this.textBoxD.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "d";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "(d * e) mod phi(n) = 1";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(6, 72);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(42, 13);
            this.labelResults.TabIndex = 4;
            this.labelResults.Text = "Results";
            this.labelResults.Visible = false;
            // 
            // groupBoxStep2
            // 
            this.groupBoxStep2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStep2.Controls.Add(this.buttonAutoFindE);
            this.groupBoxStep2.Controls.Add(this.buttonFindD);
            this.groupBoxStep2.Controls.Add(this.textBoxE);
            this.groupBoxStep2.Controls.Add(this.label7);
            this.groupBoxStep2.Location = new System.Drawing.Point(250, 3);
            this.groupBoxStep2.Name = "groupBoxStep2";
            this.groupBoxStep2.Size = new System.Drawing.Size(241, 93);
            this.groupBoxStep2.TabIndex = 1;
            this.groupBoxStep2.TabStop = false;
            this.groupBoxStep2.Text = "Step 2 - Select e";
            // 
            // buttonAutoFindE
            // 
            this.buttonAutoFindE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAutoFindE.Location = new System.Drawing.Point(115, 67);
            this.buttonAutoFindE.Name = "buttonAutoFindE";
            this.buttonAutoFindE.Size = new System.Drawing.Size(68, 23);
            this.buttonAutoFindE.TabIndex = 10;
            this.buttonAutoFindE.Text = "Auto find e";
            this.buttonAutoFindE.UseVisualStyleBackColor = true;
            this.buttonAutoFindE.Click += new System.EventHandler(this.ButtonAutoFindE_Click);
            // 
            // buttonFindD
            // 
            this.buttonFindD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindD.Location = new System.Drawing.Point(189, 67);
            this.buttonFindD.Name = "buttonFindD";
            this.buttonFindD.Size = new System.Drawing.Size(46, 23);
            this.buttonFindD.TabIndex = 9;
            this.buttonFindD.Text = "Find d";
            this.buttonFindD.UseVisualStyleBackColor = true;
            this.buttonFindD.Click += new System.EventHandler(this.ButtonFindD_Click);
            // 
            // textBoxE
            // 
            this.textBoxE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxE.Location = new System.Drawing.Point(6, 32);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(229, 20);
            this.textBoxE.TabIndex = 4;
            this.textBoxE.TextChanged += new System.EventHandler(this.TextBoxE_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "e";
            // 
            // groupBoxStep1
            // 
            this.groupBoxStep1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStep1.Controls.Add(this.textBoxPhiN);
            this.groupBoxStep1.Controls.Add(this.label6);
            this.groupBoxStep1.Controls.Add(this.textBoxN);
            this.groupBoxStep1.Controls.Add(this.label5);
            this.groupBoxStep1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxStep1.Name = "groupBoxStep1";
            this.groupBoxStep1.Size = new System.Drawing.Size(241, 93);
            this.groupBoxStep1.TabIndex = 0;
            this.groupBoxStep1.TabStop = false;
            this.groupBoxStep1.Text = "Step 1 - Find n and phi(n)";
            // 
            // textBoxPhiN
            // 
            this.textBoxPhiN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhiN.Location = new System.Drawing.Point(9, 69);
            this.textBoxPhiN.Name = "textBoxPhiN";
            this.textBoxPhiN.ReadOnly = true;
            this.textBoxPhiN.Size = new System.Drawing.Size(226, 20);
            this.textBoxPhiN.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "phi(n) = (p - 1) * (q - 1)";
            // 
            // textBoxN
            // 
            this.textBoxN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxN.Location = new System.Drawing.Point(9, 32);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.ReadOnly = true;
            this.textBoxN.Size = new System.Drawing.Size(226, 20);
            this.textBoxN.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "n = p * q";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxSettings, 2);
            this.groupBoxSettings.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxSettings.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(749, 118);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonMathsMode, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonASCIIMode, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxP, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxQ, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonCalculate, 5, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(743, 56);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "p";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo mode";
            // 
            // radioButtonMathsMode
            // 
            this.radioButtonMathsMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonMathsMode.AutoSize = true;
            this.radioButtonMathsMode.Checked = true;
            this.radioButtonMathsMode.Location = new System.Drawing.Point(73, 5);
            this.radioButtonMathsMode.Name = "radioButtonMathsMode";
            this.radioButtonMathsMode.Size = new System.Drawing.Size(83, 17);
            this.radioButtonMathsMode.TabIndex = 1;
            this.radioButtonMathsMode.TabStop = true;
            this.radioButtonMathsMode.Text = "Maths mode";
            this.radioButtonMathsMode.UseVisualStyleBackColor = true;
            // 
            // radioButtonASCIIMode
            // 
            this.radioButtonASCIIMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonASCIIMode.AutoSize = true;
            this.radioButtonASCIIMode.Location = new System.Drawing.Point(73, 33);
            this.radioButtonASCIIMode.Name = "radioButtonASCIIMode";
            this.radioButtonASCIIMode.Size = new System.Drawing.Size(81, 17);
            this.radioButtonASCIIMode.TabIndex = 2;
            this.radioButtonASCIIMode.Text = "ASCII mode";
            this.radioButtonASCIIMode.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prime";
            // 
            // comboBoxP
            // 
            this.comboBoxP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "11",
            "13",
            "17",
            "19",
            "23",
            "29",
            "31",
            "37",
            "41",
            "43",
            "47",
            "53",
            "59",
            "61",
            "67",
            "71",
            "73",
            "79",
            "83",
            "89",
            "97",
            "101",
            "103",
            "107",
            "109",
            "113",
            "127",
            "131",
            "137",
            "139",
            "149",
            "151",
            "157",
            "163",
            "167",
            "173",
            "179",
            "181",
            "191",
            "193",
            "197",
            "199",
            "211",
            "223",
            "227",
            "229",
            "233",
            "239",
            "241",
            "251",
            "257",
            "263",
            "269",
            "271",
            "277",
            "281",
            "283",
            "293",
            "307",
            "311",
            "313",
            "317",
            "331",
            "337",
            "347",
            "349",
            "353",
            "359",
            "367",
            "373",
            "379",
            "383",
            "389",
            "397",
            "401",
            "409",
            "419",
            "421",
            "431",
            "433",
            "439",
            "443",
            "449",
            "457",
            "461",
            "463",
            "467",
            "479",
            "487",
            "491",
            "499",
            "503",
            "509",
            "521",
            "523",
            "541",
            "547"});
            this.comboBoxP.Location = new System.Drawing.Point(220, 3);
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxP.TabIndex = 4;
            // 
            // comboBoxQ
            // 
            this.comboBoxQ.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQ.FormattingEnabled = true;
            this.comboBoxQ.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "11",
            "13",
            "17",
            "19",
            "23",
            "29",
            "31",
            "37",
            "41",
            "43",
            "47",
            "53",
            "59",
            "61",
            "67",
            "71",
            "73",
            "79",
            "83",
            "89",
            "97",
            "101",
            "103",
            "107",
            "109",
            "113",
            "127",
            "131",
            "137",
            "139",
            "149",
            "151",
            "157",
            "163",
            "167",
            "173",
            "179",
            "181",
            "191",
            "193",
            "197",
            "199",
            "211",
            "223",
            "227",
            "229",
            "233",
            "239",
            "241",
            "251",
            "257",
            "263",
            "269",
            "271",
            "277",
            "281",
            "283",
            "293",
            "307",
            "311",
            "313",
            "317",
            "331",
            "337",
            "347",
            "349",
            "353",
            "359",
            "367",
            "373",
            "379",
            "383",
            "389",
            "397",
            "401",
            "409",
            "419",
            "421",
            "431",
            "433",
            "439",
            "443",
            "449",
            "457",
            "461",
            "463",
            "467",
            "479",
            "487",
            "491",
            "499",
            "503",
            "509",
            "521",
            "523",
            "541",
            "547"});
            this.comboBoxQ.Location = new System.Drawing.Point(220, 31);
            this.comboBoxQ.Name = "comboBoxQ";
            this.comboBoxQ.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQ.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "q";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonCalculate.Location = new System.Drawing.Point(347, 30);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // RSADemoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(795, 560);
            this.Name = "RSADemoMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Demo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxCiphertextToPlaintext.ResumeLayout(false);
            this.groupBoxCiphertextToPlaintext.PerformLayout();
            this.groupBoxCiphertext.ResumeLayout(false);
            this.groupBoxCiphertext.PerformLayout();
            this.groupBoxPlaintext.ResumeLayout(false);
            this.groupBoxPlaintext.PerformLayout();
            this.groupBoxAlgorithm.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxStep3.ResumeLayout(false);
            this.groupBoxStep3.PerformLayout();
            this.groupBoxStep2.ResumeLayout(false);
            this.groupBoxStep2.PerformLayout();
            this.groupBoxStep1.ResumeLayout(false);
            this.groupBoxStep1.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.GroupBox groupBoxAlgorithm;
        private System.Windows.Forms.GroupBox groupBoxCiphertextToPlaintext;
        private System.Windows.Forms.GroupBox groupBoxCiphertext;
        private System.Windows.Forms.GroupBox groupBoxPlaintext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxStep3;
        private System.Windows.Forms.GroupBox groupBoxStep2;
        private System.Windows.Forms.GroupBox groupBoxStep1;
        private System.Windows.Forms.TextBox textBoxCiphertext;
        private System.Windows.Forms.TextBox textBoxCiphertextToPlaintext;
        private System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonMathsMode;
        private System.Windows.Forms.RadioButton radioButtonASCIIMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxP;
        private System.Windows.Forms.ComboBox comboBoxQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhiN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button buttonFindD;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAutoFindE;
        private System.Windows.Forms.Button buttonEncryptDecrypt;
    }
}

