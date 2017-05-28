using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFlattening {
  public class LinkedList<T> {
    private ListElement<T> head;
    private ListElement<T> tail;
    public int Count { get; set; }
    public LinkedList() {}

    public ListElement<T> this[int index] {
      get {
        //not efficient as we could decide whether or not its a shorter distance from
        //the head or tail to the element at the target index
        if (index < 0 || index >= Count) {
          throw new IndexOutOfRangeException();
        }
        ListElement<T> currentElement = head;
        for (int i = 0; i < index; i++) {
          currentElement = currentElement.Next;
        }
        return currentElement;
      }
    }

    public void AddToFront(T data) {
      ListElement<T> newElement = new ListElement<T>(data);
      if(head == null) { //First element
        head = newElement;
        tail = newElement;
      } else {
        newElement.Next = head;
        head.Previous = newElement;
        head = newElement;
      }
      Count++;
    }

    public void AddToBack(T data) {
      ListElement<T> newElement = new ListElement<T>(data);
      if(tail == null) {
        tail = newElement;
        head = newElement;
      } else {
        newElement.Previous = tail;
        tail.Next = newElement;
        tail = newElement;
      }
      Count++;
    }
  }
}
