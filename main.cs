//Bibliotecas (namespaces) necessários para a manipulação de arquivos.
using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    int soma = 0;
    int qtdNumeros=0;
    float media = 0f;
    
    //Manipulador:
    FileStream meuArq = new FileStream("meus_arqs/nivel2/dados.txt", FileMode.Open, FileAccess.Read);

    //Leitor do arquivo:
    StreamReader sr = new StreamReader(meuArq, Encoding.UTF8);

    //Enquanto não chegar ao final do arquivo:
    while(!sr.EndOfStream){
      string str = sr.ReadLine();   
      soma = soma + int.Parse(str);
      qtdNumeros++;

      Console.WriteLine(str);
    }
    sr.Close();
    meuArq.Close();

    media = (float)soma/qtdNumeros;
    Console.WriteLine($"Média: {media}");

  }
}