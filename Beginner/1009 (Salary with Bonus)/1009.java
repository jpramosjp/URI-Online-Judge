import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.00");
        String nome = ler.next();
        double salario = ler.nextDouble();
        double venda = ler.nextDouble();
        
        
        double result = (salario + (venda * 0.15));
        System.out.println("TOTAL = R$ " + df.format(result));
        
    }
 
}