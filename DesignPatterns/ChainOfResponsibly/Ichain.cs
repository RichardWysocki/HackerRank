namespace DesignPatterns.ChainOfResponsibly
{

    public interface IChain
    {
        Category Process(string name);
        void Next(IChain nextInChain);
        //void Yes(IChain nextInChain);
        //void No(IChain nextInChain);

    }

    public class Category
    {
        public string Name { get; set; }
        //public string Desc { get; set; }
    }
}
