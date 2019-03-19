using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DealOrNoDeal
{
    public partial class HighscoreForm : Form
    {
        
        public HighscoreForm()
        {
            InitializeComponent();
        }

        private void HighscoreForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("highscore.txt",FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        tbHighscore.Text += line + Environment.NewLine;
                        
                    }
                    tbHighscore.Lines = tbHighscore.Lines.OrderBy(line => line).ToArray();
                }
            }
            
        }
    }
}
