using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fight{

    public delegate void PlayerHandler(object sender, PlayerEventArgs e);

    public class PlayerEventArgs : EventArgs
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public Body Blocked { get; set; }
    }
    public class Player
    {
        private string pName;
        private int pHP;
        private Body pBlocked;

        public event PlayerHandler Wound;
        public event PlayerHandler Death;
        public event PlayerHandler Block;

        public string name { set { pName = value; } get { return pName; } }
        public int HP { set { pHP = value; } get { return pHP; } }
        public Body blocked { set { pBlocked = value; } get { return pBlocked; } }

        public Player(string name)
        {
            this.name = name;
            this.HP = 100;
            this.blocked = 0;
        }

        public void getHit(Body hit)
        {
            if (this.blocked == hit) {
                if (Block != null)
                {
                    var e = new PlayerEventArgs { Name = this.name, HP = this.HP, Blocked = this.blocked };
                    Block(this, e);
                }
            }
            else {
                this.HP -= 10;
                if (Wound != null) {
                    var e = new PlayerEventArgs { Name = this.name, HP = this.HP, Blocked = this.blocked };
                    Wound(this, e);
                }
            }
            if ((this.HP <= 0) && (Death != null))
            {
                var e = new PlayerEventArgs { Name = this.name, HP = this.HP, Blocked = this.blocked };
                Death(this, e);
            }
        }

        public void setBlock(Body block)
        {
            this.blocked = block;
        }


    }







}
