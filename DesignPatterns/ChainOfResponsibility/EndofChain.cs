using System;

namespace DesignPatterns.ChainOfResponsibility
{
    class EndofChain: IChain
    {
        
        private static readonly EndofChain _instance = new EndofChain();

        public static EndofChain Instance
        {
            get { return _instance;  }

        }

        public CategoryResponse Process(string name)
        {
            return new CategoryResponse {Name = "You are Done the process"};
        }

        public void Next(IChain nextInChain)
        {
            throw new InvalidOperationException("No Chain...");
        }
    }
}
