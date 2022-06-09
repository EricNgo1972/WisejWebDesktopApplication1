
using System;
using System.Collections.Generic;
using Wisej.Web;

namespace WisejWebDesktopApplication1
{
	public partial class Window1 : Form
	{
		public Window1()
		{
			InitializeComponent();
            
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = Person.GetSampleData();
        }
        
        
	}

    class Person
    {

        public static List<Person> GetSampleData()
        {
            var ret = new List<Person>();

            for (int i = 0; i < 1000; i++)
            {
                ret.Add(new Person() { Name = $"Person no {i}", PersonId = $"{i:000}" });
            }

            return ret;
        }

        public string PersonId { get; set; }
        
        public string Name { get; set; } 
         

    }
}
