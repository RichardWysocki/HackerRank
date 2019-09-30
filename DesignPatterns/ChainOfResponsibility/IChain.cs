namespace DesignPatterns.ChainOfResponsibility
{

    public interface IChain
    {
        CategoryResponse Process(string name);
        void Next(IChain nextInChain);
        //void Yes(IChain nextInChain);
        //void No(IChain nextInChain);

    }
}
