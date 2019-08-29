using LOL.API;
using LOL.Summoner;
using System.Linq;
using System.Windows;

namespace LOL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4("BR1");

            var summoner = summoner_V4.GetSummonerByName(SummonerName.Text);

            var position = GetPosition(summoner);

            LblNivel.Content = summoner.SummonerLevel;
            LblTier.Content = position.Tier;
            LblLoss.Content = position.Losses;
            LblWins.Content = position.Wins;
            LblRank.Content = position.Rank;
        }

        //public object GetContext()
        //{
        //    Summoner_V4 summoner_V4 = new Summoner_V4("BR1");

        //    var summoner = summoner_V4.GetSummonerByName(SummonerName.Text);

        //    var position = GetPosition(summoner);

        //    return new SummonerModel(summoner.Name, summoner.ProfileIconId, summoner.SummonerLevel, position.Tier, position.Rank,
        //        position.Wins, position.Losses);
        //}

        private PositionDTO GetPosition(SummonerDTO summoner)
        {
            League_V4 league = new League_V4("BR1");

            var position = league.GetPositions(summoner.Id).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return position ?? new PositionDTO();
        }
    }
}
