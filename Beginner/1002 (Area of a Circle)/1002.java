import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        double raio = 0;
        DecimalFormat df = new DecimalFormat("0.0000");
        Scanner ler = new Scanner(System.in);
        raio = ler.nextDouble();
        
        raio = raio * raio *3.14159;
        System.out.println("A=" + df.format(raio));
        
        
    }
 
}