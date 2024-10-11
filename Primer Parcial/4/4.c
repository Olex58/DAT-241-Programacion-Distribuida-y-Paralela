#include <stdio.h>

void pi_iter(double *pi, int t) 
{
    double s=1.0;
    *pi=0.0;
    for (int i=0; i<t; i++) 
    {
        *pi += s/(2.0*i + 1.0); 
        s= -s; 
    }
    *pi *= 4.0;
}

void pi_recur(double *pi, double s, int i, int t)
{
    if (i>=t) 
        return;
    *pi += s/(2.0*i + 1.0); 
    pi_recur(pi, -s, i + 1, t);
}

int main() 
{
    double pi=0.0;
    int t=10000; 
    int op;
    printf("1.Iterativo\n");
    printf("2.Recursivo\n");
    scanf("%d", &op);
    
    if (op==1) 
    {
        pi_iter(&pi, t);
        printf("Valor de Pi : %.15f\n",pi);
    } 
     else if (op==2) 
     {
        pi_recur(&pi, 1.0, 0, t);
        pi *= 4.0; 
        printf("Valor aproximado de Pi %.15f\n",pi);
     }
    else {
        printf("Error\n");
    }

    return 0;
}
