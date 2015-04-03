using System;

namespace RefactoringKatas.Creation
{
    public class LoanNew
    {
        private double _commitment;
        private double _outstanding;
        private int _riskRating;
        private DateTime _maturity;
        private DateTime _expiry;
        private CapitalStrategy _capitalStrategy;

        public static LoanNew CreateTermLoan(double commitment, int riskRating, DateTime maturity)
        {
            return new LoanNew(new CapitalStrategyTermLoan(), commitment, 0, riskRating, maturity, DateTime.MinValue);
        }

        public static LoanNew CreateRevolver(double commitment, int riskRating, DateTime expiry)
        {
            return new LoanNew(new CapitalStrategyRevolver(), commitment, 0, riskRating, DateTime.MinValue, expiry);
        }

        public static LoanNew CreateRCTL(double commitment, int riskRating, DateTime maturity, DateTime expiry)
        {
            return new LoanNew(new CapitalStrategyRCTL(), commitment, 0, riskRating, maturity, expiry);
        }

        
        public LoanNew(CapitalStrategy capitalStrategy, double commitment, double outstanding, int riskRating, DateTime maturity, DateTime expiry)
        {
            _commitment = commitment;
            _outstanding = outstanding;
            _riskRating = riskRating;
            _maturity = maturity;
            _expiry = expiry;
            _capitalStrategy = capitalStrategy;
        }
    }
}