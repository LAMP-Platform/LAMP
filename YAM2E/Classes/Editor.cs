using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace YAM2E.Classes
{
    public static class Editor
    {
        public static byte[] ROM; //byte array of the ROM
        public static int[] A_BANKS = { 0x24000, 0x28000, 0x2C000, 0x30000, 0x34000, 0x38000, 0x3C000 }; //pointers to level data banks

        public static void open_rom()
        {
            //Get the path to ROM
            string path = getFilePath("Gameboy ROM (*.gb)|*.gb");

            if (path != string.Empty)
            {
                //Changing button appearence
                Globals.rom_loaded = true;
                main_window.Current.updateButtonStatus();

                ROM = File.ReadAllBytes(path);
            }
        }

        public static string getFilePath(string filter) //Opens Dialog Window and returns path to file
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = filter;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    return openFileDialog.FileName;
                return string.Empty;
            }
        }
    }
}
