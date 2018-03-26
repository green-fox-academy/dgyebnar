#include <stdio.h>
#include <stdlib.h>

int main()
{
    int number;
    int a;

    for(number = 1; number < 100; number ++)
    {
        a = number % 3;

        switch(a)
        {
        case 2:
            printf("Fizz\n");
            break;
        }
    }
    return 0;
}