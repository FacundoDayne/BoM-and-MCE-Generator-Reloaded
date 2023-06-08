using BoM_and_MCE_Generator_Reloaded.Forms_and_Panels;

namespace BoM_and_MCE_Generator_Reloaded
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LandingForm());
        }
    }
}