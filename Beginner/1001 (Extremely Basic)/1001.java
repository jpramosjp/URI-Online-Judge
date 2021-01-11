import java.io.IOException;
import java.util.Scanner;
 

public class Main {
 
    public static void main(String[] args) throws IOException {
        int x = 0;
        int y = 0;
        Scanner ler = new Scanner(System.in);
        x = ler.nextInt();
        y = ler.nextInt();
        x = x + y;
        System.out.println("X = " + x);
        
        
    }
 
}