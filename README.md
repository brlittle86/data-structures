# data-structures

- Our approach to Linked Lists was to simply create two Classes, one for the Node and one for the list itself. The Node contains 3 things: the Data and Next properties, and a constructor. The Linked List makes use of the Node objects and chains them together via their Next properties, while maintaining a reference to the Head.

- Our approach to the Linked List method FindMiddleNode was to find the length of the Linked List, divide the length in half (rounding down with Math.Floor()), and then iterate down the Linked List that number of Nodes.

- For Doubly Linked Lists, it is almost identical to Singly Linked Lists, however, we accounted for the ability to look at a previous Node, as well. This changes how we delete and add, but little else.

- For Stacks and Queues, it was a simple enough implementation. Brian and I both worked out creating them from the perspective of making a Stack or Queue from a Linked List.

- For the Palindrome challenge, we created two pointers on the Head and Tail nodes and compared their data to each other as they traversed the Queue in opposite directions.
![Palindrome!](https://imgur.com/a/IX8Fl)

- For making a Queue out of two Stacks, we basically rename the Stack.Push to Enqueue, and then for the Dequeue, we Pop everything in Stack1 into Stack2, then Pop Stack2 and save the node into a variable, then we move everything back to Stack1 and return the Dequeued Node
![TwoStacksOneQueue](https://imgur.com/a/OMwsY)