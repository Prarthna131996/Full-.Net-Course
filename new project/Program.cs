// See https://aka.ms/new-console-template for more information
using Microsoft.Win32.SafeHandles;
using new_project;
using projectA.TeamA;
using System.Runtime.CompilerServices;
using System.Text;

////Console.WriteLine("Hello, World!");

////methodclass objx = new methodclass();
////objx.dox();
////objx.multiply(45, 45);
////int result = objx.divide(72,9);
////Console.WriteLine("the divison is " + result);
////objx.sum(new[]{3, 3, 3, 3, 3, 3, 3, 3, 3, });
////int result1 = objx.sums(new[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, });
////Console.WriteLine("the total is array num is " + result1);
////int[] result2 = objx.subs(5, 5);
////foreach (int i in result2)
////    Console.WriteLine(i);
////objx.xx(2, 2, 22, 2, 2, 2, 2);
////int result3 = objx.dums(34, 34, 34, 34, 3, 43, 43, 343);
////Console.WriteLine(result3);


////car objcar = new car();
////objcar.varint = 543;
////Console.WriteLine(objcar.varint);
////objcar.varstring = "rashi gupta";
////Console.WriteLine(objcar.varstring);

//////prpterty///

////objcar.noofseat = 4;
////Console.WriteLine(objcar.noofseat);
////objcar.color = "blue";
////Console.WriteLine(objcar.color);
////objcar.name = "honda";
////Console.WriteLine(objcar.name);

///////method//

////int result = objcar.Break(100);
////Console.WriteLine(result);
////int result2 = objcar.Clucth(100*2);
////Console.WriteLine(result2);

/////////////////types of methods/////////////
//using new_project;
//using System.Drawing;

////methodClass1 objmethod = new methodClass1();
////objmethod.number();
////Console.WriteLine(objmethod.number);
////objmethod.value(5, 5);
////string result = objmethod.num("rashi", "gupta");
////objmethod.apple( new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 });
////string result1 = objmethod.mangoes(new string[] { "qq", "aa", "ww", "ss" });
////Console.WriteLine(result1);
////int result2 = objmethod.pine(new int[] { 45, 4, 545, 4, 5, 767, 8765, 4564 });
////Console.WriteLine(result2);
////string[] result3 = objmethod.fruits("watermelon", "gavava", "banana");
////foreach (string s in result3)
////Console.WriteLine(s);
////objmethod.banana( 456,"eraa", "reas", "ertyb", "etsy");
////int result4 = objmethod.blows("rashi" ,5, 3, 66, 4, 6, 4, 56, 5, 3, 5);
////Console.WriteLine(result4);
////int result5 = objmethod.varint(9, 9);
////Console.WriteLine(result5);
////objmethod.varint("rashi", 25);

////  int result6 = objmethod.digi(9, 9);
////Console.WriteLine("the action of  two numbers are "   + result6);

/////////////////CONSTRUCTOR//////////////

////constructor bb = new constructor();
////Console.WriteLine(bb.varint);
////Console.WriteLine(bb.varbool);

////constructor bb2 = new constructor("yours" ,4,7);
////constructor bb3 = new constructor(8,9);

////way objway = new way();
////objway. _color = "voilet";
////Console.WriteLine(objway. _color);
////Console.WriteLine(objway.clothes);

//////copy constructor
////bb2.number = 1;
////bb2.color = "green";

////constructor copy = new constructor(bb2);
////Console.WriteLine(copy.number);
////Console.WriteLine(copy.color);

////static constructor//
////constructor.varint2 = 990;
////Console.WriteLine(constructor.varint2);
////constructor ce = new constructor();
////constructor ce2 = new constructor();
////constructor ce3 = new constructor();

////memmorymanage objce = new memmorymanage();

////Console.WriteLine(objce.drew);

////objce.drew = 89;
////Console.WriteLine(objce.drew);

