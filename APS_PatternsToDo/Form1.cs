using APS_PatternsToDo.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS_PatternsToDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //TODO: delete this
            PlainBlock labelBlock = new PlainBlock();
            labelBlock.SetForm(this);
            labelBlock.InitBlock(0);
            labelBlock.RenderItem();
        }


    }
}
