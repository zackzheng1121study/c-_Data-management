
using _20241126.Models;
namespace _20241126
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDbContext context = new ProductDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.產品類別s.ToList();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //新增產品類別
            產品類別 category = new 產品類別();
            category.類別名稱 = textBox1.Text;
            context.產品類別s.Add(category);
            context.SaveChanges();
            Form1_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //取得產品類別編號
            int categoryid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var category = context.產品類別s.FirstOrDefault(m => m.類別編號 == categoryid);
            //修改指定產品類別紀錄
            category.類別名稱 = textBox1.Text;
            context.SaveChanges();
            Form1_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //取得產品類別編號
            int categoryid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var category = context.產品類別s.FirstOrDefault(m => m.類別編號 == categoryid);
            //刪除指定產品類別紀錄
            context.產品類別s.Remove(category);
            context.SaveChanges();
            Form1_Load(sender, e);
        }
    }
}