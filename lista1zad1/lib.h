#ifndef lib_h
#define lib_h
#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
typedef int elem;

typedef struct list{
    elem val;
    struct list *next;
}list;

typedef struct kolekcja{
    bool type; // 0 - zbiór 1 - torba.
    list *elems;
    int size;
}kolekcja;

kolekcja *create_set(kolekcja *start);
kolekcja *create_bag(kolekcja *start);

#endif
