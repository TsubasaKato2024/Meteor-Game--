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
        Boolean hitFlg;     //true:当たった
        int ecnt, ex, ey;   //爆発演出用
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
            hitFlg = false;　//false:当たっていない
            ecnt = 40;      //爆発の初めの処理で位置を変更する
                            //40を代入することで条件文が実行される
        }
        //爆発演出
        private void playerExplosion()
        {
            ecnt += 4;      //ecntは拡縮のサイズにも利用している
            if (ecnt > 40)
            {
                ecnt = 8;
                ex = Cpos.X + rand.Next(40);　//爆発の位置を変更
                ey = 220 + rand.Next(50);     //自機の座標に乱数を加算
            }
            //爆発演出中の描画は、すべてここで行う
            gg.DrawImage(pBG.Image, new Rectangle(0, 0, 480, 320));
            for (int i = 0; i < 10; i++)
            {
                gg.DrawImage(pMeteor.Image, new Rectangle(enX[i], enY[i], RR * 2, RR * 2));
            }
            gg.DrawImage(pPlayer.Image, new Rectangle(Cpos.X, 220, PW, PH));
            gg.DrawImage(pExp.Image, new Rectangle(ex - ecnt / 2, ey - ecnt / 2, ecnt, ecnt));
            pBase.Image = canvas;               //↑拡縮のサイズの半分を引くことで、指定座標を中心に拡縮される
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hitFlg)
            {
                playerExplosion();
                return;     //自機と隕石が当たったらこの先の処理をしない
            }
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

            for (int i = 0; i < 10; i++)
            {
                ecx = enX[i] + RR;
                ecy = enY[i] + RR;
                dis = (ecx - pcx) * (ecx - pcx) + (ecy - pcy) * (ecy - pcy);    //自機と隕石の距離を算出
                if (dis < RR * RR) //2点間の距離として比較しているのは、隕石の半径
                {
                    hitFlg = true;  //true:当たった
                    break;          //forから抜ける
                }
            }
        }
    }
}
