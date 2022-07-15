long int getFirst(int num, int count);
long int getLast(int num, int curr);
int countNumbers(int x);
long int powTo(long int value, int power);
bool matchIndividually(int x);

bool isPalindrome(int x){
    // Begin by tasting if first and last number matches
    if (x < 0) return false;
    return matchIndividually(x);
}

long int getFirst(int num, int count){
    long int firstNum = num / powTo(10, count - 1);
    return firstNum % 10;
}

long int getLast(int num, int curr){
    long int lastNum = num % powTo(10, curr + 1);
    return lastNum / powTo(10, curr);
}

bool matchIndividually(int x){
    int numberAmount = countNumbers(x);
    if (numberAmount == 1) return true;
    
    int numberBuffer = x;
    for (int i = 0; i < numberAmount; i++) {
        if (numberAmount % 2 == 1 && i == numberAmount - 1) break;
        if (getFirst(numberBuffer, numberAmount - i) != getLast(numberBuffer, i)) return false;
    }
    return true;
}

int countNumbers(int x){
    int i = 0;
    int bufferNum = x;
    for (; bufferNum != 0; i++){
        bufferNum = bufferNum / 10;
    }
    return i;
}

long int powTo(long int value, int power){
    if (power == 0) return 1;
    long int newValue = value;
    for (int i = 1; i < power; i++){
        newValue = newValue * value; 
    }
    return newValue;
}