// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Ta na hora de aprender o curso!");
/*
//exemplo de double
double x = 10.35784;
Console.WriteLine(x);
Console.WriteLine(x.ToString("F2"));
Console.WriteLine(x.ToString("F4"));
Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
// exemplo completo com double e concatenação
int y = 32;
string z = "Maria";
char w = 'F';
Console.Write("Olá mundo!");
Console.WriteLine("Bom dia!");
Console.WriteLine("Até mais!");
Console.WriteLine();
Console.WriteLine(x);
Console.WriteLine(x.ToString("F2"));
Console.WriteLine(x.ToString("F4"));
Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();
Console.WriteLine("RESULTADO = " + x);
Console.WriteLine("O valor do troco é " + x + " reais");
Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais");
Console.WriteLine();
Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
Console.ReadLine();
*/
// mais exemplos com somas e multiplicações, tendo de int a double
// Exemplo 1 -> testando normal
/*
int x = 5;
int y = 2 + x;

Console.WriteLine("x:"+x);
Console.WriteLine("y:"+y);

Console.WriteLine("=X=X=X=X=X=X=X=X=X=X=X=");
// Exemplo 2 -> testeando com double

int w = 5;
double z = 2 * w;

Console.WriteLine("w:"+w);
Console.WriteLine("z:"+z);
Console.WriteLine("=X=X=X=X=X=X=X=X=X=X=X=");
// Exemplo 3 -> Calculo da area do trapezio

double b, B, h, AreaDoTrapezio;

b = 6.0;
B = 8.0;
h = 5.0;

AreaDoTrapezio = (b + B) / 2.0 * h;
Console.WriteLine("Area do trapezio e: "+AreaDoTrapezio);
*/
/*
Boa prática:

Sempre indique o tipo do número, se a
expressão for de ponto flutuante (não
inteira).

Para double use ->    .0
Para float use  ->    f
*/

//Console.WriteLine("=X=X==X=X=X==X=X=X=X=X=X=X=X=");
// Exemplo 4 -> divisao
/*
Casting
É a conversão explícita de um tipo para outro.
É necessário quando o compilador não é capaz de “adivinhar” que o
resultado de uma expressão deve ser de outro tipo.
*/
/*
int m, n;
double resultado;
m = 5;
n = 2;
resultado = (double) m / n; // entao aqui teria que ter double tmb para especificarmos tudo
Console.WriteLine(resultado);
*/
// exemplo 5 -> double * int
/*
double j;
int k;
j = 5.0;
k = j;
Console.WriteLine(k);
*/
//Console.WriteLine("=X=X==X=X=X==X=X=X=X=X=X=X=X=");
// Exemplo 6 -> Split das strings

// inserir no readline batata tomate abacaxi
/*
string s = Console.ReadLine();

string[] vet = s.Split(' ');
string p1 = vet[0];
string p2 = vet[1];
string p3 = vet[2];

Console.WriteLine("p1:"+ p1);
Console.WriteLine("p2:"+ p2);
Console.WriteLine("p3:"+ p3);
*/
// Inserção do readline com int
/*
int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Voce digitou:");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

string[] lst = Console.ReadLine().Split(" ");
string nome = lst[0];
char sexo = char.Parse(lst[1]);
int idade = int.Parse(lst[2]);
double altura = double.Parse(lst[3], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura);
*/
// Exercicio de fixação do curso #1
/*
Console.WriteLine("Entre seu nome completo:");
string nome = Console.ReadLine();

Console.WriteLine("Quantos quartos ha na sua casa? :");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com um preço de produto :");
double prec = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre seu ultimo nome, idade e altura: (na mesma linha)");
string[] caderno = Console.ReadLine().Split(" ");
string ultimoNome = caderno[0];
int idade = int.Parse(caderno[1]);
double altura = double.Parse(caderno[2], CultureInfo.InvariantCulture);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(prec.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
*/
// Exemplo outras funções matematica 
// Funções matematicas podem ser acessadas apartirar da math.(função) tal como Math.Sqrt(x,y) que e raiz quadrada, Math.Pow(x,y) que e elevado e por fim
// Math.Abs(x,y) recebendo o valor absoluto
// Formula da bahskara,
// primeiro o delta -> delta = Math.Pow(b , 2.0) - 4*a*c;
// agora para o resto da equação bah_pos = (+b + Math.Sqrt(delta)) / (2*a);
// bah_neg = (-b + Math.Sqrt(delta)) / (2*a);

