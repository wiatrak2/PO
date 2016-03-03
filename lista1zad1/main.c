#include <stdio.h>
#include "ops.h"
#include "lib.h"
int main() {
    
    kolekcja *bag = NULL;
    bag = create_bag(bag);
    for (int i = 0; i < 10; i++)
        wstaw(bag, i);
    wstaw(bag, 5);
    printf("%d %d\n", rozmiar(bag), szukaj(bag, 5));
    
    kolekcja *set = NULL;
    set = create_set(set);
    for (int i = 0; i < 10; i++)
        wstaw(set, i);
    wstaw(set, 5);
    printf("%d %d\n", rozmiar(set), szukaj(set, 5));
    
    return 0;
}
