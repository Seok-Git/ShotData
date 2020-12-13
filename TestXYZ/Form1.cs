
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartDirector;
using System.Collections;

using System.Diagnostics;
using MySql.Data.MySqlClient;


namespace TestXYZ
{

    public partial class Form1 : Form
    {

        MySqlConnection connection =
        new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd=1234;");
        
        public static List<float?> GX = new List<float?>();
        public static List<float?> GY = new List<float?>();
        public static List<float?> GZ = new List<float?>();

        int NowRange = -1;
        int MySQLListIndex = 0;
        bool checking;

        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form2 Chart = new Form2(this);//폼2
            Chart.Show();
        }


        private void MySqlLoader_Click(object sender, EventArgs e)
        {
            PosData Pd = new PosData();
            listView1.Items.Clear();

            try
            {
                String SelectQuery = "select * from shotdata where attacker = '" + textBox4.Text + "'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(SelectQuery, connection);
                MySqlDataReader rdr = command.ExecuteReader();

                checking = true;

                while (rdr.Read())
                {
                   ListViewItem MySqlDB = new ListViewItem();//listView1.Items[i]
                   listView1.Items.Add(MySqlDB);
                   for (int j = 0; j < 8; j++)//쿼리 조회시 데이터 리스트 박스에 입력됨.
                   {
                      String DBInsert = rdr.GetString(j);
                      MySqlDB.SubItems.Add(DBInsert);
                   }
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            checking = false;
            //Pd.ReadingList(false);

            connection.Close();


        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem MySqlDB = e.Item as ListViewItem;
            PosData Pd = new PosData();
            float[] board;

            if (MySqlDB != null&& Pd != null )
            {
                if(MySqlDB.Checked)
                {
                    if(checking == false)
                    {
                        MySQLListIndex = listView1.FocusedItem.Index; // 체크박스 선택된 인덱스
                        board = new float[3] { Convert.ToSingle(listView1.Items[MySQLListIndex].SubItems[5].Text), Convert.ToSingle(listView1.Items[MySQLListIndex].SubItems[6].Text), Convert.ToSingle(listView1.Items[MySQLListIndex].SubItems[7].Text) };
                        if (NowRange < MySQLListIndex) // 체크박스한 인덱스가 더 클경우
                        {
                            for (int k = NowRange + 1; k < MySQLListIndex + 1; k++)
                            {
                                GX.Add(null); // 선택된 인덱스까지 배열크기를 늘림
                                GY.Add(null); // 선택된 인덱스까지 배열크기를 늘림
                                GZ.Add(null); // 선택된 인덱스까지 배열크기를 늘림

                            }
                        }
                        Pd.InsertPos(MySQLListIndex, board,false);//
                        NowRange = MySQLListIndex; // 체크 박스 선택전 이전 배열크기
                    }
                    else if(checking == true)
                    {
                            NowRange++;
                            board = new float[3] { Convert.ToSingle(listView1.Items[NowRange].SubItems[5].Text), Convert.ToSingle(listView1.Items[NowRange].SubItems[6].Text), Convert.ToSingle(listView1.Items[NowRange].SubItems[7].Text) };
                            Pd.InsertPos(NowRange, board, true);
                    }
 
                }
                else 
                {
                    if (checking == false) 
                    {
                        Pd.RemovePos(listView1.FocusedItem.Index);
                    }
                }
            }
        }

        private void CCK_CheckedChanged(object sender, EventArgs e)
        {
            PosData Pd = new PosData();
            checking = true;
            if (CCK.Checked)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].Checked = true;
                }
            }
            else
            {
                if (GX.Count < listView1.Items.Count)
                {
                    for (int i = 0; i < GX.Count; i++)
                    {

                        listView1.Items[i].Checked = false;
                        Pd.RemovePos(i);

                    }
                }
                else
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {

                        listView1.Items[i].Checked = false;
                        Pd.RemovePos(i);

                    }
                }
                if (checking == true)//전부다 지웠을때
                {
                    NowRange = -1;
                }
            }
            checking = false;
        }
    }
}
