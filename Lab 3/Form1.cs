using System.Diagnostics;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        { 
        }
        List<double> Grade = new List<double>();
        List<Student> studens = new List<Student>();
        private void button1_Click(object sender, EventArgs e)
        {
            Student student1 = new Student()
            {
                _Name = Name.Text,
                _Id = S.Text,
                _BirthYear = int.Parse(B.Text),
                _Tall = double.Parse(T.Text),
                _Grade = double.Parse(G.Text),
                _Major = M.Text,
            };
            studens.Add(student1);
            Grade.Add(student1._Grade);
            dataGridView1.Rows.Add(student1._Name, student1._Id, student1._BirthYear, student1._Tall, student1._Grade, student1._Tall);

            // เรียง
            Grade.Sort();

            // 
            max.Text = "เกรดสูงสุด " + Grade.Last().ToString();
            min.Text = "เกรดต่ำสุด " + Grade.First().ToString();
            all.Text = "นักเรียนทั้งหมด " + studens.Count.ToString() + " คน";
        }

    }
}