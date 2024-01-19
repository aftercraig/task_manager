using System.Diagnostics; 

namespace task_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] processes;

        void GetAllProcesses()
        {
            processes = Process.GetProcesses();
            
            listBox1.Items.Clear();
            foreach (Process proc in processes.OrderBy(alph => alph.ProcessName))
            {
                listBox1.Items.Add(proc.ProcessName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                processes[listBox1.SelectedIndex].Kill();
                GetAllProcesses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcesses();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ÌÓ‚‡ˇ«‡‰‡˜‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Ù‡ÈÎToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Œ·ÌÓ‚ËÚ¸_Click(object sender, EventArgs e)
        {
            GetAllProcesses();
        }

        private void Ì‡ÒÚÓÈÍËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show(); 
        }
    }
}
