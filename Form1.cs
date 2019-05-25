using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

using WindowsInput.Native;//
using WindowsInput;//
using System.Runtime.InteropServices;//

namespace Jump
{
    public partial class Form1 : Form
    {
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);

        Player player = new Player();
        Obstacle obstacle = new Obstacle();
        DefaultData data = new DefaultData();
        bool startGame = false;
        bool keyPress;
        bool jump;
        bool touch;
        bool jumpSuccess;
        int distanceHorizontal;
        int distanceVertical;
        int speed;
        int lvlSpeed;
        int score;
        

        //string spacja = "a  ";//znaki zapisywane do tablicy jako kod akcji bota
        int populacja = 10;
        float szansamutacji = 0.01f;
        int wielkośćDNA =50;
        int czynowaGena=0;

        private Algorytm_Genetyczny<char> AlgGen;
        private System.Random los;
       // private Random los=new Random();
        
        void Start_AlgGen()
        {
            los = new System.Random();
            AlgGen = new Algorytm_Genetyczny<char>(populacja, wielkośćDNA, los, losowa_spacja, funkcjaFitness, szansamutacji);

        }
            private char losowa_spacja()//albo A czyli skok albo B czyli nic
        {
           // Random AlubB = new Random();
            int liczba = los.Next(0, 10);//zrob mniej A wiecej B !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (liczba > 5)//A-skok
            {
                return 'A';//a-czy-A
            } else{return 'B';}
            
        }

        //moze mozna nadpisac fitnes po kazdym przebiegu 
        private float funkcjaFitness(int index)//ktory przebiek byl najlepszy
        {
            float ile_przeskoczen = 0;//jak duzo razy przeskoczyl przez kulke
            Tworzenie_Osobnika<char> dna = AlgGen.Populacja[index];
            for (int i = 0; i < dna.Geny.Length; i++)
            {
                if (dna.Geny[i] < score)
                {
                    ile_przeskoczen += 1;
                }
            }
            return ile_przeskoczen;
        }


        InputSimulator sim = new InputSimulator();
      
       /* private void Form1_KeyDownsssss(object sender, KeyEventArgs e)//dziala naciskanie!!!!!
        {
            Random qwertlol = new Random();//ranndom dziala
            int lolollo = qwertlol.Next(0, 6);
            if (lolollo>6)
            { sim.Keyboard.KeyPress(VirtualKeyCode.VK_A); }

           // this.randomspcja_asdasdaxsd();//gdzieś dać odwołanie do metody zeby robily sie randomowe spacje
        }*/
        
