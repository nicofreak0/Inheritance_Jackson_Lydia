namespace Inheritance_Jackson_Lydia
{
    internal class Program
    {

        /// <summary>
        /// prints to console the title and ESBR rating of two games
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FPS myFPS = new FPS("M", "Call of Duty");

            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            FPS csGo = new FPS("M", "CS:GO");

            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();
        }
    }
}