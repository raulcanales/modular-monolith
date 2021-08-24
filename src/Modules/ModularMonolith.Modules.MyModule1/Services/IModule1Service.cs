namespace ModularMonolith.Modules.MyModule1.Services
{
    internal interface IModule1Service
    {
        string GetSentence();
    }

    internal class Module1Service : IModule1Service
    {
        public string GetSentence()
        {
            return "Hi from Module 1!";
        }
    }
}
