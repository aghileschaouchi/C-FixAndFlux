
namespace FixAndFlux
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.connectToDbButton = new System.Windows.Forms.ToolStripButton();
            this.addConsoleButton = new System.Windows.Forms.ToolStripButton();
            this.discFromDbButton = new System.Windows.Forms.ToolStripButton();
            this.mainTabControl1 = new FixAndFlux.MainTabControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDbButton,
            this.addConsoleButton,
            this.discFromDbButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1063, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // connectToDbButton
            // 
            this.connectToDbButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connectToDbButton.Image = ((System.Drawing.Image)(resources.GetObject("connectToDbButton.Image")));
            this.connectToDbButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectToDbButton.Name = "connectToDbButton";
            this.connectToDbButton.Size = new System.Drawing.Size(34, 28);
            this.connectToDbButton.Text = "toolStripButton1";
            this.connectToDbButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // addConsoleButton
            // 
            this.addConsoleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addConsoleButton.Image = ((System.Drawing.Image)(resources.GetObject("addConsoleButton.Image")));
            this.addConsoleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addConsoleButton.Name = "addConsoleButton";
            this.addConsoleButton.Size = new System.Drawing.Size(34, 28);
            this.addConsoleButton.Text = "toolStripButton2";
            this.addConsoleButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // discFromDbButton
            // 
            this.discFromDbButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.discFromDbButton.Image = ((System.Drawing.Image)(resources.GetObject("discFromDbButton.Image")));
            this.discFromDbButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.discFromDbButton.Name = "discFromDbButton";
            this.discFromDbButton.Size = new System.Drawing.Size(34, 28);
            this.discFromDbButton.Text = "toolStripButton3";
            // 
            // mainTabControl1
            // 
            this.mainTabControl1.Location = new System.Drawing.Point(0, 36);
            this.mainTabControl1.Name = "mainTabControl1";
            this.mainTabControl1.Size = new System.Drawing.Size(1051, 534);
            this.mainTabControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 587);
            this.Controls.Add(this.mainTabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Fix and Flux";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton connectToDbButton;
        private System.Windows.Forms.ToolStripButton addConsoleButton;
        private System.Windows.Forms.ToolStripButton discFromDbButton;
        private MainTabControl mainTabControl1;
    }
}