////memmorymanage ce2 = new memmorymanage();
////Console.WriteLine(ce2.drew);

////ce2. drew = objce.drew;
////Console.WriteLine(ce2.drew);
////objce.drew = 3421;
////Console.WriteLine(objce.drew);
////ce2 .drew = objce.drew;
////Console.WriteLine(ce2.drew);

/////static keywords//
////memmorymanage.staticmethod(3, 6);
////memmorymanage objnum = new memmorymanage();
////objnum.color("black", "white");

////////////////////////////////////////////////INHERITANCE/////////////////////

////parent objparent = new parent();
////objparent.apple();
////child objchild = new child();    
////objchild.apple();
////objchild.banana();
////grandchild objgrand = new grandchild();
////objgrand.apple();
////objgrand.banana();
////objgrand.pomo();

////parent1 objp = new parent1();
////objp.parentmethod1();
////Console.WriteLine("============================");
////child1 objc = new child1();
////objc.parentmethod1();
////objc.childmethod1 ();
////Console.WriteLine("================================");
////child2 objcc = new child2();
////objcc.parentmethod1();
////objcc.childmethod2 ();
////Console.WriteLine("=============================");
////grandchild1 objg = new grandchild1();
////objg.parentmethod1();
////objg.childmethod1 ();
////objg.grandchildmethod1 ();
////Console.WriteLine("========================");
////grandchild2 objg2 = new grandchild2();
////objg2.parentmethod1();
////objg2.childmethod2 ();
////objg2.grandchildmethod2 ();


//////////////////////////OVERRINDING AND 
////objparent.parentmethod();
////Child objchild = new Child();
////objchild.parentmethod();
////Grandchild objgrandchild = new Grandchild();
////objgrandchild.parentmethod();

////HIDING///////////////////////////

////mango objmango = new mango();
////objmango.mangomethod();

////mango objmango = new lichi();
////objmango.mangomethod();
////lichi objlichi = new kiwi();
////objlichi.lichimethod();
////objlichi.mangomethod();

///////////////access modifiers////////

////modifiers objmodifiers = new modifiers();
////objmodifiers.varint = 98;
////objmodifiers.varint3 = 45;
////objmodifiers.varint5 = 5555555;


////num objnum = new num();
//////objnum.varint = 67;
////objnum.nummethod();




//////////////////Interface//////////
////Car objcar = new Car();
////objcar.StartEngine();
////objcar.StopEngine();
////objcar.Wheels = 4;
////Console.WriteLine("the wheels are " + objcar.Wheels);
////int result = objcar.Noofbox(11, 5);
////Console.WriteLine("the no of box are " + result);
/////////multiple implementation/////////
////objcar.Memmory = 256;
////Console.WriteLine(" the memmoy of icloud is " + objcar.Memmory);
////objcar.Photos();
///////class implementation//
////objcar.Number = 7;
////Console.WriteLine(" the prize is " + (int)objcar.Number);
////objcar.Testmethod();
///////////////////explicit//
////Iveichle objex = new Car();
////objex.Testmethod();
////Icloud objco = new Car();
////objco.Testmethod();


/////////////////////////////////////////abstraction////////////

//Dog objdog = new Dog();
//objdog.count = 54;
//Console.WriteLine("the count is : " + objdog.count);
//objdog.test1();
//string result1 = objdog.makesound("awwww");
//Console.WriteLine(" the makesound is : " + result1);

////////////////collection///////

////collection obc = new collection();
////obc.Cmethod();

//program objp = new program();
//objp.main();

//using new_project;

//CollectionExample objCE = new CollectionExample();

////objCE.hastableexample();
////objCE.DictionaryExample();
////objCE.StackExample();
////objCE.StackExample2();
//objCE.QueueExample();
//objCE.QueueExample2();

////////////////////////////////methodss//

