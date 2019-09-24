using System;

namespace DesignPatterns.ChainOfResponsibly
{
    class EndofChain: IChain
    {
        
        private static EndofChain _instance = new EndofChain();

        public static EndofChain Instance
        {
            get { return _instance;  }

        }

        public Category Process(string name)
        {
            return new Category {Name = "You are Done the process"};
        }

        public void Next(IChain nextInChain)
        {
            throw new InvalidOperationException("No Chain...");
        }
    }
}
