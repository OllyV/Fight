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
        Player PlayerPlayer;
        Player PlayerComp;

        private Boolean turn;

        public FRMfight()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNnew_Click(object sender, EventArgs e)
        {
            lSTlog.Items.Clear();
            PlayerPlayer = new Player(TBname.Text);
            PlayerComp = new Player("Компьютер");
            PlayerPlayer.Wound += player_wound;
            PlayerComp.Wound += player_wound;
            PlayerPlayer.Block += player_block;
            PlayerComp.Block += player_block;
            PlayerPlayer.Death += player_death;
            PlayerComp.Death += player_death;

            LBplayer.Text = PlayerPlayer.name;
            LBcomp.Text = PlayerComp.name;
            LBplayerHP.Text = Convert.ToString(PlayerPlayer.HP);
            LBcompHP.Text = Convert.ToString(PlayerComp.HP);

            PBplayer.Minimum = 0;
            PBplayer.Maximum = 100;
            PBcomp.Minimum = 0;
            PBcomp.Maximum = 100;
            PBplayer.Value = PlayerPlayer.HP;
            PBcomp.Value = PlayerComp.HP;

            BTNnew.Visible = false;
            TBname.Visible = false;
            LBname.Visible = false;
            BTNturn.Visible = true;
            
            BTNturn.Text = "Атакуйте!";
            turn = true;
        }



        private void player_wound(object sender, PlayerEventArgs e)
        {
            lSTlog.Items.Add(String.Format("Игрок {0} закрыл: {1} и получил урон. Здоровье:{2}",e.Name, e.Blocked, e.HP));
        }
        private void player_block(object sender, PlayerEventArgs e)
        {
            lSTlog.Items.Add(String.Format("Игрок {0} закрыл: {1} и отбил атаку. Здоровье:{2}", e.Name, e.Blocked, e.HP));
        }
        private void player_death(object sender, PlayerEventArgs e)
        {
            lSTlog.Items.Add(String.Format("Игрок {0} погиб. Игра окончена.", e.Name));
            BTNnew.Visible = true;
            TBname.Visible = true;
            LBname.Visible = true;
            BTNturn.Visible = false;
        }

        private void BTNturn_Click(object sender, EventArgs e)
        {
            
            Body PlayerSelection = playerSelection();
            Body CompSelection = compSelection();
            if (turn)
            {
                lSTlog.Items.Add(String.Format("Игрок {0} бьет в {1}. Игрок {2} закрывает {3}. "
                    , PlayerPlayer.name, PlayerSelection, PlayerComp.name, CompSelection));
                PlayerComp.setBlock(CompSelection);
                PlayerComp.getHit(PlayerSelection);

                if (PlayerComp.HP <= 0) {
                    lSTlog.Items.Add(String.Format("Игрок {0} победил!", PlayerPlayer.name));
                }
                BTNturn.Text = "Защищайтесь!";
            }
            else {
                lSTlog.Items.Add(String.Format("Игрок {0} бьет в {1}. Игрок {2} закрывает {3}. "
                    , PlayerComp.name, CompSelection, PlayerPlayer.name, PlayerSelection));
                PlayerPlayer.setBlock(PlayerSelection);
                PlayerPlayer.getHit(CompSelection);

                if (PlayerPlayer.HP <= 0) {
                    lSTlog.Items.Add(String.Format("Игрок {0} победил!", PlayerComp.name));
                }
                BTNturn.Text = "Атакуйте!";
            }
            LBplayerHP.Text = Convert.ToString(PlayerPlayer.HP);
            LBcompHP.Text = Convert.ToString(PlayerComp.HP);
            PBplayer.Value = PlayerPlayer.HP;
            PBcomp.Value = PlayerComp.HP;
            turn = !turn;
        }

        private Body playerSelection()
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

        private Body compSelection()
        {
            Random rand = new Random();
            int r = rand.Next(0, 3);
            if (r==0)
            {
                return Body.HEAD;
            }
            else if (r==1)
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
