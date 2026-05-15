using System;
using System.Windows.Forms;
using System.Media;

namespace prog_kursov
{
    public partial class MenuForm : Form
    {
        private string currentDifficulty = "easy"; //текущая сложность (легкая по умолчанию)
        private Game gameForm = null; // ссылка на форму игры
        private bool isGameRunning = false; // запущена ли игра
        private SoundPlayer backgroundMusic; // для управления музыкой

        public MenuForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            PlayBackgroundMusic(); // запускаем музыку при открытии меню

            // привязываем события
            button1.Click += btnStart_Click;
            button2.Click += btnExit_Click;

            // привязываем кнопки сложности
            btnEasy.Click += btnEasy_Click;
            btnMedium.Click += btnMedium_Click;
            btnHard.Click += btnHard_Click;

            btnEasy.BackColor = System.Drawing.Color.White;
            btnMedium.BackColor = System.Drawing.Color.White;
            btnHard.BackColor = System.Drawing.Color.White;

            // ставим сложность по умолчанию
            SelectDifficulty("easy");
            LoadRecords();
        }
        // методы для обработки выбора сложности
        private void btnEasy_Click(object sender, EventArgs e)
        {
            SelectDifficulty("easy");
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            SelectDifficulty("medium");
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            SelectDifficulty("hard");
        }

        // метод для обновления интерфейса при выборе сложности
        private void SelectDifficulty(string difficulty)
        {
            currentDifficulty = difficulty;

            btnEasy.BackColor = System.Drawing.SystemColors.Control;
            btnMedium.BackColor = System.Drawing.SystemColors.Control;
            btnHard.BackColor = System.Drawing.SystemColors.Control;

            if (difficulty == "easy")
            {
                btnEasy.BackColor = System.Drawing.Color.DarkSeaGreen;
                btnMedium.BackColor = System.Drawing.Color.White;
                btnHard.BackColor = System.Drawing.Color.White;
                lblSelectedDifficulty.Text = "простая";
            }
            else if (difficulty == "medium")
            {
                btnEasy.BackColor = System.Drawing.Color.White;
                btnMedium.BackColor = System.Drawing.Color.Khaki;
                btnHard.BackColor = System.Drawing.Color.White;
                lblSelectedDifficulty.Text = "средняя";
            }
            else if (difficulty == "hard")
            {
                btnEasy.BackColor = System.Drawing.Color.White;
                btnMedium.BackColor = System.Drawing.Color.White;
                btnHard.BackColor = System.Drawing.Color.LightPink;
                lblSelectedDifficulty.Text = "сложная";
            }
        }

        // метод для загрузки рекордов и отображения их в списке
        private void LoadRecords()
        {
            listRecords.Items.Clear();
            var records = Records.LoadRecords(); // загружаем рекорды из файла

            if (records.Count == 0)
            {
                listRecords.Items.Add("Пока нет рекордов");
            }
            else
            {
                for (int i = 0; i < records.Count; i++)
                {
                    listRecords.Items.Add($"{i + 1}. {records[i].PlayerName} - {records[i].Seconds} сек");
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // если игра уже запущена, не создаём новую
            if (isGameRunning) return;

            // получаем имя игрока
            string playerName = textPlayerName.Text.Trim();
            if (string.IsNullOrEmpty(playerName))
            {
                playerName = "Игрок";
            }

            // останавливаем музыку при запуске игры
            StopBackgroundMusic();

            this.Hide();
            isGameRunning = true;

            // создаем новую игру
            gameForm = new Game(playerName, currentDifficulty);

            gameForm.FormClosed += GameForm_FormClosed;

            gameForm.Show();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // освобождаем ресурсы игры
            if (gameForm != null)
            {
                gameForm.FormClosed -= GameForm_FormClosed;
                gameForm.Dispose();
                gameForm = null;
            }

            isGameRunning = false;
            LoadRecords();

            // включаем музыку обратно при возвращении в меню
            PlayBackgroundMusic();

            this.Show();
        }

        // обработчик для кнопки выхода
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // метод для запуска музыки
        private void PlayBackgroundMusic()
        {
            try
            {
                backgroundMusic = new SoundPlayer(Properties.Resources.Back);
                backgroundMusic.PlayLooping();
            }
            catch { }
        }

        // метод для остановки музыки
        private void StopBackgroundMusic()
        {
            if (backgroundMusic != null)
            {
                backgroundMusic.Stop();
                backgroundMusic.Dispose();
                backgroundMusic = null;
            }
        }

        // при закрытии формы останавливаем музыку
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopBackgroundMusic();
            base.OnFormClosing(e);
        }
    }
}