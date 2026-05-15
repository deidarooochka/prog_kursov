using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Media;

namespace prog_kursov
{
    public partial class Game : Form
    {
        int opened_counter;  //кол-во открытых карточек (0,1,2)
        int[] pairs;        //массив значений пар
        int[] game_pairs;    //какая картинка у каждой карточки
        int[] opened;       //индексы двух открытых карт
        PictureBox[] array_picbox;   //массив всех карточек
        bool waiting = false;       // флаг задержки перед закрытием
        int movesCount;    // счетчик ходов
        int seconds;      // счетчик секунд
        bool active;     // активная ли игра
        string playerName;    //имя игрока
        string difficulty;   // сложность

        int pairsCount;    // кол-во пар(8, 10, 15)
        int totalCards;   // всего карточек
        int startImageIndex;   // с какого индекса начинаются картинки в коллекции
        int cols, rows;   //кол-во столбцов, строк

        int cardSpacing = 10;    //отступ между карточками
        int cardWidth = 90;     //ширина карточки
        int cardHeight = 105;  // высота карточки

        bool isClosing = false;   // флаг закрытия формы
        public Game(string name, string diff)
        {
            playerName = name;
            difficulty = diff;

            if (difficulty == "easy")
            {
                pairsCount = 8;
                totalCards = 16;
                cols = 4;
                rows = 4;
                startImageIndex = 0;
            }
            else if (difficulty == "medium")
            {
                pairsCount = 10;
                totalCards = 20;
                cols = 5;
                rows = 4;
                startImageIndex = 9;
            }
            else
            {
                pairsCount = 15;
                totalCards = 30;
                cols = 6;
                rows = 5;
                startImageIndex = 19; 
            }

            opened_counter = 0;

            InitializeComponent();
        
            this.StartPosition = FormStartPosition.CenterScreen;

            SetupFormSize();
            CreateGameBoard();
            this.Load += Game_load; //загрузка игры

            pairs = new int[pairsCount];
            game_pairs = new int[totalCards];
            opened = new int[2];
            this.FormClosing += Game_FormClosing; //обработка закрытия формы
        }

        private void SetupFormSize()
        {
            // запрет изменения размера окна
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.ClientSize = new Size(800, 640); //размер окна

            // (ширина + отступ) * количество столбцов + отступ
            int panelWidth = (cardWidth + cardSpacing) * cols + cardSpacing;
            int panelHeight = (cardHeight + cardSpacing) * rows + cardSpacing;

            panel1.Size = new Size(panelWidth, panelHeight);
            panel1.Location = new Point((this.ClientSize.Width - panelWidth) / 2, 80); //центрируем по горизонтали
  
            panel1.BackColor = System.Drawing.Color.SeaShell;
        }

        //создаем игровое поле
        private void CreateGameBoard()
        {
            panel1.Controls.Clear();
            array_picbox = new PictureBox[totalCards]; //массив для новых карточек

            for (int i = 0; i < totalCards; i++)
            {
                PictureBox pb = new PictureBox(); //создаем новую карточку

                // вычисляем позицию: отступ + (размер+отступ) × номер
                int row = i / cols;
                int col = i % cols;

                int x = cardSpacing + col * (cardWidth + cardSpacing);
                int y = cardSpacing + row * (cardHeight + cardSpacing);

                pb.Location = new Point(x, y);
                pb.Size = new Size(cardWidth, cardHeight);
                pb.Tag = i;
 
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.BackgroundImageLayout = ImageLayout.Zoom;

                pb.Click += pictureBox1_Click;

                panel1.Controls.Add(pb);
                array_picbox[i] = pb;
            }
        }

        
        public void hide()
        {
            int backImageIndex = 8;

            for (int i = 0; i < totalCards; i++)
            {
                if (array_picbox[i] != null)
                {
                    array_picbox[i].BackgroundImage = imageList1.Images[backImageIndex];
                    array_picbox[i].Image = null;
                }
            }
        }



        private void Game_load(object sender, EventArgs e)
        {
            hide();
            начатьНовуюToolStripMenuItem_Click(null, null);
        }

