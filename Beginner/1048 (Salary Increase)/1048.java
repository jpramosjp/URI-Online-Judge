import java.io.IOException;
import java.util.Scanner;
import java.text.DecimalFormat;
public class Main {

    public static void main(String[] args) throws IOException {
        Scanner ler = new Scanner(System.in);
        double x = ler.nextDouble();
        DecimalFormat df = new DecimalFormat("0.00");
        DecimalFormat df2 = new DecimalFormat("0");
        double soma = 0.0;
        double reajuste =0.0;
        double percentual =0.0;
        if(x>0 && x <= 400.00){
             percentual = 15;
             reajuste = x * (percentual/100);
             soma = x + reajuste;
        }
        else if (x > 400.00 && x <= 800.00){
             percentual = 12;
             reajuste = x * (percentual/100);
             soma = x + reajuste;
        }
        else if (x > 800.00 && x <= 1200.00){
            percentual = 10;
             reajuste = x * (percentual/100);
             soma = x + reajuste;
        }
        else if (x > 1200.00 && x<= 2000.00){
             percentual = 7;
             reajuste = x * (percentual/100);
             soma = x + reajuste;
        }
        else if (x > 2000.00){
             percentual = 4;
             reajuste = x * (percentual/100);
             soma = x + reajuste;
        }

            
        System.out.println("Novo salario: " + df.format(soma));
        System.out.println("Reajuste ganho: " + df.format(reajuste));
        System.out.println("Em percentual: " + df2.format(percentual) + " %");

    }
 
}