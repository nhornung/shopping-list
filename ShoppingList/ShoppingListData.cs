using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ShoppingList
{
    public class ShoppingListData : INotifyPropertyChanged
    {
        //This controls how the list is changed. A safe and secure way (want to manipulate data in our choice of interface)
        public event PropertyChangedEventHandler PropertyChanged;

        List<string> items = new List<string>();

        public IEnumerable<string> Items => items.ToArray(); //makes a copy, hides data with the toarray


        public void Add(string item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items")); //must spell string of thing your changing exactly same
        }

        public void Remove(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

    }
}
