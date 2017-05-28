using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFlattening {
  class Program {
    static void Main(string[] args) {
      LinkedList<int> list1 = new LinkedList<int>();
      list1.AddToBack(5);
      list1.AddToBack(33);
      list1.AddToBack(17);
      list1.AddToBack(2);
      list1.AddToBack(1);
      for(int i = 0; i < list1.Count; i++) {
        Console.WriteLine(list1[i].Data);
      }
      LinkedList<int> list2 = new LinkedList<int>();
      LinkedList<int> list3 = new LinkedList<int>();
      LinkedList<int> list4 = new LinkedList<int>();
      LinkedList<int> list5 = new LinkedList<int>();
      LinkedList<int> list6 = new LinkedList<int>();
      LinkedList<int> list7 = new LinkedList<int>();
      LinkedList<int> list8 = new LinkedList<int>();
      Console.ReadLine();
    }
  }
}
