﻿using System;
using System.Windows.Forms;

namespace Swap
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        Elephant elephantSaver;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant(){Name = "Lucinda", EarSize = 33};
            lloyd = new Elephant(){Name = "Lloyd", EarSize = 40};
        }

        private void Lloyd_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void Lucinda_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void Swap_Click(object sender, EventArgs e)
        {
            //Elephant holder;
            //holder = lloyd;
            //lloyd = lucinda;
            //lucinda = holder;
            if (elephantSaver == null)
            {
                elephantSaver = lucinda;
                lucinda = lloyd;
                lloyd = elephantSaver;
            }
            else
            {
                lloyd = lucinda;
                lucinda = lloyd;
                lucinda = elephantSaver;
            }
        }

        private void Talk_Click(object sender, EventArgs e)
        {
            lloyd.SpeakTo(lucinda, "What's up");
        }
    }
}
