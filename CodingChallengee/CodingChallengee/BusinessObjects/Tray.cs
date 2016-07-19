using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.BusinessObjects
{
    public class Tray
    {
        #region consants

        private const Int16 MAX_TRAY_SIZE = 10;

        #endregion

        #region private Variables

        private List<InventoryItem> _inventoryItems;
        private Double _price;

        #endregion

        #region Attributes

        public List<InventoryItem> InventoryItems
        {
            get { return _inventoryItems; }
            set { _inventoryItems = value; }
        }

        public Double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        #endregion

        #region Constructors

        public Tray()
        {
            InventoryItems = new List<InventoryItem>();
        }
        
        #endregion

        #region Private Methods
        
        private Boolean CanAddInventoryQuantity(Int16 quantity)
        {
            if ((InventoryItems.Count + quantity) <= MAX_TRAY_SIZE)
                return true;
            else
                return false;
        }

        private void AddInventory(Int16 quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                InventoryItems.Add(new InventoryItem());
            }
        }

        #endregion

        #region Public Methods

        public Int16 Replenish(Int16 quantity, Double price)
        {
            if (CanAddInventoryQuantity(quantity))
            {
                AddInventory(quantity);
                Price = price;
                return 0; // success
            }
            else
                return 1; // error
        }

        public void Remove()
        {
            if (InventoryItems.Count != 0)
            InventoryItems.RemoveAt(0);
        }

        #endregion
    }
}
