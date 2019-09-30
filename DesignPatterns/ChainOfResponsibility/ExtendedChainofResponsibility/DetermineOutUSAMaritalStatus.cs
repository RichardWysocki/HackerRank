namespace DesignPatterns.ChainOfResponsibility.ExtendedChainofResponsibility
{
    class DetermineOutUSAMaritalStatus : IDecisionChain
    {
        private IDecisionChain _yesDecisionChain = EndofExtendedChain.Instance;
        private IDecisionChain _noDecisionChain = EndofExtendedChain.Instance;

        public DetermineOutUSAMaritalStatus()
        {
            
        }

        public TaxInformationResponse Process(CustomerSurvey customerSurvey)
        {
            if (customerSurvey.Maritalstatus == MaritalStatus.Married || customerSurvey.Kids)
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
