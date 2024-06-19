using LAMP.FORMS;
using LAMP.Utilities;
using System;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace LAMP;

internal static class Program
 {
    //Creating a Webclient for the entire application
    public static HttpClient httpClient = new HttpClient();
 
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main(string[] args)
    {
        if (args.Length < 1) StartGUIApplication();
        else
        {
            //React to commands
            string command = args[0];
            switch (command)
            {
                case ("ApplyIPS"):
                    if (args.Length >= 3) CommandApplyIPS(args[1..]);
                    break;
                case ("CreateIPS"):
                    if (args.Length >= 3) CommandCreateIPS(args[1..]);
                    break;
                default:
                    Console.WriteLine($"Unknown command \'{args[0]}\'");
                    break;
            }
        }
    }

    private static void StartGUIApplication()
    {
        Application.SetHighDpiMode(HighDpiMode.DpiUnaware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Application.Run(new MainWindow());
    }

    #region Commands

    /// <summary>
    /// args[0] OriginalFile <br></br>
    /// args[1] ModifiedFile <br></br>
    /// [args[2] NewFile] <br></br>
    /// </summary>
    /// <param name="args"></param>
    private static void CommandCreateIPS(string[] args)
    {
        Console.WriteLine("Creating IPS File");
        byte[] OriginalFile = File.ReadAllBytes(args[0]);
        byte[] ModifiedFile = File.ReadAllBytes(args[1]);
        string ResultName = Path.GetFileNameWithoutExtension(args[1]) + "Patched.ips";
        if (args.Length == 3) ResultName = args[2];

        File.WriteAllBytes(ResultName, Patch.CreateIPSPatch(OriginalFile, ModifiedFile));
    }

    private static void CommandApplyIPS(string[] args)
    {
        Console.WriteLine("Applying IPS File");
    }
    #endregion
}