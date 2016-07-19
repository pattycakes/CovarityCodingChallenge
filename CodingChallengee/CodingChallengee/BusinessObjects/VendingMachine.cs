using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.BusinessObjects
{
    class VendingMachine
    {
        // This appears to also be out of scope so i stopped.

        #region consants

        
        
        public const Int16 MAX_TRAY_COUNT = 3;

        #endregion

        #region Private Variables

        private List<Tray> Trays;

        #endregion

        #region Constructors

        public VendingMachine()
        {
            for ( int i = 0; i <= MAX_TRAY_COUNT; i++)
            {
                Trays.Add(new Tray());
            }
        }

        #endregion

        #region Private Methods



        #endregion

        #region Public Methods

        public void Purchase()
        {

        }

        #endregion
    }
}
