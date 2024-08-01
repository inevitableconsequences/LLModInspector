using System.Text.Json;
using static System.Windows.Forms.AxHost;

namespace LLModInspector
{
    public partial class MainForm : Form
    {
        private Point _formPos;

        private static string? _modsPath;

        private string[]? _modsList;

        private string? _folderDialogResult;

        public MainForm() => InitializeComponent();

        private void closeButton_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void minimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void movePanel_MouseDown(object sender, MouseEventArgs e) => _formPos = new Point(e.X, e.Y);

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by The Stars Above© \nDeveloper's Github: \n https://github.com/inevitableconsequences");
            MessageBox.Show("First, select the folder with mods, then from the list that appears, select the mods that you want to enable or disable, then click the button to change the state of the mod");
        }

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

        private void btn_changeExtension_Click(object sender, EventArgs e)
        {
            var selectedItems = modsListBox.SelectedItems.Cast<string>().ToList();
            foreach (string item in selectedItems)
            {
                if (Path.GetExtension(item) == ".deactivated")
                    ChangeFileExtension(item, ".jar");
                else if (Path.GetExtension(item) == ".jar")
                    ChangeFileExtension(item, ".deactivated");
            }
        }
    }
}
