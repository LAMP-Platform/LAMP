using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAM2E.Classes
{
    public class Pointer
    {
        public int Offset;
        public int Bank;
        public int bOffset;

        public Pointer (int pointer)
        {
            Offset = pointer;

            //calculating bank and pointer
            int bankNr = Offset / 0x4000;
            Bank = bankNr;

            int offset = bankNr * 0x4000;
            offset = Offset - offset + 0x4000;
            bOffset = offset;
        }

        public Pointer (int bank, int pointer)
        {
            Bank = bank;
            bOffset = pointer;

            //calculating direct offset
            int offset = (int)((pointer - 0x4000) + bank * 0x4000);
            Offset = offset;
        }
    }
}
