using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Diagnostics;


namespace TestXYZ
{
    public class PosData
    {
        List<float?> GX = Form1.GX;
        List<float?> GY = Form1.GY;
        List<float?> GZ = Form1.GZ;

       // Form1 f1;
        Form1 f1 = new Form1();

        public void RemovePos(int index)
        {
            if (f1 != null)
            {
                GX.RemoveAt(index);
                GX.Insert(index, null);
                GY.RemoveAt(index);
                GY.Insert(index, null);
                GZ.RemoveAt(index);
                GZ.Insert(index, null);
            }
        }
        public void InsertPos(int index, float[] board,bool Check)
        {
            if (f1 != null)
            {
                if (Check == false)
                {
                    GX.Insert(index, board[0]);
                    GX.RemoveAt(index + 1);
                    GY.Insert(index, board[1]);
                    GY.RemoveAt(index + 1);
                    GZ.Insert(index, board[2]);
                    GZ.RemoveAt(index + 1);
                }
                else
                {
                    GX.Insert(index, board[0]);
                    GY.Insert(index, board[1]);
                    GZ.Insert(index, board[2]);
                }
            }
        }

        public bool ReadingList(bool Read)
        {
            return Read;
        }
    }
}
