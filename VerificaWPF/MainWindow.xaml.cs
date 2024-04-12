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

namespace marroniVerificaVettori
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
        const int dimensioneFisica = 12;
        int dimensioneLogica = 0;
        int[] accessi = new int[dimensioneFisica];
        int accessoMax;
        int meseMax = 1;
        int meseSostituzione;
        int valoreSostituzione;
        int temp;

        private void btnInsersci_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                accessi[dimensioneLogica] = int.Parse(txtAccesso.Text);
                dimensioneLogica++;
                visualizza();
                txtAccesso.Clear();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Inserire un numero");
                txtAccesso.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Vettore pieno");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Numero troppo grande");
                txtAccesso.Clear();
            }
        }
        private void visualizza()
        {
            lstAccessi.Items.Clear();
            for (int i = 0; i < dimensioneLogica; i++)
            {
                lstAccessi.Items.Add((i + 1) + " - " + accessi[i]);
            }
        }

        private void btnMax_Click(object sender, RoutedEventArgs e)
        {
            accessoMax = accessi[0];
            for (int i = 0; i < dimensioneLogica; i++)
            {
                if (accessi[i] > accessoMax)
                {
                    accessoMax = accessi[i];
                    meseMax = i + 1;
                }
            }
            lstMassimo.Items.Add( "Con " + accessoMax + " accessi, il/i mese/i");
            for (int i = 0; i < dimensioneLogica; i++)
            {
                if (accessi[i] == accessoMax)
                {
                    lstMassimo.Items.Add((i+1));
                }
            }
        }

        private void btnSostituisci_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                meseSostituzione = int.Parse(txtMese.Text);
                valoreSostituzione = int.Parse(txtValore.Text);
                accessi[meseSostituzione - 1] = valoreSostituzione;
                visualizza();
                txtMese.Clear();
                txtValore.Clear();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Inserire un numero");
                txtMese.Clear();
                txtValore.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Mese non valido");
                txtMese.Clear();
                txtValore.Clear();
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Numero troppo grande");
                txtMese.Clear();
                txtValore.Clear();
            }
        }

        private void btnPercentuale_Click(object sender, RoutedEventArgs e)
        {
            int somma = 0;
            int valoreMinimo = int.Parse(txtPercentuale.Text);
            for (int i = 0; i < dimensioneLogica; i++)
            {
                if (accessi[i] < valoreMinimo)
                {
                    somma++;
                }
            }
            double percentualeLunga =(somma*100)/dimensioneLogica;
            double percentuale = Math.Round(percentualeLunga, 2);
            txtShowPercentuale.Text = "Il numero di mesi con valori minori è " + percentuale + "%";
        }

        private void btnElimina_Click(object sender, RoutedEventArgs e)
        {
            int indice = (int.Parse(txtElimina.Text) - 1);
            try
            {
                if (indice == dimensioneLogica)
                {
                    dimensioneLogica--;
                    visualizza();
                }
                else
                {
                    for (int i = indice; i < dimensioneLogica - 1; i++)
                    {
                        temp = accessi[i];
                        accessi[i] = accessi[i + 1];
                        accessi[i + 1] = temp;
                    }
                    dimensioneLogica--;
                    txtElimina.Clear();
                    visualizza();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Inserisci un numero valido");
                txtElimina.Clear();
                return;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Indice non valido");
                txtElimina.Clear();
                return;
            }
        }
    }
}