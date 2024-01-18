using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangCreator : Creator
    {
        public override Vehicle Create()
        {
            var builder = new CarBuilder();
            return builder.Build();
        }
    }
}
