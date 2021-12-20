using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    public class Queue
    {
        public Item Haed = null;
        public Item Tail = null;
        public int alreadyInQueue = 0;
        public int currentSize = 0;
        public void Push(Item newItem)
        {
            if(Haed==null)
            {
                // Empty queue, this is the first item in queue
                Haed = newItem;
                Tail = newItem;
            }
            else
            {
                // bisli
                // bisli -> pepsi->  cola
                newItem.next = Haed;
                Haed.prev = newItem;
                Haed = newItem;
            }
            alreadyInQueue++;
            currentSize++;
        }

        public Item Pop()
        {
            Item ret = null;

            return ret;

        }
    }
}
