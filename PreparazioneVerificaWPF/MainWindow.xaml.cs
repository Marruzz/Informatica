using System.Security.Authentication;
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

namespace EserciziWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int dimensioneFisicaVettore = 25;
        int dimensioneLogicaVettore = 0;
        int[] vettore = new int[dimensioneFisicaVettore];
        int min;
        int somma = 0;
        double media = 0;
        int valoriMin;
        double percentuale = 0;
        int temp = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                vettore[dimensioneLogicaVettore] = int.Parse(txtInserisci.Text);
                dimensioneLogicaVettore++;
                txtInserisci.Clear();
                Visualizza();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Inserisci un numero valido");
                txtInserisci.Clear();
                return;
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Numero troppo grande");
                txtInserisci.Clear();
                return;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Hai raggiunto il limite di numeri inseribili");
                return;
            }
        }

        private void Visualizza()
        {
            lstNumeri.Items.Clear();
            for (int i = 0; i < dimensioneLogicaVettore; i++)
            {
                lstNumeri.Items.Add((i + 1) + "-" + vettore[i]);
            }
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            min = vettore[0];
            for (int i = 0; i < dimensioneLogicaVettore; i++)
            {
                if (vettore[i] < min)
                {
                    min = vettore[i];
                }
            }
            txtMin.Text = min.ToString();
        }

        private void btnAzzeraIndice_Click(object sender, RoutedEventArgs e)
        {
            int azzera = int.Parse(txtIndice.Text);
            if (azzera < 0 || azzera >= dimensioneLogicaVettore)
            {
                MessageBox.Show("Indice non valido");
                return;
            }
            vettore[azzera-1] = 0;
            txtIndice.Clear();
            Visualizza();
        }

        private void btnPercentuali_Click(object sender, RoutedEventArgs e)
        {
            //calcolo dellla somma
            for (int i = 0; i < dimensioneLogicaVettore; i++)
            {
                somma += vettore[i];
            }
            //calcolo della media
            media = (double)somma / dimensioneLogicaVettore;

            //calcolo della percentuale
            for (int i = 0; i < dimensioneLogicaVettore; i++)
            {
                if ((double)vettore[i] < media)
                {
                    valoriMin++;
                }
            }
            percentuale = ((double)valoriMin / dimensioneLogicaVettore) * 100;
            double trim = Math.Round(percentuale, 2);
            txtPercentuali.Text = trim.ToString() + "%";
        }

        private void btnCancella_Click(object sender, RoutedEventArgs e)
        {
            int indice = (int.Parse(txtCancella.Text)-1);
            try
            {
                if (indice == dimensioneLogicaVettore)
                {
                    dimensioneLogicaVettore--;
                    Visualizza();
                }
                else
                {
                    dimensioneLogicaVettore--;
                    for (int i = indice; i < dimensioneLogicaVettore - 1; i++)
                    {
                        temp = vettore[i];
                        vettore[i] = vettore[i + 1];
                        vettore[i + 1] = temp;
                    }
                    Visualizza();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Inserisci un numero valido");
                txtCancella.Clear();
                return;
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Indice non valido");
                txtCancella.Clear();
                return;
            }
        }
    }
}