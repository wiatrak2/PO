#include "lib.h"

imaginary *create_imaginary(imaginary *number)
{
    number = malloc(sizeof(imaginary));
    number->Im = 0;
    number->Re = 0;
    return number;
}
