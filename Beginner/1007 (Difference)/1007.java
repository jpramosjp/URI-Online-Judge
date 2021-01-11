import java.io.IOException;
import java.util.Scanner;


public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
      
        int a = ler.nextInt();
        int b = ler.nextInt();
        int c = ler.nextInt();
        int d = ler.nextInt();
        
        int result = (a * b - c * d);
        System.out.println("DIFERENCA = " + result );
        
        
    }
 
}