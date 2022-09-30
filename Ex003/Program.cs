Console.Write("Введите номер дня недели (от 1 до 7): ");
int weekDay=Convert.ToInt32(Console.ReadLine());
while (weekDay<1|weekDay>7){
    Console.Write("Вы ввели недопустимый номер дня недели, повторите ввод (от 1 до 7): ");  
    weekDay=Convert.ToInt32(Console.ReadLine());
}
if (weekDay==1) Console.WriteLine("Понедельник");
else if (weekDay==2) Console.WriteLine("Вторник");
else if (weekDay==3) Console.WriteLine("Среда");
else if (weekDay==4) Console.WriteLine("Четверг");
else if (weekDay==5) Console.WriteLine("Пятница");
else if (weekDay==6) Console.WriteLine("Суббота");
else if (weekDay==7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Вы ввели недопустимый номер дня недели");

