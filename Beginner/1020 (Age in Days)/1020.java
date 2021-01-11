import java.io.IOException;
import java.util.Scanner;


public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);

        int n = ler.nextInt();
        
        System.out.println(n/365 + " ano(s)"); n = n %365;
        System.out.println(n/30 + " mes(es)"); n = n %30;
        System.out.println(n + " dia(s)");
    }
 
}