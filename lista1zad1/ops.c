#include "ops.h"

void wstaw (kolekcja *k, elem e)
{
        if(szukaj(k, e) && !k->type)
            printf("BŁĄD, ELEMENT ZNAJDUJE SIĘ W ZBIORZE\n");
        else
        {
            list *new_elem = malloc(sizeof(list));
            new_elem->val = e;
            new_elem->next = k->elems;
            k->elems = new_elem;
            k->size = k->size + 1;
        }
}

int rozmiar (kolekcja *k)
{
    return k->size;
}



int szukaj_zbior (kolekcja *k, elem e)
{
    list *find = k->elems;
    while (find != NULL)
    {
        if (find->val == e)
            return 1;
        find = find->next;
    }
    return 0;
}

int szukaj_torba (kolekcja *k, elem e)
{
    int licznik = 0;
    list *find = k->elems;
    while (find != NULL)
    {
        if (find->val == e)
            licznik++;
        find = find->next;
    }
    return licznik;
}

int szukaj (kolekcja *k, elem e)
{
    if (!k->type)
        return szukaj_zbior(k, e);
    return szukaj_torba(k, e);
    
}

