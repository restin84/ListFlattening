using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFlattening {
  public class LinkedList<T> {
    private ListElement<T> head;
    private ListElement<T> tail;

    public LinkedList() {}

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
    }
  }
}