/*
double x = 3.0;
double y = 4.0;
double z = -5.0;
double A, B, C;
*/
// double delta, bah_pos, bah_neg;
/*
A = Math.Sqrt(x);
B = Math.Sqrt(y);
C = Math.Sqrt(25.0);

Console.WriteLine("Raiz quadrada de " + x + " = " + A);
Console.WriteLine("Raiz quadrada de " + y + " = " + B);
Console.WriteLine("Raiz quadrada de 25 = " + C);

A = Math.Pow(x, y);
B = Math.Pow(x, 2.0);
C = Math.Pow(5.0, 2.0);

Console.WriteLine(x + " elevado a " + y + " = " + A);
Console.WriteLine(x + " elevado ao quadrado = " + B);
Console.WriteLine("5 elevado ao quadrado = " + C);

A = Math.Abs(y);
B = Math.Abs(z);

Console.WriteLine("Valor absoluto de " + y + " = " + A);
Console.WriteLine("Valor absoluto de " + z + " = " + B);
*/
/*
delta = Math.Pow(4.0, 2.0) - 4 * 5.0 * 3.0;
bah_pos = (+4.0 + Math.Sqrt(delta)) / (2 * 5.0);
bah_neg = (-4.0 + Math.Sqrt(delta)) / (2 * 5.0);

Console.WriteLine("Valor da baskhara positiva e = " + bah_pos);
Console.WriteLine("Valor da baskhara negativa e = " + bah_neg);
Console.ReadLine();
*/

// Exercicio 2 -> Saldeamento
// fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma casa decimal, bem como o valor do metro quadrado
// do terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor da area do terreno, bem como o valor do preço do terreno,
// ambos com duas casas decimias, conforme exemplo.
// entrada              Saida
// 10.0 l                Area = 300.0
// 30.0 c                preço = 60000.0 
// 200.0 V
/*
Console.WriteLine("Informe a largura do terreno:");
double largura = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o comprimento do terreno:");
double comprimento = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor por metro quadrado do terreno:");
double valor = double.Parse(Console.ReadLine());

double area = (largura * comprimento);
double preco = valor * area;

Console.WriteLine("Area: "+ area.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Preço: "+ preco.ToString("F2", CultureInfo.InvariantCulture));
*/
// Exercicio 3 -> beecrowd 1001 (simples soma)
/*
int A, B, X;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());
X = A + B;

Console.WriteLine("X = " + X);
*/
// Exercicio 4 -> beecrowd 1002 (Area do circulo)
/*
double A, n, R;

n = 3.14159;
R = double.Parse(Console.ReadLine());

A = n * Math.Pow(R, 2);
Console.WriteLine("A=" + A.ToString("F4"));
*/
// Exercicio 5 -> beecrowd 1003 (Simples somação)
/* 
int A, B,SOMA;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine()); 

SOMA = A + B;

Console.WriteLine("SOMA = "+ SOMA);
*/
// Exercicio 6 -> beecrowd 1004 (Produto simples)
/* 
int X, Y, PROD;

X = int.Parse(Console.ReadLine());
Y = int.Parse(Console.ReadLine());

PROD = X * Y;
Console.WriteLine("PROD = "+ PROD); 
*/
// Execicio 7 -> beecrowd 1007 (Diferença adaptado)
/* 
int A,B,C,D,DIFERENCA;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());
C = int.Parse(Console.ReadLine());
D = int.Parse(Console.ReadLine());

DIFERENCA = (A * B) - (C * D);
Console.WriteLine("DIFERENCA = "+ DIFERENCA);
*/
// Exercicio 8 -> beecrowd 1008 (Salary)
/* 
int NUMBER, H;
double Ammount, SALARY;

NUMBER = int.Parse(Console.ReadLine());
H = int.Parse(Console.ReadLine());
Ammount = double.Parse(Console.ReadLine());

SALARY = Ammount * H;
Console.WriteLine("NUMBER = "+ NUMBER);
Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2"));
*/
// Exercicio 9 -> beecrowd 1010 (Simple Calculate)
/*
int n1, n2,q1,q2;
double p1, p2, VALOR_PAGAR;

string s1 = Console.ReadLine();
string[] v1 = s1.Split(' ');
string s2 = Console.ReadLine();
string[] v2 = s2.Split(' ');
n1 = int.Parse(v1[0]);
q1 = int.Parse(v1[1]);
p1 = double.Parse(v1[2]);
n2 = int.Parse(v2[0]);
q2 = int.Parse(v2[1]);
p2 = double.Parse(v2[2]);

VALOR_PAGAR = (p1 * q1) + (p2 *q2);
Console.WriteLine("VALOR A PAGAR: R$ "+ VALOR_PAGAR.ToString("F2"));
 */
