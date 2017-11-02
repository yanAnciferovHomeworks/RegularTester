using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string RegEx = RegularText.Text;
                string Text = TextBox.Text;

                Result.Items.Clear();

                foreach (var item in Regex.Matches(Text, RegEx))
                {
                    Result.Items.Add(item);
                }
            }
            catch (Exception)
            {
                
                
            }
           
            
            
        }

    }


}