        // начало новой игры
        private void начатьНовуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movesCount = 0;
            seconds = 0;
            active = true;
            waiting = false;
            opened_counter = 0;
            Random R = new Random();

            label1.Text = "Ходы: 0";
            label2.Text = "Время: 0 сек";
            timer1.Stop();
            timer1.Start();

            //создаем пары карточек
            for (int i = 0; i < pairsCount; i++)
            {
                pairs[i] = i;
            }

            //перемешиваем пары
            for (int i = pairsCount - 1; i > 0; i--)
            {
                int j = R.Next(i + 1);
                int temp = pairs[i];
                pairs[i] = pairs[j];
                pairs[j] = temp;
            }

            for (int i = 0; i < totalCards; i++)
            {
                array_picbox[i].Visible = true;
                game_pairs[i] = -1;
            }

            int used = 0;
            // берем пару и кладем на 2 случайные карточки, которые еще не заняты
            while (used != pairsCount)
            {
                int n1 = R.Next(totalCards);
                int n2 = R.Next(totalCards);
                if (n2 == n1) continue;
                if (game_pairs[n1] == -1 && game_pairs[n2] == -1)
                {
                    game_pairs[n1] = game_pairs[n2] = pairs[used];
                    used++;
                }
            }

            hide(); //переворачиваем все карточки рубашкой
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (active && !waiting)
            {
                seconds++;
                label2.Text = $"Время: {seconds} сек";
            }
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            if (waiting) return;  //если идет задержка, не реагируем на клики
            if (!active) return;  //если игра не активна, не реагируем на клики

            PictureBox p = (PictureBox)sender; //какую карточку кликнули
            int index = Convert.ToInt32(p.Tag); //получаем индекс карточки из ее тега

            if (!array_picbox[index].Visible) return; //если карточка уже найдена, не реагируем

            if (opened_counter == 1 && opened[0] == index) return; //если кликнули по уже открытой карточке, не реагируем

            //если уже открыто 2 карточки, прячем их
            if (opened_counter == 2)
            {
                hide();
                opened_counter = 0;
            }

            opened[opened_counter] = index; //сохраняем индекс открытой карточки
            opened_counter++;

            p.BackgroundImage = imageList1.Images[startImageIndex + game_pairs[index]];
            p.Image = null; 
            
            if (opened_counter == 2)
            {
                movesCount++;
                label1.Text = $"Ходы: {movesCount}";

                waiting = true;
                await Task.Delay(200);

                if (game_pairs[opened[0]] == game_pairs[opened[1]])

                {
                    try
                    {
                        SoundPlayer matchSound = new SoundPlayer(Properties.Resources.Match);
                        matchSound.Play();
                    }
                    catch { }
                    // если карточки совпали, делаем их невидимыми
                    array_picbox[opened[0]].Visible = false;
                    array_picbox[opened[1]].Visible = false;
                }

                hide(); 
                opened_counter = 0;
                waiting = false;
                CheckGameOver();
            }
        }

        private void CheckGameOver()
        {
            //проверяем, все ли карточки найдены
            bool allFound = true;
            for (int i = 0; i < totalCards; i++)
            {
                if (array_picbox[i].Visible)
                {
                    allFound = false;
                    break;
                }
            }

            if (allFound)
            {
                active = false;
                timer1.Stop();

                try
                {
                    SoundPlayer winSound = new SoundPlayer(Properties.Resources.Victory);
                    winSound.Play();
                }
                catch
                {
                }

                if (difficulty == "hard")
                {
                    Records.SaveRecord(playerName, seconds);
                }

                DialogResult result = MessageBox.Show( $"Поздравляем, {playerName}!\n\nВремя: {seconds} секунд\nХодов: {movesCount}\n\nХотите сыграть ещё раз?",
                "Победа!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Перезапуск
                    начатьНовуюToolStripMenuItem_Click(null, null);
                }
                else
                {
                    // Выход в меню
                    this.Close();
                }
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosing)
            {
                timer1.Stop();
                active = false;
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            if (isClosing) return;
            isClosing = true;

            timer1.Stop();
            waiting = true;
            active = false;
            this.Close();
        }
    }
}