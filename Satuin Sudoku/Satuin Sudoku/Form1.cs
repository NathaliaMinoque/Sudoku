using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satuin_Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            //Ini codingan bikin textbox array
            var soal = new TextBox[3, 3];

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var tbox = new TextBox();
                    tbox.Name = "Soal" + i + j;
                    tbox.Location = new Point((i+2) * 25, (j+2) * 25);
                    tbox.Visible = true;
                    tbox.Size = new Size(20, 20);
                    tbox.ForeColor = Color.Black;
                    this.Controls.Add(tbox);
                    //tbox.Text = "";
                    tbox = soal[i,j];
                }
            }

            soal[0, 0].Text = "1";
            soal[0, 1].Text = "2";
            soal[0, 2].Text = "3";
            soal[1, 0].Text = "4";
            soal[1, 1].Text = "5";
            soal[1, 2].Text = "6";
            soal[2, 0].Text = "7";
            soal[2, 1].Text = "8";
            soal[2, 2].Text = "9";

            //check kolom
            int cekkembar = 0;
            for (int baris = 0; baris < 3; baris++)
            {
                for (int kolom = 0; kolom < 3; kolom++)
                {
                    for (int counter = 3; counter < 3; counter++)
                    {
                        if (soal[baris, kolom] == soal[baris, counter])
                        {
                            cekkembar++;
                        }                      
                        if (cekkembar > 1)
                        {
                            soal[baris, kolom].ForeColor = Color.Red;
                            soal[baris, counter].ForeColor = Color.Red;
                        }
                    }
                }
            }
        }       
    }
}
