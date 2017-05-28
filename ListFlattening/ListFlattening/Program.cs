using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFlattening {
  class Program {
    static void Main(string[] args) {
      LinkedList<int> list5 = new LinkedList<int>();
      list5.AddToBack(7);

      LinkedList<int> list4 = new LinkedList<int>();
      list4.AddToBack(9);

      LinkedList<int> list3 = new LinkedList<int>();
      list3.AddToBack(8);

      LinkedList<int> list2 = new LinkedList<int>();
      list2.AddToBack(6);
      list2.AddToBack(26);
      list2.AddToBack(6);

      LinkedList<int> list8 = new LinkedList<int>();
      list8.AddToBack(21);
      list8.AddToBack(3);

      LinkedList<int> list7 = new LinkedList<int>();
      list7.AddToBack(12);
      list7.AddToBack(5);

      LinkedList<int> list6 = new LinkedList<int>();
      list6.AddToBack(2);
      list6.AddToBack(7);

      LinkedList<int> list1 = new LinkedList<int>();
      list1.AddToBack(5);
      list1.AddToBack(33);
      list1.AddToBack(17);
      list1.AddToBack(2);
      list1.AddToBack(1);

      list1[0].Child = list2;

      list2[1].Child = list3;
      list2[2].Child = list4;

      list4[0].Child = list5;

      list1[3].Child = list6;

      list6[0].Child = list7;

      list7[0].Child = list8;



      Console.ReadLine();
    }
  }
}
