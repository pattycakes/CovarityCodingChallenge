using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.BusinessObjects
{
    public class Currency
    {
        // sorry, I'm getting out of scope here. 
        #region constants

        private const Int16 MAX_COIN_VALUE = 2;

        #endregion

        #region private variables

        private Int16 _value;

        #endregion

        #region Attributes

        public Int16 Value
        {
            get { return _value; }
            set { _value = value; }
        }

        #endregion

        #region constructors

        public Currency(Int16 value)
        {
            Value = value;
        }

        #endregion

        #region Public Methods
        
        public Boolean IsCoin 
        {
            get { if (Value <= MAX_COIN_VALUE) return true; else return false; }
        }

        #endregion

    }
}
