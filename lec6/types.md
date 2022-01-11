in C# types are divided into 3 categories
value Types -> int,float,double,struct,enums,etc
reference Types -> interface,class,delegates,array etc

By default values types are non nullable
To make them nullable we use ?
int i=0( i is non nullable so "i" can't be set to null i=null will generate compile error)
int? j=0( j is nullable int,so j=null is legal)

Nullable type are bridge difference b/w c# types and database type