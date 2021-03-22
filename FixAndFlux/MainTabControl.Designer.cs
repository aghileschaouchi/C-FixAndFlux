
namespace FixAndFlux
{
    partial class MainTabControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consolesPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.consolesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // consolesPage
            // 
            this.consolesPage.Controls.Add(this.tabPage1);
            this.consolesPage.Controls.Add(this.clientsPage);
            this.consolesPage.Location = new System.Drawing.Point(13, 18);
            this.consolesPage.Name = "consolesPage";
            this.consolesPage.SelectedIndex = 0;
            this.consolesPage.Size = new System.Drawing.Size(1049, 629);
            this.consolesPage.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1041, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consoles";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // clientsPage
            // 
            this.clientsPage.Location = new System.Drawing.Point(4, 29);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientsPage.Size = new System.Drawing.Size(1041, 596);
            this.clientsPage.TabIndex = 1;
            this.clientsPage.Text = "Clients";
            this.clientsPage.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.consolesPage);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1077, 663);
            this.consolesPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl consolesPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage clientsPage;
    }
}
