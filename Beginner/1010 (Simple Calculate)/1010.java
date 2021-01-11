import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.00");

        int a = ler.nextInt();
        int b = ler.nextInt();
        double e = ler.nextDouble();
        int c = ler.nextInt();
        int d = ler.nextInt();
        double f = ler.nextDouble();
        
        
        double result = (e*b + d * f);
        System.out.println("VALOR A PAGAR: R$ " + df.format(result));
        
    }
 
}