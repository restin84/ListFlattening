using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFlattening {
  public class ListFlattener<T> {
    //public static LinkedList<T> FlattenList<T>(ListElement<T> head) {
    //  LinkedList<T> topLevelList = new LinkedList<T>();
    //  ListElement<T> currentElement = head;
    //  topLevelList.head = currentElement;
    //  do {
    //    topLevelList.AddToBack(currentElement.Data);
    //    if(currentElement.Child != null) {
    //      LinkedList<T> childList = FlattenList(currentElement.Child);
    //      if(currentElement.Next == null) {
    //        currentElement.Next = childList.head;
    //        topLevelList.tail = childList.tail;
    //        return topLevelList;
    //      } else {
    //        currentElement.Next.Previous = childList.tail;
    //        childList.tail.Next = currentElement.Next;
    //        currentElement.Next = childList.head;
    //        childList.head.Previous = currentElement;
    //        topLevelList.tail = childList.tail;
    //        currentElement = childList.tail.Next;
    //      }
    //    } else if (currentElement.Next != null) {
    //      currentElement = currentElement.Next;
    //    }
    //  } while (currentElement.Next != null || currentElement.Child != null);
    //  topLevelList.AddToBack(currentElement.Data);
    //  return topLevelList;
    //}

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

    public LinkedList<T> FlattenList(ListElement<T> head) {
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
