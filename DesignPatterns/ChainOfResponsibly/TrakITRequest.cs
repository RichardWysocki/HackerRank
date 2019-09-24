namespace DesignPatterns.ChainOfResponsibly
{
    class TrakItRequest: IChain
    {
        private IChain _nextChain = EndofChain.Instance;


        public Category Process(string name)
        {
            if (name == "TrakItRequest")
            { 
                return new Category { Name= "TrakIT"};
            }

            return _nextChain.Process(name);

        }

        public void Next(IChain nextInChain)
        {
            _nextChain = nextInChain;
        }
    }
}
