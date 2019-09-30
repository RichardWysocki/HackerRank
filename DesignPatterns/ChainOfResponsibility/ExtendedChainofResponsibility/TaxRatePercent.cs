namespace DesignPatterns.ChainOfResponsibility.ExtendedChainofResponsibility
{
    public class TaxRatePercent : IDecisionChain
    {
        private readonly double _defaultTaxRate;
        private IDecisionChain _yesDecisionChain = EndofExtendedChain.Instance;
        private IDecisionChain _noDecisionChain = EndofExtendedChain.Instance;

        public TaxRatePercent(double defaultTaxRate)
        {
            _defaultTaxRate = defaultTaxRate;
        }

        public TaxInformationResponse Process(CustomerSurvey customerSurvey)
        {
            return new TaxInformationResponse {TaxRate = _defaultTaxRate };
        }

        public void Yes(IDecisionChain yesDecisionChain)
        {
            _yesDecisionChain = yesDecisionChain;
        }
        public void No(IDecisionChain noDecisionChain)
        {
            _noDecisionChain = noDecisionChain;
        }
    }
}
