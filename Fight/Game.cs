using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight
{

    public delegate void GameHPHandler(int player, int comp);
    public delegate  void GameHandler(string s);
    public delegate Body GameChoiceHandler();


    class Game
    {
        public event GameHandler Log;
        public event GameHandler Death;
        public event GameHandler Turn;
        public event GameChoiceHandler Choice;
        public event GameHPHandler LogHP;

        Player PlayerPlayer;
        Player PlayerComp;
        private Boolean turn;

        public Player name { set { PlayerPlayer = value; } get { return PlayerPlayer; } }
        public Player HP { set { PlayerComp = value; } get { return PlayerComp; } }

        public Game(string name)
        {
            this.PlayerPlayer = new Player(name);
            this.PlayerComp = new Player("Компьютер");
            this.PlayerPlayer.Wound += player_wound;
            this.PlayerComp.Wound += player_wound;
            this.PlayerPlayer.Block += player_block;
            this.PlayerComp.Block += player_block;
            this.PlayerPlayer.Death += player_death;
            this.PlayerComp.Death += player_death;
            turn = true;
        }


        public void makeTurn()
        {
            Body PlayerSelection = Choice();
            Body CompSelection = compSelection();
            if (turn)
            {
                if (Log != null)
                {
                    Log(String.Format("Игрок {0} бьет в {1}. Игрок {2} закрывает {3}. "
                        , this.PlayerPlayer.name, PlayerSelection, this.PlayerComp.name, CompSelection));
                    this.PlayerComp.setBlock(CompSelection);
                    this.PlayerComp.getHit(PlayerSelection);
                    if (this.PlayerComp.HP <= 0)
                    {
                        Log(String.Format("Игрок {0} победил!", this.PlayerPlayer.name));
                    }
                }
                if (Turn != null)
                {
                    Turn("Защищайтесь!");
                }
            }
            else
            {
                if (Log != null)
                {
                    Log(String.Format("Игрок {0} бьет в {1}. Игрок {2} закрывает {3}. "
                        , this.PlayerComp.name, CompSelection, this.PlayerPlayer.name, PlayerSelection));
                    this.PlayerPlayer.setBlock(PlayerSelection);
                    this.PlayerPlayer.getHit(CompSelection);

                    if (this.PlayerPlayer.HP <= 0)
                    {
                        Log(String.Format("Игрок {0} победил!", this.PlayerComp.name));
                    }
                }
                if (Turn != null)
                {
                    Turn("Атакуйте!");
                }
            }
            if (LogHP != null)
            {
                LogHP(this.PlayerPlayer.HP, this.PlayerComp.HP);
            }
            turn = !turn;
        }


        private void player_wound(object sender, PlayerEventArgs e)
        {
            if (Log != null)
            {
                Log(String.Format("Игрок {0} закрыл: {1} и получил урон. Здоровье:{2}", e.Name, e.Blocked, e.HP));
            }
        }
        private void player_block(object sender, PlayerEventArgs e)
        {
            if (Log != null)
            {
                Log(String.Format("Игрок {0} закрыл: {1} и отбил атаку. Здоровье:{2}", e.Name, e.Blocked, e.HP));
            }
        }
        private void player_death(object sender, PlayerEventArgs e)
        {
            if (Death != null)
            {
                Death(String.Format("Игрок {0} погиб. Игра окончена.", e.Name));
            }
        }

        private Body compSelection()
        {
            Random rand = new Random();
            int r = rand.Next(0, 3);
            if (r == 0)
            {
                return Body.HEAD;
            }
            else if (r == 1)
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
