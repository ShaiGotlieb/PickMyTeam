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
    public partial class player : Form
    {
        public int level;
        public string name;
        public player[] arr4 = new player[12];

        public player(string name, int level)
        {
            this.name = name;
            this.level = level;
            InitializeComponent();
        }    
        public void pickPlayer()
        {

        }
        private void PlayersButton4_Click(object sender, EventArgs e)
        {
            PlayersButton4.Visible = false;
            PlayersButton5.Visible = false;
            PlayersButton6.Visible = false;

            randomButton.Visible = true;

            playerTextBoxVisabillity(true);
            playerComboBoxVisabillity(true);

        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            playerTextBoxVisabillity(false);
            playerComboBoxVisabillity(false);

            player player1 = new player(playerNameTextBox1.Text, playerComboBox1.SelectedIndex + 1);
            player player2 = new player(playerNameTextBox2.Text, playerComboBox2.SelectedIndex + 1);
            player player3 = new player(playerNameTextBox3.Text, playerComboBox3.SelectedIndex + 1);
            player player4 = new player(playerNameTextBox4.Text, playerComboBox4.SelectedIndex + 1);
            player player5 = new player(playerNameTextBox5.Text, playerComboBox5.SelectedIndex + 1);
            player player6 = new player(playerNameTextBox6.Text, playerComboBox6.SelectedIndex + 1);
            player player7 = new player(playerNameTextBox7.Text, playerComboBox7.SelectedIndex + 1);
            player player8 = new player(playerNameTextBox8.Text, playerComboBox8.SelectedIndex + 1);
            player player9 = new player(playerNameTextBox9.Text, playerComboBox9.SelectedIndex + 1);
            player player10 = new player(playerNameTextBox10.Text, playerComboBox10.SelectedIndex + 1);
            player player11 = new player(playerNameTextBox11.Text, playerComboBox11.SelectedIndex + 1);
            player player12 = new player(playerNameTextBox12.Text, playerComboBox12.SelectedIndex + 1);

            arr4[0] = (player)player1;
            arr4[1] = (player)player2;
            arr4[2] = (player)player3;
            arr4[3] = (player)player4;
            arr4[4] = (player)player5;
            arr4[5] = (player)player6;
            arr4[6] = (player)player7;
            arr4[7] = (player)player8;
            arr4[8] = (player)player9;
            arr4[9] = (player)player10;
            arr4[10] = (player)player11;
            arr4[11] = (player)player12;

            quickSort(arr4, 0, 11);

            team1Label.Text = "TEAM 1";
            team2Label.Text = "TEAM 2";
            team3Label.Text = "TEAM 3";

            playerLabel1.Text = arr4[0].name;
            playerLabel2.Text = arr4[5].name;
            playerLabel3.Text = arr4[8].name;
            playerLabel4.Text = arr4[11].name;
            playerLabel5.Text = arr4[1].name;
            playerLabel6.Text = arr4[4].name;
            playerLabel7.Text = arr4[7].name;
            playerLabel8.Text = arr4[10].name;
            playerLabel9.Text = arr4[2].name;
            playerLabel10.Text = arr4[3].name;
            playerLabel11.Text = arr4[6].name;
            playerLabel12.Text = arr4[9].name;

            playerLabelVisabillity(true);

            team1Label.Visible = true;
            team2Label.Visible = true;
            team3Label.Visible = true;

            teamPicBoxVisabillity(true);

            randomButton.Visible = false;
            randomBottun2.Visible = true;
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

        private void playerComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void randomBottun2_Click(object sender, EventArgs e)
        {
            quickSort(arr4, 0, 11);
            playerLabel1.Text = arr4[0].name;
            playerLabel2.Text = arr4[5].name;
            playerLabel3.Text = arr4[8].name;
            playerLabel4.Text = arr4[11].name;
            playerLabel5.Text = arr4[1].name;
            playerLabel6.Text = arr4[4].name;
            playerLabel7.Text = arr4[7].name;
            playerLabel8.Text = arr4[10].name;
            playerLabel9.Text = arr4[2].name;
            playerLabel10.Text = arr4[3].name;
            playerLabel11.Text = arr4[6].name;
            playerLabel12.Text = arr4[9].name;
        }

        _5X5 secondForm = new _5X5();

        private void PlayersButton5_Click(object sender, EventArgs e)
        {
           secondForm.Show();
            this.Hide();

        }
        _6X6 thirdForm = new _6X6();
        private void PlayersButton6_Click(object sender, EventArgs e)
        {
            thirdForm.Show();
            this.Hide();
        }

        private void playerTextBoxVisabillity(Boolean decision)
        {
            playerNameTextBox1.Visible = decision;
            playerNameTextBox2.Visible = decision;
            playerNameTextBox3.Visible = decision;
            playerNameTextBox4.Visible = decision;
            playerNameTextBox5.Visible = decision;
            playerNameTextBox6.Visible = decision;
            playerNameTextBox7.Visible = decision;
            playerNameTextBox8.Visible = decision;
            playerNameTextBox9.Visible = decision;
            playerNameTextBox10.Visible = decision;
            playerNameTextBox11.Visible = decision;
            playerNameTextBox12.Visible = decision;
        }

        private void playerComboBoxVisabillity(Boolean Cdecision)
        {
            playerComboBox1.Visible = Cdecision;
            playerComboBox2.Visible = Cdecision;
            playerComboBox3.Visible = Cdecision;
            playerComboBox4.Visible = Cdecision;
            playerComboBox5.Visible = Cdecision;
            playerComboBox6.Visible = Cdecision;
            playerComboBox7.Visible = Cdecision;
            playerComboBox8.Visible = Cdecision;
            playerComboBox9.Visible = Cdecision;
            playerComboBox10.Visible = Cdecision;
            playerComboBox11.Visible = Cdecision;
            playerComboBox12.Visible = Cdecision;
        }

        private void playerLabelVisabillity(Boolean Ldecision)
        {
            playerLabel1.Visible = Ldecision;
            playerLabel2.Visible = Ldecision;
            playerLabel3.Visible = Ldecision;
            playerLabel4.Visible = Ldecision;
            playerLabel5.Visible = Ldecision;
            playerLabel6.Visible = Ldecision;
            playerLabel7.Visible = Ldecision;
            playerLabel8.Visible = Ldecision;
            playerLabel9.Visible = Ldecision;
            playerLabel10.Visible = Ldecision;
            playerLabel11.Visible = Ldecision;
            playerLabel12.Visible = Ldecision;
        }

        private void teamPicBoxVisabillity(Boolean Pdecision)
        {
            team1PictureBox1.Visible = Pdecision;
            team1PictureBox2.Visible = Pdecision;
            team1PictureBox3.Visible = Pdecision;
            team1PictureBox4.Visible = Pdecision;
            team2PictureBox1.Visible = Pdecision;
            team2PictureBox2.Visible = Pdecision;
            team2PictureBox3.Visible = Pdecision;
            team2PictureBox4.Visible = Pdecision;
            team3PictureBox1.Visible = Pdecision;
            team3PictureBox2.Visible = Pdecision;
            team3PictureBox3.Visible = Pdecision;
            team3PictureBox4.Visible = Pdecision;
        }
    }
}
