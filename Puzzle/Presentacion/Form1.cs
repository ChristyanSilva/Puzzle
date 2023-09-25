using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button16, button12, button15);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button15, button11, button14, button16);
        }

        public void MovimientodelBoton(Button botoncentral, Button movimiento1, Button movimiento2)
        {
            if (movimiento1.Text == "*")
            {
                movimiento1.Text = botoncentral.Text;
                botoncentral.Text = "*";
            }
            else
            {
                if (movimiento2.Text == "*")
                {
                    movimiento2.Text = botoncentral.Text;
                    botoncentral.Text = "*";
                }
            }
        }
        public void MovimientodelBoton(Button botoncentral, Button movimiento1, Button movimiento2, Button movimiento3)
        {
            if (movimiento1.Text == "*")
            {
                movimiento1.Text = botoncentral.Text;
                botoncentral.Text = "*";
            }
            else
            {
                if (movimiento2.Text == "*")
                {
                    movimiento2.Text = botoncentral.Text;
                    botoncentral.Text = "*";
                }
                else
                {
                    if (movimiento3.Text== "*")
                    {
                        movimiento3.Text = botoncentral.Text;
                        botoncentral.Text = "*";
                    }
                }
            }
        }
        public void MovimientodelBoton(Button botoncentral, Button movimiento1, Button movimiento2, Button movimiento3, Button movimiento4)
        {
            if (movimiento1.Text == "*")
            {
                movimiento1.Text = botoncentral.Text;
                botoncentral.Text = "*";
            }
            else
            {
                if (movimiento2.Text == "*")
                {
                    movimiento2.Text = botoncentral.Text;
                    botoncentral.Text = "*";
                }
                else
                {
                    if (movimiento3.Text == "*")
                    {
                        movimiento3.Text = botoncentral.Text;
                        botoncentral.Text = "*";
                    }
                    else
                    {
                        if (movimiento4.Text == "*")
                        {
                            if (movimiento4.Text == "*")
                            {
                                movimiento4.Text = botoncentral.Text;
                                botoncentral.Text = "*";
                            }
                        }
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button14, button10, button13, button15);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button13, button9, button14);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button12, button8, button11, button16);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button11, button7, button10, button12, button15);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button10, button6, button9, button11, button14);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button9, button5, button10, button13);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button8, button4, button7, button12);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button7, button3, button6, button8, button11);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button6, button2, button5, button7, button10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button5, button1, button6, button9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button4, button3, button8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button3, button2, button4, button7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button2, button1, button3, button6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovimientodelBoton(button1, button2, button5);
        }
    }
}
