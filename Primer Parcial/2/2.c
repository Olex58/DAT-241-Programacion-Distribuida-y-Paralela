#include <stdio.h>

int suma(int a, int b);
int resta(int a, int b);
int multiplicacion(int a, int b);
float division(int a, int b);


int suma(int a, int b) 
{
    return a+b;
}

int resta(int a, int b) 
{
    return a-b;
}

int multi(int a, int b) 
{
    return a*b;
}

float divi(int a, int b) 
{
    return (float) a/b;
}

int main() 
{
    int num1, num2, op;
    float r;
    printf("Ingresa el primer número: ");
    scanf("%d",&num1);
    printf("Ingresa el segundo número: ");
    scanf("%d",&num2);
    printf("\nSelecciona una operación:\n");
    printf("1. Suma\n");
    printf("2. Resta\n");
    printf("3. Multiplicación\n");
    printf("4. División\n");
    printf("Ingresa la opción: ");
    scanf("%d",& op);
    
    switch(op) 
    {
        case 1:
            printf("Resultado de la suma: %d\n", suma(num1, num2));
            break;
        case 2:
            printf("Resultado de la resta: %d\n", resta(num1, num2));
            break;
        case 3:
            printf("Resultado de la multiplicación: %d\n", multi(num1, num2));
            break;
        case 4:
            if(num2 !=0) 
            {
                r=divi(num1, num2);
                printf("Resultado de la división: %.2f\n", r);
            } 
            else 
            {
                printf("Error\n");
            }
            break;
        default:
            printf("Ingrese otros números\n");
    }

    return 0;
}