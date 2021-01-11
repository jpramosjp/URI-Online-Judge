import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        DecimalFormat df = new DecimalFormat("0.00");
        int number = ler.nextInt();
        int hours = ler.nextInt();
        double salary = ler.nextDouble();
        
        
        double result = (salary * hours);
        System.out.println("NUMBER = " + number);
        System.out.println("SALARY = U$ " + df.format(result));
        
    }
 
}