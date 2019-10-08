using System;

namespace DesignPatterns.ChainOfResponsibility.ExtendedChainofResponsibility
{
    class EndofExtendedChain: IDecisionChain
    {
        private static readonly EndofExtendedChain _instance = new EndofExtendedChain();

        public static EndofExtendedChain Instance
        {
            get { return _instance; }

        }

        public TaxInformationResponse Process(CustomerSurvey customerSurvey)
        {
            return new TaxInformationResponse() { TaxRate = 0};
        }

        public void Yes(IDecisionChain yesDecisionChain)
        {
            throw new InvalidOperationException("No Chain...");
        }

        public void No(IDecisionChain noDecisionChain)
        {
            throw new InvalidOperationException("No Chain...");
        }
    }
}



