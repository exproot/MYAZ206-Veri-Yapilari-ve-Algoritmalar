using Trees;

namespace TreeTests;

public class TraversalTests {
    //Recursive
    [Fact]
    public void PreOrderRecursiveTraversalTest(){
        //arrange
        List<int> traversalList = new List<int>();
        BinaryTree<int> tree = new BinaryTree<int>();
        
        tree.Insert(25);
        tree.Insert(15);
        tree.Insert(50);
        tree.Insert(10);
        tree.Insert(22);
        tree.Insert(35);
        tree.Insert(70);
        tree.Insert(4);

        /*
                                25
                        15              50
                    10      22      35      70
                4 
        */

        //act
        Traversal.PreOrderTraversal<int>(tree.Root, traversalList); // Root-L-R

        //assert
        Assert.Collection(traversalList,
            item => Assert.Equal(25, item),
            item => Assert.Equal(15, item),
            item => Assert.Equal(10, item),
            item => Assert.Equal(4, item),
            item => Assert.Equal(22, item),
            item => Assert.Equal(50, item),
            item => Assert.Equal(35, item),
            item => Assert.Equal(70, item)
            );
    }

    [Fact]
    public void InOrderRecursiveTraversalTest(){
        //arrange
        List<int> traversalList = new List<int>();
        BinaryTree<int> tree = new BinaryTree<int>();
        
        tree.Insert(25);
        tree.Insert(15);
        tree.Insert(50);
        tree.Insert(10);
        tree.Insert(22);
        tree.Insert(35);
        tree.Insert(70);
        tree.Insert(4);

        /*
                                25
                        15              50
                    10      22      35      70
                4 
        */

        //act
        Traversal.InOrderTraversal<int>(tree.Root, traversalList); // L-R-Root

        //assert
        Assert.Collection(traversalList,
            item => Assert.Equal(4, item),
            item => Assert.Equal(10, item),
            item => Assert.Equal(15, item),
            item => Assert.Equal(22, item),
            item => Assert.Equal(25, item),
            item => Assert.Equal(35, item),
            item => Assert.Equal(50, item),
            item => Assert.Equal(70, item)
            );
    }

    [Fact]
    public void PostOrderRecursiveTraversalTest(){
        //arrange
        List<int> traversalList = new List<int>();
        BinaryTree<int> tree = new BinaryTree<int>();
        
        tree.Insert(25);
        tree.Insert(15);
        tree.Insert(50);
        tree.Insert(10);
        tree.Insert(22);
        tree.Insert(35);
        tree.Insert(70);
        tree.Insert(4);

        /*
                                25
                        15              50
                    10      22      35      70
                4 
        */

        //act
        Traversal.PostOrderTraversal<int>(tree.Root, traversalList); // L-Root-R

        //assert
        Assert.Collection(traversalList,
            item => Assert.Equal(4, item),
            item => Assert.Equal(10, item),
            item => Assert.Equal(22, item),
            item => Assert.Equal(15, item),
            item => Assert.Equal(35, item),
            item => Assert.Equal(70, item),
            item => Assert.Equal(50, item),
            item => Assert.Equal(25, item)
            );
    }

    //Iterative
    [Fact]
    public void PreOrderIterativeTraversalTest(){
        //arrange
        List<int> traversalList = new List<int>();
        BinaryTree<int> tree = new BinaryTree<int>();
        
        tree.Insert(25);
        tree.Insert(15);
        tree.Insert(50);
        tree.Insert(10);
        tree.Insert(22);
        tree.Insert(35);
        tree.Insert(70);
        tree.Insert(4);

        /*
                                25
                        15              50
                    10      22      35      70
                4 
        */

        //act
        Traversal.PreOrderTraversalIterative<int>(tree.Root, traversalList); // Root-L-R

        //assert
        Assert.Collection(traversalList,
            item => Assert.Equal(25, item),
            item => Assert.Equal(15, item),
            item => Assert.Equal(10, item),
            item => Assert.Equal(4, item),
            item => Assert.Equal(22, item),
            item => Assert.Equal(50, item),
            item => Assert.Equal(35, item),
            item => Assert.Equal(70, item)
            );
    }

    [Fact]
    public void InOrderIterativeTraversalTest(){
        //arrange
        List<int> traversalList = new List<int>();
        BinaryTree<int> tree = new BinaryTree<int>();
        
        tree.Insert(25);
        tree.Insert(15);
        tree.Insert(50);
        tree.Insert(10);
        tree.Insert(22);
        tree.Insert(35);
        tree.Insert(70);
        tree.Insert(4);

        /*
                                25
                        15              50
                    10      22      35      70
                4 
        */

        //act
        Traversal.InOrderTraversalIterative<int>(tree.Root, traversalList); // L-R-Root

        //assert
        Assert.Collection(traversalList,
            item => Assert.Equal(4, item),
            item => Assert.Equal(10, item),
            item => Assert.Equal(15, item),
            item => Assert.Equal(22, item),
            item => Assert.Equal(25, item),
            item => Assert.Equal(35, item),
            item => Assert.Equal(50, item),
            item => Assert.Equal(70, item)
            );
    }

    [Fact]
    public void PostOrderIterativeTraversalTest(){
        //arrange
        List<int> traversalList = new List<int>();
        BinaryTree<int> tree = new BinaryTree<int>();
        
        tree.Insert(25);
        tree.Insert(15);
        tree.Insert(50);
        tree.Insert(10);
        tree.Insert(22);
        tree.Insert(35);
        tree.Insert(70);
        tree.Insert(4);

        /*
                                25
                        15              50
                    10      22      35      70
                4 
        */

        //act
        Traversal.PostOrderTraversalIterative<int>(tree.Root, traversalList); // L-Root-R

        //assert
        Assert.Collection(traversalList,
            item => Assert.Equal(4, item),
            item => Assert.Equal(10, item),
            item => Assert.Equal(22, item),
            item => Assert.Equal(15, item),
            item => Assert.Equal(35, item),
            item => Assert.Equal(70, item),
            item => Assert.Equal(50, item),
            item => Assert.Equal(25, item)
            );
    }
}