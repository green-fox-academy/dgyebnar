#include <stdio.h>
#include <stdlib.h>

int main()
{
    double massInKg = 81.2;
    double heightInM = 1.78;
    double BMI = massInKg / (heightInM * heightInM);
    printf("%f\n", BMI);
// Print the Body mass index (BMI) based on these values
    return 0;

}
