namespace DesignPatterns.ChainOfResponsibility
{
    class TrakItRequest: IChain
    {
        private IChain _nextChain = EndofChain.Instance;


        public CategoryResponse Process(string name)
        {
            if (name == "TrakItRequest")
            { 
                return new CategoryResponse { Name= "TrakIT"};
            }

            return _nextChain.Process(name);

        }

        public void Next(IChain nextInChain)
        {
            _nextChain = nextInChain;
        }
    }
}
