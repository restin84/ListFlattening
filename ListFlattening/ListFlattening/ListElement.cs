using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFlattening {
  public class ListElement<T> {
    public T Data { get; private set; }
    public ListElement<T> Previous { get; set; }
    public ListElement<T> Next { get; set; }
    public LinkedList Child { get; set; }
    
    public ListElement(T data) {
      Data = data;
    }
  }
}
