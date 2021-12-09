
namespace RiotAPI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.apiTextBox = new System.Windows.Forms.TextBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.summonerNameLabel = new System.Windows.Forms.Label();
            this.summonerNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.summonerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.summonerLevelLabel = new System.Windows.Forms.Label();
            this.summonerLevelTextBox = new System.Windows.Forms.TextBox();
            this.puuidLabel = new System.Windows.Forms.Label();
            this.puuidTextBox = new System.Windows.Forms.TextBox();
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.summonerIDLabel = new System.Windows.Forms.Label();
            this.summonerIDTextBox = new System.Windows.Forms.TextBox();
            this.summonerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // apiTextBox
            // 
            this.apiTextBox.Location = new System.Drawing.Point(12, 32);
            this.apiTextBox.Name = "apiTextBox";
            this.apiTextBox.Size = new System.Drawing.Size(666, 20);
            this.apiTextBox.TabIndex = 0;
            this.apiTextBox.TextChanged += new System.EventHandler(this.ApiTextBox_TextChanged);
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.Location = new System.Drawing.Point(13, 13);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(99, 13);
            this.apiKeyLabel.TabIndex = 1;
            this.apiKeyLabel.Text = "Enter API Key Here";
            // 
            // summonerNameLabel
            // 
            this.summonerNameLabel.AutoSize = true;
            this.summonerNameLabel.Location = new System.Drawing.Point(13, 71);
            this.summonerNameLabel.Name = "summonerNameLabel";
            this.summonerNameLabel.Size = new System.Drawing.Size(142, 13);
            this.summonerNameLabel.TabIndex = 3;
            this.summonerNameLabel.Text = "Enter Summoner Name Here";
            // 
            // summonerNameTextBox
            // 
            this.summonerNameTextBox.Location = new System.Drawing.Point(12, 90);
            this.summonerNameTextBox.Name = "summonerNameTextBox";
            this.summonerNameTextBox.Size = new System.Drawing.Size(666, 20);
            this.summonerNameTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(701, 61);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // summonerInfoGroupBox
            // 
            this.summonerInfoGroupBox.Controls.Add(this.summonerLevelLabel);
            this.summonerInfoGroupBox.Controls.Add(this.summonerLevelTextBox);
            this.summonerInfoGroupBox.Controls.Add(this.puuidLabel);
            this.summonerInfoGroupBox.Controls.Add(this.puuidTextBox);
            this.summonerInfoGroupBox.Controls.Add(this.accountIDLabel);
            this.summonerInfoGroupBox.Controls.Add(this.accountIDTextBox);
            this.summonerInfoGroupBox.Controls.Add(this.summonerIDLabel);
            this.summonerInfoGroupBox.Controls.Add(this.summonerIDTextBox);
            this.summonerInfoGroupBox.Location = new System.Drawing.Point(12, 136);
            this.summonerInfoGroupBox.Name = "summonerInfoGroupBox";
            this.summonerInfoGroupBox.Size = new System.Drawing.Size(764, 231);
            this.summonerInfoGroupBox.TabIndex = 8;
            this.summonerInfoGroupBox.TabStop = false;
            // 
            // summonerLevelLabel
            // 
            this.summonerLevelLabel.AutoSize = true;
            this.summonerLevelLabel.Location = new System.Drawing.Point(6, 168);
            this.summonerLevelLabel.Name = "summonerLevelLabel";
            this.summonerLevelLabel.Size = new System.Drawing.Size(86, 13);
            this.summonerLevelLabel.TabIndex = 7;
            this.summonerLevelLabel.Text = "Summoner Level";
            // 
            // summonerLevelTextBox
            // 
            this.summonerLevelTextBox.Location = new System.Drawing.Point(6, 184);
            this.summonerLevelTextBox.Name = "summonerLevelTextBox";
            this.summonerLevelTextBox.ReadOnly = true;
            this.summonerLevelTextBox.Size = new System.Drawing.Size(512, 20);
            this.summonerLevelTextBox.TabIndex = 6;
            // 
            // puuidLabel
            // 
            this.puuidLabel.AutoSize = true;
            this.puuidLabel.Location = new System.Drawing.Point(6, 116);
            this.puuidLabel.Name = "puuidLabel";
            this.puuidLabel.Size = new System.Drawing.Size(41, 13);
            this.puuidLabel.TabIndex = 5;
            this.puuidLabel.Text = "PUUID";
            // 
            // puuidTextBox
            // 
            this.puuidTextBox.Location = new System.Drawing.Point(6, 132);
            this.puuidTextBox.Name = "puuidTextBox";
            this.puuidTextBox.ReadOnly = true;
            this.puuidTextBox.Size = new System.Drawing.Size(512, 20);
            this.puuidTextBox.TabIndex = 4;
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Location = new System.Drawing.Point(6, 64);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(61, 13);
            this.accountIDLabel.TabIndex = 3;
            this.accountIDLabel.Text = "Account ID";
            // 
            // accountIDTextBox
            // 
            this.accountIDTextBox.Location = new System.Drawing.Point(6, 80);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.ReadOnly = true;
            this.accountIDTextBox.Size = new System.Drawing.Size(512, 20);
            this.accountIDTextBox.TabIndex = 2;
            // 
            // summonerIDLabel
            // 
            this.summonerIDLabel.AutoSize = true;
            this.summonerIDLabel.Location = new System.Drawing.Point(6, 12);
            this.summonerIDLabel.Name = "summonerIDLabel";
            this.summonerIDLabel.Size = new System.Drawing.Size(71, 13);
            this.summonerIDLabel.TabIndex = 1;
            this.summonerIDLabel.Text = "Summoner ID";
            // 
            // summonerIDTextBox
            // 
            this.summonerIDTextBox.Location = new System.Drawing.Point(6, 28);
            this.summonerIDTextBox.Name = "summonerIDTextBox";
            this.summonerIDTextBox.ReadOnly = true;
            this.summonerIDTextBox.Size = new System.Drawing.Size(512, 20);
            this.summonerIDTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.summonerInfoGroupBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.summonerNameLabel);
            this.Controls.Add(this.summonerNameTextBox);
            this.Controls.Add(this.apiKeyLabel);
            this.Controls.Add(this.apiTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Riot API Tool";
            this.summonerInfoGroupBox.ResumeLayout(false);
            this.summonerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apiTextBox;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.Label summonerNameLabel;
        private System.Windows.Forms.TextBox summonerNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox summonerInfoGroupBox;
        private System.Windows.Forms.Label puuidLabel;
        private System.Windows.Forms.TextBox puuidTextBox;
        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.Label summonerIDLabel;
        private System.Windows.Forms.TextBox summonerIDTextBox;
        private System.Windows.Forms.Label summonerLevelLabel;
        private System.Windows.Forms.TextBox summonerLevelTextBox;
    }
}

