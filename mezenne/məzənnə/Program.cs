// See https://aka.ms/new-console-template for more information
float manat= 10f;

float dollar = manat / 1.7000f;

float avro = manat / 1.8282f;

float rubl = manat / 0.0265f;

Console.WriteLine("Amount" + " " + "(AZN)" + " " + ":" + " " + manat);

Console.WriteLine("US dollars"+" "+"(USD)"+" "+":"+" "+dollar);

Console.WriteLine("Avro"+" "+"(EUR)"+" "+":"+" "+ avro);

Console.WriteLine("Russian ruble"+" "+"(RUB)"+" "+":"+" "+ rubl);