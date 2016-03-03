#include <stdio.h>
#include "ops.h"
#include "lib.h"
int main() {
    imaginary *num1 = NULL;
    num1 = create_imaginary(num1);
    imaginary *num2 = NULL;
    num2 = create_imaginary(num2);
    
    
    num1->Re = 3.3;
    num1->Im = 10.6;
    num2->Re = 5;
    num2->Im = 4.9;
     
    imaginary *num3 = new_add(num1, num2);
     
    printf("%.2f %.2f\n", num3->Re, num3->Im);
    
    
    return 0;
}
