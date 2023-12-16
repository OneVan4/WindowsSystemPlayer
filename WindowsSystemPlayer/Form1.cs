using Microsoft.Win32;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using IWshRuntimeLibrary;

namespace WindowsSystemPlayer
{


    public partial class UserCfg_Form : Form
    {
        private string cfgFilePath = "cfg.txt";
        private void hours_TB_MouseClick(object sender, MouseEventArgs e)
        {
            hours_TB.Text = "";
        }

        private void minutes_TB_MouseClick(object sender, MouseEventArgs e)
        {
            minutes_TB.Text = "";
        }

        private void seconds_TB_MouseClick(object sender, MouseEventArgs e)
        {
            seconds_TB.Text = "";
        }

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern uint waveOutGetVolume(uint hwo, ref uint dwVolume);

        [DllImport("winmm.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        public static extern int waveOutSetVolume(uint uDeviceID, uint dwVolume);

        public const uint WAVE_MAPPER = unchecked((uint)-1);
        private void AddToStartup()
        {
            string appName = "WindowsMicrosoftTeam"; // Имя вашего приложения
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\" + appName + ".lnk"; // Полный путь, где будет создан ярлык

            // Создаем объект ярлыка
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);

            // Описание ярлыка в всплывающей подсказке
            shortcut.Description = "Shortcut for WindowsMicrosoftTeam "; // Описание вашего приложения

            // Путь к исполняемому файлу
            shortcut.TargetPath = Application.ExecutablePath;

            // Путь к домашнему каталогу, указываем папку, в которой запускается исполняемый файл
            shortcut.WorkingDirectory = Environment.CurrentDirectory;

            // Создаем ярлык
            shortcut.Save();

            // Добавляем запись в реестр для автозапуска
            Microsoft.Win32.RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue(appName, shortcutPath);
        }

        private bool IsValidCfg(string time, string volume, string path,string image)
        {
            TimeSpan parsedTime;
            if (TimeSpan.TryParse(time, out parsedTime) == false)
            {
                MessageBox.Show("Incorrect time! Enter time in this format: HH:MM:SS");
                return false;
            };


            try { Convert.ToInt32(volume); }
            catch
            {
                MessageBox.Show("Incorrect volume value! The volume value must be integer and in the range from 1 to 99");
                return false;
            }

            if (System.IO.File.Exists(path))
            {
                // Проверка расширения файла
                string fileExtension = Path.GetExtension(path);
                if (!fileExtension.Equals(".wav", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("The specified file must have the extension .wav");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("The file at the specified path was not found");
                return false;
            }
            if (!System.IO.File.Exists(image))
            {
                MessageBox.Show("The file at the specified path was not found");
                return false;
            }
            return true;
        }

        public UserCfg_Form()
        {
            InitializeComponent();
        }




        private void UserCfg_Form_Load(object sender, EventArgs e)
        {
            AddToStartup();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            if (System.IO.File.Exists(cfgFilePath))
            {
                string[] lines = System.IO.File.ReadAllLines(cfgFilePath);
                foreach (string line in lines)
                {
                    if (line.StartsWith("time#"))
                    {
                        string loadedTime = line.Split('#')[1].Trim();
                        string[] timeParts = loadedTime.Split(':');

                        // Убедитесь, что полученное время содержит правильное количество часов, минут и секунд
                        if (timeParts.Length == 3)
                        {
                            hours_TB.Text = timeParts[0];
                            minutes_TB.Text = timeParts[1];
                            seconds_TB.Text = timeParts[2];
                        }
                    }

                    if (line.StartsWith("path#"))
                    {
                        path_TB.Text = line.Split('#')[1].Trim();
                    }
                    if (line.StartsWith("volume#"))
                    {
                        Volume_TB.Text = line.Split('#')[1].Trim();
                    }
                    if(line.StartsWith("image#"))
                    {
                        ImagePath_TB.Text = line.Split('#')[1].Trim();
                    }
                    if (line.StartsWith("CFG#"))
                    {
                        string cfgValue = line.Split('#')[1].Trim();
                        if (cfgValue == "1")
                        {
                            
                            playMusic(); 
                            break;
                        }
                    }
                }
            }
        }


        private void save_Button_Click(object sender, EventArgs e)
        {
            string time = hours_TB.Text + ":" + minutes_TB.Text + ":" + seconds_TB.Text;
            string volume = Volume_TB.Text;
            string filePath = path_TB.Text;
            string image = ImagePath_TB.Text;
            if (IsValidCfg(time, volume, filePath,image))
            {
                using (StreamWriter sw = new StreamWriter("cfg.txt", false))
                {
                    sw.WriteLine("time# " + time);
                    sw.WriteLine("volume# " + volume);
                    sw.WriteLine("path# " + filePath);
                    sw.WriteLine("image# "+ image);
                    sw.WriteLine("CFG# " + "1");
                }
                MessageBox.Show("Your config has been saved");
            };


        }

        private void playMusic()
        {
            this.Hide();
            string time = hours_TB.Text + ":" + minutes_TB.Text + ":" + seconds_TB.Text;
            string volume = Volume_TB.Text;
            string filePath = path_TB.Text;
            string imgPath = ImagePath_TB.Text;

            DateTime specifiedTime = DateTime.Parse(time);

            // Получение текущего времени
            DateTime currentTime = DateTime.Now;

            // Вычисление времени ожидания до указанного времени
            TimeSpan waitTime = specifiedTime - currentTime;

            // Проверка, если указанное время уже прошло, не ждем и сразу запускаем музыку
            if (waitTime.TotalMilliseconds <= 0)
            {
                Play(filePath,volume,imgPath);
            }
            else
            {
                // Ожидание до указанного времени
                Thread.Sleep(waitTime);

                // Запуск музыки после ожидания
                Play(filePath,volume,imgPath);
            }
        }

        private void Play(string filePath,string volume, string imgPath)
        {
            uint hWo = WAVE_MAPPER;
            uint newVolume = 0xFFFF;

            waveOutSetVolume(hWo, newVolume);

            if (System.IO.File.Exists(filePath) && filePath.EndsWith(".wav", StringComparison.OrdinalIgnoreCase))
            {    
                ImageForm image = new ImageForm(imgPath,0,0);
                image.Show();
                 SoundPlayer player = new SoundPlayer(filePath);
                 player.PlayLooping();
            }
            else
            {
                MessageBox.Show("Неверный путь к файлу или файл не .wav");
            }
        }




    }
}
