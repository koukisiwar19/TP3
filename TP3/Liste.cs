using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Liste1.Items.Add(txtSaisie.Text.ToString());
            if(Liste1.Items.Count !=0)
            {
                BtEff1.Enabled = true;
            }
            if (List2.Items.Count !=0)
            {
                BtEff2.Enabled = true;
            }
            txtSaisie.Text = "";
        }

        private void txtSaisie_TextChanged(object sender, EventArgs e)
        {
            btAdd.Enabled = true;
        }

        private void btEffall1_Click(object sender, EventArgs e)
        {
           Liste1.Items.Clear();
        }

        private void btEffall2_Click(object sender, EventArgs e)
        {
            List2.Items.Clear();
        }

        private void BtEff1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<Liste1.SelectedItems.Count; i++)
            {
                Liste1.Items.Remove(Liste1.SelectedItems[i]);
            }
        }

        private void BtEff2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < List2.SelectedItems.Count; i++)
            {
                Liste1.Items.Remove(List2.SelectedItems[i]);
            }
        }

        private void btTo2_Click(object sender, EventArgs e)
        {
            
                List2.Items.Add(Liste1.SelectedItem);
                Liste1.Items.Remove(Liste1.SelectedItem);
                if (List2.Items.Count != 0)
                {
                    btEffall2.Enabled = true;
                    btEffall2.Enabled = true;


                
            }
        
        }

        private void btTo1_Click(object sender, EventArgs e)
        {
            Liste1.Items.Add(List2.SelectedItem);
            List2.Items.Remove(List2.SelectedItem);
            if (Liste1.Items.Count !=0)
            {
                btEffall1.Enabled = true;
                BtEff1.Enabled = true;

            }
        }

        private void btAllto2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Liste1.SelectedItems.Count; i++)
            {
                List2.Items.Add(Liste1.SelectedItems[i]);
                Liste1.Items.Remove(Liste1.SelectedItems[i]);
                if (List2.Items.Count != 0)
                {
                    btEffall2.Enabled = true;
                    BtEff2.Enabled = true;

                }
            }
        }

        private void btAllto1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < List2.SelectedItems.Count; i++)
            {
                Liste1.Items.Add(List2.SelectedItems[i]);
                List2.Items.Remove(List2.SelectedItems[i]);
                if (Liste1.Items.Count != 0)
                {
                    btEffall1.Enabled = true;
                    BtEff1.Enabled=true;
                }
            }

        }
        private void List2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(List2.Items.Count !=0)
            {
                btAllto1.Enabled = true;
                btTo1.Enabled = true;
            }
           
        }

        private void Liste1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void Liste1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Liste1.Items.Count != 0)
            {
                btTo2.Enabled = true;
                btAllto2.Enabled = true;
            }
        }
    };

    }