                public Form1()
        {
            Start_AlgGen(); //tu wygeneruj boty zeby je pozniej wywolac
            InitializeComponent();
            //gdzie wywołanie ????????????????????????????????????????????????
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();

            this.Timer.Tick += new EventHandler(Timer_Tick); 
            this.Timer.Interval = 1;
            this.Timer.Enabled = true;
            this.Timer.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)//Space)
            {
                if (player.yPos == data.playerY && startGame)
                {
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Jump.Properties.Resources.jump);
                    sp.Play();

                    keyPress = true;
                    jump = true;
                }
            }
            if (e.KeyCode == Keys.Enter && this.NewGameLabel.Enabled)//ENTER- nowa generacja
                NewGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Tworzenie_Osobnika<char> Dna = AlgGen.Populacja[czynowaGena];//numer osobnika
            for (int i = 0; i < Dna.Geny.Length; i++)//dlogosc dna
            {
                if(Dna.Geny[i]=='A')//wydobycie genow z osobnika
                {
                    sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                }
                if (Dna.Geny[i] == 'B')
                {
                    sim.Keyboard.KeyPress(VirtualKeyCode.VK_B);
                }
            }
            //......
            Touch();

            JumpPlayer();

            MoveObsticle();

            PlayerScore();
         }

        private void NewGameLabel_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void JumpPlayer()
        {
            if (keyPress)
            {
                if (jump) // do max wyskoku 
                {
                    player.yPos -= 8;
                    this.PlayerBox.Location = new Point(player.xPos, player.yPos);

                    if (player.yPos <= player.maxPos)
                        jump = false;
                }
                else // jak wroci na miejsce
                {
                    player.yPos += 8;
                    this.PlayerBox.Location = new Point(player.xPos, player.yPos);

                    if (player.yPos == data.playerY)
                        keyPress = false;
                }
            }
        }

        private void MoveObsticle()
        {
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Jump.Properties.Resources.missile);

            if (obstacle.xPos != obstacle.maxPos) // Jesli nie jest poza granicami
            {
                if(data.obstacleX - speed < obstacle.xPos && obstacle.xPos < data.obstacleX + speed)
                    sp.Play();

                this.ObstacleBox.Location = new Point(obstacle.xPos, obstacle.yPos);
                obstacle.xPos -= speed;
            }
            if (obstacle.xPos <= obstacle.maxPos) // Jesli znajdzie sie poza granicami
            {
                Random random = new Random();

                int randX = random.Next(816, 1200 + speed*50);
                obstacle.xPos = randX;

                this.ObstacleBox.Location = new Point(obstacle.xPos, obstacle.yPos);

                jumpSuccess = true;

                Speed();
            }
        }

        private void Touch()
        {
            distanceHorizontal = obstacle.xPos - player.xPos;
            distanceVertical = obstacle.yPos - player.yPos;

            if (distanceHorizontal <= player.width && distanceVertical <= player.height - 30)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Jump.Properties.Resources.die);
                sp.Play();

                GameOver();
                touch = true;
            }
        }

        private void Speed()
        {
            if (score % 2 == 1)
            {
                speed++;
                lvlSpeed++;

                this.SpeedLvl.Text = lvlSpeed.ToString();
            }
        }

        private void PlayerScore()
        {
            if (jumpSuccess && !touch)
            {
                score++;
                this.Score.Text = score.ToString();
            }

            jumpSuccess = false;
        }

        private void GameOver()
        {
            funkcjaFitness(czynowaGena);//zapisz score

            if (czynowaGena == 10)//start nowej generacji, generacja+1
            {
                 AlgGen.NowaGenerazja();
            }
            //................................
            this.PlayerBox.Image = Jump.Properties.Resources.gameEnd;

            startGame = false;

            this.GameOverLabel.Visible = true;
            this.NewGameLabel.Visible = true;
            this.NewGameLabel.Enabled = true;
            this.YourScoreLabel.Visible = true;

            this.ObstacleBox.Enabled = false;
            this.ObstacleBox.Visible = false;

            this.YourScoreLabel.Text = "Your score: " + score.ToString();

            this.Timer.Stop();
            this.ObstacleBox.Enabled = false;
        }

        private void NewGame()
        {
            czynowaGena += 1;
            //.....................
            keyPress = false;
            jump = false;
            jumpSuccess = false;
            touch = false;
            score = 0;
            speed = 10;
            lvlSpeed = 1;

            this.PlayerBox.Image = Jump.Properties.Resources.startgame;

            this.GameOverLabel.Visible = false;
            this.NewGameLabel.Visible = false;
            this.NewGameLabel.Enabled = false;
            this.YourScoreLabel.Visible = false;
            this.PlayerBox.Visible = true;
            this.PlayerBox.Enabled = true;
            this.ObstacleBox.Visible = true;
            this.ObstacleBox.Enabled = true;

            player.xPos = data.playerX;
            player.yPos = data.playerY;

            obstacle.xPos = data.obstacleX;
            obstacle.yPos = data.obstacleY;

            this.ObstacleBox.Location = new Point(obstacle.xPos, obstacle.yPos);

            this.Score.Text = score.ToString();
            this.SpeedLvl.Text = lvlSpeed.ToString();

            Count();
        }
        async Task Count()
        {
            this.Timer.Stop();

            this.Counting.Visible = true;

            System.Media.SoundPlayer spTick = new System.Media.SoundPlayer(Jump.Properties.Resources.tick);
            System.Media.SoundPlayer spStart = new System.Media.SoundPlayer(Jump.Properties.Resources.start);

            this.Counting.ForeColor = Color.IndianRed;
            this.Counting.Text = "3";
            spTick.Play();
            await Task.Delay(250);
            this.Counting.Text = "3.";
            await Task.Delay(250);
            this.Counting.Text = "3..";
            await Task.Delay(250);
            this.Counting.Text = "3...";
            await Task.Delay(250);

            this.Counting.ForeColor = Color.Khaki;
            this.Counting.Text = "2";
            spTick.Play();
            await Task.Delay(250);
            this.Counting.Text = "2.";
            await Task.Delay(250);
            this.Counting.Text = "2..";
            await Task.Delay(250);
            this.Counting.Text = "2...";
            await Task.Delay(250);

            this.Counting.ForeColor = Color.LemonChiffon;
            this.Counting.Text = "1";
            spTick.Play();
            await Task.Delay(250);
            this.Counting.Text = "1.";
            await Task.Delay(250);
            this.Counting.Text = "1..";
            await Task.Delay(250);
            this.Counting.Text = "1...";
            await Task.Delay(250);

            this.Counting.ForeColor = Color.White;
            this.Counting.Text = "GO!";
            spStart.Play();
            await Task.Delay(1000);

            this.Counting.Visible = false;

            startGame = true;

            this.Timer.Start();
            //.................
            //wywolanie osobnika z obecnej populacji
            /*Tworzenie_Osobnika<char> Dna = AlgGen.Populacja[czynowaGena];//numer osobnika
            for (int i = 0; i < Dna.Geny.Length; i++)//dlogosc dna
            {
                if(Dna.Geny[i]=='A')//wydobycie genow z osobnika
                {
                    sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                }
            }*/
        }

        private void SpeedLvlText_Click(object sender, EventArgs e)
        {

        }
    }
}
