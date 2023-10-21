using System.CodeDom.Compiler;
using System.Text.Json;

namespace Anket_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string name;
        public string surname;
        public string email;
        public string phone_num;
        public string birthday;

        Person person = new Person();
        List<Person> people = new List<Person>();

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            name = name_box.Text;
            person.Name = name;
        }

        private void surname_box_TextChanged(object sender, EventArgs e)
        {
            surname = surname_box.Text;
            person.Surname = surname;
        }

        private void email_box_TextChanged(object sender, EventArgs e)
        {
            email = email_box.Text;
            person.Email = email;
        }

        private void phone_box_TextChanged(object sender, EventArgs e)
        {
            phone_num = phone_box.Text;
            person.Phone = phone_num;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            birthday = dateTimePicker1.Value.ToLongDateString();
            person.Birth = birthday;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            people.Add(person);
            string path = "../../../People.json";
            File.Delete(path);

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string txt = JsonSerializer.Serialize(people, options);
            File.AppendAllText(path, txt);

            Person person_1 = new Person();
            person = person_1;
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            string jsontxt = File.ReadAllText("../../../People.json");

            var list = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(jsontxt);

            foreach (var item in list)
            {
                names_listBox.Items.Add(item.Name);
            }
        }
    }
}