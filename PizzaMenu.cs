using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class PizzaMenu
    {
        // Key = pizzaID, Value = pizza objekt (her gemmes alle pizzaerne)
        private Dictionary<int, Pizza> _pizzas = new Dictionary<int, Pizza>();

        // constructor 
        public PizzaMenu()
        {
        }

        // Add (create)
        public void Add(Pizza pizza)
        {
            _pizzas.Add(pizza.PizzaID, pizza);
                
        }

        // Get (Read/search)
        public Pizza? SearchPizza(int id)
        {
            if (_pizzas.ContainsKey(id))
            {
                return _pizzas[id];
            }
            return null;
        }
        

        // Update
        public void Update(Pizza updated)
        {
            if (updated != null)
                if (_pizzas.ContainsKey(updated.PizzaID))
                    _pizzas[updated.PizzaID] = updated;
                    
        }

        // Remove
        public void Remove(int pizzaNO)
        {
            if (_pizzas.ContainsKey(pizzaNO))
            {
                _pizzas.Remove(pizzaNO);
            }
        }

        //Print
        public void PrintMenu()
        {
            foreach (Pizza p in _pizzas.Values)
            {
                Console.WriteLine(p);
            }

        }
    
    }
}
