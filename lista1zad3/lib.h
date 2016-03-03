#ifndef lib_h
#define lib_h
#include <stdio.h>
#include <stdlib.h>

typedef struct imaginary{
    double Re;
    double Im;
}imaginary;

imaginary *create_imaginary(imaginary *number);


#endif
