
namespace FixAndFlux.Controls
{
    partial class AddClientControl
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
            this.clientFirstNameLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientPhoneLabel = new System.Windows.Forms.Label();
            this.clientEmailLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clientFirstNameLabel
            // 
            this.clientFirstNameLabel.AutoSize = true;
            this.clientFirstNameLabel.Location = new System.Drawing.Point(50, 31);
            this.clientFirstNameLabel.Name = "clientFirstNameLabel";
            this.clientFirstNameLabel.Size = new System.Drawing.Size(84, 20);
            this.clientFirstNameLabel.TabIndex = 0;
            this.clientFirstNameLabel.Text = "First name";
            this.clientFirstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(50, 84);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(51, 20);
            this.clientNameLabel.TabIndex = 1;
            this.clientNameLabel.Text = "Name";
            // 
            // clientPhoneLabel
            // 
            this.clientPhoneLabel.AutoSize = true;
            this.clientPhoneLabel.Location = new System.Drawing.Point(50, 131);
            this.clientPhoneLabel.Name = "clientPhoneLabel";
            this.clientPhoneLabel.Size = new System.Drawing.Size(55, 20);
            this.clientPhoneLabel.TabIndex = 2;
            this.clientPhoneLabel.Text = "Phone";
            // 
            // clientEmailLabel
            // 
            this.clientEmailLabel.AutoSize = true;
            this.clientEmailLabel.Location = new System.Drawing.Point(50, 180);
            this.clientEmailLabel.Name = "clientEmailLabel";
            this.clientEmailLabel.Size = new System.Drawing.Size(48, 20);
            this.clientEmailLabel.TabIndex = 3;
            this.clientEmailLabel.Text = "Email";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(175, 240);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(116, 37);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(251, 31);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(189, 26);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(251, 78);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(189, 26);
            this.nameTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(251, 125);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(189, 26);
            this.phoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(251, 174);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(189, 26);
            this.emailTextBox.TabIndex = 8;
            // 
            // AddClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 289);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.clientEmailLabel);
            this.Controls.Add(this.clientPhoneLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.clientFirstNameLabel);
            this.Name = "AddClientControl";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientFirstNameLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label clientPhoneLabel;
        private System.Windows.Forms.Label clientEmailLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
    }
}