//MethodExample objME = new MethodExample();
//objME.Number();
//objME.Number2(5, 5);
//object result = objME.Number3(9, " rashi");
//Console.WriteLine(result);
//objME.arraynum ( new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 });
//int result = objME.Yuvi(new int[] { 6, 6, 6, 6, 6, 6, 6, 6, 6,6 });
//string[] result = objME.Animal("dog", "cat");
//foreach (string s in result)
//    Console.WriteLine(s);

//objME.num("heena" , 4,5,43,2,5,8,7,6,9);

//int result = objME.Nrew("ititka", 55, 5, 55, 5, 5, 5, 5, 55, 5, 55);

//PropertyMethod objPM = new PropertyMethod();
//objPM.Name = "hyudai";
//objPM.Color = "black";
//objPM.Value = 45;
//objPM.Number = 90;
//Console.WriteLine(objPM.Name);
//Console.WriteLine(objPM.Color);
//Console.WriteLine(objPM.Value);
//Console.WriteLine(objPM.Number);

//int p = 1000;
//int result = objPM.Acclerator(1000);
//Console.WriteLine(result);
//int result2 = objPM.Balance(1000);
//Console.WriteLine(result2);

//Ways ways = new Ways();
//ways.number = 100;
//Console.WriteLine(ways.number);
//Console.WriteLine(ways.pro);
//int result = ways.Vox(5, 5);
//Console.WriteLine(result);
//ways.Vox(9, 5,2);


//////////constructor

//ConstructorExample CE = new ConstructorExample();
//ConstructorExample.digit();
//Console.WriteLine(ConstructorExample.digit);
//Console.WriteLine(CE.number);
//Console.WriteLine(CE.name);

//ConstructorExample CE2 = new ConstructorExample(8,9);
//ConstructorExample CE3 = new ConstructorExample(10,"himanshi");

//CE3.color = "blue";
//CE3.varint = 78;
//ConstructorExample CE4 = new ConstructorExample(CE3);
//Console.WriteLine(CE4.color);
//Console.WriteLine(CE4.varint);
//static constructor








/////////static examples 

//StaticExample objSE = new StaticExample();
//Console.WriteLine(objSE.name);
//objSE.name = "hari";
//Console.WriteLine(objSE.name);
//StaticExample objSE2 = new StaticExample(); 
//Console.WriteLine(objSE2.name);
//objSE2 = objSE;
//Console.WriteLine(objSE2.name);
//objSE.name = "rani";
//Console.WriteLine(objSE.name);
//Console.WriteLine(objSE2.name);

//objSE = null;
////Console.WriteLine(objSE.name);
//Console.WriteLine(objSE2.name);

//StaticExample.color = "ii";
//Console.WriteLine(StaticExample.color);
//StaticExample.srik();
//objSE.nums();
//int result = objSE.Number(5, 6);
//Console.WriteLine(result);
//objSE.name = "tt";
//Console.WriteLine(objSE.name);


//////////////////////INHERITANCE

// InheritanceExample objIE = new InheritanceExample();
//objIE.color = 34;

//Console.WriteLine(objIE.color);
//Childs childs = new Childs();
//childs.name = "your are good";
//Console.WriteLine(childs.name);
//childs.color = 45;
//Console.WriteLine(childs.color);
//Grandchilds grandchilds = new Grandchilds();
//grandchilds.color = 56;
//grandchilds.name = "great";
//grandchilds.numbers = 233;
//Console.WriteLine(grandchilds.numbers);
//Console.WriteLine(grandchilds.color);
//Console.WriteLine(grandchilds.name);


//ParentMethod objP = new ParentMethod();
//objP.p();
//Console.WriteLine("===============");
//ChildMethod objC = new ChildMethod();
//objC.p();
//objC.c();
//Console.WriteLine("=================");
//ChildMethod2 objC2 = new ChildMethod2();
//objC2.p();
//objC2.c2();
//Console.WriteLine("====================");
//GrandChild objg = new GrandChild();
//objg.p();
//objg.c();
//objg.g();
//Console.WriteLine("=======================");
//GrandChild2 objg2 = new GrandChild2();
//objg2.p();
//objg2.c2();
//objg2.g2();

