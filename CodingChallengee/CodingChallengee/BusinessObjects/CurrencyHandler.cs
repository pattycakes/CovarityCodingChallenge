using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.BusinessObjects
{
    public class CurrencyHandler
    {
        #region constants

        private const Int16 ONE = 1;
        private const Int16 TWO = 2;
        private const Int16 FIVE = 5;
        private const Int16 TEN = 10;

        #endregion

        #region private variables

        private Double _activeCurrency;

        #endregion

        #region Attributes

        public Double ActiveCurrency
        {
            get { return _activeCurrency; }
            set { _activeCurrency = value; }

        }
        #endregion

        #region Constructors

        public CurrencyHandler()
        {
        }

        #endregion

        #region private methods

        private Boolean IsAcceptableCurrency(Currency Currency)
        {
            if (Currency.Value == ONE ||
                Currency.Value == TWO ||
                Currency.Value == FIVE ||
                Currency.Value == TEN)
                return true;
            else
                return false;
        }

        #endregion

        #region public methods
        
        public Int16 AcceptCurrency(Currency Currency)
        {
            if (IsAcceptableCurrency(Currency))
            {
                ActiveCurrency += Currency.Value;
                return 0; // success
            }
            else
                return 1; //error
        }

        public Double ReturnAcceptedCurrency()
        {
            Double ret = ActiveCurrency;
            ActiveCurrency = 0;
            return ret;
        }

        public Double ReturnChange(Double itemCost)
        {
            Double ret = ActiveCurrency - itemCost;
            ActiveCurrency = 0;
            return ret;
        }

        #endregion
    }
}
