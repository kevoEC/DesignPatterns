using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;


namespace DesignPatterns.Factories
{
    public class FordExplorerCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarBuilder();
            return builder
                .SetModel("Explorer")
                .SetColor("Black")
                .Build();
        }
    }
}
