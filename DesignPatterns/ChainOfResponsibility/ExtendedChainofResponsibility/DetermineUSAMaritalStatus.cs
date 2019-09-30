namespace DesignPatterns.ChainOfResponsibility.ExtendedChainofResponsibility
{
    class DetermineUSAMaritalStatus : IDecisionChain
    {
        private IDecisionChain _yesDecisionChain = EndofExtendedChain.Instance;
        private IDecisionChain _noDecisionChain = EndofExtendedChain.Instance;

        public DetermineUSAMaritalStatus()
        {
            
        }

        public TaxInformationResponse Process(CustomerSurvey customerSurvey)
        {
            if (customerSurvey.Maritalstatus == MaritalStatus.Married)
                return _yesDecisionChain.Process(customerSurvey);
            return _noDecisionChain.Process(customerSurvey);
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
