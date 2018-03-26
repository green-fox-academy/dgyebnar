#include <stdio.h>
#include <stdlib.h>

int main()
{
    int number;

    printf("Please give a number!\n");
    scanf("%d", &number);
    for(int i = 1; i <= number; i++)
    {
        for(int j = 0; j < i; j++)
        {
           printf("*");
        }
        printf("\n");
    }
    return 0;
}
