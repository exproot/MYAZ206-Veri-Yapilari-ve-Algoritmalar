namespace Trees;
public class BinarySearchTreeNode<T>
{
    public BinarySearchTreeNode(){

    }
    public BinarySearchTreeNode(T val)
    {
        Value = val;
    }
    public T Value {get; set;}
    public BinarySearchTreeNode<T> Left {get; set;}
    public BinarySearchTreeNode<T> Right {get; set;}

    public override string ToString()
    {
        return $"{Value}";
    }
    public bool IsLeaf => (Left == null && Right == null);
}
