namespace XOX__Tic_Tac_Toe_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XOXtiklama(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (lblXO.Text=="X")

            {
                bt.Text = "X";
                bt.Enabled=false;
                lblXO.Text="O";

            }
            else
            {
                bt.Text="O";
                bt.Enabled=false;
                lblXO.Text ="X";
            }
            if (button1.Text== "X"&& button2.Text=="X"&& button3.Text=="X")
            {
                MessageBox.Show ("KAZANAN X");
                oyunBitis();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("KAZANAN X");
                oyunBitis();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN X");
                oyunBitis();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN X");
                oyunBitis();
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("KAZANAN X");
                oyunBitis();
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("KAZANAN X");
                oyunBitis();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN X");
                oyunBitis();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN X");
                oyunBitis();
            }
            ////////////////////////////////////////////////////////////////////////
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("KAZANAN O");
                oyunBitis();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("KAZANAN X");
                oyunBitis();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN O");
                oyunBitis();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN O");
                oyunBitis();
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("KAZANAN O");
                oyunBitis();
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("KAZANAN O");
                oyunBitis();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN O");
                oyunBitis();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN O");
                oyunBitis();
            }
            if (button1.Text!="" && button2.Text!="" && button3.Text!="" && button4.Text!="" && button5.Text!="" && button6.Text!=""&& 
            button7.Text!="" && button8.Text!="" && button9.Text!="")
            {
                MessageBox.Show("BERABERE");
                oyunBitis();
            }
        }
        private void oyunBitis()
        {
             lblXO.Text="X";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

        }
    }
}