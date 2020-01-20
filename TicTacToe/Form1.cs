using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TicTacToe
{
   

    public partial class Form1 : Form
    { 
        
    #region CONSTANTS
    const int CELL = 89;
        const int CellCount = 3;
       
    #endregion


        public Form1()
        {
            InitializeComponent();
            m_CC = m_CA;
            PlayerL.Text = "Player 1: Circle";
        }

        Pen cross = new Pen(Color.Red, 2);
        Pen circle = new Pen(Color.Purple, 2);
        bool[,] m_CA = new bool[CellCount, CellCount];
        bool[,] m_CB = new bool[CellCount, CellCount];
        bool[,] m_CC; // current ( active ) CellArray n'te Generation pointer zum umschalten 
        int PlayerStateCircle = 1; // 1 = priority
        int PlayerStateRectangle = 0;

        private void OnPanelPaint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics);
            PlayerState(PlayerStateCircle,PlayerStateRectangle,e); 
        }

        private void PlayerState(int PSC, int PSR, PaintEventArgs e)
        {
            int stateC = PSC;
            int stateR = PSR;
            if(stateC == 1)
            {
                DrawCircle(e.Graphics);
                stateR = 1;
            }
            else if(stateR == 1)
            {
                DrawCross(e.Graphics);
                stateC = 1;
            }
        }

        void DrawGrid(Graphics gr)
        {
            Pen pen = new Pen(Color.DarkBlue, 3);
            int x, y;
            for(int i = 0; i < 5; i++)
            {
                x = i * CELL;
                gr.DrawLine(pen, x, 0, x, CellCount * CELL);

            }
            for (int j = 0; j < 5; j++)
            {
                y = j * CELL;
                gr.DrawLine(pen, CellCount * CELL, y, 0, y);
            }
        }
       
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;
            PlayerL.Text = "Player 1: Circle";
            if (e.Button == MouseButtons.Left && PlayerStateCircle == 1)
            {
                x = e.X;
                y = e.Y;
                x = x / CELL;
                y = y / CELL;
                DebugL.Text = x + " " + y;
                ToggleDrawCross(x,y);
                PlayerStateRectangle = 1;
                PlayerStateCircle = 0;
                PlayerL.Text = "Player 2: Rectangle";
            }
            else if(e.Button == MouseButtons.Left && PlayerStateRectangle == 1)
            {
                x = e.X;
                y = e.Y;
                x = x / CELL;
                y = y / CELL;
                DebugL.Text = x + " " + y;
                ToggleDrawCircle(x,y);
                PlayerStateRectangle = 0;
                PlayerStateCircle = 1;
            }
            panel.Invalidate();
        }

        void ToggleDrawCircle(int x, int y)
        {
            m_CC[x, y] = true;
        }
        void ToggleDrawCross(int x, int y)
        {
           m_CC[x,y] =  m_CB[x, y] = true;
            
        }

        void DrawCross(Graphics gr)
        {
            int x, y;
            for (int i = 0; i < CellCount; i++)
            {
                for (int j = 0; j < CellCount; j++)
                {
                    x = i * CELL;
                    y = j * CELL;

                    if (m_CC[i, j])
                    {    // if true = alive 
                       // gr.FillRectangle(br, x, y, CELL_SIZE - 2 * C_M, CELL_SIZE - 2 * C_M);
                        gr.DrawRectangle(cross, x, y, CELL-2 * 2, CELL-2*2);
                    }

                }
            }
        }

        void DrawCircle(Graphics gr)
        {
            int x, y;
            for (int i = 0; i < CellCount; i++)
            {
                for (int j = 0; j < CellCount; j++)
                {
                    x = i * CELL;
                    y = j * CELL;

                    if (m_CC[i, j])
                    {    // if true = alive 
                         // gr.FillRectangle(br, x, y, CELL_SIZE - 2 * C_M, CELL_SIZE - 2 * C_M);
                        gr.DrawEllipse(circle, x, y, CELL-2*2, CELL-2*2);
                    }

                }
            }
            
        }

        private void OnResetClick(object sender, EventArgs e)
        {
            PlayerStateCircle = 1;
            PlayerStateRectangle = 0;
           for(int i = 0; i < CellCount; i++)
            {
                for(int j = 0; j < CellCount; j++)
                {
                    m_CC[i, j] = false;
                }
            }
            panel.Invalidate();
        }
    }

    // ToDO:
    //PlayerState mit der Form Verbinden
}
