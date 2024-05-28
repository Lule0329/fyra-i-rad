using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fyra_i_rad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int A = 1;
        int B = 1;
        int C = 1;  
        int D = 1;
        int E = 1;
        int F = 1;
        int G = 1;
        bool turn = false;

        private void CheckWin()
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
            // Kolumn A  \/
            if (sender == A1 || sender == A2 || sender == A3 || sender == A4 || sender == A5 || sender == A6) // kollar om knappen man trycker på är i A-kolumnen
            {
                if (A == 1)
                {
                    A1.Enabled = false;
                    if (turn == false)
                    {
                        A1.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        A1.BackColor = Color.Green;
                        turn = false;
                    }
                    A++;
                }
                else if (A == 2)
                {
                    A2.Enabled = false;
                    if (turn == false)
                    {
                        A2.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        A2.BackColor = Color.Green;
                        turn = false;
                    }
                    A++;
                }
                else if (A == 3)
                {
                    A3.Enabled = false;
                    if (turn == false)
                    {
                        A3.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        A3.BackColor = Color.Green;
                        turn = false;
                    }
                    A++;
                }
                else if (A == 4)
                {
                    A4.Enabled = false;
                    if (turn == false)
                    {
                        A4.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        A4.BackColor = Color.Green;
                        turn = false;
                    }
                    A++;
                }
                else if (A == 5)
                {
                    A5.Enabled = false;
                    if (turn == false)
                    {
                        A5.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        A5.BackColor = Color.Green;
                        turn = false;
                    }
                    A++;
                }
                else if (A == 6)
                {
                    A6.Enabled = false;
                    if (turn == false)
                    {
                        A6.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        A6.BackColor = Color.Green;
                        turn = false;
                    }
                    A++;
                }
            }

            // Kolumn B  \/
            if (sender == B1 || sender == B2 || sender == B3 || sender == B4 || sender == B5 || sender == B6)
            {
                if (B == 1)
                {
                    B1.Enabled = false;
                    if (turn == false)
                    {
                        B1.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        B1.BackColor = Color.Green;
                        turn = false;
                    }
                    B++;
                }
                else if (B == 2)
                {
                    B2.Enabled = false;
                    if (turn == false)
                    {
                        B2.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        B2.BackColor = Color.Green;
                        turn = false;
                    }
                    B++;
                }
                else if (B == 3)
                {
                    B3.Enabled = false;
                    if (turn == false)
                    {
                        B3.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        B3.BackColor = Color.Green;
                        turn = false;
                    }
                    B++;
                }
                else if (B == 4)
                {
                    B4.Enabled = false;
                    if (turn == false)
                    {
                        B4.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        B4.BackColor = Color.Green;
                        turn = false;
                    }
                    B++;
                }
                else if (B == 5)
                {
                    B5.Enabled = false;
                    if (turn == false)
                    {
                        B5.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        B5.BackColor = Color.Green;
                        turn = false;
                    }
                    B++;
                }
                else if (B == 6)
                {
                    B6.Enabled = false;
                    if (turn == false)
                    {
                        B6.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        B6.BackColor = Color.Green;
                        turn = false;
                    }
                    B++;
                }
            }

            // Kolumn C  \/
            if (sender == C1 || sender == C2 || sender == C3 || sender == C4 || sender == C5 || sender == C6)
            {
                if (C == 1)
                {
                    C1.Enabled = false;
                    if (turn == false)
                    {
                        C1.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        C1.BackColor = Color.Green;
                        turn = false;
                    }
                    C++;
                }
                else if (C == 2)
                {
                    C2.Enabled = false;
                    if (turn == false)
                    {
                        C2.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        C2.BackColor = Color.Green;
                        turn = false;
                    }
                    C++;
                }
                else if (C == 3)
                {
                    C3.Enabled = false;
                    if (turn == false)
                    {
                        C3.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        C3.BackColor = Color.Green;
                        turn = false;
                    }
                    C++;
                }
                else if (C == 4)
                {
                    C4.Enabled = false;
                    if (turn == false)
                    {
                        C4.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        C4.BackColor = Color.Green;
                        turn = false;
                    }
                    C++;
                }
                else if (C == 5)
                {
                    C5.Enabled = false;
                    if (turn == false)
                    {
                        C5.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        C5.BackColor = Color.Green;
                        turn = false;
                    }
                    C++;
                }
                else if (C == 6)
                {
                    C6.Enabled = false;
                    if (turn == false)
                    {
                        C6.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        C6.BackColor = Color.Green;
                        turn = false;
                    }
                    C++;
                }
            }

            // Kolumn D  \/
            if (sender == D1 || sender == D2 || sender == D3 || sender == D4 || sender == D5 || sender == D6)
            {
                if (D == 1)
                {
                    D1.Enabled = false;
                    if (turn == false)
                    {
                        D1.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        D1.BackColor = Color.Green;
                        turn = false;
                    }
                    D++;
                }
                else if (D == 2)
                {
                    D2.Enabled = false;
                    if (turn == false)
                    {
                        D2.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        D2.BackColor = Color.Green;
                        turn = false;
                    }
                    D++;
                }
                else if (D == 3)
                {
                    D3.Enabled = false;
                    if (turn == false)
                    {
                        D3.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        D3.BackColor = Color.Green;
                        turn = false;
                    }
                    D++;
                }
                else if (D == 4)
                {
                    D4.Enabled = false;
                    if (turn == false)
                    {
                        D4.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        D4.BackColor = Color.Green;
                        turn = false;
                    }
                    D++;
                }
                else if (D == 5)
                {
                    D5.Enabled = false;
                    if (turn == false)
                    {
                        D5.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        D5.BackColor = Color.Green;
                        turn = false;
                    }
                    D++;
                }
                else if (D == 6)
                {
                    D6.Enabled = false;
                    if (turn == false)
                    {
                        D6.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        D6.BackColor = Color.Green;
                        turn = false;
                    }
                    D++;
                }
            }

            // Kolumn E  \/
            if (sender == E1 || sender == E2 || sender == E3 || sender == E4 || sender == E5 || sender == E6)
            {
                if (E == 1)
                {
                    E1.Enabled = false;
                    if (turn == false)
                    {
                        E1.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        E1.BackColor = Color.Green;
                        turn = false;
                    }
                    E++;
                }
                else if (E == 2)
                {
                    E2.Enabled = false;
                    if (turn == false)
                    {
                        E2.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        E2.BackColor = Color.Green;
                        turn = false;
                    }
                    E++;
                }
                else if (E == 3)
                {
                    E3.Enabled = false;
                    if (turn == false)
                    {
                        E3.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        E3.BackColor = Color.Green;
                        turn = false;
                    }
                    E++;
                }
                else if (E == 4)
                {
                    E4.Enabled = false;
                    if (turn == false)
                    {
                        E4.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        E4.BackColor = Color.Green;
                        turn = false;
                    }
                    E++;
                }
                else if (E == 5)
                {
                    E5.Enabled = false;
                    if (turn == false)
                    {
                        E5.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        E5.BackColor = Color.Green;
                        turn = false;
                    }
                    E++;
                }
                else if (E == 6)
                {
                    E6.Enabled = false;
                    if (turn == false)
                    {
                        E6.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        E6.BackColor = Color.Green;
                        turn = false;
                    }
                    E++;
                }
            }

            // Kolumn F  \/
            if (sender == F1 || sender == F2 || sender == F3 || sender == F4 || sender == F5 || sender == F6)
            {
                if (F == 1)
                {
                    F1.Enabled = false;
                    if (turn == false)
                    {
                        F1.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        F1.BackColor = Color.Green;
                        turn = false;
                    }
                    F++;
                }
                else if (F == 2)
                {
                    F2.Enabled = false;
                    if (turn == false)
                    {
                        F2.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        F2.BackColor = Color.Green;
                        turn = false;
                    }
                    F++;
                }
                else if (F == 3)
                {
                    F3.Enabled = false;
                    if (turn == false)
                    {
                        F3.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        F3.BackColor = Color.Green;
                        turn = false;
                    }
                    F++;
                }
                else if (F == 4)
                {
                    F4.Enabled = false;
                    if (turn == false)
                    {
                        F4.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        F4.BackColor = Color.Green;
                        turn = false;
                    }
                    F++;
                }
                else if (F == 5)
                {
                    F5.Enabled = false;
                    if (turn == false)
                    {
                        F5.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        F5.BackColor = Color.Green;
                        turn = false;
                    }
                    F++;
                }
                else if (F == 6)
                {
                    F6.Enabled = false;
                    if (turn == false)
                    {
                        F6.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        F6.BackColor = Color.Green;
                        turn = false;
                    }
                    F++;
                }
            }

            // Kolumn G  \/
            if (sender == G1 || sender == G2 || sender == G3 || sender == G4 || sender == G5 || sender == G6)
            {
                if (G == 1)
                {
                    G1.Enabled = false;
                    if (turn == false)
                    {
                        G1.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        G1.BackColor = Color.Green;
                        turn = false;
                    }
                    G++;
                }
                else if (G == 2)
                {
                    G2.Enabled = false;
                    if (turn == false)
                    {
                        G2.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        G2.BackColor = Color.Green;
                        turn = false;
                    }
                    G++;
                }
                else if (G == 3)
                {
                    G3.Enabled = false;
                    if (turn == false)
                    {
                        G3.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        G3.BackColor = Color.Green;
                        turn = false;
                    }
                    G++;
                }
                else if (G == 4)
                {
                    G4.Enabled = false;
                    if (turn == false)
                    {
                        G4.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        G4.BackColor = Color.Green;
                        turn = false;
                    }
                    G++;
                }
                else if (G == 5)
                {
                    G5.Enabled = false;
                    if (turn == false)
                    {
                        G5.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        G5.BackColor = Color.Green;
                        turn = false;
                    }
                    G++;
                }
                else if (G == 6)
                {
                    G6.Enabled = false;
                    if (turn == false)
                    {
                        G6.BackColor = Color.Red;
                        turn = true;
                    }
                    else
                    {
                        G6.BackColor = Color.Green;
                        turn = false;
                    }
                    G++;
                }
            }
        }

        private void G6_MouseEnter(object sender, EventArgs e)
        {
            if (sender == A1 || sender == A2 || sender == A3 || sender == A4 || sender == A5 || sender == A6)
            {
                if (A == 1)
                {
                    if (turn ==  false)
                    { A1.BackColor = Color.Red; }
                    else { A1.BackColor = Color.Green; }

                    A2.BackColor = SystemColors.ControlDarkDark;
                    A3.BackColor = SystemColors.ControlDarkDark;
                    A4.BackColor = SystemColors.ControlDarkDark;
                    A5.BackColor = SystemColors.ControlDarkDark;
                    A6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (A == 2)
                {
                    if (turn == false)
                    { A2.BackColor = Color.Red; }
                    else { A2.BackColor = Color.Green; }

                    A3.BackColor = SystemColors.ControlDarkDark;
                    A4.BackColor = SystemColors.ControlDarkDark;
                    A5.BackColor = SystemColors.ControlDarkDark;
                    A6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (A == 3)
                {
                    if (turn == false)
                    { A3.BackColor = Color.Red; }
                    else { A3.BackColor = Color.Green; }

                    A4.BackColor = SystemColors.ControlDarkDark;
                    A5.BackColor = SystemColors.ControlDarkDark;
                    A6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (A == 4)
                {
                    if (turn == false)
                    { A4.BackColor = Color.Red; }
                    else { A4.BackColor = Color.Green; }

                    A5.BackColor = SystemColors.ControlDarkDark;
                    A6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (A == 5)
                {
                    if (turn == false)
                    { A5.BackColor = Color.Red; }
                    else { A5.BackColor = Color.Green; }

                    A6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (A == 6)
                {
                    if (turn == false)
                    { A6.BackColor = Color.Red; }
                    else { A6.BackColor = Color.Green; }
                }
            }

            if (sender == B1 || sender == B2 || sender == B3 || sender == B4 || sender == B5 || sender == B6)
            {
                if (B == 1)
                {
                    if (turn == false)
                    { B1.BackColor = Color.Red; }
                    else { B1.BackColor = Color.Green; }

                    B2.BackColor = SystemColors.ControlDarkDark;
                    B3.BackColor = SystemColors.ControlDarkDark;
                    B4.BackColor = SystemColors.ControlDarkDark;
                    B5.BackColor = SystemColors.ControlDarkDark;
                    B6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (B == 2)
                {
                    if (turn == false)
                    { B2.BackColor = Color.Red; }
                    else { B2.BackColor = Color.Green; }

                    B3.BackColor = SystemColors.ControlDarkDark;
                    B4.BackColor = SystemColors.ControlDarkDark;
                    B5.BackColor = SystemColors.ControlDarkDark;
                    B6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (B == 3)
                {
                    if (turn == false)
                    { B3.BackColor = Color.Red; }
                    else { B3.BackColor = Color.Green; }

                    B4.BackColor = SystemColors.ControlDarkDark;
                    B5.BackColor = SystemColors.ControlDarkDark;
                    B6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (B == 4)
                {
                    if (turn == false)
                    { B4.BackColor = Color.Red; }
                    else { B4.BackColor = Color.Green; }

                    B5.BackColor = SystemColors.ControlDarkDark;
                    B6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (B == 5)
                {
                    if (turn == false)
                    { B5.BackColor = Color.Red; }
                    else { B5.BackColor = Color.Green; }

                    B6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (B == 6)
                {
                    if (turn == false)
                    { B6.BackColor = Color.Red; }
                    else { B6.BackColor = Color.Green; }
                }
            }

            if (sender == C1 || sender == C2 || sender == C3 || sender == C4 || sender == C5 || sender == C6)
            {
                if (C == 1)
                {
                    if (turn == false)
                    { C1.BackColor = Color.Red; }
                    else { C1.BackColor = Color.Green; }

                    C2.BackColor = SystemColors.ControlDarkDark;
                    C3.BackColor = SystemColors.ControlDarkDark;
                    C4.BackColor = SystemColors.ControlDarkDark;
                    C5.BackColor = SystemColors.ControlDarkDark;
                    C6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (C == 2)
                {
                    if (turn == false)
                    { C2.BackColor = Color.Red; }
                    else { C2.BackColor = Color.Green; }

                    C3.BackColor = SystemColors.ControlDarkDark;
                    C4.BackColor = SystemColors.ControlDarkDark;
                    C5.BackColor = SystemColors.ControlDarkDark;
                    C6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (C == 3)
                {
                    if (turn == false)
                    { C3.BackColor = Color.Red; }
                    else { C3.BackColor = Color.Green; }

                    C4.BackColor = SystemColors.ControlDarkDark;
                    C5.BackColor = SystemColors.ControlDarkDark;
                    C6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (C == 4)
                {
                    if (turn == false)
                    { C4.BackColor = Color.Red; }
                    else { C4.BackColor = Color.Green; }

                    C5.BackColor = SystemColors.ControlDarkDark;
                    C6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (C == 5)
                {
                    if (turn == false)
                    { C5.BackColor = Color.Red; }
                    else { C5.BackColor = Color.Green; }

                    C6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (C == 6)
                {
                    if (turn == false)
                    { C6.BackColor = Color.Red; }
                    else { C6.BackColor = Color.Green; }
                }
            }

            if (sender == D1 || sender == D2 || sender == D3 || sender == D4 || sender == D5 || sender == D6)
            {
                if (D == 1)
                {
                    if (turn == false)
                    { D1.BackColor = Color.Red; }
                    else { D1.BackColor = Color.Green; }

                    D2.BackColor = SystemColors.ControlDarkDark;
                    D3.BackColor = SystemColors.ControlDarkDark;
                    D4.BackColor = SystemColors.ControlDarkDark;
                    D5.BackColor = SystemColors.ControlDarkDark;
                    D6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (D == 2)
                {
                    if (turn == false)
                    { D2.BackColor = Color.Red; }
                    else { D2.BackColor = Color.Green; }

                    D3.BackColor = SystemColors.ControlDarkDark;
                    D4.BackColor = SystemColors.ControlDarkDark;
                    D5.BackColor = SystemColors.ControlDarkDark;
                    D6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (D == 3)
                {
                    if (turn == false)
                    { D3.BackColor = Color.Red; }
                    else { D3.BackColor = Color.Green; }

                    D4.BackColor = SystemColors.ControlDarkDark;
                    D5.BackColor = SystemColors.ControlDarkDark;
                    D6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (D == 4)
                {
                    if (turn == false)
                    { D4.BackColor = Color.Red; }
                    else { D4.BackColor = Color.Green; }

                    D5.BackColor = SystemColors.ControlDarkDark;
                    D6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (D == 5)
                {
                    if (turn == false)
                    { D5.BackColor = Color.Red; }
                    else { D5.BackColor = Color.Green; }

                    D6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (D == 6)
                {
                    if (turn == false)
                    { D6.BackColor = Color.Red; }
                    else { D6.BackColor = Color.Green; }
                }
            }

            if (sender == E1 || sender == E2 || sender == E3 || sender == E4 || sender == E5 || sender == E6)
            {
                if (E == 1)
                {
                    if (turn == false)
                    { E1.BackColor = Color.Red; }
                    else { E1.BackColor = Color.Green; }

                    E2.BackColor = SystemColors.ControlDarkDark;
                    E3.BackColor = SystemColors.ControlDarkDark;
                    E4.BackColor = SystemColors.ControlDarkDark;
                    E5.BackColor = SystemColors.ControlDarkDark;
                    E6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (E == 2)
                {
                    if (turn == false)
                    { E2.BackColor = Color.Red; }
                    else { E2.BackColor = Color.Green; }

                    E3.BackColor = SystemColors.ControlDarkDark;
                    E4.BackColor = SystemColors.ControlDarkDark;
                    E5.BackColor = SystemColors.ControlDarkDark;
                    E6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (E == 3)
                {
                    if (turn == false)
                    { E3.BackColor = Color.Red; }
                    else { E3.BackColor = Color.Green; }

                    E4.BackColor = SystemColors.ControlDarkDark;
                    E5.BackColor = SystemColors.ControlDarkDark;
                    E6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (E == 4)
                {
                    if (turn == false)
                    { E4.BackColor = Color.Red; }
                    else { E4.BackColor = Color.Green; }

                    E5.BackColor = SystemColors.ControlDarkDark;
                    E6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (E == 5)
                {
                    if (turn == false)
                    { E5.BackColor = Color.Red; }
                    else { E5.BackColor = Color.Green; }

                    E6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (E == 6)
                {
                    if (turn == false)
                    { E6.BackColor = Color.Red; }
                    else { E6.BackColor = Color.Green; }
                }
            }

            if (sender == F1 || sender == F2 || sender == F3 || sender == F4 || sender == F5 || sender == F6)
            {
                if (F == 1)
                {
                    if (turn == false)
                    { F1.BackColor = Color.Red; }
                    else { F1.BackColor = Color.Green; }

                    F2.BackColor = SystemColors.ControlDarkDark;
                    F3.BackColor = SystemColors.ControlDarkDark;
                    F4.BackColor = SystemColors.ControlDarkDark;
                    F5.BackColor = SystemColors.ControlDarkDark;
                    F6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (F == 2)
                {
                    if (turn == false)
                    { F2.BackColor = Color.Red; }
                    else { F2.BackColor = Color.Green; }

                    F3.BackColor = SystemColors.ControlDarkDark;
                    F4.BackColor = SystemColors.ControlDarkDark;
                    F5.BackColor = SystemColors.ControlDarkDark;
                    F6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (F == 3)
                {
                    if (turn == false)
                    { F3.BackColor = Color.Red; }
                    else { F3.BackColor = Color.Green; }

                    F4.BackColor = SystemColors.ControlDarkDark;
                    F5.BackColor = SystemColors.ControlDarkDark;
                    F6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (F == 4)
                {
                    if (turn == false)
                    { F4.BackColor = Color.Red; }
                    else { F4.BackColor = Color.Green; }

                    F5.BackColor = SystemColors.ControlDarkDark;
                    F6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (F == 5)
                {
                    if (turn == false)
                    { F5.BackColor = Color.Red; }
                    else { F5.BackColor = Color.Green; }

                    F6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (F == 6)
                {
                    if (turn == false)
                    { F6.BackColor = Color.Red; }
                    else { F6.BackColor = Color.Green; }
                }
            }

            if (sender == G1 || sender == G2 || sender == G3 || sender == G4 || sender == G5 || sender == G6)
            {
                if (G == 1)
                {
                    if (turn == false)
                    { G1.BackColor = Color.Red; }
                    else { G1.BackColor = Color.Green; }

                    G2.BackColor = SystemColors.ControlDarkDark;
                    G3.BackColor = SystemColors.ControlDarkDark;
                    G4.BackColor = SystemColors.ControlDarkDark;
                    G5.BackColor = SystemColors.ControlDarkDark;
                    G6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (G == 2)
                {
                    if (turn == false)
                    { G2.BackColor = Color.Red; }
                    else { G2.BackColor = Color.Green; }

                    G3.BackColor = SystemColors.ControlDarkDark;
                    G4.BackColor = SystemColors.ControlDarkDark;
                    G5.BackColor = SystemColors.ControlDarkDark;
                    G6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (G == 3)
                {
                    if (turn == false)
                    { G3.BackColor = Color.Red; }
                    else { G3.BackColor = Color.Green; }

                    G4.BackColor = SystemColors.ControlDarkDark;
                    G5.BackColor = SystemColors.ControlDarkDark;
                    G6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (G == 4)
                {
                    if (turn == false)
                    { G4.BackColor = Color.Red; }
                    else { G4.BackColor = Color.Green; }

                    G5.BackColor = SystemColors.ControlDarkDark;
                    G6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (G == 5)
                {
                    if (turn == false)
                    { G5.BackColor = Color.Red; }
                    else { G5.BackColor = Color.Green; }

                    G6.BackColor = SystemColors.ControlDarkDark;
                }
                else if (G == 6)
                {
                    if (turn == false)
                    { G6.BackColor = Color.Red; }
                    else { G6.BackColor = Color.Green; }
                }
            }
        }
        

        private void G6_MouseLeave(object sender, EventArgs e)
        {
            if (sender == A1 || sender == A2 || sender == A3 || sender == A4 || sender == A5 || sender == A6)
            {
                if (A == 1)
                {
                    A1.BackColor = SystemColors.ControlDark;
                    A2.BackColor = SystemColors.ControlDark;
                    A3.BackColor = SystemColors.ControlDark;
                    A4.BackColor = SystemColors.ControlDark;
                    A5.BackColor = SystemColors.ControlDark;
                    A6.BackColor = SystemColors.ControlDark;
                }
                else if (A == 2)
                {
                    A2.BackColor = SystemColors.ControlDark;
                    A3.BackColor = SystemColors.ControlDark;
                    A4.BackColor = SystemColors.ControlDark;
                    A5.BackColor = SystemColors.ControlDark;
                    A6.BackColor = SystemColors.ControlDark;
                }
                else if (A == 3)
                {
                    A3.BackColor = SystemColors.ControlDark;
                    A4.BackColor = SystemColors.ControlDark;
                    A5.BackColor = SystemColors.ControlDark;
                    A6.BackColor = SystemColors.ControlDark;
                }
                else if (A == 4)
                {
                    A4.BackColor = SystemColors.ControlDark;
                    A5.BackColor = SystemColors.ControlDark;
                    A6.BackColor = SystemColors.ControlDark;
                }
                else if (A == 5)
                {
                    A5.BackColor = SystemColors.ControlDark;
                    A6.BackColor = SystemColors.ControlDark;
                }
                else if (A == 6)
                {
                    A6.BackColor = SystemColors.ControlDark;
                }
            }

            if (sender == B1 || sender == B2 || sender == B3 || sender == B4 || sender == B5 || sender == B6)
            {
                if (B == 1)
                {
                    B1.BackColor = SystemColors.ControlDark;
                    B2.BackColor = SystemColors.ControlDark;
                    B3.BackColor = SystemColors.ControlDark;
                    B4.BackColor = SystemColors.ControlDark;
                    B5.BackColor = SystemColors.ControlDark;
                    B6.BackColor = SystemColors.ControlDark;
                }
                else if (B == 2)
                {
                    B2.BackColor = SystemColors.ControlDark;
                    B3.BackColor = SystemColors.ControlDark;
                    B4.BackColor = SystemColors.ControlDark;
                    B5.BackColor = SystemColors.ControlDark;
                    B6.BackColor = SystemColors.ControlDark;
                }
                else if (B == 3)
                {
                    B3.BackColor = SystemColors.ControlDark;
                    B4.BackColor = SystemColors.ControlDark;
                    B5.BackColor = SystemColors.ControlDark;
                    B6.BackColor = SystemColors.ControlDark;
                }
                else if (B == 4)
                {
                    B4.BackColor = SystemColors.ControlDark;
                    B5.BackColor = SystemColors.ControlDark;
                    B6.BackColor = SystemColors.ControlDark;
                }
                else if (B == 5)
                {
                    B5.BackColor = SystemColors.ControlDark;
                    B6.BackColor = SystemColors.ControlDark;
                }
                else if (B == 6)
                {
                    B6.BackColor = SystemColors.ControlDark;
                }
            }

            if (sender == C1 || sender == C2 || sender == C3 || sender == C4 || sender == C5 || sender == C6)
            {
                if (C == 1)
                {
                    C1.BackColor = SystemColors.ControlDark;
                    C2.BackColor = SystemColors.ControlDark;
                    C3.BackColor = SystemColors.ControlDark;
                    C4.BackColor = SystemColors.ControlDark;
                    C5.BackColor = SystemColors.ControlDark;
                    C6.BackColor = SystemColors.ControlDark;
                }
                else if (C == 2)
                {
                    C2.BackColor = SystemColors.ControlDark;
                    C3.BackColor = SystemColors.ControlDark;
                    C4.BackColor = SystemColors.ControlDark;
                    C5.BackColor = SystemColors.ControlDark;
                    C6.BackColor = SystemColors.ControlDark;
                }
                else if (C == 3)
                {
                    C3.BackColor = SystemColors.ControlDark;
                    C4.BackColor = SystemColors.ControlDark;
                    C5.BackColor = SystemColors.ControlDark;
                    C6.BackColor = SystemColors.ControlDark;
                }
                else if (C == 4)
                {
                    C4.BackColor = SystemColors.ControlDark;
                    C5.BackColor = SystemColors.ControlDark;
                    C6.BackColor = SystemColors.ControlDark;
                }
                else if (C == 5)
                {
                    C5.BackColor = SystemColors.ControlDark;
                    C6.BackColor = SystemColors.ControlDark;
                }
                else if (C == 6)
                {
                    C6.BackColor = SystemColors.ControlDark;
                }
            }

            if (sender == D1 || sender == D2 || sender == D3 || sender == D4 || sender == D5 || sender == D6)
            {
                if (D == 1)
                {
                    D1.BackColor = SystemColors.ControlDark;
                    D2.BackColor = SystemColors.ControlDark;
                    D3.BackColor = SystemColors.ControlDark;
                    D4.BackColor = SystemColors.ControlDark;
                    D5.BackColor = SystemColors.ControlDark;
                    D6.BackColor = SystemColors.ControlDark;
                }
                else if (D == 2)
                {
                    D2.BackColor = SystemColors.ControlDark;
                    D3.BackColor = SystemColors.ControlDark;
                    D4.BackColor = SystemColors.ControlDark;
                    D5.BackColor = SystemColors.ControlDark;
                    D6.BackColor = SystemColors.ControlDark;
                }
                else if (D == 3)
                {
                    D3.BackColor = SystemColors.ControlDark;
                    D4.BackColor = SystemColors.ControlDark;
                    D5.BackColor = SystemColors.ControlDark;
                    D6.BackColor = SystemColors.ControlDark;
                }
                else if (D == 4)
                {
                    D4.BackColor = SystemColors.ControlDark;
                    D5.BackColor = SystemColors.ControlDark;
                    D6.BackColor = SystemColors.ControlDark;
                }
                else if (D == 5)
                {
                    D5.BackColor = SystemColors.ControlDark;
                    D6.BackColor = SystemColors.ControlDark;
                }
                else if (D == 6)
                {
                    D6.BackColor = SystemColors.ControlDark;
                }
            }

            if (sender == E1 || sender == E2 || sender == E3 || sender == E4 || sender == E5 || sender == E6)
            {
                if (E == 1)
                {
                    E1.BackColor = SystemColors.ControlDark;
                    E2.BackColor = SystemColors.ControlDark;
                    E3.BackColor = SystemColors.ControlDark;
                    E4.BackColor = SystemColors.ControlDark;
                    E5.BackColor = SystemColors.ControlDark;
                    E6.BackColor = SystemColors.ControlDark;
                }
                else if (E == 2)
                {
                    E2.BackColor = SystemColors.ControlDark;
                    E3.BackColor = SystemColors.ControlDark;
                    E4.BackColor = SystemColors.ControlDark;
                    E5.BackColor = SystemColors.ControlDark;
                    E6.BackColor = SystemColors.ControlDark;
                }
                else if (E == 3)
                {
                    E3.BackColor = SystemColors.ControlDark;
                    E4.BackColor = SystemColors.ControlDark;
                    E5.BackColor = SystemColors.ControlDark;
                    E6.BackColor = SystemColors.ControlDark;
                }
                else if (E == 4)
                {
                    E4.BackColor = SystemColors.ControlDark;
                    E5.BackColor = SystemColors.ControlDark;
                    E6.BackColor = SystemColors.ControlDark;
                }
                else if (E == 5)
                {
                    E5.BackColor = SystemColors.ControlDark;
                    E6.BackColor = SystemColors.ControlDark;
                }
                else if (E == 6)
                {
                    E6.BackColor = SystemColors.ControlDark;
                }
            }

            if (sender == F1 || sender == F2 || sender == F3 || sender == F4 || sender == F5 || sender == F6)
            {
                if (F == 1)
                {
                    F1.BackColor = SystemColors.ControlDark;
                    F2.BackColor = SystemColors.ControlDark;
                    F3.BackColor = SystemColors.ControlDark;
                    F4.BackColor = SystemColors.ControlDark;
                    F5.BackColor = SystemColors.ControlDark;
                    F6.BackColor = SystemColors.ControlDark;
                }
                else if (F == 2)
                {
                    F2.BackColor = SystemColors.ControlDark;
                    F3.BackColor = SystemColors.ControlDark;
                    F4.BackColor = SystemColors.ControlDark;
                    F5.BackColor = SystemColors.ControlDark;
                    F6.BackColor = SystemColors.ControlDark;
                }
                else if (F == 3)
                {
                    F3.BackColor = SystemColors.ControlDark;
                    F4.BackColor = SystemColors.ControlDark;
                    F5.BackColor = SystemColors.ControlDark;
                    F6.BackColor = SystemColors.ControlDark;
                }
                else if (F == 4)
                {
                    F4.BackColor = SystemColors.ControlDark;
                    F5.BackColor = SystemColors.ControlDark;
                    F6.BackColor = SystemColors.ControlDark;
                }
                else if (F == 5)
                {
                    F5.BackColor = SystemColors.ControlDark;
                    F6.BackColor = SystemColors.ControlDark;
                }
                else if (F == 6)
                {
                    F6.BackColor = SystemColors.ControlDark;
                }
            }

            if (sender == G1 || sender == G2 || sender == G3 || sender == G4 || sender == G5 || sender == G6)
            {
                if (G == 1)
                {
                    G1.BackColor = SystemColors.ControlDark;
                    G2.BackColor = SystemColors.ControlDark;
                    G3.BackColor = SystemColors.ControlDark;
                    G4.BackColor = SystemColors.ControlDark;
                    G5.BackColor = SystemColors.ControlDark;
                    G6.BackColor = SystemColors.ControlDark;
                }
                else if (G == 2)
                {
                    G2.BackColor = SystemColors.ControlDark;
                    G3.BackColor = SystemColors.ControlDark;
                    G4.BackColor = SystemColors.ControlDark;
                    G5.BackColor = SystemColors.ControlDark;
                    G6.BackColor = SystemColors.ControlDark;
                }
                else if (G == 3)
                {
                    G3.BackColor = SystemColors.ControlDark;
                    G4.BackColor = SystemColors.ControlDark;
                    G5.BackColor = SystemColors.ControlDark;
                    G6.BackColor = SystemColors.ControlDark;
                }
                else if (G == 4)
                {
                    G4.BackColor = SystemColors.ControlDark;
                    G5.BackColor = SystemColors.ControlDark;
                    G6.BackColor = SystemColors.ControlDark;
                }
                else if (G == 5)
                {
                    G5.BackColor = SystemColors.ControlDark;
                    G6.BackColor = SystemColors.ControlDark;
                }
                else if (G == 6)
                {
                    G6.BackColor = SystemColors.ControlDark;
                }
            }
        }
    }
}