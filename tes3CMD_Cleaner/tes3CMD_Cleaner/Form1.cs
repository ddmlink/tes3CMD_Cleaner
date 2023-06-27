namespace tes3CMD_Cleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.DragDrop += new DragEventHandler(checkedListBox1_DragDrop);
            checkedListBox1.DragEnter += new DragEventHandler(checkedListBox1_DragEnter);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkedListBox1.DragDrop -= checkedListBox1_DragDrop;
            checkedListBox1.DragEnter -= checkedListBox1_DragEnter;
            // I've heard that it's good to remove delegates before closing
        }

        private void checkedListBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null || sender == null)
                return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void checkedListBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data == null)
                return;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!checkedListBox1.Items.Contains(file))
                {
                    if (file.ToLower().EndsWith(".esp") || file.ToLower().EndsWith(".esm"))
                    {
                        string fileN = Path.GetFileName(file);
                        checkedListBox1.Items.Add(fileN);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count <= 0)
            {
                MessageBox.Show("No plugins in list.");
                return;
            }
            if (!File.Exists(".\\tes3cmd.exe"))
            {
                MessageBox.Show("Could not locate tes3cmd.exe. Please make sure it is in the same folder as this app and try again.");
                return;
            }

            string p = "clean "; // params. Note that this and all params end with a space
            // example: "--backup-dir Clean_Backups --cell-params --gmsts --overwrite "

            if (chkCellParams.Checked) { p += "--cell-params "; }
            if (chkDups.Checked) { p += "--dups "; }
            if (chkGMST.Checked) { p += "--gmsts "; }
            if (chkInstances.Checked) { p += "--instances "; }
            if (chkJunk.Checked) { p += "--junk-cells "; }
            p += "--overwrite ";

            //string f = "";
            foreach (string item in checkedListBox1.Items)
            {
                if (item.ToLower().EndsWith(".esp") || item.ToLower().EndsWith(".esm"))
                {
                    p += "\"" + item + "\" "; // wrap each item in quotes and stick a space on the end
                }
            }

            string time = DateTime.Now.ToString();
            time = time.Replace('/', '-');
            time = time.Replace(':', '.'); // file names can't have these characters
            time = time.Replace(' ', '_'); // tes3cmd didn't like the spaces and thought it was a few plugins
            p += "> Clean_" + time + ".txt";
            // example: "myplugin1.esp" "myplugin2.esp"

            System.Diagnostics.Process tes = new System.Diagnostics.Process();
            //tes.StartInfo.FileName = ".\\tes3cmd.exe";
            //tes.StartInfo.Arguments = p;

            // for some reason, calling tes3cmd directly doesn't work,
            // but starting cmd and then running the command works fine so long
            // as /k or /c is included.

            // Parameter issue, maybe? Well, it works.

            tes.StartInfo.FileName = "cmd.exe";
            tes.StartInfo.Arguments = "/c " + ".\\tes3cmd.exe" + " " + p;

            bool errorOccurred = false;
            try
            {
                tes.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // no idea what kind of errors to catch, so keeping it generic
                errorOccurred = true;
            }

            tes.WaitForExit();
            if (errorOccurred)
            {
                MessageBox.Show("Completed with errors. Log was saved to Clean_" + time + ".txt");
            }
            else
            {
                MessageBox.Show("Done! Log was saved to Clean_" + time + ".txt");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = true;
                dialog.Filter = "Plugins (*.esp;*.esm)|*.esp;*.esm";
                dialog.Title = "Morrowind Plugin Browser";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string fileN = Path.GetFileName(file);
                        if (!checkedListBox1.Items.Contains(fileN))
                        {
                            checkedListBox1.Items.Add(fileN);
                        }
                    }
                }
            }
        }
    }
}