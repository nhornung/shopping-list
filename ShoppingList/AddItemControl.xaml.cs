using System;
using System.Collections.Generic;
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

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for AddItemControl.xaml
    /// </summary>
    public partial class AddItemControl : UserControl
    {
        public AddItemControl()
        {
            InitializeComponent();

            AddItemButton.Click += OnAddItemButtonClick;
        }

        protected void OnAddItemButtonClick(object sender, RoutedEventArgs args)
        {
            /*
            var item = ItemToAdd.Text;

            //var data = (ShoppingListData)DataContext; this throws an exception if does not work 
            var data = DataContext as ShoppingListData; // This one assigns data null if it doesnt work

            if (data !=null)
            {
                // safe to work with data
            }

            if (DataContext is ShoppingListData data2) //data2 will only exist in this block and will be a shopping list data
            {

            }
            */

            if(DataContext is ShoppingListData data)
            {
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }

        }
    }
}
