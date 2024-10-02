/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode list = new ListNode(0); // N� fict�cio
        // Ambos compartilham o mesmo n� fict�cio (endere�o na mem�ria), por isso que podemos retornar o list.next no   final.
        ListNode curr = list;
        // carry � o valor a esquerda da soma dos valores dos n�s divido por 10. Esse valor � carregado para a pr�xima intera��o.
        int carry = 0;
        while (l1 != null || l2 != null)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            int sum = carry + x + y;
            carry = sum / 10;
            // O next � o valor a direita da soma dos valores dos n�s divido por 10.
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        if (carry > 0)
        {
            curr.next = new ListNode(carry);
        }

        return list.next;
    }
}