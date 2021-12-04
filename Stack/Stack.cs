using System;
using System.Collections.Generic;

namespace Stack
{
  

    public class Stack
    {
        private List<object> _list = new List<object>(); // init the list object called _list
        // new here, and no constuctor needed
        // also fix the instance required issiue


        // this will create instance issue
        /* 
        public Stack()
        {
           List<object> _list = new List<object>(); // create instance of the list
          

            // _list.Add(new object());
        }
        */

        public void Push(object obj)
        {

            // append object at the top update
            // step 1. up casting
            // if (obj != null)
            // { throw new InvalidOperationException("can not add empty object to stack"); }

            try
            {
                _list.Add(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         

           // Console.WriteLine( "add success"+ _list[(_list.Count - 1)]);



            // step 2. append



        }

        public object Pop()
        {
            int index = _list.Count - 1;

            // return latest updated object
            object temp = _list[index];
            _list.RemoveAt(index); // remove at will remove index
            //Console.WriteLine("remove "+ _list.Count);
            return temp;
            
        }

        public void Clear()
        {
            // clear all object from the staci
            _list.Clear();
        }


    }
}

// Up casting all input into object
// store list of object in stack
// Down casting object then return value