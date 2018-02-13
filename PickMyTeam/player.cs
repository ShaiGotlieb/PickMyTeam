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
        private Timer _timer;

        private DateTime _startTime = DateTime.MinValue;
        private TimeSpan _currentElapsedTime = TimeSpan.Zero;
        private TimeSpan _totalElapsedTime = TimeSpan.Zero;

        private bool _timerRunning = false;


        public player[] arr4 = new player[12];
        public player(string name, int level)
        {
            this.name = name;
            this.level = level;
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timer_Tick);
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            // We do this to 'chop off' any stray milliseconds
            // resulting from the Timer's inherent inaccuracy,
            // with the bonus that the TimeSpan.ToString() method
            // will now show the correct HH:MM:SS format
            var timeSinceStartTime = DateTime.Now - _startTime;
            timeSinceStartTime = new TimeSpan(timeSinceStartTime.Hours,
                                              timeSinceStartTime.Minutes,
                                              timeSinceStartTime.Seconds);

            // The current elapsed time is the time since the start button
            // was clicked, plus the total time elapsed since the last reset
            _currentElapsedTime = timeSinceStartTime + _totalElapsedTime;

            // These are just two Label controls which display the current
            // elapsed time and total elapsed time
            _totalElapsedTimeDisplay.Text = _currentElapsedTime.ToString();
            _currentElapsedTimeDisplay.Text = timeSinceStartTime.ToString();
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            // If the timer isn't already running
            if (!_timerRunning)
            {
                // Set the start time to Now
                _startTime = DateTime.Now;

                // Store the total elapsed time so far
                _totalElapsedTime = _currentElapsedTime;

                _timer.Start();
                _timerRunning = true;
            }
            else // If the timer is already running
            {
                _timer.Stop();
                _timerRunning = false;
            }
        }

        private void resetButton_Click_1(object sender, EventArgs e)
        {
            // Stop and reset the timer if it was running
            _timer.Stop();
            _timerRunning = false;

            // Reset the elapsed time TimeSpan objects
            _totalElapsedTime = TimeSpan.Zero;
            _currentElapsedTime = TimeSpan.Zero;
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


            playerNameTextBox1.Visible = true;
            playerNameTextBox2.Visible = true;
            playerNameTextBox3.Visible = true;
            playerNameTextBox4.Visible = true;
            playerNameTextBox5.Visible = true;
            playerNameTextBox6.Visible = true;
            playerNameTextBox7.Visible = true;
            playerNameTextBox8.Visible = true;
            playerNameTextBox9.Visible = true;
            playerNameTextBox10.Visible = true;
            playerNameTextBox11.Visible = true;
            playerNameTextBox12.Visible = true;
            

            playerComboBox1.Visible = true;
            playerComboBox2.Visible = true;
            playerComboBox3.Visible = true;
            playerComboBox4.Visible = true;
            playerComboBox5.Visible = true;
            playerComboBox6.Visible = true;
            playerComboBox7.Visible = true;
            playerComboBox8.Visible = true;
            playerComboBox9.Visible = true;
            playerComboBox10.Visible = true;
            playerComboBox11.Visible = true;
            playerComboBox12.Visible = true;




        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            playerNameTextBox1.Visible = false;
            playerNameTextBox2.Visible = false;
            playerNameTextBox3.Visible = false;
            playerNameTextBox4.Visible = false;
            playerNameTextBox5.Visible = false;
            playerNameTextBox6.Visible = false;
            playerNameTextBox7.Visible = false;
            playerNameTextBox8.Visible = false;
            playerNameTextBox9.Visible = false;
            playerNameTextBox10.Visible = false;
            playerNameTextBox11.Visible = false;
            playerNameTextBox12.Visible = false;

            playerComboBox1.Visible = false;
            playerComboBox2.Visible = false;
            playerComboBox3.Visible = false;
            playerComboBox4.Visible = false;
            playerComboBox5.Visible = false;
            playerComboBox6.Visible = false;
            playerComboBox7.Visible = false;
            playerComboBox8.Visible = false;
            playerComboBox9.Visible = false;
            playerComboBox10.Visible = false;
            playerComboBox11.Visible = false;
            playerComboBox12.Visible = false;

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
            playerLabel1.Visible = true;
            playerLabel2.Visible = true;
            playerLabel3.Visible = true;
            playerLabel4.Visible = true;
            playerLabel5.Visible = true;
            playerLabel6.Visible = true;
            playerLabel7.Visible = true;
            playerLabel8.Visible = true;
            playerLabel9.Visible = true;
            playerLabel10.Visible = true;
            playerLabel11.Visible = true;
            playerLabel12.Visible = true;
            team1Label.Visible = true;
            team2Label.Visible = true;
            team3Label.Visible = true;
            team1PictureBox1.Visible = true;
            team1PictureBox2.Visible = true;
            team1PictureBox3.Visible = true;
            team1PictureBox4.Visible = true;
            team2PictureBox1.Visible = true;
            team2PictureBox2.Visible = true;
            team2PictureBox3.Visible = true;
            team2PictureBox4.Visible = true;
            team3PictureBox1.Visible = true;
            team3PictureBox2.Visible = true;
            team3PictureBox3.Visible = true;
            team3PictureBox4.Visible = true;
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

    }
}
