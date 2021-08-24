namespace ModularMonolith.Modules.MyModule2.Services
{
    internal interface IModule2Service
    {
        string GetSentence();
    }

    internal class Module2Service : IModule2Service
    {
        public string GetSentence()
        {
            return "Hi from Module 2!";
        }
    }
}
