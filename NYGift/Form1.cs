using System;
using NYGift.Classes;
using NYGift.Enum;
using NYGift.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;


using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYGift
{
    public partial class Form1 : Form
    {
        private INYGift _gift;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var temp = _gift.SortSweetnessByWeight();
            int j = 0;
            foreach ( var i in temp)
            {
                listBox1.Items.Insert(j, String.Format("Name:{0}," + "SugarPerUnit: {1}", i.Name, i.SugarPerUnit));
            }
        }

        private void buttoninfo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int j = 0;
            foreach (var i in _gift.Items)
            {
               
                listBox1.Items.Insert(j, String.Format("{0},{1}", i.TypeOfSweetness, i.ItemInfo));
                j++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            _gift = new Gift("Gift", new List<ISweetness>());
            Candy candy = new Candy("bears in raspberry", 10, 45, 300, TypeOfCandies.Caramel);
            Candy candy2 = new Candy("crazy bee", 6, 60, 250, TypeOfCandies.Zhele);
            Candy candy3 = new Candy("up", 5, 20, 220,TypeOfCandies.Lollipop);
            Candy candy4 = new Candy("chupa chups", 20, 70, 150, TypeOfCandies.Lollipop);
            Candy candy5 = new Candy("cow", 10, 80, 500, TypeOfCandies.Caramel);
            Candy candy6 = new Candy("bears in raspberry", 10, 45, 300, TypeOfCandies.Caramel);
            Chocolate chocolate = new Chocolate("alpen gold", 100, 40, 540, TypeOfChocolate.Milk);
            _gift.AddSweet(candy);
            _gift.AddSweet(candy2);
            _gift.AddSweet(candy3);
            _gift.AddSweet(candy4);
            _gift.AddSweet(candy5);
            _gift.AddSweet(candy6);
            _gift.AddSweet(chocolate);
        }



        private void buttonfind_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int j = 0;
            double min=Convert.ToDouble (textBox5.Text);
            double max= Convert.ToDouble(textBox6.Text);
            foreach (var i in _gift.FindSweetnessBySugar(min,max))
            {

                listBox1.Items.Insert(j, String.Format("{0},{1}", i.TypeOfSweetness, i.ItemInfo));
                j++;
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {

        }

       
    }
}
