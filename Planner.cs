using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Pz63
{
    public partial class Planner : Form
    {
        private TaskDatabase tasks;
        public Planner()
        {
            InitializeComponent();
            tasks = new TaskDatabase();
            tasks.Initialize();
            dataGridView1.DataSource = tasks.Tasks.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridView1.DataSource = tasks.Tasks.Where(i => i.Importance == TaskImportance.Важное).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = tasks.Tasks.Where(i => i.Importance == TaskImportance.Подождет).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = tasks.Tasks.Where(i => i.Importance == TaskImportance.Обычное).ToList();
                    break;
                case 3:
                    dataGridView1.DataSource = tasks.Tasks.Where(i => i.Importance == TaskImportance.Срочное).ToList();
                    break;
                case 4:
                    dataGridView1.DataSource = tasks.Tasks.Where(i => i.Status == TaskStatus.Выполнено).ToList();
                    break;
                case 5:
                    dataGridView1.DataSource = tasks.Tasks.Where(i => i.Status == TaskStatus.Отменено).ToList();
                    break;
                case 6:
                    dataGridView1.DataSource = tasks.Tasks.Where(i => i.Status == TaskStatus.Невыполнено).ToList();
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tasks.Tasks.Where(i => i.Title.ToLower().Contains(textBox1.Text.ToLower()) || i.Date.Contains(textBox1.Text)).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Sbros();
            }
        }
        public void Sbros()
        {
            dataGridView1.DataSource = tasks.Tasks.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tasks.Tasks.OrderBy(i => i.Title).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sbros();
            comboBox1.SelectedIndex = -1;
            textBox1.Clear();
        }

    }
}
