using System;
class Aula05{

    static void Main(){
 
    //int n1, n2, n3;
    //n1=10; n2=20; n3=30;
    //Console.Write("\nn1=\t{0}, \nn2=\t{1}, \nn3=\t{2}",n1,n2,n3);

    double valorCompra = 5.50;
    double valorVenda;
    double lucro = 0.1;
    string produto = "Pastel";

    valorVenda=valorCompra+(valorCompra*lucro);

    Console.WriteLine("Produto..............:{0,15}",produto);
    Console.WriteLine("Val.Compra...........:{0,15:c}",valorCompra);
    Console.WriteLine("Lucro................:{0,15:p}",lucro);
    Console.WriteLine("Valor de venda.......:{0,15:c}",valorVenda);


    }
}