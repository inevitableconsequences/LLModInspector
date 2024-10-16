namespace LLModInspector
{
    public partial class MainForm : Form
    {
        private Point _formPos;

        private static string? _modsPath;

        private string[]? _modsList;

        private string[]? _filteredMods;

        private string? _folderDialogResult;

        public MainForm() => InitializeComponent();

        private void closeButton_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void minimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void movePanel_MouseDown(object sender, MouseEventArgs e) => _formPos = new Point(e.X, e.Y);

        private void btn_info_Click(object sender, EventArgs e) => MessageBox.Show("First, select the folder with mods, then from the list that appears, select the mods that you want to enable or disable, then click the button to change the state of the mod");

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
                btn_getModsPath.BackColor = Color.Green;
            else
                btn_getModsPath.BackColor = SystemColors.Control;
            _modsPath = dialog.SelectedPath;
            using (StreamWriter stream = new("path.txt")) stream.WriteLine(dialog.SelectedPath);
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
                MessageBox.Show("Folder isn't choosed or something went wrong (you probably can see this message at first time this program starts)");
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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = searchTextBox.Text.ToLower();
                _filteredMods = _modsList.Where(item => Path.GetFileName(item).ToLower().Contains(search)).Select(item => Path.GetFileName(item)).ToArray();
                modsListBox.Items.Clear();
                modsListBox.Items.AddRange(_filteredMods);
            }
            catch (Exception)
            {
                searchTextBox.Clear();
            }
        }

        private void selectAllLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < modsListBox.Items.Count; i++)
                modsListBox.SetSelected(i, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("path.txt"))
            {
                using (StreamReader stream = new("path.txt")) _modsPath = stream.ReadLine();
                RefreshListOfMods();
            }
            else
                using (FileStream fs = new("path.txt", FileMode.Create)) MessageBox.Show("File with mods path is created");
        }
    }
}
