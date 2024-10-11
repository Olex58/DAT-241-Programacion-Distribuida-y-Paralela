#include <stdio.h>
#include <omp.h>

void fibonacci(int n) 
{
    long long fib[n];
    fib[0] = 0;
    fib[1] = 1; 

    #pragma omp parallel
    {
        #pragma omp for
        for (int i = 2; i < n; i++) 
            fib[i] = fib[i - 1] + fib[i - 2]; 
        #pragma omp critical 
        {
            printf("Serie Fibonacci: ");
            for (int i = 0; i < n; i++) 
                printf("%lld ", fib[i]);
            printf("\n");
        }
    }
}

int main() 
{
    int n=20;
    fibonacci(n);
    return 0;
}
