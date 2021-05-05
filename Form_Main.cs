using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSalonCSharp
{
    public partial class Form_Main : Form
    {
        private int idCounter = 0;
        private List<Customer> customerList = null;
        private Random random;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            random = new Random();
            idCounter = 0;
            customerList = new List<Customer>();
            GenerateCustomers(3);
        }

        private void listBox_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Customers.SelectedIndex > -1)
            {
                int selIndex = Int32.Parse(listBox_Customers.SelectedItem.GetType().GetProperty("Value").GetValue(listBox_Customers.SelectedItem, null).ToString());
                int index = customerList.FindIndex(x => x.id == selIndex);

                label_Id.Text = customerList[index].id.ToString();
                label_Name.Text = customerList[index].name.ToString();
                label_Gender.Text = customerList[index].gender.ToString();
                label_Age.Text = customerList[index].age.ToString();
                label_Mood.Text = customerList[index].mood.ToString();

                label_SpecialAffection.Text = customerList[index].specialAttributes.affection.ToString();


                label_HairCurrentLength.Text = customerList[index].currentHair.lengthText;
                label_HairCurrentColor.Text = customerList[index].currentHair.color.ToString();
                panel_HairCurrentColor.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + ((int)customerList[index].currentHair.color).ToString("X"));
                label_HairCurrentComposition.Text = customerList[index].currentHair.composition.ToString();
                pictureBox_HairCurrentPhoto.Image = Image.FromFile(customerList[index].currentHair.photo);

                label_HairDesiredLength.Text = customerList[index].desiredHair.lengthText;
                label_HairDesiredColor.Text = customerList[index].desiredHair.color.ToString();
                panel_HairDesiredColor.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + ((int)customerList[index].desiredHair.color).ToString("X"));
                label_HairDesiredComposition.Text = customerList[index].desiredHair.composition.ToString();
                pictureBox_HairDesiredPhoto.Image = Image.FromFile(customerList[index].desiredHair.photo);
            }
        }

        private void GenerateCustomers(int count)
        {

            for (int i = 0; i < count; i++)
            {
                idCounter++;

                // Customer
                Customer customer = new Customer
                {
                    id = idCounter,
                    name = GenerateRandomName(),
                    gender = Gender.female,
                    age = random.Next(18, 49),
                    mood = GenerateRandomMood(),
                    currentHair = GenerateRandomHair(),
                    desiredHair = GenerateRandomHair()
                };

                customerList.Add(customer);
            }

            listBox_Customers.DataSource = null;
            listBox_Customers.Items.Clear();

            List<Object> items = new List<Object>();
            listBox_Customers.DisplayMember = "Text";
            listBox_Customers.ValueMember = "Value";

            foreach (Customer customer in customerList)
            {
                items.Add(new { Text = "[" + customer.id.ToString() + "] " + customer.name + " (" + customer.currentHair.lengthText + ")", Value = customer.id });
            }

            listBox_Customers.DataSource = items;

        }

        private string GenerateRandomName()
        {
            Array values = Enum.GetValues(typeof(FirstNames));
            FirstNames randomFirstName = (FirstNames)values.GetValue(random.Next(values.Length));
            return randomFirstName.ToString();
        }

        private HairComposition GenerateRandomHairComposition()
        {
            Array values = Enum.GetValues(typeof(HairComposition));
            HairComposition randomHairComposition = (HairComposition)values.GetValue(random.Next(values.Length));
            return randomHairComposition;
        }

        private Hair GenerateRandomHair()
        {
            Hair newHair = new Hair
            {
                length = random.Next(1, 1),
                color = GenerateRandomHairColor(),
                composition = GenerateRandomHairComposition()
            };

            switch (newHair.length)
            {
                case 0:
                    // Bald
                    newHair.lengthText = "Bald";
                    break;
                case 1:
                    // Short
                    newHair.lengthText = "Short";
                    break;
                case 2:
                    // Medium
                    newHair.lengthText = "Medium";
                    break;
                case 3:
                    // Long
                    newHair.lengthText = "Long";
                    break;
                case 4:
                    // Very Long
                    newHair.lengthText = "Very Long";
                    break;
                default:
                    break;
            }

            List<string> photoList = new List<string>();
            photoList = Directory.EnumerateFiles(Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Images", newHair.lengthText), "*.jpg", SearchOption.TopDirectoryOnly).ToList();
            int ii = random.Next(0, photoList.Count - 1);
            newHair.photo = photoList[ii];

            return newHair;
        }

        private HairColor GenerateRandomHairColor()
        {
            Array values = Enum.GetValues(typeof(HairColor));
            HairColor randomHairColor = (HairColor)values.GetValue(random.Next(values.Length));

            return randomHairColor;
        }

        private Mood GenerateRandomMood()
        {
            Array values = Enum.GetValues(typeof(Mood));
            Mood randomMood = (Mood)values.GetValue(random.Next(values.Length));

            return randomMood;
        }

    }
}
