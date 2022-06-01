#include <iostream>
#include <cmath>

using namespace std;

int main() 
{
    float value;

    cout << "Give me a number and I will find its square root:" << endl;
    cin >> value;
    if(value >= 0.0) {
        float squareroot = sqrtf(value);
        cout << "You have given: " << value << endl;
        cout << "The square root is: " << squareroot << endl;
    }
}