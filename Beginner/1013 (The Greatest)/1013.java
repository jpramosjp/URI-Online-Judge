import java.io.IOException;
import java.util.Scanner;


public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);

        int a = ler.nextInt();
        int b = ler.nextInt();
        int c = ler.nextInt();
        if (a >= b && a >= c){
            System.out.println(a + " eh o maior");
        }
        else if (b >= a && b >= c){
            System.out.println(b + " eh o maior");
        }
        else if (c >= a && c >= b){
            System.out.println(c + " eh o maior");
        }
        
    }
 
}