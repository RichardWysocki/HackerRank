namespace DesignPatterns.ChainOfResponsibility.ExtendedChainofResponsibility
{
    public interface IDecisionChain
    {
        TaxInformationResponse Process(CustomerSurvey customerSurvey);
        
        void Yes(IDecisionChain yesDecisionChain);
        void No(IDecisionChain noDecisionChain);

    }
}
 