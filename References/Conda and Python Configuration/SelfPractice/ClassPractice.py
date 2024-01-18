class Node:
    def __init__(self, value=None, left=None, right=None):
        self.value = value # information that is being stored in the tree
        self.left = left   # the left child (subtree)
        self.right = right # the right child (subtree) 

    def __str__(self):
        return f'Value: {self.value}, Left: {self.left}, Right: {self.right},'

node1 = Node(2, 1,3)

print(node1)   