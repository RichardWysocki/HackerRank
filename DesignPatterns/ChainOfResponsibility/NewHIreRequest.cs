namespace DesignPatterns.ChainOfResponsibility
{
    class NewHireRequest: IChain
    {
        private IChain _nextChain;

        public CategoryResponse Process(string name)
        {
            if (name == "NewHireRequest")
            {
                return new CategoryResponse { Name = "New Hire" };
            }

            return _nextChain.Process(name);
        }

        public void Next(IChain nextInChain)
        {
            _nextChain = nextInChain;
        }
    }
}