////////////////////method overridng////////

//Couple couple = new Couple();
//couple.A();

//Creek creek = new Creek();
//creek.A();

//Couple objc = new Creek();
//objc.A();

//Grovy grovy = new Grovy();
//grovy.A();

///method hiding 

//apple objapple = new apple();
//int result = objapple.sum(5, "hello");
////Console.WriteLine(result);

//mangoes objmango = new mangoes();
//int result1 = objmango.sum(5, 5);
//Console.WriteLine(result1);

//Banana objbanana = new Banana();
//objbanana.sum = 67;
//Console.WriteLine(objbanana.sum);


//apple objapple2 = new mangoes();
//int result = objapple2.sum(3, "90");
////Console.WriteLine(result);

//int result2 = objapple2.sum(9, 9);

///////////////////interface////////

//Tempon objT = new Tempon();
//objT.sum();
//int result = objT.sum2(5, 5);
//Console.WriteLine(result);
//objT.Sum3 = 5;
//Console.WriteLine(objT.Sum3);
//objT.test();
//objT.Sums = 54546;
//Console.WriteLine(objT.Sums);
//objT.method1();

//explicitly//

//Imath1 objI = new Tempon();
//objI.method1();

//Imath2 objI2 = new Tempon();
//objI2.method1();

///////C//////////ABSTRACTION/////////

//ClassMethod objCM = new ClassMethod();
//int result = objCM.Money(9, 4);
//Console.WriteLine(result);
//objCM.TestMethod();

////////////////COLLECTIONS ///////////

//CollectionExampless objCE = new CollectionExampless();
//objCE.Animals();
//objCE.Parrot();
//objCE.Diwali();
//objCE.Christmis();

//genricexample objGE = new genricexample();
//objGE.testmethod();
//objGE.testmethod2();
//objGE.testMthod3();
//objGE.testmethod4();

//ExceptionHandaling objEH = new ExceptionHandaling();
//objEH.TestMethod();
//objEH.TestMethod2(3);

//Console.WriteLine("plz enter your name");
//string Name = Console.ReadLine();
//Console.WriteLine("your last name");
//string Last = Console.ReadLine();   
//Console.WriteLine("hello {0},{1} " , Name , Last);

//int a = 90;
//Console.WriteLine("minvalue={0}", int.MinValue);
//Console.WriteLine("maxvalue={0}", int.MaxValue);


//string Name = "\"Aradhya\"";
//Console.WriteLine(Name);
//string Count = @"one\n two\n three";//verbatim
//Console.WriteLine(Count);
//string Names = "rashi\tgupta";
//Console.WriteLine(Names);
//string a = "rashi\bgupta";
//Console.WriteLine(a);

//int number = 21;
//bool isnumber = number== 21?true:false;




//if (number == 11)
//{
//    isnumber = true;
//}
//else
//{ isnumber = false; }

//Console.WriteLine("number = {0}",isnumber);

//int?ticketonsale = 100;
//int availabletickets = ticketonsale ?? 0;
//Console.WriteLine("tickets are {0}" , availabletickets);

//parse//

//string str = "1234";
//int n =int.Parse(str);
//Console.WriteLine(n);

////tryparse 

//string str2 = "123apv";
//int result = 0; 
//bool n2 =int.TryParse(str2 ,out  result);
//if (n2)
//    Console.WriteLine(result);
//else
//    Console.WriteLine("invalid number");



//Console.WriteLine("enter your number");
//int number = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//while(count<=number)
//{
//    Console.Write(count + " ");
//    count = count + 2;
//}

////////practice

