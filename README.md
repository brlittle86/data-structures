# data-structures

- Our approach to Linked Lists was to simply create two Classes, one for the Node and one for the list itself. The Node contains 3 things: the Data and Next properties, and a constructor. The Linked List makes use of the Node objects and chains them together via their Next properties, while maintaining a reference to the Head.

- Our approach to the Linked List method FindMiddleNode was to find the length of the Linked List, divide the length in half (rounding down with Math.Floor()), and then iterate down the Linked List that number of Nodes.

- For Doubly Linked Lists, it is almost identical to Singly Linked Lists, however, we accounted for the ability to look at a previous Node, as well. This changes how we delete and add, but little else.

- For Stacks and Queues, it was a simple enough implementation. Brian and I both worked out creating them from the perspective of making a Stack or Queue from a Linked List.

- For the Palindrome challenge, we created two pointers on the Head and Tail nodes and compared their data to each other as they traversed the Queue in opposite directions.
![Palindrome!](https://imgur.com/a/IX8Fl)

- For making a Queue out of two Stacks, we basically rename the Stack.Push to Enqueue, and then for the Dequeue, we Pop everything in Stack1 into Stack2, then Pop Stack2 and save the node into a variable, then we move everything back to Stack1 and return the Dequeued Node
![TwoStacksOneQueue](https://imgur.com/a/OMwsY)

- In order to do a Sorted Push on a Stack, we first place the new data in a List, then we Pop everything from the stack into the list. After that, we sort and reverse the list. Then we push each item in the list back into the stack.
![SortedPush](https://lh4.googleusercontent.com/ZpY-tHiOlakkfsZ3Zh_0qYgXhGCMqtX-1gZfGag2xG_u-80tzz8PuDAQ6neWDPBm4VD5OPztBDQzFaF-CFOWQkyiXYDrV-yG1qQj=w1920-h930

- For Trees, we just did some basic Nodes with Value, Left, and Right. The Tree has a pair of methods with some rudimentary logic to add to the left or right node.
![BasicTree](https://lh3.googleusercontent.com/73SqXCYvYDqNyfBu4IYDoXcTTnIF_erXZSHfIDS_7_5nEMc0lqClF7hFDanfsFDY1FZkwgeFHFf1AMDv3L5xWlOMGqPQd3OD2rO8=w1920-h930)

- For Traversal, we devised a recursive method to move through all available nodes and Console.WriteLine the Data of each node.
![TreeTraversal](https://lh5.googleusercontent.com/bZbc8lVs_GQUKxobYsJ1onWSoUVfjbVGCk7HT0aLfnarLAmVOoEjs-vWe4MGhrXuIRXO6nxO6QIQp4ncDgIa9lxvB4VJjuw51-GS=w1920-h930)

- For In and Post Order Traversal, all that is required is changes to when the Tree node Data is written, relative to the recursive calls
![OtherTreeTraversals](https://lh4.googleusercontent.com/NfFqdnUZIMy-DfFgfu4BphaVWo5FhMaOttwG7ggn5s-nV9uyigUP0vLSaeIpF2hfW8I-Jg5VE90VzJ7WUt_XilEu0KXDzOLtcrx2=w1920-h930)

- For Breadth First Traversal, we use a Queue - a method that has an O-notation of O(n). The root gets enqueued, then, while the queue is not empty, it dequeues on the queue and stores that node in a temporary variable. It then writes the Data in the node and checks for and enqueues the Left and Right of the node. This repeats as long as the queue has nodes.
![BreadthFirst](https://lh4.googleusercontent.com/40y48WmIlM78Uc9az65Dj4Besl34GjrZsMLDf7eRoqJ1GtVMV5gMOr_lkijOx-9T0jCZHWFVtwc9kTjjIExdbLBJI6vF2WnNR3u2=w1920-h930)

- For Binary Search Trees, I simply added logic to an Add method to automatically sort the tree as the new value is entered - resulting in a composition where the Left leaf is always less than, and the Right leaf is always greater than, the current leaf's value.
![BinarySearchTree!](https://lh3.googleusercontent.com/1eFqsuZoNVa8uJ9bthfvWIvcTrPL5UK2p7aQ9rmNE2s_16_o0QKFM9MgX7YliLiPCCm0YX4gzut3ZahRedJ1m5NpFs_dyLUdlRFqssI-OLOHa-GwOWUKEGOyvd4WcL5T3ZlSYSIZgOe1alM96yRzT6bCrXX2AUUPLXnOGJ9k_S9JjcibRnpGv-0Afy9k6fjr7JCzsu4QFFus7RDaSmLqpoI7lIDx-dObsb9wgRTrb_xN3FJ0PLT7hhtG9Xv_XSzlAYilwJwtUhhcjOQGvA3Fr7ooEQ1iM8DnxFd76mzQcy0RxKx7z6RpwCFHEo_jHwiLzSF1sk6aX9ABx8wafbmQVPvzem8ysbIbs8msgoyQ5bpA4-VNsDuH2yM9c8-iu5ZLKTrTdTPCz3wKpVn0_0BCyMicv63xfuy1psq6BEkvpDFRE9kuOwLeUEOY9icnNGNibxgK8F_fNKgPmBQHF0Iq9tRI-ehgiBQCI3QUvPs9EAS9RpvnGz5j8M_4vmA8t9ynxcokzf9Hd0HceECXk3scNNSAdaAw2sFOKdw0digXWH2n7ZpkA53HYVdI0SdWmLa6mCOfU0Du7MbgfIJz5NQWO0kSBwiZoh3K_SXjk7yIww=w712-h949-no)