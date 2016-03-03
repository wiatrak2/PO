#include "ops.h"
imaginary *new_add(imaginary *num1, imaginary *num2)
{
    imaginary *new_num = NULL;
    new_num = create_imaginary(new_num);
    new_num->Re = num1->Re + num2->Re;
    new_num->Im = num1->Im + num2->Im;
    return new_num;
}

imaginary *new_sub(imaginary *num1, imaginary *num2)
{
    imaginary *new_num = NULL;
    new_num = create_imaginary(new_num);
    new_num->Re = num1->Re - num2->Re;
    new_num->Im = num1->Im - num2->Im;
    return new_num;
}

imaginary *new_mult(imaginary *num1, imaginary *num2)
{
    imaginary *new_num = NULL;
    new_num = create_imaginary(new_num);
    new_num->Re = num1->Re * num2->Re - num1->Im * num2->Im;
    new_num->Im = num1->Im * num2->Re + num1->Re *num2->Im;
    return new_num;
}

imaginary *new_div(imaginary *num1, imaginary *num2)
{
    imaginary *new_num = NULL;
    new_num = create_imaginary(new_num);
    new_num->Re = num1->Re * num2->Re + num1->Im * num2->Im;
    new_num->Re /= ((num2->Im * num2->Im) + (num2->Re * num2->Re));
    new_num->Im = num1->Im * num2->Re - num1->Re *num2->Im;
    new_num->Im /= ((num2->Im * num2->Im) + (num2->Re * num2->Re));
    return new_num;
}

void mod_add(imaginary *num1, imaginary *num2)
{
    num2->Re = num1->Re + num2->Re;
    num2->Im = num1->Im + num2->Im;
}

void mod_sub(imaginary *num1, imaginary *num2)
{
    num2->Re = num1->Re - num2->Re;
    num2->Im = num1->Im - num2->Im;
}

void mod_mult(imaginary *num1, imaginary *num2)
{
    num2->Re = num1->Re * num2->Re - num1->Im * num2->Im;
    num2->Im = num1->Im * num2->Re + num1->Re *num2->Im;
}

void mod_div(imaginary *num1, imaginary *num2)
{
    double a = num1->Re;
    double b = num1->Im;
    double c = num2->Re;
    double d = num2->Im;
    num2->Re = (a*c + b*d)/(c*c + d*d);
    num2->Im = (b*c - a*d)/(c*c + d*d);
}