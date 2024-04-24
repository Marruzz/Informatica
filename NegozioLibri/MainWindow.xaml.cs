using System;
using System.Collections.Generic;
using System.Windows;

namespace negozioLibri
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> _inventory = new Dictionary<string, int>();
        private void AddBook(string title, int quantity)
        {
            title=title.ToUpper();
            if (_inventory.ContainsKey(title))
            {
                _inventory[title] += quantity;
            }
            else
            {
                _inventory.Add(title, quantity);
            }
        }

        private void RemoveBook(string title, int quantity)
        {
            if (_inventory.ContainsKey(title) && _inventory[title] >= quantity)
            {
                _inventory[title] -= quantity;

                if (_inventory[title] == 0)
                {
                    _inventory.Remove(title);
                }
            }
            else
            {
                MessageBox.Show("The book is not available in the inventory or the quantity is insufficient.");
            }
        }

        private void ShowInventory()
        {
            string inventoryString = "Inventory:\n\n";

            foreach (KeyValuePair<string, int> book in _inventory)
            {
                inventoryString += $"{book.Key}: {book.Value}\n";
            }

            MessageBox.Show(inventoryString);
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddBook(TitleTextBox.Text, int.Parse(QuantityTextBox.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
                QuantityTextBox.Clear();
                TitleTextBox.Clear();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RemoveBook(TitleTextBox.Text, int.Parse(QuantityTextBox.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid quantity.");
            }
            TitleTextBox.Clear();
            QuantityTextBox.Clear();
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            ShowInventory();
        }
    }
}