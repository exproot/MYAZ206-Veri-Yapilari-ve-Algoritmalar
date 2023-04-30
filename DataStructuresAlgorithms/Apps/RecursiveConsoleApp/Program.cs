#region Sum with itetarion and recursive

int sum_iter(int n) {
    if(n == 0)
        return 0;
    
    int sum = 0;
    for(int i =1; i <= n; i++){
        sum += i;
    }

    return sum;
}

int sum_rec(int n){
    if(n == 0)
        return 0;
    
    return n + sum_rec(n-1);
}

#endregion

#region Factorial with iteration and recursive

int fact_iter(int n) {
    if(n == 0)
        return 1;
        
    int mul = 1;
    for(int i = 1; i<=n; i++){
        mul *= i;
    }
    return mul;
}

int fact_rec(int n) {
    if(n == 0)
        return 1;
    if(n == 1)
        return 1;
    
    return n * fact_rec(n-1);
    
}

#endregion

#region LinkedList traversal with iteration and recursive

void trav_iter(LinkedListNode<int> node) {
    var current = node;
    Console.Write("LinkedList traversal with iteration: ");
    
    while(current != null) {
        Console.Write(current.Value + " ");
        current = current.Next;
    }
}

void trav_rec(LinkedListNode<int> node) {
    if(node is null)
        return;
    
    Console.Write(node.Value + " ");
    trav_rec(node.Next);
}

#endregion

LinkedList<int> list = new LinkedList<int>(new int[] {0,1,2,3,4,5});
int n = 5;
Console.WriteLine("Sum with iteration: " + sum_iter(n));
Console.WriteLine("Sum with recursive: " + sum_rec(n));
Console.WriteLine("Factorial with iteration: " + fact_iter(n));
Console.WriteLine("Factorial with recursive: " + fact_rec(n));
trav_iter(list.First);
Console.Write("\nLinkedList traversal with recursive: ");
trav_rec(list.First);
Console.ReadKey();