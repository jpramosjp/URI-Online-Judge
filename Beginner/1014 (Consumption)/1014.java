import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Main {

    public static void main(String[] args) throws IOException {
        DecimalFormat df = new DecimalFormat("0.000");
        Scanner ler = new Scanner(System.in);

        int x = ler.nextInt();
        double y = ler.nextDouble();

        System.out.println(df.format(x/y)+" km/l");
        
    }
 
}