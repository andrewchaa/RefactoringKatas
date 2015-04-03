using System;
using RefactoringKatas.References;

namespace RefactoringKatas.Constructor_Chain
{
    public class Loan
    {
        private float _notional;
        private readonly float _outstanding;
        private readonly int _rating;
        private readonly DateTime _expiry;
        private readonly DateTime _maturity;
        private CapitalStrategy _strategy;

        public Loan(float notional, float outstanding, int rating, DateTime expiry)
        {
            _strategy = new TermROC();
            _notional = notional;
            _outstanding = outstanding;
            _rating = rating;
            _expiry = expiry;
        }

        public Loan(float notional, float outstanding, int rating, DateTime expiry, DateTime maturity)
        {
            _strategy = new RevolvingTermROC();
            _notional = notional;
            _outstanding = outstanding;
            _rating = rating;
            _expiry = expiry;
            _maturity = maturity;
        }

        public Loan(CapitalStrategy strategy, float notional, float outstanding, int rating, DateTime expiry, DateTime maturity)
        {
            _strategy = strategy;
            _notional = notional;
            _outstanding = outstanding;
            _rating = rating;
            _expiry = expiry;
            _maturity = maturity;
        }
    }
}
