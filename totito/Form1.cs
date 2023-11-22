using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace totito
{
    public partial class Form1 : Form
    {
        string jugador1 = "";
        string jugador2 = "";
        
        public Form1()
        {
            InitializeComponent();
            panel4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Juego();
        }

        public void Juego()
        {
            jugador1 = textBox1.Text;
            jugador2 = textBox2.Text;

            Random rndFigura = new Random();
            int figura = rndFigura.Next(2);

            Random rndJugador = new Random();
            int jugador = rndJugador.Next(2);

            if (jugador == 0)
            {
                label5.Text = jugador1;
                label6.Text = jugador2;
            }
            else
            {
                label6.Text = jugador1;
                label5.Text = jugador2;
            }

            if (figura == 0)
            {
                label9.Text = "X";
                label8.Text = "O";
                turno(1);
            }
            else
            {
                label8.Text = "X";
                label9.Text = "O";
                turno(2);
            }

            panel1.Visible = false;
            panel4.Visible = true;

            if (label19.Text == "Turno")
            {
                label15.Text = label9.Text;
            }
            else {
                label15.Text = label8.Text;
             }
        }

        public void turno (int valor)
        {
            if (valor == 1)
            {
                label19.Text = "Turno";
                label18.Text = "";
                label19.Font = new System.Drawing.Font(label19.Font, FontStyle.Bold);
            }
            else {
                label18.Text = "Turno";
                label19.Text = "";
                label18.Font = new System.Drawing.Font(label18.Font, FontStyle.Bold);
            }
        }

        public void cambioTurno()
        {
            if (label19.Text == "Turno")
            {
                label18.Text = "Turno";
                label19.Text = "";
                label15.Text = label8.Text;
            }
            else
            {
                label19.Text = "Turno";
                label18.Text = "";
                label15.Text = label9.Text;
            }
        }

        public void ganador()
        {
            if (button2.Text == "X" && button4.Text == "X" && button3.Text == "X")
            {
                label20.Text = "ganador";
                
            }
            else
            {
                label20.Text = "";
            }
        }
    
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = label15.Text;
            cambioTurno();
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = label15.Text;
            cambioTurno();
            button4.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = label15.Text;
            cambioTurno();
            button3.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = label15.Text;
            cambioTurno();
            button7.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = label15.Text;
            cambioTurno();
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = label15.Text;
            cambioTurno();
            button5.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = label15.Text;
            cambioTurno();
            button10.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = label15.Text;
            cambioTurno();
            button9.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = label15.Text;
            cambioTurno();
            button8.Enabled = false;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {
            ganador();
        }
    }
}