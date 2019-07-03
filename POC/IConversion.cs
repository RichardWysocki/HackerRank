using System.Collections.Generic;

namespace POC
{
    public interface IConversion
    {
        string Run(List<Product> list1, List<Category> list2);

    }
}
