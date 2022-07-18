

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* shuffle(int* nums, int numsSize, int n, int* returnSize){
    int* arr = (int*)malloc(numsSize * sizeof(int));
    if(arr == NULL) return NULL;
    *returnSize = numsSize;
    
    for (int i=0, j=0; j < n; i+=2, j++){
        arr[i] = nums[j];
        arr[i+1] = nums[j+n];
    }
    return arr;
}