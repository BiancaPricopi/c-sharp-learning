
public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
}

/*
 * void inserareFinal(Nod* &cap, int valoare)
{
    //Creeam noul nod si ii atribuim valoarea din paramentru
    Nod *elem_final = new Nod;
    elem_final->numar = valoare;
    elem_final->urmator = NULL;
    if (cap == NULL) // In cazul in care lista noastra este vida, punem elementul in lista
        cap = elem_final;
    else
    {
        //Parcurgem lista pana la final
        Nod *nod_curent = cap;
        while (nod_curent->urmator != NULL)
            nod_curent = nod_curent->urmator;
        //Mutam sageata ultimului element catre elementul creat anterior
        nod_curent->urmator = elem_final;
    }
}*/
public class Solution
{
    public int sizeOfList(ListNode head)
    {
        int size = 0;
        ListNode parcurg = head;
        while (parcurg.next != null)
        {
            parcurg = parcurg.next;
            size++;
        }
        size++;
        return size;
    }
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode(-1);
        int sum;
        int remainder = 0;
        ListNode parcurgL1;
        ListNode parcurgL2;
        if (sizeOfList(l1) > sizeOfList(l2))
        {
            parcurgL1 = l1;
            parcurgL2 = l2;
        }
        else
        {
            parcurgL1 = l2;
            parcurgL2 = l1;
        }
        bool finishL2 = false;
        bool finishL1 = false;
        int val2;
        while(parcurgL1.next != null || !finishL1)
        {
            if (parcurgL2.next != null)
            {
                val2 = parcurgL2.val;
                parcurgL2 = parcurgL2.next;
            }
            else
            {
                if(!finishL2)
                {
                    val2 = parcurgL2.val;
                    finishL2 = true;
                }
                else
                {
                    val2 = 0;
                }
            }
            sum = parcurgL1.val + val2 + remainder;
            remainder = 0;
            if(sum >= 10)
            {
                remainder = sum / 10;
            }
            if(result.val == -1)
            {
                result.val = sum % 10;
            }
            else
            {
                ListNode parcurg = result;
                while(parcurg.next != null)
                {
                    parcurg = parcurg.next; 
                }
                parcurg.next = new ListNode(sum % 10);
            }
            if (parcurgL1.next == null)
            {
                finishL1 = true;
            }
            else
            {
                parcurgL1 = parcurgL1.next;
            }
        }
        if(remainder > 0)
        {
            ListNode parcurg = result;
            while (parcurg.next != null)
            {
                parcurg = parcurg.next;
            }
            parcurg.next = new ListNode(remainder % 10);
        }

        return result;
    }
}

public class Test
{
    public static void Main()
    {
        Solution solution = new Solution();
        ListNode l1 = new ListNode(9);
        ListNode n1 = new ListNode(9);
        ListNode n2 = new ListNode(9);
        l1.next = n1;
        n1.next = n2;

        ListNode l2 = new ListNode(9);
        n1 = new ListNode(9);
        n2 = new ListNode(9);
        l2.next = n1;
        n1.next = n2;

        ListNode mynode = solution.AddTwoNumbers(l1, l2); ;
        while (mynode.next != null)
        {
            Console.WriteLine(mynode.val);
            mynode = mynode.next;   
        }
        Console.WriteLine(mynode.val);
    }
}
