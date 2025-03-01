#include <iostream>
using namespace std;

int main() {
    int std;
    char input[100];  // آرایه‌ای برای ذخیره ورودی
    cout << "Enter a line: ";
    cin.getline(input, sizeof(input));  // گرفتن خط ورودی
    cin >> std;
    cout << "std num";
    return 0;
}
