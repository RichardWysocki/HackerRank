namespace DesignPatterns.ChainOfResponsibly
{
    class NewHireRequest: IChain
    {
        private IChain _nextChain;

        public Category Process(string name)
        {
            if (name == "NewHireRequest")
            {
                return new Category { Name = "New Hire" };
            }

            return _nextChain.Process(name);
        }

        public void Next(IChain nextInChain)
        {
            _nextChain = nextInChain;
        }
    }
}
