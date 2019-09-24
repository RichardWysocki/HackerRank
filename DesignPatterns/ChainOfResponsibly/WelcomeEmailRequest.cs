namespace DesignPatterns.ChainOfResponsibly
{
    class WelcomeEmailRequest: IChain
    {
        private IChain _nextChain;

        public Category Process(string name)
        {
            if (name == "WelcomeEmailRequest")
            {
                return new Category { Name = "Welcome Email" };
            }

            return _nextChain.Process(name);
        }

        public void Next(IChain nextInChain)
        {
            _nextChain = nextInChain;
        }
    }
}
