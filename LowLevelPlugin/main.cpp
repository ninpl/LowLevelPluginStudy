#include <stdlib.h>
#include <math.h>
#include "main.h"

extern "C" int ** EXPORT_API fillArray(int size)
{
    int i = 0, j = 0;
    int ** array = (int**) calloc(size, sizeof(int*));

    for(i = 0; i < size; i++)
    {
        array[i] = (int*) calloc(size, sizeof(int));
        for(j = 0; j < size; j++)
        {
            array[i][j] = i * size + j;
        }
    }

    return array;
}
