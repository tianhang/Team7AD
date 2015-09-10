using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.EntityFacade;

namespace ClassLibraryBL.Controller.stockClerk
{
    public class ViewInventoryController
    {
        InventoryFacade inventoryFacade;
        public ViewInventoryController()
        {
            inventoryFacade = new InventoryFacade();
        }

        public Object getInventoryData()
        {
            return inventoryFacade.getInventoryData();
        }

        public Object getLowBalanceData()
        {
            return inventoryFacade.getLowBalanceData();
        }
    }
}
