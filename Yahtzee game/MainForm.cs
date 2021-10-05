using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yahtzee_game
{
    public partial class MainForm : Form
    {
        int numPlayers = 0;
        public MainForm()
        {
            InitializeComponent();
            string conneString = "Server=.\\GAME;Database=Yahtzee;User Id=sa;Password=6638";
            SqlConnection cnn = new SqlConnection(conneString);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand dcmd = new SqlCommand("DROP TABLE IF EXISTS [PlayerScore]", cnn);
            dcmd.ExecuteNonQuery();
            dcmd = new SqlCommand("CREATE TABLE PlayerScore(PlayerName varchar(30) NOT NULL, PlayerNum int NOT NULL, ones int, twos int, threes int, fours int, fives int, sixes int, " +
                "threeofkind int, fourofkind int, fullhouse int, smallstraight int, largestraight int, yahtzee int, chance int);", cnn);
            dcmd.ExecuteNonQuery();
            cnn.Close();
        }
       
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnAddPlayer.Visible = false;
            btnStartGame.Visible = false;
            txtPlayerName.Visible = false;
            lblAddPlayerMsg.Visible = false;
            string connectionString = "Server=.\\GAME;Database=Yahtzee;User Id=sa;Password=6638";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd;

            /*
            string command = "SELECT COUNT(*) FROM PlayerScore ";

            cmd = new SqlCommand(command, cnn);
            Int32 numPlayers = (Int32)cmd.ExecuteScalar();
            */

            GameController controller = new GameController(numPlayers);
            
            cnn.Close();

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            string conneString = "Server=.\\GAME;Database=Yahtzee;User Id=sa;Password=6638";
            SqlConnection cnn = new SqlConnection(conneString);
            
            
            string insert = "INSERT INTO [PlayerScore] ([PlayerName], [PlayerNum], [ones], [twos], [threes], [fours], [fives], [sixes], [threeofkind]," +
                " [fourofkind], [fullhouse], [smallstraight], [largestraight], [yahtzee], [chance]) " +
                "VALUES (@name, @num, @ones, @twos, @threes, @fours, @fives, @sixes, @threeofkind, @fourofkind, @fullhouse, @smallstraight," +
                " @largestraight, @yahtzee, @chance)";
             using(SqlCommand cmd = new SqlCommand(insert, cnn))
            {
                cmd.Parameters.Add("@num", SqlDbType.Int).Value = ++numPlayers;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtPlayerName.Text;
                cmd.Parameters.Add("@ones", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@twos", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@threes", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@fours", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@fives", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@sixes", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@threeofkind", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@fourofkind", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@fullhouse", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@smallstraight", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@largestraight", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@yahtzee", SqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("@chance", SqlDbType.VarChar).Value = 0;
                cnn.Open();
                int result = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            lblAddPlayerMsg.Text = txtPlayerName.Text + " was added to the game!";
            txtPlayerName.Text = "";
            txtPlayerName.Focus();
           
        }

       

        
    }
}