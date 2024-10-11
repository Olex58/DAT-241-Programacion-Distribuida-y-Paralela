#include <stdio.h>
#include <stdlib.h>
#include <mpi.h>

#define N 4  

void multiMatr(int r, int tam, int A[N][N], int B[N][N], int C[N][N]) 
{
    int rp = N / tam; 
    int sr = r * rp;  
    int er = sr + rp; 
    for (int i = sr; i < er; i++) 
    {
        for (int j = 0; j < N; j++) 
        {
            C[i][j] = 0;
            for (int k = 0; k < N; k++) 
                C[i][j] += A[i][k] * B[k][j];
        }
    }
}

int main(int argc, char** argv) 
{
    int r, tam;
    int A[N][N], B[N][N], C[N][N];
    int A2[N][N];
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &r);
    MPI_Comm_size(MPI_COMM_WORLD, &tam);

    if (r == 0) 
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                A[i][j] = i + j;
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                B[i][j] = i * j;
        }
    }
    MPI_Bcast(B, N*N, MPI_INT, 0, MPI_COMM_WORLD);
    MPI_Scatter(A, N*N/tam, MPI_INT, A2, N*N/tam, MPI_INT, 0, MPI_COMM_WORLD);
    
    multiMatr(r, tam, A2, B, C);

    MPI_Gather(C, N*N/tam, MPI_INT, C, N*N/tam, MPI_INT, 0, MPI_COMM_WORLD);

    if (r == 0) 
    {
        printf("Resultado de la multiplicación:\n");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                printf("%d ", C[i][j]);
            }
            printf("\n");
        }
    }

    MPI_Finalize();
    return 0;
}
