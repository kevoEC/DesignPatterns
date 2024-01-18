using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public abstract class Creator
    {
        public abstract Vehicle Create();
    }
}
