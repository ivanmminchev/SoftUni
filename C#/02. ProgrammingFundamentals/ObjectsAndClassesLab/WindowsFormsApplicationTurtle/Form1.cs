﻿using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationTurtle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.Delay = (200);
            Turtle.Forward(100);
            Turtle.Rotate(120);
            Turtle.Forward(100);
            Turtle.Rotate(120);
            Turtle.Forward(100);
            Turtle.Rotate(120);
        }
    }
} 
