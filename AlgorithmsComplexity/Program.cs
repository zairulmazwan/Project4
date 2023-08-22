// See https://aka.ms/new-console-template for more information

//Generate random numbers example 1
Console.WriteLine("Random numbers example 1:");
List<int> data1 = DataClass.genNumbers(10);
DataClass.printList(data1);

//Generate random numbers example 2
Console.WriteLine("Random numbers example 2:");
List<int> data2 = DataClass.genRandomNumbers(15);
DataClass.printList(data2);

//Write the dataset to a file
DataClass.writeFile(data2);
