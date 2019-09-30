namespace DesignPatterns.ChainOfResponsibility
{
    class WelcomeEmailRequest: IChain
    {
        private IChain _nextChain;

        public CategoryResponse Process(string name)
        {
            if (name == "WelcomeEmailRequest")
            {
                return new CategoryResponse { Name = "Welcome Email" };
            }

            return _nextChain.Process(name);
        }

        public void Next(IChain nextInChain)
        {
            _nextChain = nextInChain;
        }
    }
}
