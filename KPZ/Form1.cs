using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPZ
{

    public partial class Form1 : Form
    {
        private System.Windows.Forms.Label BlockName;
        PictureBox pictBox;

        string code;

        int numofvar = 0;
        string[] eq = { };
        int peri0, peri1, peri2, peri3, peri4, peri5 = 0;
        string pers0, pers1, pers2, pers3, pers4, pers5 = "";


        bool ins = true;

        int comp;

        bool i = false;

        int x = 30;
        int y = 30;
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i <1000; i++)
            {
                listBox2.Items.Add("");
            }
        }

        private PictureBox AddNewPictureBox(int x, int y)
        {
            pictBox = new PictureBox();
            pictBox.Location = new Point(x, y);
            pictBox.BackColor = Color.White;
            pictBox.BorderStyle = BorderStyle.FixedSingle;
            pictBox.Width = 90;
            pictBox.Height = 45;
            listBox2.Controls.Add(pictBox);
            return pictBox;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            code = textBox1.Text;
            code = code.Replace(" ", "");
            int l;
            if (code.Contains("=="))
            {
                eq = code.Split('=');
                l = eq.Length;
                if (l == 3)
                {
                    this.BlockName = new System.Windows.Forms.Label();
                    this.BlockName.BackColor = Color.White;
                    this.BlockName.TextAlign = ContentAlignment.MiddleCenter;
                    this.BlockName.Location = new System.Drawing.Point(x + 1, y + 1);
                    this.BlockName.Size = new System.Drawing.Size(88, 43);
                    listBox2.Controls.Add(this.BlockName);
                    BlockName.Text = code;
                    AddNewPictureBox(x, y);
                    y += 70;
                    if (pers0 == eq[0])
                    {
                        if (peri0 == Convert.ToInt32(eq[2]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers1 == eq[0])
                    {
                        if (peri1 == Convert.ToInt32(eq[2]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers2 == eq[0])
                    {
                        if (peri2 == Convert.ToInt32(eq[2]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers3 == eq[0])
                    {
                        if (peri3 == Convert.ToInt32(eq[2]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers4 == eq[0])
                    {
                        if (peri4 == Convert.ToInt32(eq[2]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers5 == eq[0])
                    {
                        if (peri5 == Convert.ToInt32(eq[2]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else
                    {
                        textBox1.Text = "Error";
                    }
                }
                else
                {
                    textBox1.Text = "Error";
                }
            }
            else if (code.Contains("<"))
            {
                eq = code.Split('<');
                l = eq.Length;
                if (l == 2)
                {
                    this.BlockName = new System.Windows.Forms.Label();
                    this.BlockName.BackColor = Color.White;
                    this.BlockName.TextAlign = ContentAlignment.MiddleCenter;
                    this.BlockName.Location = new System.Drawing.Point(x + 1, y + 1);
                    this.BlockName.Size = new System.Drawing.Size(88, 43);
                    listBox2.Controls.Add(this.BlockName);
                    BlockName.Text = code;
                    AddNewPictureBox(x, y);
                    y += 70;
                    if (pers0 == eq[0])
                    {
                        if (peri0 < Convert.ToInt32(eq[1]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers1 == eq[0])
                    {
                        if (peri1 < Convert.ToInt32(eq[1]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers2 == eq[0])
                    {
                        if (peri2 < Convert.ToInt32(eq[1]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers3 == eq[0])
                    {
                        if (peri3 < Convert.ToInt32(eq[1]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers4 == eq[0])
                    {
                        if (peri4 < Convert.ToInt32(eq[1]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else if (pers5 == eq[0])
                    {
                        if (peri5 < Convert.ToInt32(eq[1]))
                        {
                            i = false;
                            x += 30;
                        }
                        else
                        {
                            i = true;
                            x -= 30;
                        }
                    }
                    else
                    {
                        textBox1.Text = "Error";
                    }
                }
                else
                {
                    textBox1.Text = "Error";
                }
            }
            else if (code.Contains("="))
            {
                eq = code.Split('=');
                l = eq.Length;
                if (l == 2)
                {
                    if (!(Int32.TryParse(eq[0], out comp)))
                    {
                        if (!i)
                        {
                            if ((Int32.TryParse(eq[1], out comp)))
                            {
                                if (eq[0] == pers0)
                                {
                                    peri0 = Convert.ToInt32(eq[1]);
                                }
                                else if (eq[0] == pers1)
                                {
                                    peri1 = Convert.ToInt32(eq[1]);
                                }
                                else if (eq[0] == pers2)
                                {
                                    peri2 = Convert.ToInt32(eq[1]);
                                }
                                else if (eq[0] == pers3)
                                {
                                    peri3 = Convert.ToInt32(eq[1]);
                                }
                                else if (eq[0] == pers4)
                                {
                                    peri4 = Convert.ToInt32(eq[1]);
                                }
                                else if (eq[0] == pers5)
                                {
                                    peri5 = Convert.ToInt32(eq[1]);
                                }
                                else
                                {
                                    if (numofvar == 0)
                                    {
                                        pers0 = eq[0];
                                        peri0 = Convert.ToInt32(eq[1]);
                                    }
                                    if (numofvar == 1)
                                    {
                                        pers1 = eq[0];
                                        peri1 = Convert.ToInt32(eq[1]);
                                    }
                                    if (numofvar == 2)
                                    {
                                        pers2 = eq[0];
                                        peri2 = Convert.ToInt32(eq[1]);
                                    }
                                    if (numofvar == 3)
                                    {
                                        pers3 = eq[0];
                                        peri3 = Convert.ToInt32(eq[1]);
                                    }
                                    if (numofvar == 4)
                                    {
                                        pers4 = eq[0];
                                        peri4 = Convert.ToInt32(eq[1]);
                                    }
                                    if (numofvar == 5)
                                    {
                                        pers5 = eq[0];
                                        peri5 = Convert.ToInt32(eq[1]);
                                    }
                                    numofvar++;
                                }
                                this.BlockName = new System.Windows.Forms.Label();
                                this.BlockName.BackColor = Color.White;
                                this.BlockName.TextAlign = ContentAlignment.MiddleCenter;
                                this.BlockName.Location = new System.Drawing.Point(x + 1, y + 1);
                                this.BlockName.Size = new System.Drawing.Size(88, 43);
                                listBox2.Controls.Add(this.BlockName);
                                BlockName.Text = code;
                                AddNewPictureBox(x, y);
                                y += 70;
                            }
                            else
                            {
                                if (eq[0] == pers0)
                                {
                                    if (eq[1] == pers1)
                                    {
                                        peri0 = peri1;
                                    }
                                    if (eq[1] == pers2)
                                    {
                                        peri0 = peri2;
                                    }
                                    if (eq[1] == pers3)
                                    {
                                        peri0 = peri3;
                                    }
                                    if (eq[1] == pers4)
                                    {
                                        peri0 = peri4;
                                    }
                                    if (eq[1] == pers5)
                                    {
                                        peri0 = peri5;
                                    }
                                }
                                else if (eq[0] == pers1)
                                {
                                    if (eq[1] == pers0)
                                    {
                                        peri1 = peri0;
                                    }
                                    if (eq[1] == pers2)
                                    {
                                        peri1 = peri2;
                                    }
                                    if (eq[1] == pers3)
                                    {
                                        peri1 = peri3;
                                    }
                                    if (eq[1] == pers4)
                                    {
                                        peri1 = peri4;
                                    }
                                    if (eq[1] == pers5)
                                    {
                                        peri1 = peri5;
                                    }
                                }
                                else if (eq[0] == pers2)
                                {
                                    if (eq[1] == pers1)
                                    {
                                        peri2 = peri1;
                                    }
                                    if (eq[1] == pers0)
                                    {
                                        peri2 = peri0;
                                    }
                                    if (eq[1] == pers3)
                                    {
                                        peri2 = peri3;
                                    }
                                    if (eq[1] == pers4)
                                    {
                                        peri2 = peri4;
                                    }
                                    if (eq[1] == pers5)
                                    {
                                        peri2 = peri5;
                                    }
                                }
                                else if (eq[0] == pers3)
                                {
                                    if (eq[1] == pers1)
                                    {
                                        peri3 = peri1;
                                    }
                                    if (eq[1] == pers2)
                                    {
                                        peri3 = peri2;
                                    }
                                    if (eq[1] == pers0)
                                    {
                                        peri3 = peri0;
                                    }
                                    if (eq[1] == pers4)
                                    {
                                        peri3 = peri4;
                                    }
                                    if (eq[1] == pers5)
                                    {
                                        peri3 = peri5;
                                    }
                                }
                                else if (eq[0] == pers4)
                                {
                                    if (eq[1] == pers1)
                                    {
                                        peri4 = peri1;
                                    }
                                    if (eq[1] == pers2)
                                    {
                                        peri4 = peri2;
                                    }
                                    if (eq[1] == pers3)
                                    {
                                        peri4 = peri3;
                                    }
                                    if (eq[1] == pers0)
                                    {
                                        peri4 = peri0;
                                    }
                                    if (eq[1] == pers5)
                                    {
                                        peri4 = peri5;
                                    }
                                }
                                else if (eq[0] == pers5)
                                {
                                    if (eq[1] == pers1)
                                    {
                                        peri5 = peri1;
                                    }
                                    if (eq[1] == pers2)
                                    {
                                        peri5 = peri2;
                                    }
                                    if (eq[1] == pers3)
                                    {
                                        peri5 = peri3;
                                    }
                                    if (eq[1] == pers4)
                                    {
                                        peri5 = peri4;
                                    }
                                    if (eq[1] == pers0)
                                    {
                                        peri5 = peri0;
                                    }
                                }
                                else
                                {
                                    if (numofvar == 0)
                                    {
                                        if (eq[1] == pers1)
                                        {
                                            pers0 = eq[0];
                                            peri0 = peri1;
                                        }
                                        if (eq[1] == pers2)
                                        {
                                            pers0 = eq[0];
                                            peri0 = peri2;
                                        }
                                        if (eq[1] == pers3)
                                        {
                                            pers0 = eq[0];
                                            peri0 = peri3;
                                        }
                                        if (eq[1] == pers4)
                                        {
                                            pers0 = eq[0];
                                            peri0 = peri4;
                                        }
                                        if (eq[1] == pers5)
                                        {
                                            pers0 = eq[0];
                                            peri0 = peri5;
                                        }
                                    }
                                    if (numofvar == 1)
                                    {
                                        if (eq[1] == pers0)
                                        {
                                            pers1 = eq[0];
                                            peri1 = peri0;
                                        }
                                        if (eq[1] == pers2)
                                        {
                                            pers1 = eq[0];
                                            peri1 = peri2;
                                        }
                                        if (eq[1] == pers3)
                                        {
                                            pers1 = eq[0];
                                            peri1 = peri3;
                                        }
                                        if (eq[1] == pers4)
                                        {
                                            pers1 = eq[0];
                                            peri1 = peri4;
                                        }
                                        if (eq[1] == pers5)
                                        {
                                            pers1 = eq[0];
                                            peri1 = peri5;
                                        }
                                    }
                                    if (numofvar == 2)
                                    {
                                        if (eq[1] == pers1)
                                        {
                                            pers2 = eq[0];
                                            peri2 = peri1;
                                        }
                                        if (eq[1] == pers0)
                                        {
                                            pers2 = eq[0];
                                            peri2 = peri0;
                                        }
                                        if (eq[1] == pers3)
                                        {
                                            pers2 = eq[0];
                                            peri2 = peri3;
                                        }
                                        if (eq[1] == pers4)
                                        {
                                            pers2 = eq[0];
                                            peri2 = peri4;
                                        }
                                        if (eq[1] == pers5)
                                        {
                                            pers2 = eq[0];
                                            peri2 = peri5;
                                        }
                                    }
                                    if (numofvar == 3)
                                    {
                                        listBox1.Items.Add(eq[0] + eq[1] + pers1 + peri1);
                                        if (eq[1] == pers1)
                                        {
                                            pers3 = eq[0];
                                            peri3 = peri1;
                                        }
                                        if (eq[1] == pers2)
                                        {
                                            pers3 = eq[0];
                                            peri3 = peri2;
                                        }
                                        if (eq[1] == pers0)
                                        {
                                            pers3 = eq[0];
                                            peri3 = peri0;
                                        }
                                        if (eq[1] == pers4)
                                        {
                                            pers3 = eq[0];
                                            peri3 = peri4;
                                        }
                                        if (eq[1] == pers5)
                                        {
                                            pers3 = eq[0];
                                            peri3 = peri5;
                                        }
                                    }
                                    if (numofvar == 4)
                                    {
                                        if (eq[1] == pers1)
                                        {
                                            pers4 = eq[0];
                                            peri4 = peri1;
                                        }
                                        if (eq[1] == pers2)
                                        {
                                            pers4 = eq[0];
                                            peri4 = peri2;
                                        }
                                        if (eq[1] == pers3)
                                        {
                                            pers4 = eq[0];
                                            peri4 = peri3;
                                        }
                                        if (eq[1] == pers0)
                                        {
                                            pers4 = eq[0];
                                            peri4 = peri0;
                                        }
                                        if (eq[1] == pers5)
                                        {
                                            pers4 = eq[0];
                                            peri4 = peri5;
                                        }
                                    }
                                    if (numofvar == 5)
                                    {
                                        if (eq[1] == pers1)
                                        {
                                            pers5 = eq[0];
                                            peri5 = peri1;
                                        }
                                        if (eq[1] == pers2)
                                        {
                                            pers5 = eq[0];
                                            peri5 = peri2;
                                        }
                                        if (eq[1] == pers3)
                                        {
                                            pers5 = eq[0];
                                            peri5 = peri3;
                                        }
                                        if (eq[1] == pers4)
                                        {
                                            pers5 = eq[0];
                                            peri5 = peri4;
                                        }
                                        if (eq[1] == pers0)
                                        {
                                            pers5 = eq[0];
                                            peri5 = peri0;
                                        }
                                    }
                                    numofvar++;
                                }
                                this.BlockName = new System.Windows.Forms.Label();
                                this.BlockName.BackColor = Color.White;
                                this.BlockName.TextAlign = ContentAlignment.MiddleCenter;
                                this.BlockName.Location = new System.Drawing.Point(x + 1, y + 1);
                                this.BlockName.Size = new System.Drawing.Size(88, 43);
                                listBox2.Controls.Add(this.BlockName);
                                BlockName.Text = code;
                                AddNewPictureBox(x, y);
                                y += 70;
                            }
                        }
                        else
                        {
                            this.BlockName = new System.Windows.Forms.Label();
                            this.BlockName.BackColor = Color.White;
                            this.BlockName.TextAlign = ContentAlignment.MiddleCenter;
                            this.BlockName.Location = new System.Drawing.Point(x + 1, y + 1);
                            this.BlockName.Size = new System.Drawing.Size(88, 43);
                            listBox2.Controls.Add(this.BlockName);
                            BlockName.Text = code;
                            AddNewPictureBox(x, y);
                            i = false;
                            y += 70;
                        }
                    }
                    else
                    {
                        textBox1.Text = "Error";
                    }
                }
                else
                {
                    textBox1.Text = "Error";
                }
            }
            else if (code.Contains("print"))
            {
                this.BlockName = new System.Windows.Forms.Label();
                this.BlockName.BackColor = Color.White;
                this.BlockName.TextAlign = ContentAlignment.MiddleCenter;
                this.BlockName.Location = new System.Drawing.Point(x + 1, y + 1);
                this.BlockName.Size = new System.Drawing.Size(88, 43);
                listBox2.Controls.Add(this.BlockName);
                BlockName.Text = code;
                AddNewPictureBox(x, y);
                y += 70;

                code = code.Replace("print", "");
                if (code == "")
                {

                }
                else
                {
                    if (!i)
                    {
                        if (String.Compare(code, pers0) == 0)
                        {
                            listBox1.Items.Add(peri0);
                        }
                        if (String.Compare(code, pers1) == 0)
                        {
                            listBox1.Items.Add(peri1);
                        }
                        if (String.Compare(code, pers2) == 0)
                        {
                            listBox1.Items.Add(peri2);
                        }
                        if (String.Compare(code, pers3) == 0)
                        {
                            listBox1.Items.Add(peri3);
                        }
                        if (String.Compare(code, pers4) == 0)
                        {
                            listBox1.Items.Add(peri4);
                        }
                        if (String.Compare(code, pers5) == 0)
                        {
                            listBox1.Items.Add(peri5);
                        }
                    }
                    else
                    {
                        i = false;
                    }
                }

            }
            else if (code.Contains("input"))
            {
                this.BlockName = new System.Windows.Forms.Label();
                this.BlockName.BackColor = Color.White;
                this.BlockName.TextAlign = ContentAlignment.MiddleCenter;
                this.BlockName.Location = new System.Drawing.Point(x + 1, y + 1);
                this.BlockName.Size = new System.Drawing.Size(88, 43);
                listBox2.Controls.Add(this.BlockName);
                BlockName.Text = code;
                AddNewPictureBox(x, y);
                y += 70;
                code = code.Replace("input", "");
                if (code == "")
                {

                }
                else
                {
                    if (!i)
                    {
                        ins = true;
                        button1.Visible = false;
                        label3.Visible = true;
                    }
                    else
                    {
                        i = false;
                    }
                }
            }
            
            textBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            if (ins)
            {
                if ((Int32.TryParse(textBox2.Text, out comp)))
                {

                    if (pers0 == code)
                    {
                        peri0 = Convert.ToInt32(textBox2.Text);
                    }
                    else if (pers1 == code)
                    {
                        peri1 = Convert.ToInt32(textBox2.Text);
                    }
                    else if (pers2 == code)
                    {
                        peri2 = Convert.ToInt32(textBox2.Text);
                    }
                    else if (pers3 == code)
                    {
                        peri3 = Convert.ToInt32(textBox2.Text);
                    }
                    else if (pers4 == code)
                    {
                        peri4 = Convert.ToInt32(textBox2.Text);
                    }
                    else if (pers5 == code)
                    {
                        peri5 = Convert.ToInt32(textBox2.Text);
                    }
                    else
                    {
                        if (numofvar == 0)
                        {
                            pers0 = code;
                            peri0 = Convert.ToInt32(textBox2.Text);
                        }
                        if (numofvar == 1)
                        {
                            pers1 = code;
                            peri1 = Convert.ToInt32(textBox2.Text);
                        }
                        if (numofvar == 2)
                        {
                            pers2 = code;
                            peri2 = Convert.ToInt32(textBox2.Text);
                        }
                        if (numofvar == 3)
                        {
                            pers3 = code;
                            peri3 = Convert.ToInt32(textBox2.Text);
                        }
                        if (numofvar == 4)
                        {
                            pers4 = code;
                            peri4 = Convert.ToInt32(textBox2.Text);
                        }
                        if (numofvar == 5)
                        {
                            pers5 = code;
                            peri5 = Convert.ToInt32(textBox2.Text);
                        }
                        numofvar++;
                    }
                    button1.Visible = true;
                    label3.Visible = false;
                    ins = false;
                }
            }
            textBox2.Text = "";
        }

    }
}
