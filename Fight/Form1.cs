using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Fight
{
    public enum Body { HEAD, CHEST, LEGS };
    public partial class FRMfight : Form
    {
        Game game;
        public FRMfight()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PBplayer.Minimum = 0;
            PBplayer.Maximum = 100;
            PBcomp.Minimum = 0;
            PBcomp.Maximum = 100;
        }

        private void BTNnew_Click(object sender, EventArgs e)
        {
            lSTlog.Items.Clear();
            game = new Game(TBname.Text);
            game.Log += game_log;
            game.Death += game_death;
            game.Turn += game_turn;
            game.Choice += game_choice;
            game.LogHP += game_logHP;

            LBplayer.Text = TBname.Text;
            LBcomp.Text = "Компьютер";
            LBplayerHP.Text = "100";
            LBcompHP.Text = "100";

            PBplayer.Value = 100;
            PBcomp.Value = 100;

            BTNnew.Visible = false;
            TBname.Visible = false;
            LBname.Visible = false;
            BTNturn.Visible = true;
            
            BTNturn.Text = "Атакуйте!";
        }
        private void BTNturn_Click(object sender, EventArgs e)
        {
            game.makeTurn();
        }


        private void game_death(string s)
        {
            lSTlog.Items.Add(s);
            BTNnew.Visible = true;
            TBname.Visible = true;
            LBname.Visible = true;
            BTNturn.Visible = false;
        }

        private void game_log(string s)
        {
            lSTlog.Items.Add(s);
        }
        private void game_turn(string s)
        {
            BTNturn.Text = s;
        }
        private void game_logHP(int player, int comp)
        {
            LBplayerHP.Text = Convert.ToString(player);
            LBcompHP.Text = Convert.ToString(comp);
            PBplayer.Value = player;
            PBcomp.Value = comp;
        }

        private Body game_choice()
        {
            if (RB1.Checked == true)
            {
                return Body.HEAD;
            }
            else if (RB2.Checked == true)
            {
                return Body.CHEST;
            }
            else
            {
                return Body.LEGS;
            }
        }

    }
}
