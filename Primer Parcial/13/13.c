#include <stdio.h>
#include <string.h>
#include <mpi.h>

#define numEle 10       
#define stringTam 20   

int main(int argc, char** argv) 
{
    int r, tam; 
    char vector[numEle][stringTam];
    
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &r);  
    MPI_Comm_size(MPI_COMM_WORLD, &tam); 
    
    if (r==0)
    {  
        for (int i=0;i<numEle;i++) 
            snprintf(vector[i], stringTam, "String %d", i);
        for (int i=0;i<numEle;i+=2) 
            MPI_Send(vector[i], stringTam, MPI_CHAR, 1, 0, MPI_COMM_WORLD);
        for (int i=1;i<numEle;i+=2) 
            MPI_Send(vector[i], stringTam, MPI_CHAR, 2, 0, MPI_COMM_WORLD);
            
    } 
    else if (r==1) 
    {  
        for (int i=0;i<numEle/2;i++)
        {
            char recib[stringTam];  
            MPI_Recv(recib, stringTam, MPI_CHAR, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            printf("Par: %s\n", recib); 
        }
    } 
    else if (r==2) 
    {  
        
        for (int i=0;i<(numEle+1)/2;i++) 
        { 
            char recib[stringTam];  
            MPI_Recv(recib, stringTam, MPI_CHAR, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            printf("Impar: %s\n", recib);  
        }
    }

    MPI_Finalize();
    return 0;
}
