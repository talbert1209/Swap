﻿using System.Windows.Forms;

namespace Swap
{
    public class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI()
        {
            MessageBox.Show($@"My ears are {EarSize} inches tall", $@"{Name} says...");
        }
    }
}