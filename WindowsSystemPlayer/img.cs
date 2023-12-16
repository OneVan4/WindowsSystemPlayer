

namespace WindowsSystemPlayer
{
    public partial class ImageForm : Form
    {
        private string _imagePath;

        public ImageForm(string imagePath, int x, int y)
        {
            InitializeComponent();
            button1.FlatStyle = FlatStyle.Popup;
            LoadImage(imagePath); // Загрузка изображения при создании формы
            button1.Location = new Point(this.ClientSize.Width - button1.Width - 10, this.ClientSize.Height - button1.Height - 10);
            _imagePath = imagePath;

            // Инициализация таймер
            _timer.Interval = 1000; // Интервал в миллисекундах (в данном случае, 1 секунда)
            _timer.Tick += new EventHandler(Timer_Tick);
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Вызов функции task() по истечении времени таймера
            _timer.Stop(); // Остановить таймер, чтобы он больше не вызывал этот метод
            task();
        }

        private void LoadImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    this.BackgroundImage = System.Drawing.Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Invalid image path or file does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the image: " + ex.Message);
            }
        }

        private void Image_Load(object sender, EventArgs e)
        {

            button1.Location = new Point(this.ClientSize.Width - button1.Width - 10, this.ClientSize.Height - button1.Height - 10);
          

        }
        private void task()
        {
            this.Close();
            ImageForm form = new ImageForm(_imagePath, button1.Location.X, button1.Location.Y);
            form.TopMost = true;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

     
    }
}