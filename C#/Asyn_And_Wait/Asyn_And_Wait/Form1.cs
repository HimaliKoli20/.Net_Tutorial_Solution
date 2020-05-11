using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asyn_And_Wait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            
            using (StreamReader reader = new StreamReader(@"C:\Users\DELL\Desktop\Git Practice\C#\Asyn_And_Wait\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                
                Thread.Sleep(5000);
            }

            return count;
        }

        private void btnProcessFIle_Click(object sender, EventArgs e)
        {
            int count = 0;
            Thread thread = new Thread(() =>
            {
                count = CountCharacters();
                Action action = () => lblCount.Text = count.ToString() + " characters in file";
                this.BeginInvoke(action);
            });
            thread.Start();

            lblCount.Text = "Processing file. Please wait...";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}