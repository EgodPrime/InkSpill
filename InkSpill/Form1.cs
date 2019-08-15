using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkSpill
{
    public partial class Form1 : Form
    {
        private int chance,level=55;
        private  int[] grids = new int[400];
        private List<int> points = new List<int>();
        private readonly List<Color> colors = new List<Color>{Color.Red,Color.Green,Color.Blue,Color.Yellow,Color.Purple };
        public Form1()
        {
            InitializeComponent();
        }
        // 初始化游戏
        private void Init()
        {
            Random r = new Random();
            points.Clear();
            chance = level;
            for(int i=0;i<400;i++)
            {
                grids[i] = r.Next(5);
            }
            points.Add(0);
            DrawChance();
            DrawGame();
            TSMI_restart.Enabled = true;
            
        }
        // 按键函数
        private void BtnRed_Click(object sender, EventArgs e)
        {
            ChangeColor(colors[0]);
            DrawGame();
            ChanceDecrese(); 
        }
        private void BtnGreen_Click(object sender, EventArgs e)
        {
            ChangeColor(colors[1]);
            DrawGame();
            ChanceDecrese();
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            ChangeColor(colors[2]);
            DrawGame();
            ChanceDecrese();
        }

        private void BtnYellow_Click(object sender, EventArgs e)
        {
            ChangeColor(colors[3]);
            DrawGame();
            ChanceDecrese();
        }

        private void BtnPurple_Click(object sender, EventArgs e)
        {
            ChangeColor(colors[4]);
            DrawGame();
            ChanceDecrese();
        }
        // 变化颜色
        private void ChangeColor(Color color)
        {
            foreach (int p in points)
            {
                int c = colors.IndexOf(color);
                grids[p] = c;
            }
            int current,select,x1,y1,x2,y2,dx,dy;
            select = colors.IndexOf(color);
            for (int i = 0; i < 400; i++)
            {
                current = grids[i];
                if(current == select && !points.Contains(i))
                {
                    for(int j=0;j<points.Count;j++)
                    {
                        x1 = i % 20; y1 = i / 20;
                        x2 = points[j] % 20; y2 = points[j] / 20;
                        dx = x2 - x1;dy = y2 - y1;
                        if((dx*dx + dy * dy) == 1)
                        {
                            points.Add(i);
                            break;
                        }
                    }
                   
                }
            }
            if (points.Count == 400)
            {
                MessageBox.Show(string.Format("胜利!共用步数:{0:G}",level-chance), "");
                FileStream fs = new FileStream("top.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine((level - chance).ToString());
                sw.Close();
                fs.Close();
            }
        }
        // 减少可点击数并判断胜负
        private void ChanceDecrese()
        {
            chance -= 1;
            DrawChance();
            if(chance == 0)
            {
                MessageBox.Show("失败!\n你不仅仅需要脑子，还需要那么一点运气！\n这句话反过来说有时候也成立。", "");
                Init();
            }
        }
        // 画剩余点击数
        private void DrawChance()
        {
            float per = (float)chance / level;
            Graphics g = panelChance.CreateGraphics();
            g.Clear(Color.White);
            Color color;
            if (per > 0.5f)
            {
                color = Color.Green;
            }
            else if (per > 0.3f)
            {
                color = Color.Orange;
            }
            else
            {
                color = Color.Red;
            }
            Brush b = new SolidBrush(color);
            Pen p = new Pen(Color.Black,2.0f);
            int block = 400 / level;
            for(int i = chance-1; i >-1; i--)
            {
                g.DrawRectangle(p, 0, 400 - block - i * block, 40, block);
                g.FillRectangle(b, 0, 400 - block - i * block, 40, block);
            }
            b.Dispose();
            p.Dispose();
            g.Dispose();
        }
        // 画游戏网格
        private void DrawGame()
        {
            Graphics g = panelGame.CreateGraphics();
            g.Clear(Color.White);
            int x, y;
            Brush b;
            Pen p;

            for (int i=0;i<400;i++)
            {
                x = i % 20;
                y = i / 20;
                b = new SolidBrush(colors[grids[i]]);
                p = new Pen(b, 1.0f);
                g.DrawRectangle(p, x*20, y*20, 20, 20);
                g.FillRectangle(b, x * 20, y * 20, 20, 20);
                b.Dispose();
                p.Dispose();
            }
            g.Dispose();
        }

        private void TSMI_start_Click(object sender, EventArgs e)
        {
            panelChance.Visible = true;
            panelGame.Visible = true;
            btnRed.Visible = true;
            btnGreen.Visible = true;
            btnBlue.Visible = true;
            btnYellow.Visible = true;
            btnPurple.Visible = true;
            Init();
        }

        private void TSMI_restart_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void TSMI_top_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("top.txt", Encoding.UTF8);
                string line;
                string show = "";
                int i = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    show += string.Format("{0:0} :{1:G}次\n", i, line);
                }
                sr.Close();
                MessageBox.Show(show, "top");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("目前还没有排行记录！","提示");
            }
        }

        private void TSMI_level0_Click(object sender, EventArgs e)
        {
            level = 100;
            Init();
            MessageBox.Show("你这水平。。。像CXK啊。。。", "");
        }
        private void TSMI_level1_Click(object sender, EventArgs e)
        {
            level = 55;
            Init();
        }

        private void TSMI_level2_Click(object sender, EventArgs e)
        {
            level = 50;
            Init();
        }

        private void TSMI_level3_Click(object sender, EventArgs e)
        {
            level = 40;
            Init();
        }

        private void TSMI_level4_Click(object sender, EventArgs e)
        {
            level = 30;
            Init();
        }

        private void TSMI_author_Click(object sender, EventArgs e)
        {
            MessageBox.Show("没错，本游戏的制作者就是人称郫县第一美男子，兼具才华与智慧的那个男人—Egod。");
        }

        private void TSMI_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
