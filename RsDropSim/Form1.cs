using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RsDropSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        public void bandosRoller()
        {
            listBox1.Items.Clear();

            List<Drops> itemTassets = new List<Drops>();
            List<Drops> itemChestplate = new List<Drops>();
            List<Drops> itemBoots = new List<Drops>();
            List<Drops> itemHilt = new List<Drops>();
            List<Drops> itemPet = new List<Drops>();

            Drops bandosTassets = new Drops("Bandos Tassets", 27275614);
            Drops bandosChestplate = new Drops("Bandos Chestplate", 18933772);
            Drops bandosBoots = new Drops("Bandos Boots", 180791);
            Drops bandosHilt = new Drops("Bandos Hilt", 9694593);
            Drops bandosPet = new Drops("Pet general graardor");

            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter the amount of kills");
                textBox1.Focus();
            }
            else
            {
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    var armor = rnd.Next(1, 382);
                    var hilt = rnd.Next(1, 509);
                    var pet = rnd.Next(1, 5001);
                    //armor rolls
                    if (armor == 1)
                    {
                        itemTassets.Add(bandosTassets);
                    }
                    else if (armor == 2)
                    {
                        itemChestplate.Add(bandosChestplate);
                    }
                    else if (armor == 3)
                    {
                        itemBoots.Add(bandosBoots);
                    }

                    if (hilt == 1)
                    {
                        itemHilt.Add(bandosHilt);
                    }

                    if (pet == 1)
                    {
                        itemPet.Add(bandosPet);
                    }
                }
                listBox1.Items.Add("You have received x" + itemTassets.Count + " Bandos Tassets");
                listBox1.Items.Add("You have received x" + itemChestplate.Count + " Bandos Chestplate");
                listBox1.Items.Add("You have received x" + itemBoots.Count + " Bandos Boots");
                listBox1.Items.Add("You have received x" + itemHilt.Count + " Bandos hilt");
                listBox1.Items.Add("You have received x" + itemPet.Count + " Pet general graador");
            }
            uint sumOfTassets = 0;
            uint sumOfChestplates = 0;
            uint sumOfBoots = 0;
            uint sumofHilts = 0;

            //adding values in each list of each item, then summing total
            foreach (var item in itemTassets)
            {
                sumOfTassets += bandosTassets.value;
            }
            foreach (var item in itemChestplate)
            {
                sumOfChestplates += bandosChestplate.value;
            }
            foreach (var item in itemBoots)
            {
                sumOfBoots += bandosBoots.value;
            }
            foreach (var item in itemHilt)
            {
                sumofHilts += bandosHilt.value;
            }
            uint sumOfTotal = sumOfTassets + sumofHilts + sumOfChestplates + sumOfBoots;

            if (textBox1.Text != "")
            {
                listBox1.Items.Add("You have earned " + string.Format("{0:n0}", sumOfTotal) + " gp!");
            }

        }

        public void saradominRoller()
        {
            Drops ACB = new Drops("Armadyl Crossbow", 25356319);
            Drops Hilt = new Drops("Saradomin Hilt", 41065566);
            Drops Pet = new Drops("Pet Zilyana");

            List<Drops> armadylCrossbow = new List<Drops>();
            List<Drops> saraHilt = new List<Drops>();
            List<Drops> petZilyana = new List<Drops>();

            uint acbSum = 0;
            uint hiltSum = 0;

            if (textBox1.Text == "")
            {
                MessageBox.Show("How many kills?");
                textBox1.Focus();
            }
            else
            {
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    int unique = rnd.Next(1, 512);
                    int pet = rnd.Next(1, 5000);

                    if (unique == 1)
                    {
                        armadylCrossbow.Add(ACB);
                    }
                    else if (unique == 2)
                    {
                        saraHilt.Add(Hilt);
                    }

                    if (pet == 1)
                    {
                        petZilyana.Add(Pet);
                    }
                }
            }

            foreach(Drops cbow in armadylCrossbow)
            {
                acbSum += ACB.value;
            }
            foreach(Drops hilt in saraHilt)
            {
                hiltSum += Hilt.value;
            }

            uint totalValue = acbSum + hiltSum;

            if (textBox1.Text != "")
            {
                listBox1.Items.Add("You have received x" + armadylCrossbow.Count + " Armadyl Crossbow");
                listBox1.Items.Add("You have received x" + saraHilt.Count + " Saradomin Hilt");
                listBox1.Items.Add("You have received x" + petZilyana.Count + " Pet Zilyana");
                listBox1.Items.Add("You have earned " + string.Format("{0:n0}", totalValue) + " gp!");
            }

        }

        public void zamorakRoller()
        {
            Drops zamorakianSpear = new Drops("Zamorakian Spear", 16633167);
            Drops zamorakHilt = new Drops("Zamorak Hilt", 2934022);
            Drops zamorakPet = new Drops("Pet K'ril Tsutsaroth");

            List<Drops> Spear = new List<Drops>();
            List<Drops> Hilt = new List<Drops>();
            List<Drops> Pet = new List<Drops>();

            uint spearValue = 0;
            uint hiltValue = 0;

            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                int spearRoll = rnd.Next(1, 127);
                int hiltRoll = rnd.Next(1, 508);
                int petRoll = rnd.Next(1, 5000);

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter amount of kills");
                }
                else
                {
                    if (spearRoll == 1)
                    {
                        Spear.Add(zamorakianSpear);
                    }
                    if (hiltRoll == 1)
                    {
                        Hilt.Add(zamorakHilt);
                    }
                    if (petRoll == 1)
                    {
                        Pet.Add(zamorakPet);
                    }
                }
            }

            foreach(var item in Spear)
            {
                spearValue += zamorakianSpear.value;
            }
            foreach (var item in Hilt)
            {
                hiltValue += zamorakHilt.value;
            }
            listBox1.Items.Add("You have received x" + Spear.Count + " Zamorakian Spear");
            listBox1.Items.Add("You have received x" + Hilt.Count + " Zamorakian Hilt");
            listBox1.Items.Add("You have received x" + Pet.Count + "Pet k'ril tsutaroth");
            listBox1.Items.Add("You have received " + string.Format("{0:n0}", (spearValue + hiltValue)) + "gp!");
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                bandosRoller();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                saradominRoller();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                zamorakRoller();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Text = "";
            textBox1.Text = "";
        }
    }
}