//practice objP = new practice();
//objP.TestMethod();
//practice.fruits();
//int z = default;
//practice.veg( ref z);
//objP.Method1();
//objP.Method2(100, out );
//ṇṇobjP.Num1(3,5,5,5,6,7,6,7,6,7,6,6);
//int result = objP.num2( 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 );



//circle objc = new circle(5);
//float area = objc.Apple();
//Console.WriteLine("area= {0}",area);
//circle objc2 = new circle(9);
//float area2 = objc2.Apple();
//Console.WriteLine("area = {0} " ,area2);    

//Console.WriteLine("minvalue ={0} " , uint.MinValue);    
//Console.WriteLine("maxvalue = {0} " , ulong.MaxValue);  

//string Name = "\"RASHI\"";
//Console.WriteLine(Name);

//string Count = "one\n two\n three\n four";
//Console.WriteLine(Count);

//string First = "Rashi\\GUPTA";
//Console.WriteLine(First);

//int Num = 33;
//bool isvalue = Num ==10 ? true : false;
//Console.WriteLine("Number ={0}" , isvalue);

//int num = 12;
//bool Ser;
//if (num == 12)
//{
//    Console.WriteLine(Ser = true);
//}
//else
//{
//    Console.WriteLine(Ser = false);
//}


//int? ticketonsale = 10;
//int availableticket = ticketonsale==100? 100 : 0; 
//Console.WriteLine(availableticket);
//if (ticketonsale == null)
//{    
//    availableticket = 0;
//    Console.WriteLine("availableticket ={0}",availableticket);
//}
//else
//{
//    availableticket = ticketonsale.Value;
//    Console.WriteLine("availableticket ={0}",availableticket);
//}

//implicit and explicit conversion 

//int i = 1123;
//int f = i;
//Console.WriteLine(f);

//float u = 123.45f;
//int i = Convert.ToInt32(u);
//Console.WriteLine(i);

//string Number = "190";
//int a = Convert.ToInt32(Number);
//Console.WriteLine(a);


//string value = "123abc";
//int result;
//bool sucess = int.TryParse(value, out result);
//if (sucess)
//{
//    Console.WriteLine("sucessfull = {0} ", result);

//}
//else
//{
//    Console.WriteLine("invalid opertaion");
//}

//Parameters objP = new Parameters();
//int result = 0;
//objP.valuemethod();
//objP.valuemethod2(10,5,out result);

/*CExamples.color = "black";
CExamples C = new CExamples("rashi" , "Gupta");
C.FullName();
CExamples C2 = new CExamples(C);
C2.FullName();
Console.WriteLine(C2.FullName);
Console.WriteLine(C);
Luv objL = new Luv(5);
float area = objL.totalarea();
Console.WriteLine(area);*/

//FullEmployee objFE = new FullEmployee();
//objFE.FirstName = "Rashi";
//objFE.LastName = "Gupta";
//objFE.Email = "www.Goolge";
//objFE.Yearly = 50000;
//Console.WriteLine(objFE.FirstName);
//Console.WriteLine(objFE.LastName);
//Console.WriteLine(objFE.Email);
//Console.WriteLine(objFE.Yearly);
//objFE.FullName();

//PartEmployee partFE = new PartEmployee();
//partFE.FirstName = "Shiva";
//partFE.LastName = "Gupta";
//partFE.Email = " kk@gmail.com";
//partFE.hourly = 1200;
//Console.WriteLine(partFE.FirstName);
//Console.WriteLine(partFE.LastName);
//Console.WriteLine(partFE.Email);
//Console.WriteLine(partFE.hourly);
//partFE.FullName();

////////method hiding 

//baseclass baseclass = new baseclass();
//baseclass.BaseMethod();

//baseclass objB = new ChildBase();
//objB.BaseMethod();

//ChildBase objC = new grandbase();
//objC.BaseMethod();

//method override

//b objb = new c();
//objb.Method();
//c objc = new g();
//objc.Method();

//interface 

