using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        private Player.騎士 player1 = new Player.騎士();

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Monster monster = new Monster("哥布林")
            {
                Hp = 20,
                Power = 1,
                Exp = 3,
                Level=5,
                
            };
            player1.Attack(monster);
            monster.Attack(player1);
            
            Player1Status(txtPlayerLog, player1, monster, player1.AddExp(monster.Exp),player1.getlevel());
            AttactLog(txtMonster, player1, monster);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Monster monster = new Monster("死亡騎士")
            {
                Hp = 3000,
                Power = 20,
                Exp = 10,
                Level =52
            };
            player1.Attack(monster);
            monster.Attack(player1);

            Player1Status(txtPlayerLog, player1, monster, player1.AddExp(monster.Exp), player1.getlevel());
            AttactLog(txtMonster, player1, monster);


        }

        private void AttactLog(TextBox txtLog, Player player ,Monster monster)
        {
            txtMonster.Text += $"{player.Name}攻擊{monster.Name}造成傷害:{monster.GetHP().ToString()}{Environment.NewLine}";
        }

        private void Player1Status(TextBox txtLog,Player player,Monster monster,int exp,int level)
        {
            txtPlayerLog.Text = $"{player1.Name} 血量:({player1.GetHP().ToString()} 經驗值:({exp}) 等級:({level}){Environment.NewLine})";
        }

        private void MonsterStatus()
        {
            //txtMonster.Text = $"{}({player2.Hp.ToString()})";
        }
    }
}
