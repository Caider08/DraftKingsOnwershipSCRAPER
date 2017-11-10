using System;

namespace DraftKingsOnwershipSCRAPER
{
    partial class GetPlayerTags
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
            this.playerTagsGridView = new System.Windows.Forms.DataGridView();
            this.SiteLogIn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.navigate = new System.Windows.Forms.Button();
            this.ScrapySharpTest = new System.Windows.Forms.Button();
            this.BrowserTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerTagsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // playerTagsGridView
            // 
            this.playerTagsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerTagsGridView.Location = new System.Drawing.Point(729, 12);
            this.playerTagsGridView.Name = "playerTagsGridView";
            this.playerTagsGridView.RowTemplate.Height = 24;
            this.playerTagsGridView.Size = new System.Drawing.Size(596, 477);
            this.playerTagsGridView.TabIndex = 0;
            this.playerTagsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SiteLogIn
            // 
            this.SiteLogIn.Location = new System.Drawing.Point(12, 455);
            this.SiteLogIn.Name = "SiteLogIn";
            this.SiteLogIn.Size = new System.Drawing.Size(149, 70);
            this.SiteLogIn.TabIndex = 1;
            this.SiteLogIn.Text = "SiteLogIn";
            this.SiteLogIn.UseVisualStyleBackColor = true;
            this.SiteLogIn.Click += new System.EventHandler(this.SiteLogIn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(689, 425);
            this.webBrowser1.TabIndex = 2;
            // 
            // navigate
            // 
            this.navigate.Location = new System.Drawing.Point(190, 455);
            this.navigate.Name = "navigate";
            this.navigate.Size = new System.Drawing.Size(158, 65);
            this.navigate.TabIndex = 3;
            this.navigate.Text = "navigate";
            this.navigate.UseVisualStyleBackColor = true;
            this.navigate.Click += new System.EventHandler(this.navigate_Click);
            // 
            // ScrapySharpTest
            // 
            this.ScrapySharpTest.Location = new System.Drawing.Point(385, 459);
            this.ScrapySharpTest.Name = "ScrapySharpTest";
            this.ScrapySharpTest.Size = new System.Drawing.Size(145, 60);
            this.ScrapySharpTest.TabIndex = 4;
            this.ScrapySharpTest.Text = "ScrapySharpTest";
            this.ScrapySharpTest.UseVisualStyleBackColor = true;
            // 
            // BrowserTest
            // 
            this.BrowserTest.BackColor = System.Drawing.Color.Transparent;
            this.BrowserTest.Location = new System.Drawing.Point(563, 455);
            this.BrowserTest.Name = "BrowserTest";
            this.BrowserTest.Size = new System.Drawing.Size(138, 63);
            this.BrowserTest.TabIndex = 5;
            this.BrowserTest.Text = "BrowserTest";
            this.BrowserTest.UseVisualStyleBackColor = false;
            this.BrowserTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetPlayerTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 537);
            this.Controls.Add(this.BrowserTest);
            this.Controls.Add(this.ScrapySharpTest);
            this.Controls.Add(this.navigate);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.SiteLogIn);
            this.Controls.Add(this.playerTagsGridView);
            this.Name = "GetPlayerTags";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GetPlayerTags_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerTagsGridView)).EndInit();
            this.ResumeLayout(false);

        }

 

        #endregion

        private System.Windows.Forms.DataGridView playerTagsGridView;
        private System.Windows.Forms.Button SiteLogIn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button navigate;
        private System.Windows.Forms.Button ScrapySharpTest;
        private System.Windows.Forms.Button BrowserTest;
    }
}