//T objT = new T();
//objT.Test1();
//objT.Name = "Himanshi";
//Console.WriteLine(objT.Name);
//int result = objT.Sum(30, 40);
//Console.WriteLine(result);

//Cars objC = new Cars();
//objC.Method();
//objC.Method2 = 100;
//Console.WriteLine(objC.Method2);
//int result = objC.Number(34);
//Console.WriteLine(result);

//Veichle objV = new Veichle();
//objV.Method();

//Bus2 bus2 = new Veichle();
//bus2.Method();

//Bus objB = new Veichle();
//objB.Method();

//    Quess objQ = new Quess();
//objQ.Id = 102;
//Console.WriteLine(objQ.Id);

//delegate 
/*DelegatesExample objD = new DelegatesExample();
DelegateTestMethod objDTM = new DelegateTestMethod(objD.Testmethod);
DelegateTestMethod objDTM2 = new DelegateTestMethod(objD.Testmethod2);


objDTM(100);
objDTM(200); */

//List<employee> emplist = new List<employee>();
//new employee() {Id = 1 ,Name ="priti",salary=50000,experience = 2};
//new employee() { Id = 2, Name = "prateek", salary = 51000, experience = 5 };
//new employee() { Id = 3, Name = "paritosh", salary = 53000, experience = 10 };



//employee empObj = new employee();
////empObj.promotemployee(emplist);  
//empObj.promotemployee(emplist, num => num.experience >= 5);

//refandout objRF = new refandout();
//objRF.nummethod();
//objRF.sum(23, 23);
//objRF.sum(23, 4, 44, 4, 4, 4, 44, 4, 4, 4, 4);
//Console.WriteLine("pas marks "  + objRF.PassMarks);

///////////////exception //
///
//ExceptionHandlings objEh = new ExceptionHandlings();
//objEh.Method1();
///////////////////CUSTOM
/*Custom custom = new Custom();
try
{
   custom.Test();
}
catch(UserAlreadyLoggedIn ex)
{
   Console.WriteLine(ex.Message);
}*/
///////////////////enums 

/*EnumsExaples[] objE = new  EnumsExaples[3];
objE[0] = new EnumsExaples
{
    name = "rashi",
    gender = 0
};
objE[1] = new EnumsExaples
{
    name = "hema",
    gender = 1
};
objE[2] = new EnumsExaples
{
    name = "priya",
    gender = 2
};

foreach(var e in objE)
{
    Console.WriteLine(e.name + "  "  + e.gender);
}*/

/////genrics 

//Calculater objC = new Calculater();
//  bool value = objC.value(6, 8);
//if (value)
//{
//    Console.WriteLine("equal");
//}
//else
//{
//    Console.WriteLine("not equal");
//}

//int i = 10;
//Console.WriteLine(i.ToString());

/*string Name = "welcome";
Name  += "it";
Name += "experts";
Name += "era";
Console.WriteLine(Name);
StringBuilder sa = new StringBuilder();
sa.Append("hello");
sa.Append("welcoe");
Console.WriteLine(sa.ToString());*/

//int a = 10;
//int b = 20;
//Console.WriteLine("number before swaping " + "  = " + a);
//Console.WriteLine("number before swaping" + "  = " + b);
//Console.WriteLine("===============================");

//int c = a;
//a = b;
//b = c;

// a = a + b; //10+20 = 30
//b = a - b;//30-20 = 10
//a = a - b;//30-10 = 20


//a = a * b;//10*20 = 200
//b = a / b; //200/20 = 10
//a = a / b; //200/10 = 20

//Console.WriteLine("number after swaping" +"  = " + a);
//Console.WriteLine("number after swaping" + "  = "  + b);

try
{
    int a = 10;
    int b = 0;
    int result = a/b;
}
catch (Exception ex)
{
    throw ; // Stack trace: DivideByZeroException at 'throw ex' location
}
int one = 10;
int two = 0;
Console.WriteLine(one + two);

Console.ReadLine();