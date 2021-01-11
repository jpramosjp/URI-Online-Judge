import java.io.IOException;
import java.util.Scanner;


public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);

        int n = ler.nextInt();
        
        System.out.print(n/3600 + ":"); n = n %3600;
        System.out.print(n/60 + ":"); n = n %60;
        System.out.println(n);
    }
 
}