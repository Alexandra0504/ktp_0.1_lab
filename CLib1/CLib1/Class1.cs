using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLib1
{
    public class Class1
    {
        public static void output_mas(ref DataGridView grid, params int[] a)
        {
            grid.RowCount = 2;
            grid.ColumnCount = a.GetLength(0);

            for (int i = 0; i < a.GetLength(0); i++)
            {
                grid.Rows[0].Cells[i].Value = i + 1;
                grid.Rows[1].Cells[i].Value = a[i];
            }
            int Width = 0;
            for (int j = 0; j < grid.ColumnCount; j++)
            {
                Width += grid.Columns[j].Width;
                if (Width > 1500)
                    grid.Width = 1500;
                else
                    grid.Width = Width;
            }

        }
        public static void enter_mas(int n, params int[] massivchikk)
        {
            Random a = new Random();
            for (int i = 0; i < n; i++)
                massivchikk[i] = (int)(a.Next(10));/// потом изменить на 1000
        }
        public static void set_mass(int x, ref int[] rezmas, params int[] massivchikk)
        {
           rezmas[0] = 0;

            for (int i = 0; i < massivchikk.GetLength(0); i++)
            {
                if ((rezmas[0] < 1) && (massivchikk[i] == x))
                    rezmas[0] = i + 1;
            }
            if (rezmas[0] == 0)
                MessageBox.Show("Элемент,который равен х, не нашелся");         
             }    
        }


    }

