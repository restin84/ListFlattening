using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFlattening {
  public class ListFlattener<T> {
    //public static LinkedList<T> FlattenList(LinkedList<T> topLevel) {
    //  ListElement<T> thisLevelTail = topLevel.tail;
    //  ListElement<T> currentElement = head;
    //  while(currentElement.Next != null) {
        
    //  }
    //}

    private static void Append(ListElement<T> tail, ListElement<T> toAppend) {
     
    }

    public ListFlattener() {

    }
    private LinkedList<T> result;

    public  void AddList(ListElement<T> head) {
      ListElement<T> currentElement = head;
      while (currentElement.Next != null) {
        result.AddToBack(currentElement.Data);
        if(currentElement.Child != null) {
          AddList(currentElement.Child);
        }
        currentElement = currentElement.Next;
      }
      result.AddToBack(currentElement.Data);
      if(currentElement.Child != null) {
        AddList(currentElement.Child);
      }
      return;
    }

    public LinkedList<T> TraverseAndAddFlatten(ListElement<T> head) {
      result = new LinkedList<T>();
      AddList(head);
      return result;
    }
  }
}





















//ListElement<T> currentElement = head;
//LinkedList<T> childList;
//      do {
//        if (currentElement.Child != null) {
//          childList = FlattenList(currentElement, currentElement.Next);
          
//        } else {
//          childList = null;
//        }
//      } while (currentElement.Next != null);
