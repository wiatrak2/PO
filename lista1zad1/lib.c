#include "lib.h"
kolekcja *create_set(kolekcja *start)
{
    start = malloc(sizeof(kolekcja));
    start->type = false;
    start->size = 0;
    start->elems = NULL;
    return start;
}

kolekcja *create_bag(kolekcja *start)
{
    start = malloc(sizeof(kolekcja));
    start->type = true;
    start->size = 0;
    start->elems = NULL;
    return start;
}