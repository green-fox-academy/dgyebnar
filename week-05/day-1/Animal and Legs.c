#include <stdio.h>
#include <stdlib.h>

int main()
{
    // Write a program that asks for two integers
    // The first represents the number of chickens the farmer has
    // The second represents the number of pigs owned by the farmer
    // It should print how many legs all the animals have
    int numberOfChickens;
    int numberOfPigs;

    printf("Please give a number of chickens!\n");
    scanf("%d", &numberOfChickens);

    printf("Please give a number of pigs!\n");
    scanf("%d", &numberOfPigs);

    printf("The amount of the chicken's legs: %d\n", numberOfChickens * 2);
    printf("The amount of the pig's legs: %d\n", numberOfPigs * 4);

    return 0;
}