// Exercicio 10 -> beecrowd 1014 (Kilometragem)
/* 
int X;
double Y, Consumption;

X = int.Parse(Console.ReadLine());
Y = double.Parse(Console.ReadLine());
Consumption = X / Y;
Console.WriteLine(Consumption.ToString("F3")+" km/l");
*/
// Exercicio 11 -> beecrowd 1016 (Distancia)
/* 
double distance = double.Parse(Console.ReadLine());
double tempo = distance / 0.5;

Console.WriteLine(tempo + " minutos");
*/
// Exercicio 12 -> beecrowd 1017 (Gasolina consumida)
/* 
int tempo, velo;

tempo = int.Parse(Console.ReadLine());
velo = int.Parse(Console.ReadLine());

double gasolinaConsumida = (tempo * velo) / 12.0;

Console.WriteLine(gasolinaConsumida.ToString("F3"));
*/
// Exercicio 13 -> beecrowd 1005 (mediana)
/* 
double A, B, MEDIA;

A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());

MEDIA =  ((A * 3.5) + (B * 7.5)) / (3.5 + 7.5);

Console.WriteLine("MEDIA = "+ MEDIA.ToString("F5"));
*/
// Exercicio 14 -> beecrowd 1006 (Mediana boa)
/* 
double A, B,C , MEDIA;

A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());
C = double.Parse(Console.ReadLine());

MEDIA = ((A * 2) + (B * 3)+ (C * 5)) / (2 + 3 + 5);

Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
*/
// Exercicio 15 -> proposta de exercicio resolvida (Calculo da area, perimetro e diagonal do retangulo)
/* 
double A, B,areaR,perimetroR,diagonalR;

A = double.Parse(Console.ReadLine());
B = double.Parse(Console.ReadLine());

areaR = A * B;
perimetroR = 2 * (A + B);
diagonalR = Math.Sqrt(Math.Pow(B,2) + Math.Pow(A,2));

Console.WriteLine("Area = "      + areaR.ToString("F4"));
Console.WriteLine("perimetro = " + perimetroR.ToString("F4"));
Console.WriteLine("diagonalR = " + diagonalR.ToString("F4"));
*/
// Exercicio 16 -> proposta de exercicio resolvida (fatiamento de strings)
/*
string nomeUm, nomeDois;
double idadeUm, idadeDois;

string[] vetorUm = Console.ReadLine().Split(' ');
string[] vetorDois = Console.ReadLine().Split(' ');

nomeUm = vetorUm[0];
nomeDois = vetorDois[0];
idadeUm = double.Parse(vetorUm[1]);
idadeDois = double.Parse(vetorDois[1]);
double media = (idadeDois + idadeUm)/ 2;

Console.WriteLine("A idade de " + nomeUm + " e " + nomeDois + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos.");
 */
