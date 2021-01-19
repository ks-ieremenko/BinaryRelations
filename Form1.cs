using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryRelations
{
    public partial class Form1 : Form
    {
        delegate bool MyDelegate(int[,] matrix);
        public static bool isRef = false, isAntiref = false, isAsym = false, isSym = false, isAntiSym = false, isTransit = false;
        public Form1()
        {
            InitializeComponent();
        }
        public static void Set(SortedSet<int> set, RichTextBox r, string str)
        {
            foreach (var i in set)
                str += i + ", ";
            str = str.Substring(0, str.Length - 2) + " }";
            r.Text += str + '\n';
        }
        public static bool IsReflexive(int[,] matrix)
        {
            int i = 0;
            for (int j = 0; j < matrix.GetLength(1) && i < matrix.GetLength(0); j++, i++)
                if (matrix[i, j] != 1)
                    return false;
            isRef = true;
            return true;
        }
        public static bool IsAntiReflexive(int[,] matrix)
        {
            int i = 0;
            for (int j = 0; j < matrix.GetLength(1) && i < matrix.GetLength(0); j++, i++)
                if (matrix[i, j] != 0)
                        return false;
            isAntiref = true;
            return true;
        }
        public static bool IsSymmetric(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1) && i > j; j++)
                    if (matrix[i, j] != matrix[j, i])
                        return false;
            isSym = true;
            return true;
        }
        public static bool hasSymOne(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1) && i > j; j++)
                {
                    if (matrix[i, j] == 1 && matrix[i, j] == matrix[j, i])
                        return true;
                }
            return false;
        }
        public static bool IsAntiSymmetric(int[,] matrix)
        {
            if (GetZerosAndOnes(matrix) > 0 && !hasSymOne(matrix))
            {
                isSym = true;
                return true;
            }
            return false;
        }
        public static bool IsAsymmetric(int[,] matrix)
        {
            if (IsAntiReflexive(matrix) && !hasSymOne(matrix))
            {
                isAntiref = true;
                return true;
            }
            return false;
        }
        public static int GetZerosAndOnes(int[,] matrix)
        {
            int j = 0;
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
            {
                if (matrix[i, j] == 1)
                    counter++;
            }
            return counter;
        }
        private void MyFunction(MyDelegate del, int[,] matrix, PictureBox pic)
        {
            if (del(matrix))
                pic.Image = Properties.Resources.tick;
            else
                pic.Image = Properties.Resources.cross;

        }
        public bool IsTransitive(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            object[] firstRow = new object[n];
            for (int i = 0; i < n; i++)
                squareDgv.Columns.Add("", "");
            int[,] squareMatrix = Mul(matrix, matrix);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    firstRow[j] = squareMatrix[i, j];
                squareDgv.Rows.Add(firstRow);
            }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (squareMatrix[i, j] > 0)
                        if (matrix[i, j] <=0)
                            return false;
            return true;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            matrixDgv.Rows.Clear();
            matrixDgv.Columns.Clear();
            squareDgv.Rows.Clear();
            squareDgv.Columns.Clear();
        }

        private void ArefLbl_MouseHover(object sender, EventArgs e)
        {
            Todo("На главной диагонали все элементы равны нулю", "На главной диагонали НЕ все элементы равны нулю", ArefLbl, isAntiref);
        }

        private void SymLbl_MouseHover(object sender, EventArgs e)
        {
            Todo("Все единицы симметричны относительно главной диагонали", "НЕ все единицы симметричны относительно главной диагонали", SymLbl, isSym);
        }


        private void AsymLbl_MouseHover(object sender, EventArgs e)
        {
            Todo("Отсутствуют единицы, которые симметричны относительно \nглавной диагонали, на которой все элементы - нули",
                "Присутствуют единицы, которые симметричны относительно \nглавной диагонали или на диагонали есть единица(ы)", AsymLbl, isAsym);
        }

        private void TrLbl_MouseHover(object sender, EventArgs e)
        {
            Todo("Для соответственных элементов матрицы БО B и матрицы \nкоторая есть ее квадратом K выполняется условие: " +
                "\nэлемент матрицы K > 0 => элемент матрицы B > 0",
                "Для соответственных элементов матрицы БО B и матрицы \nкоторая есть ее квадратом K НЕ выполняется условие: " +
                "\nэлемент матрицы K > 0 => элемент матрицы B > 0",
                TrLbl, isTransit);
        }

        private void AntisLbl_MouseHover(object sender, EventArgs e)
        {
            Todo("Отсутствуют единицы, которые симметричны относительно \nглавной диагонали, на которой есть единица(ы)",
                "Присутствуют единицы, которые симметричны относительно \nглавной диагонали или на диагонали нет единиц", AntisLbl, isAntiSym);
        }

        public static int[,] Mul(int[,] matrix1, int[,] matrix2)
        {
            int sum;
            int n = matrix1.GetLength(0);
            int[,] result = new int[n,n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    sum = 0;
                    for (int k = 0; k < n; k++)
                        sum += matrix1[i, k] * matrix2[k, j];
                    result[i, j] = sum;
                }
            return result;
        }

        private void RefLbl_MouseHover(object sender, EventArgs e)
        {
            Todo("На главной диагонали все элементы равны единице", "На главной диагонали НЕ все элементы равны единице", RefLbl, isRef);
        }
        public void Todo(string text1, string text2, Label lbl, bool isTrue)
        {
            if (isTrue)
                toolTip1.Show(text1, lbl);
            else
                toolTip1.Show(text2, lbl);
        }
        private void RefLbl_MouseLeave(object sender, EventArgs e)
        {
            //if(matrixDgv.Rows.Count > 0 && matrixDgv.Columns.Count > 0)
            //    matrixDgv.Rows[1].Cells[1].Style.BackColor = Color.White;
        }

        private void analyzeBtn_Click(object sender, EventArgs e)
        {
            //очистка таблицы
            button2_Click_1(sender, e);
            //перенос на след строку

            string[] textboxBr = inputTxt.Text.Replace(')', ' ').Replace('(', ' ').Split(' ');
            List<int> BinRel = new List<int>();

            foreach (string i in textboxBr)
                if (int.TryParse(i.ToString(), out int res))
                    BinRel.Add(res);

            var obl_V = Enumerable.Range(0, BinRel.Count).Where(x => x % 2 == 0).Select(x => BinRel[x]);
            var obl_Z = Enumerable.Range(0, BinRel.Count).Where(x => x % 2 != 0).Select(x => BinRel[x]);

            SortedSet<int> oblV = new SortedSet<int>(obl_V);
            SortedSet<int> oblZ = new SortedSet<int>(obl_Z);
            SortedSet<int> oblBr = new SortedSet<int>(obl_V.Union(obl_Z));
            oblTxt.Text = "";
            Set(oblV, oblTxt, "Область определения: D(R) = { ");
            Set(oblZ, oblTxt, "Область значений: E(R) = { ");
            Set(oblBr, oblTxt, "Область бинарного отношения: O(R) = { ");
            int rows = oblBr.Count;
            int[,] matrix = new int[rows, rows];
            object[] firstRow = new object[rows + 1];
            Array.Clear(matrix, 0, rows * rows);
            int prev, next;

            for (int i = 1; i < BinRel.Count; i += 2)
            {
                prev = BinRel[i - 1];
                next = BinRel[i];
                matrix[oblV.ToList().IndexOf(prev), oblBr.ToList().IndexOf(next)] = 1;
            }
            firstRow[0] = "";
            for (int i = 0; i <= rows; i++)
            {
                matrixDgv.Columns.Add("", "");
                if (i != rows)
                    firstRow[i + 1] = oblBr.ToList()[i];
            }
            matrixDgv.Rows.Add(firstRow);
            for (int i = 0; i < rows; i++)
            {
                firstRow[0] = oblBr.ToList()[i];
                for (int j = 1; j <= rows; j++)
                    firstRow[j] = matrix[i, j - 1];
                matrixDgv.Rows.Add(firstRow);
            }
            for (int i = 1; i <= rows; i++)
            {
                matrixDgv.Rows[0].Cells[i].Style.BackColor = Color.FromArgb(255, 255, 204);
                matrixDgv.Rows[i].Cells[0].Style.BackColor = Color.Beige;
                if (matrix[i - 1, i - 1] == 0)
                    matrixDgv.Rows[i].Cells[i].Style.ForeColor = Color.FromArgb(0, 0, 255);
                else
                    matrixDgv.Rows[i].Cells[i].Style.ForeColor = Color.FromArgb(162, 0, 255);
            }
            matrixDgv.SelectedCells[0].Selected = false;
            MyFunction(IsReflexive, matrix, pictureBox1);
            MyFunction(IsAntiReflexive, matrix, pictureBox2);
            MyFunction(IsSymmetric, matrix, pictureBox3);
            MyFunction(IsAntiSymmetric, matrix, pictureBox4);
            MyFunction(IsAsymmetric, matrix, pictureBox5);
            MyFunction(IsTransitive, matrix, pictureBox6);
        }
    }
}
