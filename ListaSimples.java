import java.util.*;
public class ListaSimples{
public static void main(String args[]){
 //Creating a List
 long start = System.currentTimeMillis();
 List<String> list=new ArrayList<String>();
 //Adding elements in the List
 list.add("Macoratti");
 list.add("Jefferson");
 list.add("Miriam");

 //Iterating the List element using for-each loop
 for(String fruit:list)
  System.out.println(fruit);

  long elapsed = System.currentTimeMillis() - start;
  System.out.println("o metodo executou em " + elapsed +"ms");
}
}
