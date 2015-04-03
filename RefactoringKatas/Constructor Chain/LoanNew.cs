using System;
using RefactoringKatas.References;

namespace RefactoringKatas.Constructor_Chain
{
    public class LoanNew
    {
        private float _notional;
        private readonly float _outstanding;
        private readonly int _rating;
        private readonly DateTime _expiry;
        private readonly DateTime? _maturity;
        private CapitalStrategy _strategy;

        public LoanNew(float notional, float outstanding, int rating, DateTime expiry)
            : this(new TermROC(), notional, outstanding, rating, expiry, null)
        {}

        public LoanNew(float notional, float outstanding, int rating, DateTime expiry, DateTime maturity)
            : this(new RevolvingTermROC(), notional, outstanding, rating, expiry, maturity)
        {}

        public LoanNew(CapitalStrategy strategy, float notional, float outstanding, int rating, DateTime expiry, DateTime? maturity)
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
