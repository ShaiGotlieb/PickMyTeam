using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickMyTeam
{
    public partial class _6X6 : Form
    {
        public player[] arr6 = new player[18];
        public _6X6()
        {
            InitializeComponent();
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = true;
            comboBox7.Visible = true;
            comboBox8.Visible = true;
            comboBox9.Visible = true;
            comboBox10.Visible = true;
            comboBox11.Visible = true;
            comboBox12.Visible = true;
            comboBox13.Visible = true;
            comboBox14.Visible = true;
            comboBox15.Visible = true;
            comboBox16.Visible = true;
            comboBox17.Visible = true;
            comboBox18.Visible = true;

            team3PictureBox1.Visible = false;
            team3PictureBox2.Visible = false;
            team3PictureBox3.Visible = false;
            team3PictureBox4.Visible = false;
            team3PictureBox5.Visible = false;
            team3PictureBox6.Visible = false;
            team3PictureBox7.Visible = false;
            team3PictureBox8.Visible = false;
            team3PictureBox9.Visible = false;
            team3PictureBox10.Visible = false;
            team3PictureBox11.Visible = false;
            team3PictureBox12.Visible = false;
            team3PictureBox13.Visible = false;
            team3PictureBox14.Visible = false;
            team3PictureBox15.Visible = false;
            team3PictureBox16.Visible = false;
            team3PictureBox17.Visible = false;
            team3PictureBox18.Visible = false;

            player3Label1.Visible = false;
            player3Label2.Visible = false;
            player3Label3.Visible = false;
            player3Label4.Visible = false;
            player3Label5.Visible = false;
            player3Label6.Visible = false;
            player3Label7.Visible = false;
            player3Label8.Visible = false;
            player3Label9.Visible = false;
            player3Label10.Visible = false;
            player3Label11.Visible = false;
            player3Label12.Visible = false;
            player3Label13.Visible = false;
            player3Label14.Visible = false;
            player3Label15.Visible = false;
            player3Label16.Visible = false;
            player3Label17.Visible = false;
            player3Label18.Visible = false;
        }

        private void randomButton5X5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            comboBox11.Visible = false;
            comboBox12.Visible = false;
            comboBox13.Visible = false;
            comboBox14.Visible = false;
            comboBox15.Visible = false;
            comboBox16.Visible = false;
            comboBox17.Visible = false;
            comboBox18.Visible = false;

            player player1 = new player(textBox1.Text, comboBox1.SelectedIndex + 1);
            player player2 = new player(textBox2.Text, comboBox2.SelectedIndex + 1);
            player player3 = new player(textBox3.Text, comboBox3.SelectedIndex + 1);
            player player4 = new player(textBox4.Text, comboBox4.SelectedIndex + 1);
            player player5 = new player(textBox5.Text, comboBox5.SelectedIndex + 1);
            player player6 = new player(textBox6.Text, comboBox6.SelectedIndex + 1);
            player player7 = new player(textBox7.Text, comboBox7.SelectedIndex + 1);
            player player8 = new player(textBox8.Text, comboBox8.SelectedIndex + 1);
            player player9 = new player(textBox9.Text, comboBox9.SelectedIndex + 1);
            player player10 = new player(textBox10.Text, comboBox10.SelectedIndex + 1);
            player player11 = new player(textBox11.Text, comboBox11.SelectedIndex + 1);
            player player12 = new player(textBox12.Text, comboBox12.SelectedIndex + 1);
            player player13 = new player(textBox13.Text, comboBox13.SelectedIndex + 1);
            player player14 = new player(textBox14.Text, comboBox14.SelectedIndex + 1);
            player player15 = new player(textBox15.Text, comboBox15.SelectedIndex + 1);
            player player16 = new player(textBox16.Text, comboBox16.SelectedIndex + 1);
            player player17 = new player(textBox17.Text, comboBox17.SelectedIndex + 1);
            player player18 = new player(textBox18.Text, comboBox18.SelectedIndex + 1);

            arr6[0] = (player)player1;
            arr6[1] = (player)player2;
            arr6[2] = (player)player3;
            arr6[3] = (player)player4;
            arr6[4] = (player)player5;
            arr6[5] = (player)player6;
            arr6[6] = (player)player7;
            arr6[7] = (player)player8;
            arr6[8] = (player)player9;
            arr6[9] = (player)player10;
            arr6[10] = (player)player11;
            arr6[11] = (player)player12;
            arr6[12] = (player)player13;
            arr6[13] = (player)player14;
            arr6[14] = (player)player15;
            arr6[15] = (player)player16;
            arr6[16] = (player)player17;
            arr6[17] = (player)player18;

            quickSort(arr6, 0, 17);

            player3Label1.Text = arr6[0].name;
            player3Label2.Text = arr6[3].name;
            player3Label3.Text = arr6[6].name;
            player3Label4.Text = arr6[11].name;
            player3Label5.Text = arr6[14].name;
            player3Label6.Text = arr6[17].name;
            player3Label7.Text = arr6[1].name;
            player3Label8.Text = arr6[4].name;
            player3Label9.Text = arr6[7].name;
            player3Label10.Text = arr6[10].name;
            player3Label11.Text = arr6[13].name;
            player3Label12.Text = arr6[16].name;
            player3Label13.Text = arr6[2].name;
            player3Label14.Text = arr6[5].name;
            player3Label15.Text = arr6[8].name;
            player3Label16.Text = arr6[9].name;
            player3Label17.Text = arr6[12].name;
            player3Label18.Text = arr6[15].name;

            player3Label1.Visible = true;
            player3Label2.Visible = true;
            player3Label3.Visible = true;
            player3Label4.Visible = true;
            player3Label5.Visible = true;
            player3Label6.Visible = true;
            player3Label7.Visible = true;
            player3Label8.Visible = true;
            player3Label9.Visible = true;
            player3Label10.Visible = true;
            player3Label11.Visible = true;
            player3Label12.Visible = true;
            player3Label13.Visible = true;
            player3Label14.Visible = true;
            player3Label15.Visible = true;
            player3Label16.Visible = true;
            player3Label17.Visible = true;
            player3Label18.Visible = true;

            team3PictureBox1.Visible = true;
            team3PictureBox2.Visible = true;
            team3PictureBox3.Visible = true;
            team3PictureBox4.Visible = true;
            team3PictureBox5.Visible = true;
            team3PictureBox6.Visible = true;
            team3PictureBox7.Visible = true;
            team3PictureBox8.Visible = true;
            team3PictureBox9.Visible = true;
            team3PictureBox10.Visible = true;
            team3PictureBox11.Visible = true;
            team3PictureBox12.Visible = true;
            team3PictureBox13.Visible = true;
            team3PictureBox14.Visible = true;
            team3PictureBox15.Visible = true;
            team3PictureBox16.Visible = true;
            team3PictureBox17.Visible = true;
            team3PictureBox18.Visible = true;

            team1label1.Visible = true;
            team2label2.Visible = true;
            team3label3.Visible = true;

            randomButton6X6.Visible = false;
            locoHotbutton.Visible = true;
        }

        public static void quickSort(player[] A, int left, int right)
        {
            if (left > right || left < 0 || right < 0) return;

            int index = partition(A, left, right);

            if (index != -1)
            {
                quickSort(A, left, index - 1);
                quickSort(A, index + 1, right);
            }
        }

        public static int partition(player[] A, int left, int right)
        {
            if (left > right) return -1;

            int end = left;

            int pivot = A[right].level;    // choose last one to pivot, easy to code
            for (int i = left; i < right; i++)
            {
                if (A[i].level < pivot)
                {
                    swap(A, i, end);
                    end++;
                }
            }

            swap(A, end, right);

            return end;
        }

        public static void swap(player[] A, int left, int right)
        {
            player tmp = A[left];
            A[left] = A[right];
            A[right] = tmp;
        }

        private void locoHotbutton_Click(object sender, EventArgs e)
        {
            quickSort(arr6, 0, 17);
            player3Label1.Text = arr6[0].name;
            player3Label2.Text = arr6[3].name;
            player3Label3.Text = arr6[8].name;
            player3Label4.Text = arr6[11].name;
            player3Label5.Text = arr6[14].name;
            player3Label6.Text = arr6[1].name;
            player3Label7.Text = arr6[4].name;
            player3Label8.Text = arr6[7].name;
            player3Label9.Text = arr6[10].name;
            player3Label10.Text = arr6[13].name;
            player3Label11.Text = arr6[2].name;
            player3Label12.Text = arr6[5].name;
            player3Label13.Text = arr6[6].name;
            player3Label14.Text = arr6[9].name;
            player3Label15.Text = arr6[12].name;
        }
    }
}
    

