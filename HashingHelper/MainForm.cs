using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace HashingHelper
{
    public partial class MainForm : Form
    {
        private string strMD5 = string.Empty;
        private string strSHA1 = string.Empty;
        private string strSHA256 = string.Empty;
        private string strSHA384 = string.Empty;
        private string strSHA512 = string.Empty;

        public string StrMD5
        {
            get
            {
                return strMD5;
            }
            set
            {
                strMD5 = value;
                //OnPropertyChanged("MD5");
            }
        }
        public string StrSHA1 { get => strSHA1; set => strSHA1 = value; }
        public string StrSHA256 { get => strSHA256; set => strSHA256 = value; }
        public string StrSHA384 { get => strSHA384; set => strSHA384 = value; }
        public string StrSHA512 { get => strSHA512; set => strSHA512 = value; }

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

        private async void btnHash_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            DateTime finish;
            statusPGBar.Value = 0;
            statusPGBar.Maximum = 100;

            var tasks = new[]
            {
                Task.Run(() => MD5Hash()),
                Task.Run(() => SHA1Hash()),
                Task.Run(() => SHA256Hash()),
                Task.Run(() => SHA384Hash()),
                Task.Run(() => SHA512Hash()),
            };
            //Task.WaitAll(tasks);

            finish = DateTime.Now;

        }

        private void MD5Hash()
        {
            FileInfo file = new FileInfo(txtFile.Text);
            var resp = GetHashCode(file.FullName, MD5.Create());
            txtMD5.Invoke((MethodInvoker)delegate { txtMD5.Text = resp; statusPGBar.Value += 20; });
        }

        private void SHA1Hash()
        {
            FileInfo file = new FileInfo(txtFile.Text);
            var resp = GetHashCode(file.FullName, SHA1.Create());
            txtSHA1.Invoke((MethodInvoker)delegate { txtSHA1.Text = resp; statusPGBar.Value += 20; });
        }

        private void SHA256Hash()
        {
            FileInfo file = new FileInfo(txtFile.Text);
            var resp = GetHashCode(file.FullName, SHA256.Create());
            txtsha256.Invoke((MethodInvoker)delegate { txtsha256.Text = resp; statusPGBar.Value += 20; });
        }

        private void SHA384Hash()
        {
            FileInfo file = new FileInfo(txtFile.Text);
            var resp = GetHashCode(file.FullName, SHA384.Create());
            txtsha384.Invoke((MethodInvoker)delegate { txtsha384.Text = resp; statusPGBar.Value += 20; });
        }

        private void SHA512Hash()
        {
            FileInfo file = new FileInfo(txtFile.Text);
            var resp = GetHashCode(file.FullName, SHA512.Create());
            txtsha512.Invoke((MethodInvoker)delegate { txtsha512.Text = resp; statusPGBar.Value += 20; });
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}