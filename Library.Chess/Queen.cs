﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Chess
{
    public class Queen : Figure
    {
        public override char Name => '♕';
        public Queen(Color color) : base(color) { }

        public override bool Move(int i1, int j1, int i2, int j2, Figure[,] array)
        {
            bool step = true;
            int i = i1, j = j1;

            do
            {
                if (i != i1 || j != j1)
                    if (array[i, j] != null) { step = false; break; }

                     if (i1 < i2) i++;
                else if (i1 > i2) i--;
                     if (j1 < j2) j++;
                else if (j1 > j2) j--;

            } while (i != i2 || j != j2);

                if ((i1 + j1 == i2 + j2 || i1 - j1 == i2 - j2 || i1 == i2 || j1 == j) && step
                 && (array[i2, j2] == null || array[i2, j2].Color != Color && array[i2, j2].Name != '♔'))
            {
                return true;
            }
            return false;
        }
    }
}
