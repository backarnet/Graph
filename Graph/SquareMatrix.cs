using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class SquareMatrix
    {
        public int Dimension { get; private set; }

        public string[][] Matrix { get; private set; }

        public string[] Titles { get; private set; }

        public SquareMatrix(int dimension)
        {
            this.Dimension = dimension;
            Matrix = new string[dimension][];
            Titles = new string[dimension];
        }

        public SquareMatrix(string[][] data)
        {
            Matrix = data;
            Dimension = data.Length;
        }

        public SquareMatrix(string[] textData, char separator)
        {
            if (false) // Regular expression check
            {
                throw new Exception("Text valibdation exception");
            }
            char[] separatorArray = { separator };
            var s = textData[0].Split(separatorArray, StringSplitOptions.RemoveEmptyEntries);

            this.Dimension = s.Length;
            Matrix = new string[Dimension][];
            Titles = new string[Dimension];

            Titles = textData[0].Split(separatorArray, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < Dimension; i++)
            {
                try
                {
                    Matrix[i] = textData[i + 1]
                        .Split(separatorArray, StringSplitOptions.RemoveEmptyEntries)
                        .Skip(1)
                        .ToArray();
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException("Not Square");
                }
            }
        }

        public SquareMatrix Transpose()
        {
            string[][] newMatrix = new string[Dimension][];

            for (int i = 0; i < Dimension; i++)
            {
                newMatrix[i] = new string[Dimension];
                for (int j = 0; j < Dimension; j++)
                {
                    newMatrix[i][j] = Matrix[j][i];
                }
            }
            return new SquareMatrix(newMatrix);
        }

        public bool IsSymmetric()
        {
            for (int i = 0; i < Dimension; i++)
            {
                if (!Matrix[i].SequenceEqual(Transpose().Matrix[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {

            string matrix = "";

            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    matrix += this.Matrix[i][j];
                    if (j < this.Matrix[i].Length -1)
                    {
                        matrix += '-';
                    }
                }
                matrix += "\r\n";
            }

            return matrix;
        }
    }
}
