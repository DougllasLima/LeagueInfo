using LeagueInfo.Config;
using LeagueInfo.Summoner;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;

namespace LeagueInfo
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cbRegion.Items.Add("BR1");
            cbRegion.Items.Add("EU");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4("BR1");

            var summoner = summoner_V4.GetSummonerByName(SummonerName.Text);

            Match_V4 match_V4 = new Match_V4("BR1");

//            var seila = match_V4.GetMatchByMatchId(1726239613);

            var position = GetPosition(summoner);

            var ChampMastery = new Champion_Mastery_V4("BR1");

            var championMasteryDTOs = ChampMastery.GetChampMasteryList(summoner.Id);

            var championsList = new ChampionsList.ChampionsList();

            lblTier.Content = String.Format("{0} {1}", position.Tier, position.Rank);

            var status = String.Format("{0} LP / {1}W {2}L", position.leaguePoints, position.Wins, position.Losses);

            float total = (position.Wins + position.Losses);

            int percentwin = Convert.ToInt32((position.Wins / total) * 100);

            lblPercentWin.Content = String.Format("Taxa de Vitória {0}%", percentwin);

            lblStatus.Content = status;

            lblName.Content = summoner.Name;

            var webBorder = new BitmapImage(new Uri("https://opgg-static.akamaized.net/images/borders2/" + position.Tier.ToLower() + ".png"));

            imgBorder.Source = webBorder;

            TierIcon.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/TierIcons/" + position.Tier + ".png"));

            var webTier = new BitmapImage(new Uri("https://opgg-static.akamaized.net/images/profile_icons/profileIcon" + summoner.ProfileIconId + ".jpg"));
            
            ProfileIcon.Source = webTier;

            var webChampIcon1 = new BitmapImage(new Uri("https://opgg-static.akamaized.net/images/lol/champion/" + championsList.GetValue(championMasteryDTOs[0].championId) + ".png?image=w_45&v=1"));
            var webMasteryIcon1 = new BitmapImage(new Uri("https://www.masterypoints.com/assets/img/lol/mastery_icons/master" + championMasteryDTOs[0].championLevel + ".png?v=v8")); 
            lblNameChamp1.Content = championsList.GetValue(championMasteryDTOs[0].championId);
            lblMastery1.Content = String.Format("Maestria {0}", championMasteryDTOs[0].championLevel);
            lblMasteryPoints1.Content = String.Format("{0} MP", championMasteryDTOs[0].championPoints);
            ChampIcon1.ImageSource = webChampIcon1;
            MasteryIcon1.ImageSource = webMasteryIcon1;

            var webChampIcon2 = new BitmapImage(new Uri("https://opgg-static.akamaized.net/images/lol/champion/" + championsList.GetValue(championMasteryDTOs[1].championId) + ".png?image=w_45&v=1"));
            var webMasteryIcon2 = new BitmapImage(new Uri("https://www.masterypoints.com/assets/img/lol/mastery_icons/master" + championMasteryDTOs[1].championLevel + ".png?v=v8"));
            lblNameChamp2.Content = championsList.GetValue(championMasteryDTOs[1].championId);
            lblMastery2.Content = String.Format("Maestria {0}", championMasteryDTOs[1].championLevel);
            lblMasteryPoints2.Content = String.Format("{0} MP", championMasteryDTOs[1].championPoints);
            ChampIcon2.ImageSource = webChampIcon2;
            MasteryIcon2.ImageSource = webMasteryIcon2;

            var webChampIcon3 = new BitmapImage(new Uri("https://opgg-static.akamaized.net/images/lol/champion/" + championsList.GetValue(championMasteryDTOs[2].championId) + ".png?image=w_45&v=1"));
            var webMasteryIcon3 = new BitmapImage(new Uri("https://www.masterypoints.com/assets/img/lol/mastery_icons/master" + championMasteryDTOs[2].championLevel + ".png?v=v8"));
            lblNameChamp3.Content = championsList.GetValue(championMasteryDTOs[2].championId);
            lblMastery3.Content = String.Format("Maestria {0}", championMasteryDTOs[2].championLevel);
            lblMasteryPoints3.Content = String.Format("{0} MP", championMasteryDTOs[2].championPoints);
            ChampIcon3.ImageSource = webChampIcon3;
            MasteryIcon3.ImageSource = webMasteryIcon3;

            var webChampIcon4 = new BitmapImage(new Uri("https://opgg-static.akamaized.net/images/lol/champion/" + championsList.GetValue(championMasteryDTOs[3].championId) + ".png?image=w_45&v=1"));
            var webMasteryIcon4 = new BitmapImage(new Uri("https://www.masterypoints.com/assets/img/lol/mastery_icons/master" + championMasteryDTOs[3].championLevel + ".png?v=v8"));
            lblNameChamp4.Content = championsList.GetValue(championMasteryDTOs[3].championId);
            lblMastery4.Content = String.Format("Maestria {0}", championMasteryDTOs[3].championLevel);
            lblMasteryPoints4.Content = String.Format("{0} MP", championMasteryDTOs[3].championPoints);
            ChampIcon4.ImageSource = webChampIcon4;
            MasteryIcon4.ImageSource = webMasteryIcon4;

            var webChampIcon5 = new BitmapImage(new Uri("https://opgg-static.akamaized.net/images/lol/champion/" + championsList.GetValue(championMasteryDTOs[4].championId) + ".png?image=w_45&v=1"));
            var webMasteryIcon5 = new BitmapImage(new Uri("https://www.masterypoints.com/assets/img/lol/mastery_icons/master" + championMasteryDTOs[4].championLevel + ".png?v=v8"));
            lblNameChamp5.Content = championsList.GetValue(championMasteryDTOs[4].championId);
            lblMastery5.Content = String.Format("Maestria {0}", championMasteryDTOs[4].championLevel);
            lblMasteryPoints5.Content = String.Format("{0} MP", championMasteryDTOs[4].championPoints);
            ChampIcon5.ImageSource = webChampIcon5;
            MasteryIcon5.ImageSource = webMasteryIcon5;
        }

        private PositionDTO GetPosition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4("BR1");

            var position = league.GetPositions(summoner.Id).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return position ?? new PositionDTO();
        }
    }
}
