Implicit Coversion is done by compiler
1>when there is no loss of information is coversion is done
2>if there is no possibility of throwing exception during the conversion

Converting an int to float will not lose information and no exception will be thrown hence implicit conversion is possible

whereas as when converting a float to an int, we lose fractional part and also a possibility of overflow exception,Hence in this case an explicit conversion is required.For explicit conversion we can use cast operator or convert class in c#

