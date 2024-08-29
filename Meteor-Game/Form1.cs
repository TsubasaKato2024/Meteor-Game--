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
        int[] enX = new int[10];    //隕石の座標　
        int[] enY = new int[10];    //配列の宣言
        Random rand = new Random();
        int RR;             //隕石の半径
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
            RR = 70 / 2;    //隕石の半径
            for (int i = 0; i < 10; i++)    //for文を使いまとめて処理する
            {
                enX[i] = rand.Next(1, 450); //隕石の初期配置座標
                enY[i] = rand.Next(1, 900) - 1000;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gg.DrawImage(pBG.Image, new Rectangle(0, 0, 480, 320));

            //隕石の移動
            for (int i = 0; i < 10; i++)
            {
                enY[i] += 5; //隕石の移動
                gg.DrawImage(pMeteor.Image, new Rectangle(enX[i], enY[i], RR * 2, RR * 2));　//隕石の描画
                if (enY[i] > pBase.Height)  //画面外へ出たら上に戻す
                {
                    enX[i] = rand.Next(1, 450);
                    enY[i] = rand.Next(1, 300) - 400;
                }
            }

            Cpos = PointToClient(Cursor.Position);

            if (Cpos.X < 0) //画面外へ出ないように変更
            {
                Cpos.X = 0;
            }
            if (Cpos.X > Width - PW)
            {
                Cpos.X = Width - PW;
            }
            gg.DrawImage(pPlayer.Image, new Rectangle(Cpos.X, 220, PW, PH));
            //↑自機の絵                  ↑カーソルのx座標のみ利用

            pBase.Image = canvas;
            hitCheck(); //当たり判定
        }
        //自機と隕石の当たり判定
        private void hitCheck()
        {
            int pcx = Cpos.X + (PW / 2);    //自機の中心座標
            int pcy = 220 + (PH / 2);
            int ecx, ecy, dis;              //自機と隕石の距離計算用

            Text = "";  //タイトルを消す
            for (int i = 0; i < 10; i++)
            {
                ecx = enX[i] + RR;
                ecy = enY[i] + RR;
                dis = (ecx - pcx) * (ecx - pcx) + (ecy - pcy) * (ecy - pcy);    //自機と隕石の距離を算出
                if (dis < RR * RR) //2点間の距離として比較しているのは、隕石の半径
                {
                    Text = "hit";  //タイトルに表示
                    break;          //forから抜ける
                }
            }
        }
    }
}
