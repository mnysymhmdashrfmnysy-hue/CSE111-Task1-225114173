// Name: Mohamed Ashraf Mnesiy
// Student ID: 225114173

namespace Cse111Task1;

public class StudentList
{
    public Student? First { get; private set; }
    public Student? Last { get; private set; }
    public int Count { get; private set; }

    
    public void AddFront(int id)
    {
        Student node = new Student(id);
        node.Next = First;
        First = node;

        if (Last == null)    
            Last = node;

        Count++;
    }

    
    public void AddEnd(int id)
    {
        Student node = new Student(id);

        if (Last == null)      
        {
            First = node;
            Last = node;
        }
        else
        {
            Last.Next = node;
            Last = node;
        }

        Count++;
    }

    
    public bool Remove(int id)
    {
        Student? prev = null;
        Student? cur = First;

        while (cur != null)
        {
            if (cur.Id == id)
            {
                if (prev == null)          
                    First = cur.Next;
                else
                    prev.Next = cur.Next;

                if (cur == Last)           
                    Last = prev;           

                cur.Next = null;
                Count--;
                return true;
            }

            prev = cur;
            cur = cur.Next;
        }

        return false;                     
    }

   
    public void Reverse()
    {
        Student? prev = null;
        Student? cur = First;
        Last = First;                      

        while (cur != null)
        {
            Student? next = cur.Next;      
            cur.Next = prev;
            prev = cur;
            cur = next;
        }

        First = prev;                      
    }

    
    public void Print()
    {
        Student? cur = First;
        while (cur != null)
        {
            Console.Write(cur.Id);
            if (cur.Next != null)
                Console.Write(" ");
            cur = cur.Next;
        }
        Console.WriteLine();
    }
}
