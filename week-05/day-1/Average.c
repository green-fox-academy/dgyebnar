#include <stdio.h>
#include <stdlib.h>

int main()
{
        // Write a program that asks for 5 integers in a row,
        // then it should print the sum and the average of these numbers like:
        //
        // Sum: 22, Average: 4.4
    int number1, number2, number3, number4, number5;
    int sum;
    printf("Give 5 number\n");
    scanf("%d", &number1);
    scanf("%d", &number2);
    scanf("%d", &number3);
    scanf("%d", &number4);
    scanf("%d", &number5);
    sum = number1+number2+number3+number4+number5;
    float average = sum / 5.0;
    printf("The sum: %d\n", sum);
    printf("The average: %f\n", average);

    return 0;
}
