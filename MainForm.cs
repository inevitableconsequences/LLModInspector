namespace LLModInspector
{
    public partial class MainForm : Form
    {
        private Point _formPos;

        private string? _modsPath;

        private string[]? _modsList;

        private string? _folderDialogResult;

        public MainForm() => InitializeComponent();

        private void closeButton_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void minimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void movePanel_MouseDown(object sender, MouseEventArgs e) => _formPos = new Point(e.X, e.Y);

        private void btn_info_Click(object sender, EventArgs e) => MessageBox.Show("Developed by The Stars Above© \nDeveloper's Github: \n https://github.com/inevitableconsequences");

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
            RefreshListOfMods();
        }

        private void btn_refreshModsList_Click(object sender, EventArgs e)
        {
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

            MessageBox.Show($"Trying to change extension:\n{oldFilePath}\nTo =>: {newFilePathWithExtension}");

            if (File.Exists(oldFilePath))
            {
                try
                {
                    File.Move(oldFilePath, newFilePathWithExtension);
                    MessageBox.Show($"Extension successfully changed: {oldFilePath} => {newFilePathWithExtension}");
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
