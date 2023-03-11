using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace HashingHelper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Select File to Hash",
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                ShowReadOnly = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
                txtMD5.Text = "";
                txtSHA1.Text = "";
                txtsha256.Text = "";
                txtsha384.Text = "";
                txtsha512.Text = "";
            }
        }

        private string GetHashCode(string filePath, HashAlgorithm cryptoService)
        {
            using (cryptoService)
            {
                using (var fileStream = new FileStream(filePath,
                                                       FileMode.Open,
                                                       FileAccess.Read,
                                                       FileShare.ReadWrite))
                {
                    var hash = cryptoService.ComputeHash(fileStream);
                    var hashString = Convert.ToBase64String(hash);
                    return hashString.TrimEnd('=');
                }
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
             HashFile();
        }

        private void HashFile()
        {
            DateTime start = DateTime.Now;
            DateTime finish;
            statusPGBar.Value = 0;
            statusPGBar.Maximum = 100; 

            FileInfo file = new FileInfo(txtFile.Text);

            txtMD5.Text = GetHashCode(file.FullName, MD5.Create());
            statusPGBar.Value += 20;

            txtSHA1.Text = GetHashCode(file.FullName, SHA1.Create());
            statusPGBar.Value += 20;
            txtsha256.Text = GetHashCode(file.FullName, SHA256.Create());
            statusPGBar.Value += 20;
            txtsha384.Text = GetHashCode(file.FullName, SHA384.Create());
            statusPGBar.Value += 20;
            txtsha512.Text = GetHashCode(file.FullName, SHA512.Create());
            statusPGBar.Value += 20;

            finish = DateTime.Now;
            TimeSpan ts = finish - start;
            statusLbl.Text = "Operation took: " + ts.ToString();
        }


        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}