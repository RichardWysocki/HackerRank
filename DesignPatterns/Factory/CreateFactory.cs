using System.Reflection;

namespace DesignPatterns.Factory
{
    public class CreateFactory
    {
        public ITransactions LoadFactory(string type)
        {
            type = "DesignPatterns.Factory." + type;
            var result = Assembly.GetExecutingAssembly().CreateInstance(type) as ITransactions;
            return result;
        }
    }
}
