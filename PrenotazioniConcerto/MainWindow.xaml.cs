using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prenotazioniConcerto
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

        private bool[] prenotazioni = new bool[49];
        int buttonCliccato;
        bool[] selected = new bool[49];
        int volteClick = 0;
        string nome;
        int postiLiberi = 49;


        private void btnClick(object sender, RoutedEventArgs e)
        {
            Button cliccato = (Button)sender;
            nome = cliccato.Name;
            buttonCliccato = nome.IndexOf(nome);
            if (volteClick == 0)
            {
                for (int i = 0; i < 49; i++)
                {
                    selected[i] = false;
                }
                volteClick++;
            }

            //controllo se è selezionato o meno
            if (selected[buttonCliccato] == true)
            {
                selected[buttonCliccato] = false;
            }
            else
            {
                selected[buttonCliccato] = true;
            }

            //inizializzazione come false di tutto il vettore delle selezioni
            checkSelezioni(sender);
        }

        private void btnPrenota_Click(object sender, RoutedEventArgs e)
        {
            Button cliccato = (Button)sender;
            nome = cliccato.Name;
            buttonCliccato = nome.IndexOf(nome);
            for (int i = 0; i < 49; i++)
            {
                foreach (Button btn in gridPrenotazioni.Children)
                {
                    if (btn.Background == Brushes.LightGreen)
                    {
                        btn.Background = Brushes.Red;
                        btn.IsEnabled = false;
                        btn.Content = "Prenotato";
                        prenotazioni[i] = true;
                    }
                }
            }
            
        }

        private void checkSelezioni(object sender)
        {
            Button cliccato = (Button)sender;
            string name = cliccato.Name;
            buttonCliccato = name.IndexOf(name);
            if (selected[buttonCliccato] == true)
            {
                cliccato.Background = Brushes.LightGreen;
            }
            else
            {
                cliccato.Background = Brushes.LightGray;
            }
        }
    }
}