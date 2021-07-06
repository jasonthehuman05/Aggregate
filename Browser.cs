﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aggregate
{
    public partial class Browser : Form
    {
        public Browser(string url)
        {
            InitializeComponent();

            browserControl.Source = new Uri(url);
        }
    }
}
