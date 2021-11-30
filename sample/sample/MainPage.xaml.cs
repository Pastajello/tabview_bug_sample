using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Monkeys = LoadMonkeys();
            InitializeComponent();
            TabView.TabItemsSource = Monkeys;
        }


        public ObservableCollection<Monkey> Monkeys { get; set; }

        static ObservableCollection<Monkey> LoadMonkeys() => new ObservableCollection<Monkey>
        {
            new Monkey
            {
                Index = "0",
                Name = "Baboon",
                Location = "Africa & Asia",
                Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg",
                Color = Color.LightSalmon
            },

            new Monkey
            {
                Index = "1",
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg",
                Color = Color.LightBlue
            },

            new Monkey
            {
                Index = "2",
                Name = "Blue Monkey",
                Location = "Central and East Africa",
                Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                Color = Color.LightSlateGray
            },
        };
    }

    public class Monkey
    {
        public string Index { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public string Details { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public Color Color { get; set; }
    }
}



