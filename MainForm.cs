using System.Text.Json;

namespace LLModInspector
{
    public partial class MainForm : Form
    {
        private Point _formPos;

        private static string? _modsPath;

        private string[]? _modsList;

        private string? _folderDialogResult;

        private static string? _filePath = "setting.json";

        public MainForm()
        {
            InitializeComponent();
            //LoadState();
        }

        private void closeButton_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void minimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void movePanel_MouseDown(object sender, MouseEventArgs e) => _formPos = new Point(e.X, e.Y);

        private void btn_info_Click(object sender, EventArgs e) => MessageBox.Show("Developed by The Stars Above© \nDeveloper's Github: \n https://github.com/inevitableconsequences");

        //static void SaveState(string path)
        //{
        //    if (File.Exists(_filePath))
        //    {
        //        string jsonString = JsonSerializer.Serialize(path);
        //        using (var writer = new StreamWriter(_filePath))
        //        {
        //            writer.Write(jsonString);
        //        }
        //    }
        //    else
        //    {
        //        File.Create(_filePath);
        //    }
            
        //}

        //static string LoadState()
        //{
        //    // Проверка существования файла
        //    if (File.Exists(_filePath))
        //    {
        //        var jsonString = File.ReadAllText(_filePath);
        //        return JsonSerializer.Deserialize<string>(jsonString);
        //    }            
        //    return "Something went wrong";
        //}

        private void movePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Left += e.X - _formPos.X;
            Top += e.Y - _formPos.Y;
        }

        private void btn_getModsPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();
            _folderDialogResult = dialog.ShowDialog().ToString();
            if (_folderDialogResult == "OK")
            {
                btn_getModsPath.BackColor = Color.Green;
                //SaveState(_modsPath);
            }
            else
                btn_getModsPath.BackColor = SystemColors.Control;
            _modsPath = dialog.SelectedPath;
            RefreshListOfMods();
        }

        private void RefreshListOfMods()
        {
            modsListBox.Items.Clear();
            try
            {
                _modsList = Directory.GetFiles(_modsPath);
                foreach (var modName in _modsList)
                {
                    var fileName = Path.GetFileName(modName);
                    modsListBox.Items.Add(fileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Folder isn't choosed or something went wrong");
            }
        }

        private void modsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                string itemName = modsListBox.Items[e.Index].ToString();
                if (e.NewValue == CheckState.Checked)
                {
                    if (Path.GetExtension(itemName) == ".deactivated")
                        ChangeFileExtension(itemName, ".jar");
                }
                else
                {
                    if (Path.GetExtension(itemName) == ".jar")
                        ChangeFileExtension(itemName, ".deactivated");
                }
            });
        }

        private void ChangeFileExtension(string fileNameWithoutExtension, string newExtension)
        {
            string oldFilePath = Path.Combine(_modsPath, fileNameWithoutExtension);
            string newFilePathWithExtension = Path.ChangeExtension(oldFilePath, newExtension.TrimStart('.'));
            if (File.Exists(oldFilePath))
            {
                try
                {
                    File.Move(oldFilePath, newFilePathWithExtension);
                    RefreshListOfMods();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Maybe something is wrong?: {ex.Message}");
                }
            }
            else
                MessageBox.Show($"File {oldFilePath} not found.");
        }
    }
}
