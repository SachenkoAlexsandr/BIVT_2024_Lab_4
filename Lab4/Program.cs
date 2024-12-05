using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Xml.Schema;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

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

        for (int i = 0; i < n; i++)
            answer += A[i, i];                    

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
        int[] answer = default(int[]);
        // code here

        if (A.GetLength(0) != 4 || A.GetLength(1) != 7) 
            return answer;

        int[] min_idx_arr = new int[A.GetLength(0)];                

        for (int i = 0, k = 0; i < A.GetLength(0); i++, k++)
        {
            int min_row_elem = A[i, 0];
            int idx = 0;

            for (int j = 0; j < A.GetLength(1); j++)
            {
                if (min_row_elem > A[i, j])
                {
                    min_row_elem = A[i, j];
                    idx = j;
                }                    
            }
            
            min_idx_arr[k] = idx;
        }

        answer = min_idx_arr; 

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

        if (A.GetLength(0) != 5 || A.GetLength(1) != 7)
            return A;

        for (int i = 0; i < A.GetLength(0); i++)
        {
            int max_row_elem = A[i, 0], max_row_idx = 0;

            for (int j = 0; j < A.GetLength(1); j++)
                if (max_row_elem < A[i, j])
                {
                    max_row_elem = A[i, j];
                    max_row_idx = j;
                }

            int tmp = A[i, 0];
            A[i, 0] = A[i, max_row_idx];
            A[i, max_row_idx] = tmp;
        }

        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
            {
                Console.Write($"{A[i, j]} ");
            }
            Console.WriteLine();        }
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

        // end

        return A;
    }
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

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

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0 ||
            matrix.GetLength(0) != matrix.GetLength(1))
                return null;

        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
                matrix[i, i] = 0;
            else
            {
                matrix[0, i] = 0;
                matrix[n - 1, i] = 0;

                matrix[i, 0] = 0;
                matrix[i, n - 1] = 0;
            }
        }

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

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0 ||
            matrix.GetLength(0) != matrix.GetLength(1))
            return null;

        int n = matrix.GetLength(0);

        for (int i = n / 2; i < n; i++)            
            for (int j = 0; j < i + 1; j++)
            {
                matrix[i, j] = 1;
            }

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

        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0 ||
            matrix.GetLength(0) != matrix.GetLength(1))
            return (null, null);

        int n = matrix.GetLength(0);
        upper = new int[(n * n - n) / 2 + n];
        lower = new int[(n * n - n) / 2];

        for (int  i = 0, row_i = 0, col_j = 0;  i < n;  i++)
            for (int j = 0, ri = row_i, cj = col_j; j < n; j++)
            {
                if (j >= i)
                {
                    upper[ri] = matrix[i, j];
                    ri++;
                }
                else
                {
                    lower[cj] = matrix[i, j];
                    cj++;
                }
                row_i = ri;
                col_j = cj;
            }

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

    public void Display_matrix(int[,] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            for (int j = 0; j < A.GetLength(1); j++)
                Console.Write($"{A[i, j]} ");
            Console.WriteLine();
        }            
    }
    public void Display_array(int[] A)
    {
        for (int i = 0; i < A.GetLength(0); i++)
        {
            Console.Write($"{A[i]} ");
        }
    }
}