using System;

namespace RefactoringKatas.Creation
{
    // Use creation methods

    public class Loan
    {
        private double _commitment;
        private double _outstanding;
        private int _riskRating;
        private DateTime _maturity;
        private DateTime _expiry;
        private CapitalStrategy _capitalStrategy;

        public Loan(double commitment, int riskRating, DateTime maturity)
            : this(commitment, 0.00, riskRating, maturity, DateTime.MinValue)
        {
        }

        public Loan(double commitment, int riskRating, DateTime maturity, DateTime expiry)
            : this(commitment, 0.00, riskRating, maturity, expiry)
        {
        }

        public Loan(double commitment, double outstanding, int riskRating, DateTime maturity, DateTime expiry)
            : this(null, commitment, outstanding, riskRating, maturity, expiry)
        {
        }

        public Loan(CapitalStrategy capitalStrategy, double commitment, int riskRating, DateTime maturity,
            DateTime expiry)
            : this(capitalStrategy, commitment, 0.00, riskRating, maturity, expiry)
        {
        }

        public Loan(CapitalStrategy capitalStrategy, double commitment, double outstanding, int riskRating,
            DateTime maturity, DateTime expiry)
        {
            _commitment = commitment;
            _outstanding = outstanding;
            _riskRating = riskRating;
            _maturity = maturity;
            _expiry = expiry;
            _capitalStrategy = capitalStrategy;

            if (capitalStrategy == null)
            {
                if (expiry == DateTime.MinValue)
                    _capitalStrategy = new CapitalStrategyTermLoan();
                else if (maturity == DateTime.MinValue)
                    _capitalStrategy = new CapitalStrategyRevolver();
                else
                    _capitalStrategy = new CapitalStrategyRCTL();
            }
        }
    }
}
