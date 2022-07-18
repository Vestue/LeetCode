long int powa(int n, int p);

int minimumSum(int num){
    int arr[4];
    
    // Slice
    for (int i = 0; i < 4; i++)
    {
        arr[i] = (num % powa(10, i + 1)) / powa(10, i);
    }
    
    // Sort
    for (int sort = 0; sort < 4; sort++){
        for (int i = 0; i < 3; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }
        }
    }
    
    return arr[0] * 10 + arr[1] * 10 + arr[2] + arr[3];
}

long int powa(int n, int p)
{
    if (p == 0) return 1;
    int result = n;
    for (int i = 2; i <= p; i++)
    {
        result *= n;
    }
    return result;
}