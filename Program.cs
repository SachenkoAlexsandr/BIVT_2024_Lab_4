using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_3(new int[,] {{ 1, 2, 3, 4 },{ 5, 6, 7, 8 },{ 9, 10, 11, 12 },{ 13, 14, 15, 16 }});
        //program.Task_1_6(new int[,] {{ 1, 2, 3, 4, 5, 6, 7 },{ 5, 6, 7, 8, -9, 10, 11 },{ 9, 10, -11, -12, -13, -14, -15 },{ -13, -14, 15, 16, 17, 18, -19 } });
        //program.Task_1_9(new int[,] { { 1, 2, 3, 4, -5, -6, -7 },
        //        { 5, 11, -17, 11, -10, 6, 5 },
        //        { -9, -10, -11, -14, -15, -16, 1 },
        //        { -9, -10, -11, -14, -15, -6, -2 },
        //        { -9, -10, -11, -14, -15, 6, 4 } });
        //program.Task_1_12(new int[,] {{ 1, 2, 3, 4, -5, -6, -7 },
        //        { 5, 11, -17, 11, -10, 6, 5 },
        //        { -9, -10, -11, -14, -15, -16, 1 },
        //        { -9, -10, -11, -14, 15, -6, -2 },
        //        { -9, -10, -11, -14, -15, 6, 4 },
        //        { 0, -2, -3, -4, -5, 0, 5 }});
        //program.Task_1_15(new int[,] {{ 1, 2, -3, 4, -5, 6, 7 },
        //        { 5, 6, -7, 8, 9, -10, -11 },
        //        { 9, 10, 11, -12, 13, 14, 15 },
        //        { -13, 14, 15, 16, 17, -18, -19 },
        //        { 0, -1, -2, -3, -4, -5, -6 }});
        //program.Task_1_18(new int[,] {{ 1, 2, -3, 4, -5, 6, 7 },
        //        { 5, 6, -7, 8, 9, -10, -11 },
        //        { 9, 10, 11, 12, 13, 14, 15 },
        //        { -13, 14, 15, 16, 17, -18, -19 },
        //        { 0, -1, -2, -3, -4, -5, -6 }}, 5, 7);
        //program.Task_1_21(new int[,] {{ 1, 2, -3, 4, -5, 7, 0 },
        //        { 5, 6, -7, 8, 9, -11, 0 },
        //        { 9, 10, 11, 12, 13, 15, 0 },
        //        { -13, 14, 15, 16, 17, -19,0 },
        //        { 0, -1, -2, -3, -4, -6, 0 }});
        //program.Task_2_1(new double[,] {{ 1, 2, -3, 7, -5, 7, 7 },
        //        { 5, 6, -7, 8, 9, 9, -11 },
        //        { 9, 10, 11, 12, 13, 15, 15 },
        //        { -13, -30, 25, 25, 16, 17, -19 },
        //        { -6, -5, -1, -2, -3, -4, -6 }});
        //program.Task_2_2(new int[,] {{ 1, 2, -3, 7, 7 },
        //        { 5, 6, -7, 9, -11 },
        //        { 9, 10, 11, 15, 15 },
        //        { -13, 14, 25, 25, -19 },
        //        { 5, 6, -7, 8, 9},
        //        { -13, 14, 25, 25, -19 },
        //        { 0, 0, -1, -2, -3 }});
        //program.Task_2_3(new int[,] {{ 1, 2, -3, 7, 7 },
        //        { 5, 6, -7, 9, -11 },
        //        { 9, 10, 11, 15, 15 },
        //        { -13, 14, 25, 25, -19 },
        //        { 5, 6, -7, 8, 9},
        //        { -13, 14, 2, 3, -19 },
        //        { 1, 2, -3, 7, 0 },
        //        { 5, 0, -1, 9, -1 },
        //        { 9, 10, 11, 2, 15 },
        //        { 0, 0, -1, -2, -3 }});
        program.Task_2_4(new int[,] {{ 1, 2, -3, 7, 7 },
                { 5, 6, -7, 9, -11 },
                { 9, 10, 11, 15, 15 },
                { -13, 14, 25, 25, -19 },
                { 5, 6, -7, 8, 9},
                { -13, 14, 25, 25, -19 },
                { 0, 0, -1, -2, -3 }},
                new int[] { 10, 20, 30, 0, -50 });


    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int n = A.GetLength(0);

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            answer += A[i, i];
            //answer += A[i, n - i - 1];
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        //int[] answer = default(int[]);
        // code here
        int strok = A.GetLength(0), stolb = A.GetLength(1); 
        int[] answer = new int [strok];

        if (A == null || A.GetLength(0) != 4 || A.GetLength(1) != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            int elemin = 999;
            int indmin = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (A[i, j] < elemin)
                {
                    elemin = A[i, j];
                    indmin = j;
                }
            }
            answer[i] = indmin;
        }
        Console.Write("Искомый массив: ");
        for (int i = 0; i < answer.Length; i++)
        {
            Console.Write(answer[i] + " ");
        }
        Console.WriteLine();

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            int elemax = -999, indmax = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = j;
                }
            }
            A[i, indmax] = A[i, 0];
            A[i, 0] = elemax;
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here
        int strok = A.GetLength(0), stolb = A.GetLength(1);             
        
        if (A == null || strok != 6 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        int indmax = 0, jndmax = 0, elemax = -999;
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                    jndmax = j;
                }
            }
        }
        Console.WriteLine("Макс элемент: " + A[indmax, jndmax]);
        Console.WriteLine("Находится в строке " + (indmax+1) + " в столбце " + (jndmax+1));

        int[,] answer = new int[strok - 1, stolb - 1];
        for (int i = 0, a = 0; i < strok; i++)
        {
            if (i == indmax) continue;                   //пропуск строки
            for (int j = 0, b = 0; j < stolb; j++)
            {
                if (j == jndmax) continue;               //пропуск столбца
                answer[a, b] = A[i, j];
                b++;
            }
            a++;
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok-1; i++)
        {
            for (int j = 0; j < stolb-1; j++)
                Console.Write(answer[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
        A = answer;
        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here
        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || A.GetLength(0) != 5 || A.GetLength(1) != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        int indmax = 0, jndmax = 0;
        for (int i = 0; i < strok; i++)
        {
            int elemax = -999;
            for (int j = 0 ; j < stolb; j++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                    jndmax = j;
                }
            }
            A[indmax, jndmax] *= (i + 1);
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here        

        Console.WriteLine("Исходная матрица:");     // массив до
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(D[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)                 // для каждой строки поочередно
        {
            int jotrfirst = -1, jotrlast = -1;
            int elemax = -999, jndmax = -1;

            for (int j = 0; j < m; j++)             // поиск первого отрицательного
            {
                if (D[i, j] < 0)
                {
                    jotrfirst = j;
                    break;
                }
            }
            for (int j = 0; j < jotrfirst; j++)     // поиск максимального до первого отриц.
            {
                if (D[i, j] > elemax)
                {
                    elemax = D[i, j];
                    jndmax = j;
                }
            }
            for (int j = (m-1); j >= 0; j--)        // поиск последнего отрицательного
            {
                if (D[i, j] < 0)
                {
                    jotrlast = j;
                    break;
                }
            }
            if (jotrfirst <= 0)                     // если отрицательных нет, то продолжить
            {
                continue;
            }
            else                                    // замена 
            { 
                D[i, jndmax] = D[i, jotrlast];
                D[i, jotrlast] = elemax;
            }            
        }             

        Console.WriteLine("Искомая матрица:");      // массив после
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(D[i, j] + " ");
            Console.WriteLine();
        }    

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here



        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 5 || stolb != 7)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < strok; i++)
        {
            double elemax = -999;
            int jndmax = 0;
            for (int j = 0; j < stolb; j++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    jndmax = j;
                }
            }

            if (jndmax == 0 || A[i, jndmax - 1] > A[i, jndmax + 1])
            {
                if (A[i, jndmax + 1] > 0)
                    A[i, jndmax + 1] *= 2;
                else if (A[i, jndmax + 1] < 0)
                    A[i, jndmax + 1] /= 2;
            }
            else if (jndmax == stolb-1 || A[i, jndmax - 1] < A[i, jndmax + 1])
            {
                if (A[i, jndmax - 1] > 0)
                    A[i, jndmax - 1] *= 2;
                else if (A[i, jndmax - 1] < 0)
                    A[i, jndmax - 1] /= 2;
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 7 || stolb != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int j = 0; j < stolb; j++)
        {
            int kolvopol = 0, kolvootr = 0;
            int elemax = -999, indmax = 0;
            for (int i = 0; i < strok; i++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                }
                if (A[i, j] >= 0) kolvopol += 1;
                else kolvootr += 1;
            }
            for (int i = 0; i < strok; i++)
            {
                if (kolvopol > kolvootr)
                    A[indmax, j] = 0;
                else
                    A[indmax, j] = indmax+1;
            }
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        int strok = A.GetLength(0), stolb = A.GetLength(1);

        if (A == null || strok != 10 || stolb != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        for (int j = 0; j < stolb; j++)
        {
            int elemax = -999, indmax = 0;
            for (int i = 0; i < strok; i++)
            {
                if (A[i, j] > elemax)
                {
                    elemax = A[i, j];
                    indmax = i;
                }
            }
            if (indmax < (strok / 2))
            {
                int sum = 0;
                for (int i = indmax+1; i < strok; i++)
                {
                    sum += A[i, j];
                }
                A[0, j] = sum;
            }
            
        }

        Console.WriteLine("Искомая матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here
        //Дана матрица A размера 7 × 5 и массив B размера 5.Заменить максимальный элемент столбца
        //соответствующим элементом массива B, если этот элемент больше найденного максимального
        //элемента столбца. В противном случае замены не производить

        int strok = A.GetLength(0), stolb = A.GetLength(1), dlina = B.Length;

        if (A == null || strok != 7 || stolb != 5 || B == null || dlina != 5)
        {
            return null;
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
                Console.Write(A[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < dlina; i++)
        {
            Console.Write(B[i] + " ");
        }
        Console.WriteLine();

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        // end

        return A;
    }
    #endregion

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    #endregion
}