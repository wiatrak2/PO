#ifndef ops_h
#define ops_h
#include "lib.h"
//funkcje zwracające nowe struktury.
imaginary *new_add(imaginary *num1, imaginary *num2);
imaginary *new_sub(imaginary *num1, imaginary *num2);
imaginary *new_mult(imaginary *num1, imaginary *num2);
imaginary *new_div(imaginary *num1, imaginary *num2);
//funkcje modyfikujące instniejące struktury, wynikiem działania są wartości struktury podanej jako drugi argument.
void mod_add(imaginary *num1, imaginary *num2);
void mod_sub(imaginary *num1, imaginary *num2);
void mod_mult(imaginary *num1, imaginary *num2);
void mod_div(imaginary *num1, imaginary *num2);

#endif
