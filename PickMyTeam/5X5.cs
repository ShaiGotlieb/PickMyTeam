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
    public partial class _5X5 : Form
    {
        public player[] arr5 = new player[15];
        public _5X5()
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

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;

            locoHotbutton.Visible = false;


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

            arr5[0] = (player)player1;
            arr5[1] = (player)player2;
            arr5[2] = (player)player3;
            arr5[3] = (player)player4;
            arr5[4] = (player)player5;
            arr5[5] = (player)player6;
            arr5[6] = (player)player7;
            arr5[7] = (player)player8;
            arr5[8] = (player)player9;
            arr5[9] = (player)player10;
            arr5[10] = (player)player11;
            arr5[11] = (player)player12;
            arr5[12] = (player)player13;
            arr5[13] = (player)player14;
            arr5[14] = (player)player15;

            quickSort(arr5, 0, 14);

            label1.Text = arr5[0].name;
            label2.Text = arr5[3].name;
            label3.Text = arr5[8].name;
            label4.Text = arr5[11].name;
            label5.Text = arr5[14].name;
            label6.Text = arr5[1].name;
            label7.Text = arr5[4].name;
            label8.Text = arr5[7].name;
            label9.Text = arr5[10].name;
            label10.Text = arr5[13].name;
            label11.Text = arr5[2].name;
            label12.Text = arr5[5].name;
            label13.Text = arr5[6].name;
            label14.Text = arr5[9].name;
            label15.Text = arr5[12].name;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;

            randomButton5X5.Visible = false;
            locoHotbutton.Visible = true;
        }

        private void locoHotbutton_Click(object sender, EventArgs e)
        {
            quickSort(arr5, 0, 14);
            label1.Text = arr5[0].name;
            label2.Text = arr5[3].name;
            label3.Text = arr5[8].name;
            label4.Text = arr5[11].name;
            label5.Text = arr5[14].name;
            label6.Text = arr5[1].name;
            label7.Text = arr5[4].name;
            label8.Text = arr5[7].name;
            label9.Text = arr5[10].name;
            label10.Text = arr5[13].name;
            label11.Text = arr5[2].name;
            label12.Text = arr5[5].name;
            label13.Text = arr5[6].name;
            label14.Text = arr5[9].name;
            label15.Text = arr5[12].name;
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

    }
}