// Exercicio 17 -> Beecrowd 1009 (Salario com bonus)
/* 
string nome;
double TotalDeVendas, SalarioFixo, Total;

nome = Console.ReadLine();
SalarioFixo = double.Parse(Console.ReadLine());
TotalDeVendas = double.Parse(Console.ReadLine());

Total = TotalDeVendas * 15/100 + SalarioFixo;

Console.WriteLine("TOTAL = R$ "+ Total.ToString("F2"));
*/
// Exercicio 18 -> Beecrowd 1011 (Sphere)
/* 
double Radius, Pi,VOLUME;

Radius = double.Parse(Console.ReadLine());
Pi = 3.14159;

VOLUME = (4.0 / 3) * Pi * Math.Pow(Radius, 3);

Console.WriteLine("VOLUME = "+ VOLUME.ToString("F3"));
*/
// Exercicio 19 -> Beecrowd 1012 (Area Total)
/*
double A, B, C,Pi,TRIANGULO,TRAPEZIO,CIRCULO,QUADRADO,RETANGULO;

string[] v1 = Console.ReadLine().Split(' ');
A = double.Parse(v1[0]);
B = double.Parse(v1[1]);
C = double.Parse(v1[2]);
Pi = 3.14159;

TRIANGULO = A * C / 2;
CIRCULO = Pi * Math.Pow(C,2);
TRAPEZIO = (A + B)* C / 2;
QUADRADO = Math.Pow(B, 2);
RETANGULO = A * B;

Console.WriteLine("TRIANGULO: "+TRIANGULO.ToString("F3"));
Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3"));
Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3"));
Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3"));
Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3"));
*/
// Exercicio 20 -> Beecrowd 1013 (eh o maior)
/* 
int A,B, C,Resultado;

string[] v1 = Console.ReadLine().Split(' ');
A = int.Parse(v1[0]);
B = int.Parse(v1[1]);
C = int.Parse(v1[2]);

Resultado = (A + B + Math.Abs(A - B)) / 2;
int InsaResult = (Resultado + C + Math.Abs(Resultado - C)) / 2;

Console.WriteLine($"{InsaResult} eh o maior");
*/
// Exercicio 21 -> Beecrowd 1015 (a distancia de dois pontos)
/*
double x1, y1, x2, y2;

string[] p1 = Console.ReadLine().Split(' ');
string[] p2 = Console.ReadLine().Split(' ');

x1 = double.Parse(p1[0]);
y1 = double.Parse(p1[1]);

x2 = double.Parse(p2[0]);
y2 = double.Parse(p2[1]);

double equation = Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2);
double distance = Math.Sqrt(equation);

Console.WriteLine(distance.ToString("F4"));
*/
// Exercicio resolvido Beecrowd 1019 (conversao do tempo) 
// nota: horas e o input / 3600, minuto e resto / 60 e segundo e resto % 60
/* 
int N, restante,horas,minutos,segundos;

N = int.Parse(Console.ReadLine());

horas = N / 3600;
restante = N % 3600;

minutos = restante / 60;
segundos = restante % 60;

Console.WriteLine(horas+":"+minutos+":"+segundos);
*/
// Exercicio Beecrowd 1018 mod(resto) (Banking motes)
/*
int N, cem,cento,cinquenta,vinte,vinto,dez,dento,cinto,cinco,dois,donto,um,umto;

N = int.Parse(Console.ReadLine());

cem = N / 100;
cento = N % 100;
cinquenta = cento / 50;

vinte = cento % 50;
vinto = vinte / 20;

dez = vinte % 20;
dento = dez / 10;

cinco = dez % 10;
cinto = cinco / 5;

dois = cinco % 5;
donto = dois / 2;

um = dois % 2;
umto = um / 1;

Console.WriteLine(N);
Console.WriteLine(cem + " nota(s) de R$ 100,00");
Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
Console.WriteLine(vinto + " nota(s) de R$ 20,00"); 
Console.WriteLine(dento + " nota(s) de R$ 10,00");
Console.WriteLine(cinto + " nota(s) de R$ 5,00");
Console.WriteLine(donto + " nota(s) de R$ 2,00");
Console.WriteLine(umto  + " nota(s) de R$ 1,00");
*/
// Exercicio Beecrowd 1020 (Age in days)
/* 
int  anos, meses, dias;

dias = int.Parse(Console.ReadLine());

anos = dias /365;
dias %= 365;
meses = dias / 30;
dias %= 30;

Console.WriteLine(anos + " ano(s)");
Console.WriteLine(meses+ " mes(es)");
Console.WriteLine(dias + " dia(s)");
*/
// Exercicio Beecrowd 1021 (baking motes and coins)
/* 
double N;
int quociente, resto;

N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Um pouco de ajuda veio do codigo https://github.com/acenelio/curso-logica-de-programacao-csharp/blob/master/uri1021/uri1021/Program.cs

// Vamos multiplicar N por 100 e forçar a conversão para int.
// Desse modo, por exemplo, 576.73 vai se tornar 57673

// Vamos tambem somar 0.5 antes de converter, para assegurar 
// que o numero seja devidamente arredondado, pois o tipo double
// as vezes da problema de arredondamento (por exemplo: se digitarmos
// 576.81 e multiplicarmos por 100, o resultado sera 57680.99999999,
// dai o casting resultaria em 57680 e nao 57681 como desejado)

resto = (int)(N * 100.0 + 0.5);

// X- NOTAS -X
// Notas de 100.00
quociente = resto / (100 * 100);
resto = resto % (100 * 100);

Console.WriteLine("NOTAS:");
Console.WriteLine(quociente + " nota(s) de R$ 100.00");
// Notas de 50.00
quociente = resto / (50 * 100);
resto = resto % (50 * 100);
Console.WriteLine(quociente + " nota(s) de R$ 50.00");
// Notas de 20.00
quociente = resto / (20 * 100);
resto = resto % (20 * 100);
Console.WriteLine(quociente + " nota(s) de R$ 20.00");
// Notas de 10.00
quociente = resto / (10 * 100);
resto = resto % (10 * 100);
Console.WriteLine(quociente + " nota(s) de R$ 10.00");
// Notas de 5.00
quociente = resto / (5 * 100);
resto = resto % (5 * 100);
Console.WriteLine(quociente + " nota(s) de R$ 5.00");
// Notas de 2.00
quociente = resto / (2 * 100);
resto = resto % (2 * 100);
Console.WriteLine(quociente + " nota(s) de R$ 2.00");
Console.WriteLine("MOEDAS:");
//  X- MOEDAS -X
//  Moedas de 1.00
quociente = resto / 100;
resto = resto % 100;
Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
// Moedas de 0.50 
quociente = resto / 50;
resto = resto % 50;
Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
// Moedas de 0.25
quociente = resto / 25;
resto = resto % 25;
Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
// Moedas de 0.10
quociente = resto / 10;
resto = resto % 10;
Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
// Moedas de 0.05
quociente = resto / 5;
resto = resto % 5;
Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
// Moedas 0.01
quociente = resto / 1;
Console.WriteLine(quociente + " moeda(s) de R$ 0.01");
*/
// Exercicio Beecrowd 1061 (Desafio - intepretação -> Event time)
/* 
int I_D, inicio_Horas, inicio_Minutos, inicio_Segundos, F_D, fim_Horas,fim_Minutos, fim_Segundos,totalInicioSegundos,totalFimSegundos, Dias,Horas,Minutos,Segundos,totalDuraçãoEmSegundos;
// Inicio do evento V
string[] inicio_Dia = Console.ReadLine().Split(' ');
I_D = int.Parse(inicio_Dia[1]);

string[] inicio_Horario = Console.ReadLine().Split(' ');
inicio_Horas = int.Parse(inicio_Horario[0]);
inicio_Minutos = int.Parse(inicio_Horario[2]);
inicio_Segundos = int.Parse(inicio_Horario[4]);
// Fim do evento V
string[] fim_Dia = Console.ReadLine().Split(' ');
F_D = int.Parse(fim_Dia[1]);

string[] fim_Horario = Console.ReadLine().Split(' ');
fim_Horas = int.Parse(fim_Horario[0]);
fim_Minutos = int.Parse(fim_Horario[2]);
fim_Segundos = int.Parse(fim_Horario[4]);
//  Calculo todo dos segundos para cada componente e o calculo total
totalInicioSegundos = I_D * 24 * 3600 + inicio_Horas * 3600 + inicio_Minutos * 60 + inicio_Segundos;
totalFimSegundos = F_D * 24 * 3600 + fim_Horas * 3600 + fim_Minutos * 60 + fim_Segundos;
totalDuraçãoEmSegundos = totalFimSegundos - totalInicioSegundos;
// Calculo da transformação de dias
Dias = totalDuraçãoEmSegundos / (24 * 3600);
totalDuraçãoEmSegundos %= (24 * 3600);

Horas = totalDuraçãoEmSegundos / 3600;
totalDuraçãoEmSegundos %= 3600;

Minutos = totalDuraçãoEmSegundos / 60;
totalDuraçãoEmSegundos %= 60;

Segundos = totalDuraçãoEmSegundos;
Console.WriteLine("==X==X==X==X==");
// Fim e impressao dos dados como solicitado
Console.WriteLine($"{Dias} dia(s)");
Console.WriteLine($"{Horas} hora(s)");
Console.WriteLine($"{Minutos} minuto(s)");
Console.WriteLine($"{Segundos} segundo(s)");
*/