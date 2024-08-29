using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteor_Game
{
    public partial class Form1 : Form
    {
        static Bitmap canvas = new Bitmap(480, 320);
        Graphics gg = Graphics.FromImage(canvas);
        int PW, PH;　//自機の幅、高さ調整
        Point Cpos; //カーソル座標
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMeteor.Hide();
            pPlayer.Hide();
            pBG.Hide();
            pExp.Hide();
            pGameover.Hide();
            pMsg.Hide();
            pTitle.Hide();

            initGame(); //初期処理
        }

        private void initGame()
        {
            PW = 38;        //自機の幅
            PH = 48;        //自機の高さ
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gg.DrawImage(pBG.Image, new Rectangle(0, 0, 480, 320));

            Cpos = PointToClient(Cursor.Position);
            
            if (Cpos.X < 0) //画面外へ出ないように変更
            {
                Cpos.X = 0;
            }
            if (Cpos.X > Width - PW)
            {
                Cpos.X = Width - PW;
            }
            gg.DrawImage(pPlayer.Image, new Rectangle(Cpos.X,220,PW,PH));
                        //↑自機の絵                  ↑カーソルのx座標のみ利用

            pBase.Image = canvas;
        }
    }
}
