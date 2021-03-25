
namespace FixAndFlux.Controls
{
    partial class AddConsoleControl
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
            this.consoleBrandComboBox = new System.Windows.Forms.ComboBox();
            this.consoleNameComboBox = new System.Windows.Forms.ComboBox();
            this.clientIdComboBox = new System.Windows.Forms.ComboBox();
            this.problemRTBox = new System.Windows.Forms.RichTextBox();
            this.consoleBrandLabel = new System.Windows.Forms.Label();
            this.consoleNameLabel = new System.Windows.Forms.Label();
            this.problemLabel = new System.Windows.Forms.Label();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.addConsoleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consoleBrandComboBox
            // 
            this.consoleBrandComboBox.FormattingEnabled = true;
            this.consoleBrandComboBox.Items.AddRange(new object[] {
            "Sony",
            "Microsoft",
            "Nintendo",
            "SNK",
            "Sega"});
            this.consoleBrandComboBox.Location = new System.Drawing.Point(482, 59);
            this.consoleBrandComboBox.Name = "consoleBrandComboBox";
            this.consoleBrandComboBox.Size = new System.Drawing.Size(237, 28);
            this.consoleBrandComboBox.TabIndex = 0;
            this.consoleBrandComboBox.SelectedIndexChanged += new System.EventHandler(this.consoleBrandComboBox_SelectedIndexChanged);
            // 
            // consoleNameComboBox
            // 
            this.consoleNameComboBox.FormattingEnabled = true;
            this.consoleNameComboBox.Items.AddRange(new object[] {
            "Ps one",
            "Ps one slim",
            "Ps2 fat",
            "Ps2 slim",
            "Ps3 fat",
            "Ps3 slim",
            "Ps3 ultra slim",
            "Ps4 fat",
            "Ps4 slim",
            "Ps4 pro",
            "Psp",
            "Ps vita",
            "Xbox",
            "Xbox 360 fat",
            "Xbox 360 slim",
            "Xbox One",
            "Xbox One S",
            "Xbox One X",
            "Xbox Series X",
            "Nes",
            "SNes",
            "Nintendo 64",
            "Gamecube",
            "Wii",
            "Wii U",
            "Switch",
            "Switch light",
            "Gameboy classic",
            "Gameboy pocket",
            "Gameboy light",
            "Gameboy color",
            "Gameboy advance",
            "Gameboy advance sp",
            "Gameboy micro",
            "Ds",
            "Ds light",
            "Dsi",
            "Dsi XL",
            "2DS",
            "2DS XL",
            "3DS",
            "3DS XL"});
            this.consoleNameComboBox.Location = new System.Drawing.Point(482, 116);
            this.consoleNameComboBox.Name = "consoleNameComboBox";
            this.consoleNameComboBox.Size = new System.Drawing.Size(237, 28);
            this.consoleNameComboBox.TabIndex = 1;
            // 
            // clientIdComboBox
            // 
            this.clientIdComboBox.FormattingEnabled = true;
            this.clientIdComboBox.Location = new System.Drawing.Point(482, 485);
            this.clientIdComboBox.Name = "clientIdComboBox";
            this.clientIdComboBox.Size = new System.Drawing.Size(237, 28);
            this.clientIdComboBox.TabIndex = 2;
            // 
            // problemRTBox
            // 
            this.problemRTBox.Location = new System.Drawing.Point(144, 204);
            this.problemRTBox.Name = "problemRTBox";
            this.problemRTBox.Size = new System.Drawing.Size(575, 237);
            this.problemRTBox.TabIndex = 3;
            this.problemRTBox.Text = "";
            // 
            // consoleBrandLabel
            // 
            this.consoleBrandLabel.AutoSize = true;
            this.consoleBrandLabel.Location = new System.Drawing.Point(29, 59);
            this.consoleBrandLabel.Name = "consoleBrandLabel";
            this.consoleBrandLabel.Size = new System.Drawing.Size(112, 20);
            this.consoleBrandLabel.TabIndex = 4;
            this.consoleBrandLabel.Text = "Console brand";
            // 
            // consoleNameLabel
            // 
            this.consoleNameLabel.AutoSize = true;
            this.consoleNameLabel.Location = new System.Drawing.Point(29, 116);
            this.consoleNameLabel.Name = "consoleNameLabel";
            this.consoleNameLabel.Size = new System.Drawing.Size(111, 20);
            this.consoleNameLabel.TabIndex = 5;
            this.consoleNameLabel.Text = "Console name";
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Location = new System.Drawing.Point(29, 204);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(67, 20);
            this.problemLabel.TabIndex = 6;
            this.problemLabel.Text = "Problem";
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Location = new System.Drawing.Point(29, 485);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(49, 20);
            this.clientIdLabel.TabIndex = 7;
            this.clientIdLabel.Text = "Client";
            // 
            // addConsoleButton
            // 
            this.addConsoleButton.Location = new System.Drawing.Point(325, 558);
            this.addConsoleButton.Name = "addConsoleButton";
            this.addConsoleButton.Size = new System.Drawing.Size(108, 38);
            this.addConsoleButton.TabIndex = 8;
            this.addConsoleButton.Text = "Add";
            this.addConsoleButton.UseVisualStyleBackColor = true;
            this.addConsoleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddConsoleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 608);
            this.Controls.Add(this.addConsoleButton);
            this.Controls.Add(this.clientIdLabel);
            this.Controls.Add(this.problemLabel);
            this.Controls.Add(this.consoleNameLabel);
            this.Controls.Add(this.consoleBrandLabel);
            this.Controls.Add(this.problemRTBox);
            this.Controls.Add(this.clientIdComboBox);
            this.Controls.Add(this.consoleNameComboBox);
            this.Controls.Add(this.consoleBrandComboBox);
            this.Name = "AddConsoleControl";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox consoleBrandComboBox;
        private System.Windows.Forms.ComboBox consoleNameComboBox;
        private System.Windows.Forms.ComboBox clientIdComboBox;
        private System.Windows.Forms.RichTextBox problemRTBox;
        private System.Windows.Forms.Label consoleBrandLabel;
        private System.Windows.Forms.Label consoleNameLabel;
        private System.Windows.Forms.Label problemLabel;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.Button addConsoleButton;
    }
}