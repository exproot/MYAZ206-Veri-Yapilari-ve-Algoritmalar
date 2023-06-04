namespace Trees;

public class Traversal {
    //Recursive

    // Root-L-R
    public static void PreOrderTraversal<T>(BinarySearchTreeNode<T> root, List<T> list) {
        // Base Case
        if(root == null) return;

        list.Add(root.Value);

        PreOrderTraversal(root.Left, list);
        PreOrderTraversal(root.Right, list);
    }

    //L-Root-R
    public static void InOrderTraversal<T>(BinarySearchTreeNode<T> root, List<T> list) {
        // Base Case
        if(root == null) return;

        InOrderTraversal(root.Left, list);

        list.Add(root.Value);

        InOrderTraversal(root.Right, list);
    }

    //L-R-Root
    public static void PostOrderTraversal<T>(BinarySearchTreeNode<T> root, List<T> list) {
        // Base Case
        if(root == null) return;

        PostOrderTraversal(root.Left, list);

        PostOrderTraversal(root.Right, list);
        
        list.Add(root.Value);
    }

    //Iterative
    public static void PreOrderTraversalIterative<T>(BinarySearchTreeNode<T> root, List<T> list) {
        // Base Case
        if(root == null) return;

        Stack<BinarySearchTreeNode<T>> stack = new Stack<BinarySearchTreeNode<T>>();

        stack.Push(root);

        while(stack.Count > 0){
            BinarySearchTreeNode<T> node = stack.Pop();
            list.Add(node.Value);

            if(node.Right != null)
                stack.Push(node.Right);
            if(node.Left != null)
                stack.Push(node.Left);
        }
    }
    
    public static void InOrderTraversalIterative<T>(BinarySearchTreeNode<T> root, List<T> list) {
        // Base Case
        if(root == null) return;

        Stack<BinarySearchTreeNode<T>> stack = new Stack<BinarySearchTreeNode<T>>();

        BinarySearchTreeNode<T> node = root;

        while(stack.Count > 0 || node != null){
            if(node != null){
                stack.Push(node);
                node = node.Left;
            } else {
                node = stack.Pop();
                list.Add(node.Value);
                node = node.Right;
            }
        }
    }
    public static void PostOrderTraversalIterative<T>(BinarySearchTreeNode<T> root, List<T> list) {
        // Base Case
        if(root == null) return;

        Stack<BinarySearchTreeNode<T>> stack = new Stack<BinarySearchTreeNode<T>>();

        BinarySearchTreeNode<T> node1 = root;
        BinarySearchTreeNode<T> node2 = null;

        while(stack.Count > 0 || node1 != null) {
            if(node1 != null){
                stack.Push(node1);
                node1 = node1.Left;
            }else {
                node1 = stack.Peek();
                if(node1.Right == null || node1.Right == node2){
                    list.Add(node1.Value);
                    stack.Pop();
                    node2 = node1;
                    node1 = null;
                } else {
                    node1 = node1.Right;
                }
            }
        }
    }
}