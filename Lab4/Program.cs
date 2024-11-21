public class Program
{
    public static void Matrix(double[,] A)
    {
        for (int i = 0; i < 6; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                Console.Write($"{A[i,j]} ");
            }
            Console.WriteLine();
        }
    }
    public static void Main()
    {
        Program program = new Program();

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here
        foreach (int item in A) { answer += item; }
        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int s = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] > 0)
                {
                    answer += A[i, j];
                    s++;
                }
            }
        }
        if (s == 0) { return 0; }
        answer /= s;
        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        // code here
        int a = A.GetLength(0);
        for (int i = 0; i < a; i++)
        {
            answer += A[i, i];
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int mi = 9999;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[i, j] < mi)
                {
                    mi = A[i, j];
                    row = i;
                    col = j;
                }
            }
        }
        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here
        int b = A.GetLength(0);
        for (int i = 0; i < b; i++)
        {
            if (A[i, colIndex] < 0)
            {
                value += A[i, colIndex];
                rowIndex = i;
                break;
            }
        }
        if (rowIndex == -1) { return (0, 0); }
        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 3 || b != 5)
        {
            return null;
        }
        int mi = 9999;
        answer = new int[b];
        for (int j = 0; j < b; j++)
        {
            mi = -9999;
            for (int i = 0; i < a; i++)
            {
                if (A[i, j] > mi)
                {
                    mi = A[i, j];
                }
            }
            answer[j] = mi;
        }
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

        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 5 || b != 7)
        {
            return null;
        }
        int ma = -99999;
        int idex = -1;
        int s;
        for (int x = 0; x < A.GetLength(0); x++)
        {
            if (A[x, 3] > ma)
            {
                ma = A[x,3];
                idex = x;
            }
        }
        for (int y = 0; y<A.GetLength(1); y++)
        {
            s = A[3, y];
            A[3, y] = A[idex,y];
            A[idex,y] = s;
        }
        foreach (var x in A) Console.Write($" {x}");
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
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        if (a != 5 || b != 5)
        {
            return null;
        }
        int ma = -9999,i = -1,s;
        for(int y = 0; y< A.GetLength(0); y++)
        {
            if (A[y,y] > ma)
            {
                ma = A[y,y];
                i = y;
            }
        }
        Console.WriteLine(i);
        for(int y = 0; y< A.GetLength(0); y++)
        {
            s=A[y, 3];
            A[y, 3] = A[y, i];
            A[y,i] = s;

        }
        foreach(int y in A)
        {
            Console.WriteLine(y);
        }
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
        int a = A.GetLength(0);
        int b = A.GetLength(1);
        int ma = -9999,i=-1,fl=0;
        int [] l = new int[b];
        for (int y = 0; y < a; y++)
        {
            ma = -9999;
            l=new int[b];
            fl = 0;
            for (int x = 0; x < b; x++)
            {
                if (A[y, x] > ma)
                {
                    ma=A[y, x];
                    i = x;
                }
            }
            for(int o=0; o<b; o++)
            {
                if (A[y, o] == ma)
                {
                    fl = 1;
                }
                if (o == b - 1)
                {
                    l[o] = ma;
                }
                else
                {
                    l[o] = A[y,o+fl];
                }
            }
            fl = 0;
            for (int x = 0;x < b; x++)
            {
                A[y,x] = l[x];
            }
        }
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
        int i = -1;
        for(int x = 0; x<n; x++)
        {
            double ma = -9999;
            i = -1;
            for (int y = 0; y<m; y++)
            {
                if (C[x,y] > ma)
                {
                    ma = C[x,y];
                    i = y;
                }
            }
            for(int k = 0; k < i; k++)
            {
                if (C[x,k] < 0)
                {
                    C[x,k] = C[x,k]/ma;
                }
            }
        }
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
        if (Z.GetLength(0) != 6 || Z.GetLength(1) != 8) return null;
        double sr = 0,ma=-9999;
        int k = 0,i=-1,v=0,a=0,b=0;
        // code here
        foreach(int x in Z)
        {
            if (x > 0)
            {
                sr += x;
                k++;
            }
            if (x > ma)
            {
                ma = x;
                i = v;
            }
            v++;
        }
        sr = sr / k;
        a = i / 6-1;
        b = i % 6;
        Z[a, b] = sr;
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
        int k = 0;
        int mi = 9999,mii = -1, ma = -9999, mai=-1;
        for (int x =0; x < 6; x++)
        {
            for(int y =0; y< 7; y++)
            {
                if (X[x, y] < 0)
                {
                    k++;
                }
            }
            if (k < mi) { mi = k; mii = x; }
            if (k > ma) { ma = k; mai = x; }
        }
        int s = 0;
        for (int x = 0; x < 6; x++)
        {
            for (int y = 0; y < 7; y++)
            {
                s = X[mii, y];
                X[mii, y] = X[mai, y];
                X[mai,y] = s;
            }
        }
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
    #endregion
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