#include <ctime>
#include <iostream>
using namespace std;

int main() {
    time_t t = time(0);   // get time now
    struct tm * now = localtime( & t );
    cout << (now->tm_year + 1900) << '-' 
         << (now->tm_mon + 1) << '-'
         <<  now->tm_mday
         << endl;


double dItemPrice;
int iAge;
int iItemNum;
double dTotal;

cout << t;

cout << "Customer Age:" ;
cin >> iAge;
 
    
cout << "Enter number of items: ";
cin >> iItemNum;

while  (iItemNum >= 0);

{
    iItemNum = iItemNum  - 1;

cout << "Enter Item Price: ";
cin >> dItemPrice;

if (iAge >= 65);

{
    dItemPrice = dItemPrice - 1.00;
    }



cout << dItemPrice;
dTotal = dTotal + dItemPrice;

}

cout << dTotal; 
cout << "Thank you, loyal shopper!" ;


}

