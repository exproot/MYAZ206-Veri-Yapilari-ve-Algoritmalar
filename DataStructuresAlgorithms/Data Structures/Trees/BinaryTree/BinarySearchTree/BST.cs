namespace Trees;

public class BST<T> where T: IComparable {
    public BinarySearchTreeNode<T> Root {get; set;}
    public BST() {
        Root = null; 
    }
    public BST(BinarySearchTreeNode<T> node) 
    { 
        Root = node; 
    }

    public BST(IEnumerable<T> collection) : this()
    {
        foreach (var item in collection)
        {
            Add(item);
        }
    }

    public void Add(T item) {
        var newNode = new BinarySearchTreeNode<T>(item);

        if(Root == null){
            Root = newNode;
            return;
        }

        var current = Root;
        BinarySearchTreeNode<T> parent;
        while (true)
        {
            parent = current;
            // left sub-tree
            if(item.CompareTo(current.Value)< 0){
                current = current.Left;
                if(current == null){
                    parent.Left = newNode;
                    return;
                }
            } 
            // right sub-tree
            else {
                current = current.Right;
                if(current == null){
                    parent.Right = newNode;
                    return;
                }
            }
        }
    }

    public T FindMin(BinarySearchTreeNode<T> root)
        {
            T minValue = root.Value;
            while (root.Left != null)
            {
                minValue = root.Left.Value;
                root = root.Left;
            }
            return minValue;
        }

    public T FindMin()
    {
        BinarySearchTreeNode<T> current = Root;
        T minValue = current.Value;
        while (current.Left != null)
        {
            minValue = current.Left.Value;
            current = current.Left;
        }
        return minValue;
    }

    public T FindMax()
    {
        if (Root == null)
            throw new Exception("Empty tree!");

        var current = Root;
        while (!(current.Right == null))
            current = current.Right;
        return current.Value;
    }

    public BinarySearchTreeNode<T> Find(T key)
    {
        if (Root == null)
            throw new Exception("Empty tree!");

        var current = Root;

        while (current.Value.CompareTo(key) != 0)
        {
            if (key.CompareTo(current.Value) < 0)
                current = current.Left;
            else
                current = current.Right;
            if (current == null)
                throw new Exception("Could not found!");
        }
        return current;
    }

    public BinarySearchTreeNode<T> Remove(BinarySearchTreeNode<T> root, T key)
    {
        if (root == null)
            throw new Exception("Empty tree!");
        if (key.CompareTo(root.Value) < 0)
        {
            root.Left = Remove(root.Left, key);
        }
        else if (key.CompareTo(root.Value) > 0)
        {
            root.Right = Remove(root.Right, key);
        }
        else
        {
            // silme prosedürü
            // tek cocuklu ya da cocuksuz
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            // iki cocuk var ise
            root.Value = FindMin(root.Right);
            root.Right = Remove(root.Right, root.Value);
        }
        return root;
    }
}
