using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace StoreCatalog
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; //расположение по центру экрана
        }
        private void Catalog_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=Katya_ld\\MSSQLSERVER3; Database=StoreCatalog; Integrated Security=true"; //подключение к бд
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Catalog", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (CatalogTbCntrl.TabPages.Contains(AppliancesTbPg))
                    {

                        // PictureBox 1
                        PictureBox pictureBox1 = new PictureBox();
                        pictureBox1.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Location = new Point(75, 25); // местоположение картинки
                        AppliancesTbPg.Controls.Add(pictureBox1);
                        Label labelPrice1 = new Label();
                        labelPrice1.Text = reader["Price"].ToString();
                        labelPrice1.Location = new Point(125, 75); // местоположение цены
                        AppliancesTbPg.Controls.Add(labelPrice1);
                        Label labelName1 = new Label();
                        labelName1.Text = reader["Name"].ToString();
                        labelName1.Location = new Point(75, 75); // местоположение названия
                        AppliancesTbPg.Controls.Add(labelName1);
                        reader.Read();

                        // PictureBox 2
                        PictureBox pictureBox2 = new PictureBox();
                        pictureBox2.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox2.Location = new Point(225, 25);
                        AppliancesTbPg.Controls.Add(pictureBox2);
                        Label labelPrice2 = new Label();
                        labelPrice2.Text = reader["Price"].ToString();
                        labelPrice2.Location = new Point(275, 75);
                        AppliancesTbPg.Controls.Add(labelPrice2);
                        Label labelName2 = new Label();
                        labelName2.Text = reader["Name"].ToString();
                        labelName2.Location = new Point(225, 75);
                        AppliancesTbPg.Controls.Add(labelName2);
                        reader.Read();

                        // PictureBox 3
                        PictureBox pictureBox3 = new PictureBox();
                        pictureBox3.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox3.Location = new Point(395, 25);
                        AppliancesTbPg.Controls.Add(pictureBox3);
                        Label labelPrice3 = new Label();
                        labelPrice3.Text = reader["Price"].ToString();
                        labelPrice3.Location = new Point(475, 75);
                        AppliancesTbPg.Controls.Add(labelPrice3);
                        Label labelName3 = new Label();
                        labelName3.Text = reader["Name"].ToString();
                        labelName3.Location = new Point(375, 75);
                        AppliancesTbPg.Controls.Add(labelName3);
                        reader.Read();

                        // PictureBox 4
                        PictureBox pictureBox4 = new PictureBox();
                        pictureBox4.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox4.Location = new Point(575, 25);
                        AppliancesTbPg.Controls.Add(pictureBox4);
                        Label labelPrice4 = new Label();
                        labelPrice4.Text = reader["Price"].ToString();
                        labelPrice4.Location = new Point(635, 75);
                        AppliancesTbPg.Controls.Add(labelPrice4);
                        Label labelName4 = new Label();
                        labelName4.Text = reader["Name"].ToString();
                        labelName4.Location = new Point(575, 75);
                        AppliancesTbPg.Controls.Add(labelName4);
                        reader.Read();

                        // PictureBox 5
                        PictureBox pictureBox5 = new PictureBox();
                        pictureBox5.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox5.Location = new Point(75, 125);
                        AppliancesTbPg.Controls.Add(pictureBox5);
                        Label labelPrice5 = new Label();
                        labelPrice5.Text = reader["Price"].ToString();
                        labelPrice5.Location = new Point(125, 175);
                        AppliancesTbPg.Controls.Add(labelPrice5);
                        Label labelName5 = new Label();
                        labelName5.Text = reader["Name"].ToString();
                        labelName5.Location = new Point(75, 175);
                        AppliancesTbPg.Controls.Add(labelName5);
                        reader.Read();

                        // PictureBox 6
                        PictureBox pictureBox6 = new PictureBox();
                        pictureBox6.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox6.Location = new Point(225, 125);
                        AppliancesTbPg.Controls.Add(pictureBox6);
                        Label labelPrice6 = new Label();
                        labelPrice6.Text = reader["Price"].ToString();
                        labelPrice6.Location = new Point(275, 175);
                        AppliancesTbPg.Controls.Add(labelPrice6);
                        Label labelName6 = new Label();
                        labelName6.Text = reader["Name"].ToString();
                        labelName6.Location = new Point(225, 175);
                        AppliancesTbPg.Controls.Add(labelName6);
                        reader.Read();
                    }
                    if (CatalogTbCntrl.TabPages.Contains(ToolsTbPg))
                    {
                        // PictureBox 7
                        PictureBox pictureBox7 = new PictureBox();
                        pictureBox7.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox7.Location = new Point(75, 25); // местоположение картинки
                        ToolsTbPg.Controls.Add(pictureBox7);
                        Label labelPrice7 = new Label();
                        labelPrice7.Text = reader["Price"].ToString();
                        labelPrice7.Location = new Point(125, 75); // местоположение цены
                        ToolsTbPg.Controls.Add(labelPrice7);
                        Label labelName7 = new Label();
                        labelName7.Text = reader["Name"].ToString();
                        labelName7.Location = new Point(75, 75); // местоположение названия
                        ToolsTbPg.Controls.Add(labelName7);
                        reader.Read();

                        // PictureBox 8
                        PictureBox pictureBox8 = new PictureBox();
                        pictureBox8.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox8.Location = new Point(225, 25);
                        ToolsTbPg.Controls.Add(pictureBox8);
                        Label labelPrice8 = new Label();
                        labelPrice8.Text = reader["Price"].ToString();
                        labelPrice8.Location = new Point(290, 75);
                        ToolsTbPg.Controls.Add(labelPrice8);
                        Label labelName8 = new Label();
                        labelName8.Text = reader["Name"].ToString();
                        labelName8.Location = new Point(225, 75);
                        ToolsTbPg.Controls.Add(labelName8);
                        reader.Read();

                        // PictureBox 9
                        PictureBox pictureBox9 = new PictureBox();
                        pictureBox9.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox9.Location = new Point(395, 25);
                        ToolsTbPg.Controls.Add(pictureBox9);
                        Label labelPrice9 = new Label();
                        labelPrice9.Text = reader["Price"].ToString();
                        labelPrice9.Location = new Point(440, 75);
                        ToolsTbPg.Controls.Add(labelPrice9);
                        Label labelName9 = new Label();
                        labelName9.Text = reader["Name"].ToString();
                        labelName9.Location = new Point(395, 75);
                        ToolsTbPg.Controls.Add(labelName9);
                        reader.Read();

                        // PictureBox 10
                        PictureBox pictureBox10 = new PictureBox();
                        pictureBox10.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox10.Location = new Point(545, 25);
                        ToolsTbPg.Controls.Add(pictureBox10);
                        Label labelPrice10 = new Label();
                        labelPrice10.Text = reader["Price"].ToString();
                        labelPrice10.Location = new Point(610, 75);
                        ToolsTbPg.Controls.Add(labelPrice10);
                        Label labelName10 = new Label();
                        labelName10.Text = reader["Name"].ToString();
                        labelName10.Location = new Point(545, 75);
                        ToolsTbPg.Controls.Add(labelName10);
                        reader.Read();

                        // PictureBox 11
                        PictureBox pictureBox11 = new PictureBox();
                        pictureBox11.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox11.Location = new Point(75, 125);
                        ToolsTbPg.Controls.Add(pictureBox11);
                        Label labelPrice11 = new Label();
                        labelPrice11.Text = reader["Price"].ToString();
                        labelPrice11.Location = new Point(125, 175);
                        ToolsTbPg.Controls.Add(labelPrice11);
                        Label labelName11 = new Label();
                        labelName11.Text = reader["Name"].ToString();
                        labelName11.Location = new Point(75, 175);
                        ToolsTbPg.Controls.Add(labelName11);
                        reader.Read();

                        // PictureBox 12
                        PictureBox pictureBox12 = new PictureBox();
                        pictureBox12.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox12.Location = new Point(225, 125);
                        ToolsTbPg.Controls.Add(pictureBox12);
                        Label labelPrice12 = new Label();
                        labelPrice12.Text = reader["Price"].ToString();
                        labelPrice12.Location = new Point(290, 175);
                        ToolsTbPg.Controls.Add(labelPrice12);
                        Label labelName12 = new Label();
                        labelName12.Text = reader["Name"].ToString();
                        labelName12.Location = new Point(225, 175);
                        ToolsTbPg.Controls.Add(labelName12);
                        reader.Read();
                    }
                    if (CatalogTbCntrl.TabPages.Contains(InteriorTbPg))
                    {

                        // PictureBox 13
                        PictureBox pictureBox13 = new PictureBox();
                        pictureBox13.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox13.Location = new Point(75, 25); // местоположение картинки
                        InteriorTbPg.Controls.Add(pictureBox13);
                        Label labelPrice13 = new Label();
                        labelPrice13.Text = reader["Price"].ToString();
                        labelPrice13.Location = new Point(125, 75); // местоположение цены
                        InteriorTbPg.Controls.Add(labelPrice13);
                        Label labelName13 = new Label();
                        labelName13.Text = reader["Name"].ToString();
                        labelName13.Location = new Point(63, 75); // местоположение названия
                        InteriorTbPg.Controls.Add(labelName13);
                        reader.Read();

                        // PictureBox 14
                        PictureBox pictureBox14 = new PictureBox();
                        pictureBox14.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox14.Location = new Point(235, 25);
                        InteriorTbPg.Controls.Add(pictureBox14);
                        Label labelPrice14 = new Label();
                        labelPrice14.Text = reader["Price"].ToString();
                        labelPrice14.Location = new Point(290, 75);
                        InteriorTbPg.Controls.Add(labelPrice14);
                        Label labelName14 = new Label();
                        labelName14.Text = reader["Name"].ToString();
                        labelName14.Location = new Point(235, 75);
                        InteriorTbPg.Controls.Add(labelName14);
                        reader.Read();

                        // PictureBox 15
                        PictureBox pictureBox15 = new PictureBox();
                        pictureBox15.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox15.Location = new Point(395, 25);
                        InteriorTbPg.Controls.Add(pictureBox15);
                        Label labelPrice15 = new Label();
                        labelPrice15.Text = reader["Price"].ToString();
                        labelPrice15.Location = new Point(440, 75);
                        InteriorTbPg.Controls.Add(labelPrice15);
                        Label labelName15 = new Label();
                        labelName15.Text = reader["Name"].ToString();
                        labelName15.Location = new Point(395, 75);
                        InteriorTbPg.Controls.Add(labelName15);
                        reader.Read();

                        // PictureBox 16
                        PictureBox pictureBox16 = new PictureBox();
                        pictureBox16.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox16.Location = new Point(545, 25);
                        InteriorTbPg.Controls.Add(pictureBox16);
                        Label labelPrice16 = new Label();
                        labelPrice16.Text = reader["Price"].ToString();
                        labelPrice16.Location = new Point(610, 75);
                        InteriorTbPg.Controls.Add(labelPrice16);
                        Label labelName16 = new Label();
                        labelName16.Text = reader["Name"].ToString();
                        labelName16.Location = new Point(545, 75);
                        InteriorTbPg.Controls.Add(labelName16);
                        reader.Read();

                        // PictureBox 17
                        PictureBox pictureBox17 = new PictureBox();
                        pictureBox17.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox17.Location = new Point(75, 125);
                        InteriorTbPg.Controls.Add(pictureBox17);
                        Label labelPrice17 = new Label();
                        labelPrice17.Text = reader["Price"].ToString();
                        labelPrice17.Location = new Point(125, 175);
                        InteriorTbPg.Controls.Add(labelPrice17);
                        Label labelName17 = new Label();
                        labelName17.Text = reader["Name"].ToString();
                        labelName17.Location = new Point(75, 175);
                        InteriorTbPg.Controls.Add(labelName17);
                        reader.Read();

                        // PictureBox 18
                        PictureBox pictureBox18 = new PictureBox();
                        pictureBox18.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox18.Location = new Point(225, 125);
                        InteriorTbPg.Controls.Add(pictureBox18);
                        Label labelPrice18 = new Label();
                        labelPrice18.Text = reader["Price"].ToString();
                        labelPrice18.Location = new Point(290, 175);
                        InteriorTbPg.Controls.Add(labelPrice18);
                        Label labelName18 = new Label();
                        labelName18.Text = reader["Name"].ToString();
                        labelName18.Location = new Point(225, 175);
                        InteriorTbPg.Controls.Add(labelName18);
                        reader.Read();
                    }
                    if (CatalogTbCntrl.TabPages.Contains(DishesTbPg))
                    {
                        // PictureBox 19
                        PictureBox pictureBox19 = new PictureBox();
                        pictureBox19.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox19.Location = new Point(73, 25); // местоположение картинки
                        DishesTbPg.Controls.Add(pictureBox19);
                        Label labelPrice19 = new Label();
                        labelPrice19.Text = reader["Price"].ToString();
                        labelPrice19.Location = new Point(127, 75); // местоположение цены
                        DishesTbPg.Controls.Add(labelPrice19);
                        Label labelName19 = new Label();
                        labelName19.Text = reader["Name"].ToString();
                        labelName19.Location = new Point(60, 75); // местоположение названия
                        DishesTbPg.Controls.Add(labelName19);
                        reader.Read();

                        // PictureBox 20
                        PictureBox pictureBox20 = new PictureBox();
                        pictureBox20.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox20.Location = new Point(225, 25);
                        DishesTbPg.Controls.Add(pictureBox20);
                        Label labelPrice20 = new Label();
                        labelPrice20.Text = reader["Price"].ToString();
                        labelPrice20.Location = new Point(275, 75);
                        DishesTbPg.Controls.Add(labelPrice20);
                        Label labelName20 = new Label();
                        labelName20.Text = reader["Name"].ToString();
                        labelName20.Location = new Point(225, 75);
                        DishesTbPg.Controls.Add(labelName20);
                        reader.Read();

                        // PictureBox 21
                        PictureBox pictureBox21 = new PictureBox();
                        pictureBox21.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox21.Location = new Point(395, 25);
                        DishesTbPg.Controls.Add(pictureBox21);
                        Label labelPrice21 = new Label();
                        labelPrice21.Text = reader["Price"].ToString();
                        labelPrice21.Location = new Point(450, 75);
                        DishesTbPg.Controls.Add(labelPrice21);
                        Label labelName21 = new Label();
                        labelName21.Text = reader["Name"].ToString();
                        labelName21.Location = new Point(385, 75);
                        DishesTbPg.Controls.Add(labelName21);
                        reader.Read();

                        // PictureBox 22
                        PictureBox pictureBox22 = new PictureBox();
                        pictureBox22.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox22.Location = new Point(545, 25);
                        DishesTbPg.Controls.Add(pictureBox22);
                        Label labelPrice22 = new Label();
                        labelPrice22.Text = reader["Price"].ToString();
                        labelPrice22.Location = new Point(600, 75);
                        DishesTbPg.Controls.Add(labelPrice22);
                        Label labelName22 = new Label();
                        labelName22.Text = reader["Name"].ToString();
                        labelName22.Location = new Point(550, 75);
                        DishesTbPg.Controls.Add(labelName22);
                        reader.Read();

                        // PictureBox 23
                        PictureBox pictureBox23 = new PictureBox();
                        pictureBox23.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox23.Location = new Point(75, 125);
                        DishesTbPg.Controls.Add(pictureBox23);
                        Label labelPrice23 = new Label();
                        labelPrice23.Text = reader["Price"].ToString();
                        labelPrice23.Location = new Point(125, 175);
                        DishesTbPg.Controls.Add(labelPrice23);
                        Label labelName23 = new Label();
                        labelName23.Text = reader["Name"].ToString();
                        labelName23.Location = new Point(75, 175);
                        DishesTbPg.Controls.Add(labelName23);
                        reader.Read();

                        // PictureBox 24
                        PictureBox pictureBox24 = new PictureBox();
                        pictureBox24.Image = System.Drawing.Image.FromStream(new MemoryStream((byte[])reader["Image"]));
                        pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox24.Location = new Point(225, 125);
                        DishesTbPg.Controls.Add(pictureBox24);
                        Label labelPrice24 = new Label();
                        labelPrice24.Text = reader["Price"].ToString();
                        labelPrice24.Location = new Point(305, 175);
                        DishesTbPg.Controls.Add(labelPrice24);
                        Label labelName24 = new Label();
                        labelName24.Text = reader["Name"].ToString();
                        labelName24.Location = new Point(225, 175);
                        DishesTbPg.Controls.Add(labelName24);
                    }
                }
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm newForm = new MainForm();
            newForm.Show();
        }
    }
}