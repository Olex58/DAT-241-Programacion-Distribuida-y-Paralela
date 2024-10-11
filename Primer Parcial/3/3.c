#include <stdio.h>

void suma(int *a, int *b, int *resultado) {
    *resultado = *a + *b;
}

void resta(int *a, int *b, int *resultado) {
    *resultado = *a - *b;
}

void multiplicacion(int *a, int *b, int *resultado) {
    *resultado = (*a) * (*b);
}

void division(int *a, int *b, float *resultado) {
    if (*b != 0) {
        *resultado = (float)(*a) / (*b);
    } else {
        printf("Error: Divisi�n por cero no permitida.\n");
    }
}

int main() {
    int num1, num2;
    int resultado_int;
    float resultado_float;
    

    printf("Ingrese el primer n�mero: ");
    scanf("%d", &num1);
    printf("Ingrese el segundo n�mero: ");
    scanf("%d", &num2);

    suma(&num1, &num2, &resultado_int);
    printf("Suma: %d + %d = %d\n", num1, num2, resultado_int);

    resta(&num1, &num2, &resultado_int);
    printf("Resta: %d - %d = %d\n", num1, num2, resultado_int);


    multiplicacion(&num1, &num2, &resultado_int);
    printf("Multiplicaci�n: %d * %d = %d\n", num1, num2, resultado_int);

    division(&num1, &num2, &resultado_float);
    if (num2 != 0) {
        printf("Divisi�n: %d / %d = %.2f\n", num1, num2, resultado_float);
    }

    return 0;
}
