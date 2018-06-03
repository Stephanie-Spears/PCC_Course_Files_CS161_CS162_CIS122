#include "list.h"
using namespace std;

int main()
{
    node * head = NULL;
    build(head);
    display(head);

    //PLEASE PUT YOUR CODE HERE to call the function assigned
	sumOfList(node * head);
//compute and return the sum of integers in the linear linked list
	insert(node *& head, int position, int newInt); //is this *& a pointer to a reference?
//insert newInt at index "position" where index starts with 0.


    display(head);
    destroy(head);
    
    return 0;
}
