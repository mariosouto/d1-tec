# Valor vs Referencia

En C# tenemos dos clases de tipos, _Value Types_ y _Reference Types_. El CLR de .NET tiene tres posibles ubicaciones en donde guardar objetos de las que a nosotros nos interesarán dos de ellas, el _stack_ y el _managed heap_.

La información almacenada en el _stack_ puede crearse y destruírse fácilmente y su tiempo de vida está determinado por el scope que lo define.

La información almacenada en el _heap_ es controlada por el Garbage Collector de .NET, que determina su tiempo de vida.

Los _Value Types_ son ubicados en el _stack_ mientras que los _Reference Types_ se ubican en el heap.
