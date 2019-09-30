namespace DesignPatterns.ChainOfResponsibility.ExtendedChainofResponsibility
{
    class IsOver100KSalary_Determine : IDecisionChain
    {
        private IDecisionChain _yesDecisionChain = EndofExtendedChain.Instance;
        private IDecisionChain _noDecisionChain = EndofExtendedChain.Instance;

        public TaxInformationResponse Process(CustomerSurvey customerSurvey)
        {
            if (customerSurvey.Salary >= 100000)
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
