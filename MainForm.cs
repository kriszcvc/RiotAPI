using System;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;
using MingweiSamuel.Camille.ChampionMasteryV4;
using MingweiSamuel.Camille.LeagueV4;

namespace RiotAPI
{
    public partial class MainForm : Form
    {
        public string APIKey
        {
            get => apiTextBox.Text;
            set => apiTextBox.Text = value;
        }

        public string SummonerName
        {
            get => summonerNameTextBox.Text;
            set => summonerNameTextBox.Text = value;
        }

        public string SummonerID
        {
            get => summonerIDTextBox.Text;
            set => summonerIDTextBox.Text = value;
        }

        public string AccountID
        {
            get => accountIDTextBox.Text;
            set => accountIDTextBox.Text = value;
        }
        public string PUUID
        {
            get => puuidTextBox.Text;
            set => puuidTextBox.Text = value;
        }

        public string SummonerLevel
        {
            get => summonerLevelTextBox.Text;
            set => summonerLevelTextBox.Text = value;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ApiTextBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = !string.IsNullOrEmpty(apiTextBox.Text);
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(summonerNameTextBox.Text))
            {
                var riotApi = RiotApi.NewInstance($"{APIKey}");
                Summoner summoner = riotApi.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, $"{SummonerName}");

                SummonerID = $"{summoner.Id}";
                AccountID = $"{summoner.AccountId}";
                PUUID = $"{summoner.Puuid}";
                SummonerLevel = $"{summoner.SummonerLevel}";
            }
            else
            {
                MessageBox.Show("Please enter a Summoner Name.");
            }
        }
    }
}