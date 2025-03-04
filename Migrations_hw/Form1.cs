using Microsoft.EntityFrameworkCore;

namespace Migrations_hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void AddGroup()
        {
            string name = textBox7.Text;
            int year = int.Parse(textBox4.Text);

            try
            {


                if (name != null && year > 0)
                {
                    await using (var db = new UniversityContext())
                    {

                        var group = new Groups()
                        {
                            Name = name,
                            Year = year
                        };

                        await db.AddRangeAsync(group);
                        await db.SaveChangesAsync();



                    }
                    MessageBox.Show("Successfully added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RemoveGroup()
        {
            string name = textBox7.Text;
            int year = int.Parse(textBox4.Text);

            try
            {


                if (name != null)
                {
                    await using (var db = new UniversityContext())
                    {

                        var query = await db.Groups.Where(g => g.Name == name).ToListAsync();

                        db.Groups.RemoveRange(query);
                        await db.SaveChangesAsync();



                    }
                    MessageBox.Show("Successfully removed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void EditGroup()
        {
            string name = textBox7.Text;
            int year = int.Parse(textBox4.Text);

            try
            {


                if (name != null)
                {
                    await using (var db = new UniversityContext())
                    {

                        var query = await db.Groups.SingleOrDefaultAsync(g => g.Name == name);
                        if (query != null)
                        {
                            if (name != null && year > 0)
                                query.Name = name;
                            query.Year = year;
                        }


                        await db.SaveChangesAsync();



                    }
                    MessageBox.Show("Successfully edited");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void AddDepartment()
        {
            string name = textBox6.Text;
            int financing = int.Parse(textBox5.Text);

            try
            {


                if (name != null && financing > 0)
                {
                    await using (var db = new UniversityContext())
                    {

                        var department = new Departments()
                        {
                            Name = name,
                            Financing = financing
                        };

                        await db.AddRangeAsync(department);
                        await db.SaveChangesAsync();



                    }
                    MessageBox.Show("Successfully added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RemoveDepartment()
        {
            string name = textBox6.Text;
            int year = int.Parse(textBox5.Text);

            try
            {


                if (name != null)
                {
                    await using (var db = new UniversityContext())
                    {

                        var query = await db.Departments.Where(g => g.Name == name).ToListAsync();

                        db.Departments.RemoveRange(query);
                        await db.SaveChangesAsync();



                    }
                    MessageBox.Show("Successfully removed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void EditDepartment()
        {
            string name = textBox6.Text;
            int financing = int.Parse(textBox5.Text);

            try
            {


                if (name != null)
                {
                    await using (var db = new UniversityContext())
                    {

                        var query = await db.Departments.SingleOrDefaultAsync(g => g.Name == name);
                        if (query != null)
                        {
                            if (name != null && financing > 0)
                                query.Name = name;
                            query.Financing = financing;
                        }


                        await db.SaveChangesAsync();



                    }
                    MessageBox.Show("Successfully edited");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void AddTeacher()
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            int salary = int.Parse(textBox3.Text);

            try
            {


                if (name != null && surname != null && salary > 0)
                {
                    await using (var db = new UniversityContext())
                    {

                        var teacher = new Teachers()
                        {
                            Name = name,
                            Surname = surname,
                            Salary = salary
                        };

                        await db.AddRangeAsync(teacher);
                        await db.SaveChangesAsync();



                    }
                    MessageBox.Show("Successfully added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RemoveTeacher()
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            int salary = int.Parse(textBox3.Text);

            try
            {


                if (name != null && surname != null)
                {
                    await using (var db = new UniversityContext())
                    {

                        var query = await db.Teachers.Where(t => t.Name == name && t.Surname == surname).SingleOrDefaultAsync();
                        db.Teachers.RemoveRange(query);
                        await db.SaveChangesAsync();



                    }
                    MessageBox.Show("Successfully removed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void EditTeacher()
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            int salary = int.Parse(textBox3.Text);

            try
            {


                if (name != null && surname != null)
                {
                    await using (var db = new UniversityContext())
                    {

                        var query = await db.Teachers.SingleOrDefaultAsync(t => t.Name == name && t.Surname == surname);
                        if (query != null)
                        {
                            if (name != null && surname != null)
                                query.Name = name;
                            query.Surname = surname;
                            query.Salary = salary;
                        }


                        await db.SaveChangesAsync();



                    }
                    MessageBox.Show("Successfully edited");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacher();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveTeacher();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditTeacher();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDepartment();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveDepartment();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditDepartment();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddGroup();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RemoveGroup();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EditGroup();
        }
    }
}
