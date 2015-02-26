namespace EnvironmentSystem
{
    using EnvironmentSystem.Core;

    public class EnvironmentSystemMain
    {
        static void Main()
        {
            var keyController = new KeyController();
            var engine = new ExtendEngine(keyController);
            engine.Run();
        }
    }
}
