#include <mpi.h>
#include <stdio.h>
#include <stdlib.h>

#define numEle 10

int main(int argc, char *argv[])
{
    int r, tam;
    int vecA[numEle], vecB[numEle], vecResult[numEle];

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &r);  
    MPI_Comm_size(MPI_COMM_WORLD, &tam); 

    if (r == 0) 
    {
        for (int i=0;i<numEle;i++) 
        {
            vecA[i] = i + 1;  
            vecB[i] = i + 1;
        } 
        if (tam>1) 
        {
            MPI_Send(vecA, numEle, MPI_INT, 1, 0, MPI_COMM_WORLD);
            MPI_Send(vecB, numEle, MPI_INT, 1, 0, MPI_COMM_WORLD);
        }
        if (tam>2) 
        {
            MPI_Send(vecA, numEle, MPI_INT, 2, 0, MPI_COMM_WORLD);
            MPI_Send(vecB, numEle, MPI_INT, 2, 0, MPI_COMM_WORLD);
        }
    } else {
       
        if (r==1 || r==2) 
        {
            MPI_Recv(vecA, numEle, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            MPI_Recv(vecB, numEle, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
        }
    }

    if (r == 1) 
    {
        for (int i = 1; i < numEle; i += 2) 
        {
            vecResult[i] = vecA[i] + vecB[i];
        }

        MPI_Send(vecResult, numEle, MPI_INT, 0, 0, MPI_COMM_WORLD);
    } else if (r == 2) {
     
        for (int i = 0; i < numEle; i += 2) 
        {
            vecResult[i] = vecA[i] + vecB[i];
        }
        MPI_Send(vecResult, numEle, MPI_INT, 0, 0, MPI_COMM_WORLD);
    } else if (r == 0) {
        
        int vecResult1[numEle] = {0}, vecResult2[numEle] = {0};
        if (tam > 1) 
        {
            MPI_Recv(vecResult1, numEle, MPI_INT, 1, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
        }
        if (tam > 2) 
        {
            MPI_Recv(vecResult2, numEle, MPI_INT, 2, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
        }

        for (int i = 0; i < numEle; i++
        {
            if (i % 2 == 0) {
                vecResult[i] = vecResult2[i]; 
            } else {
                vecResult[i] = vecResult1[i]; 
            }
        }
        printf("Vector suma: ");
        for (int i = 0; i < numEle; i++)
        {
            printf("%d ", vecResult[i]);
        }
        printf("\n");
    }

    MPI_Finalize();
    return 0;
}
