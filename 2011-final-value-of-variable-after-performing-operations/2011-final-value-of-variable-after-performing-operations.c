#include <string.h>

int finalValueAfterOperations(char ** operations, int operationsSize){
    int val = 0;
    for(int i = 0; i < operationsSize; i++)
    {
        if (strcmp(operations[i], "++X") == 0 || strcmp(operations[i], "X++") == 0)
            val++;
        else val--;   
    }
    return val;
}