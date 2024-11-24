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

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        
        // code here
        int i1 = A.GetLength(0);
        int j1 = A.GetLength(1);
        for(int i =0;i< i1;i++)
        {
            for(int j = 0; j < j1;j++)
            {
                answer += A[i, j];
            }
        }
        
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
        int i1 = A.GetLength (0);
        int j1 = A.GetLength(1);
        if (i1 != 4 && j1 != 4)
            return answer;
        for(int i =0; i<i1;i++)
        {
            for(int j = 0;j<j1;j++)
            {
                if(i==j)
                    answer += A[i, j];
            }    
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
        int[] answer = new int[4];
        // code here
        int jmin = 0;
        
        int i1 = A.GetLength(0);
        int j1 = A.GetLength(1);
        if (i1 != 4 && j1 != 7) return null;
        for(int i =0;i<i1;i++)
        {
            for(int j =1;j<j1; j++)
            {
                if (A[i,j] < A[i,jmin])
                {
                    jmin = j;
                   
                }
            }
            answer[i] =jmin;
        }
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
        int jmax =0;
        int i1 = A.GetLength (0);
        int j1 = A.GetLength (1);
        if (i1 != 5 || j1 != 7) return null;
        for(int i = 0;i < i1;i++)
        {
            for(int j =1;j<j1;j++)
            {
                if (A[i, j] > A[i, jmax])
                {
                    jmax = j;
                }
            }
            int t = A[i,jmax];
            A[i,jmax] = A[i,0];
            A[i, 0] = t;
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
        
        int imaxi = 0;int imaxj = 0;
        int i1 = A.GetLength (0); int j1 = A.GetLength (1);
        if (i1 != 6 || j1 != 7) return null;
        for(int i = 0;i<i1;i++)
        {
            for (int j = 0; j < j1; j++)
            {
                if (A[i, j] > A[imaxi, imaxj])
                {
                    imaxi = i;
                    imaxj = j;
                }
            }
        }
        int newi1 = i1 - 1;
        int newj1 = j1 - 1;
        int[,] A2 = new int[newi1, newj1];
        int i2 = 0; int j2 = 0;
        for(int i = 0; i < i1;i++)
        {
            if(i == imaxi)
            {
                continue;
            }
            j2 = 0;
            for(int j = 0;j < j1;j++)
            {
                if(j ==imaxj)
                    { continue; }
                A2[i2,j2]= A[i,j];
                j2++;
            }
            i2++;
        }
       


        // end

        return A2;
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
        int jmax = 0;
        int i1 = A.GetLength(0);
        int j1 = A.GetLength(1);
        if (i1 != 5 || j1 != 7) return null;
        for(int i = 0; i<i1;i++)
        {
            for(int j = 1;j<j1;j++)
            {
                if (A[i, j] > A[i, jmax])
                {
                    jmax = j;
             
                }
                A[i, jmax] *= (j + 1);
            }
            
        }

        Console.WriteLine(jmax);
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
        int jmax = -1;
        int indexj = -1;
        int i1 = D.GetLength(0);
        int j1 = D.GetLength(1);
        if (i1 != n || j1 != m) return null;
        for(int i = 0;i<i1;i++)
        {
            if (D[i,0] <0) continue;
            for(int j=1;j<j1;j++)
            {
                if (D[i, j] > 0)
                {
                    if (D[i, j] > D[i, jmax])
                    {
                        jmax = j;
                    }
                }
                if (D[i,j]<0)
                {
                    indexj = j;
                }
                
            }
            if(indexj != -1 &&  jmax != -1)
            {
                int t = D[i, jmax];
                D[i, jmax] = D[i,indexj];
                D[i,indexj] = t;
            }
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
        int n = H.GetLength(0);
        int m = H.GetLength(1);
        int[] answer = new int[n];
        if (n != 5 || m != 7) return null;
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 1; j < m; j++)
            {
                if (H[i, j] > H[i, jmax])
                {
                    jmax = j;
                }
            }
            int t = H[i,jmax];
            H[i,m-1] = H[i,m-2];
            H[i, m - 2] = t;
        }

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
        int n = Y.GetLength(0), m = Y.GetLength(1);
        if (n != 6 || m != 5) return null;
        // code here
        for (int i = 0; i < n; i++)
        {
            int jMax = 0;
            for (int j = 1; j < m; j++)
            {
                if (Y[i, jMax] < Y[i, j]) jMax = j;
            }
            double mid = 0, count = 0;
            for (int j = jMax; j < m; j++)
            {
                if (j == jMax) continue;
                if (Y[i, j] > 0)
                {
                    mid += Y[i, j];
                    count++;
                }
            }
            if (mid != 0) mid /= count;
            for (int j = 0; j < jMax; j++)
            {
                if (Y[i, j] < 0) Y[i, j] = mid;
            }
        }

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

        int n = B.GetLength(0), m = B.GetLength(1);
        if (n != 5 || m != 7) return null;
        int[] temp = new int[n];
        for (int i = 0; i < n; i++)
        {
            int jmax = 0;
            for (int j = 1; j < m; j++)
            {
                if (B[i, j] > B[i, jmax])
                        jmax = j;
            }
            temp[i] = B[i, jmax];
        }
        for (int i = 0; i < n; i++)
        {
            B[i, 3] = temp[4 - i];
        }

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
        
        // code here
        int k = 0;
        int i1 = A.GetLength(0);
        int j2 = A.GetLength(1);
        if (i1 != 5 || j2 != 7) return null;
        for(int i =0;i<i1;i++)
        {
            for(int j =0;j<j2;j++)
            {
                if (A[i,j] < 0)
                {
                    k++;
                }
            }
        }
        int[] answer = new int[k];
        int ik= 0;
        for (int i =0;i<i1; i++)
        {
            for(int j = 0;j<j2; j++)
            {
                if (A[i,j] <0)
                {
                    answer[ik] = A[i,j];
                    ik++;
                }
            }
        }
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