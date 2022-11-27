using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Calendar 
{
    public static void InfoCalendar(){
        Console.Clear();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                              Calendar 2022                                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|      01 January         |       02 February       |      03 March          |      04 April          |");
        Console.WriteLine("|      05 May             |       06 June           |      07 July           |      08 August         |");
        Console.WriteLine("|      09 September       |       10 October        |      11 November       |      12 December       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(" (13) <<- Back.");
        Console.Write("Choose number (1-12) : ");
        Calendarnum calendarnum = (Calendarnum)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (calendarnum) {
            case Calendarnum.January:
                ShowInfoCalendar1();
                break;
            case Calendarnum.February:
                ShowInfoCalendar2();
                break;
            case Calendarnum.March:
                ShowInfoCalendar3();
                break;
            case Calendarnum.April:
                ShowInfoCalendar4();
                break;
            case Calendarnum.May:
                ShowInfoCalendar5();
                break;
            case Calendarnum.June:
                ShowInfoCalendar6();
                break;
            case Calendarnum.July:
                ShowInfoCalendar7();
                break;
            case Calendarnum.August:
                ShowInfoCalendar8();
                break;
            case Calendarnum.September:
                ShowInfoCalendar9();
                break;
            case Calendarnum.October:
                ShowInfoCalendar10();
                break;
            case Calendarnum.November:
                ShowInfoCalendar11();
                break;
            case Calendarnum.December:
                ShowInfoCalendar12();
                break;
            case Calendarnum.PreviousPage:
                BackToPrintListMenuWhenLogin();
                break;
        default:
            break;
        }
    }

    static void BackToPrintListMenuWhenLogin() {
        Console.Clear();
        Program.PrintListMenuWhenLogin();
    }

    static void BackToInfoCalendar() {
        Console.Clear();
        InfoCalendar();
    }

    public static void ShowInfoCalendar1() {
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             January 2022                                              ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                                                         |      01      |     02     |");
        Console.WriteLine("|     03      |      04      |       05       |      06      |     07     |      08      |     09     |");
        Console.WriteLine("|     10      |      11      |       12       |      13      |     14     |      15      |     16     |");
        Console.WriteLine("|     17      |      18      |       19       |      20      |     21     |      22      |     23     |");
        Console.WriteLine("|     24      |      25      |       26       |      27      |     28     |      29      |     30     |");
        Console.WriteLine("|     31      |                                                                                       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar2() {
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             February 2022                                             ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|             |      01      |       02       |      03      |     04     |      05      |     06     |");
        Console.WriteLine("|     07      |      08      |       09       |      10      |     11     |      12      |     13     |");
        Console.WriteLine("|     14      |      15      |       16       |      17      |     18     |      19      |     20     |");
        Console.WriteLine("|     21      |      22      |       23       |      24      |     25     |      26      |     27     |");
        Console.WriteLine("|     28      |                                                                                       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar3(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             March 2022                                                ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|             |      01      |       02       |      03      |     04     |      05      |     06     |");
        Console.WriteLine("|     07      |      08      |       09       |      10      |     11     |      12      |     13     |");
        Console.WriteLine("|     14      |      15      |       16       |      17      |     18     |      19      |     20     |");
        Console.WriteLine("|     21      |      22      |       23       |      24      |     25     |      26      |     27     |");
        Console.WriteLine("|     28      |      29      |       30       |      31      |                                        |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar4(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             April 2022                                                ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                                            |     01     |      02      |     03     |");
        Console.WriteLine("|     04      |      05      |       06       |      07      |     08     |      09      |     10     |");
        Console.WriteLine("|     11      |      12      |       13       |      14      |     15     |      16      |     17     |");
        Console.WriteLine("|     18      |      19      |       20       |      21      |     22     |      23      |     24     |");
        Console.WriteLine("|     25      |      26      |       27       |      28      |     29     |      30      |            |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar5(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             May 2022                                                  ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                                                                        |     01     |");
        Console.WriteLine("|     02      |      03      |       04       |      05      |     06     |      07      |     08     |");
        Console.WriteLine("|     09      |      10      |       11       |      12      |     13     |      14      |     15     |");
        Console.WriteLine("|     16      |      17      |       18       |      19      |     20     |      21      |     22     |");
        Console.WriteLine("|     23      |      24      |       25       |      26      |     27     |      28      |     29     |");
        Console.WriteLine("|     30      |      31      |                                                                        |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar6(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             June 2022                                                 ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                            |       01       |      02      |     03     |      04      |     05     |");
        Console.WriteLine("|     06      |      07      |       08       |      09      |     10     |      11      |     12     |");
        Console.WriteLine("|     13      |      14      |       15       |      16      |     17     |      18      |     19     |");
        Console.WriteLine("|     20      |      21      |       22       |      23      |     24     |      25      |     26     |");
        Console.WriteLine("|     27      |      28      |       29       |      30      |                                        |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar7(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             July 2022                                                 ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                                            |     01     |      02      |     03     |");
        Console.WriteLine("|     04      |      05      |        06      |      07      |     08     |      09      |     10     |");
        Console.WriteLine("|     11      |      12      |        13      |      14      |     15     |      16      |     17     |");
        Console.WriteLine("|     18      |      19      |        20      |      21      |     22     |      23      |     24     |");
        Console.WriteLine("|     25      |      26      |        27      |      28      |     29     |      30      |     31     |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar8(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             August 2022                                               ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     01      |      02      |       03       |      04      |     05     |      06      |     07     |");
        Console.WriteLine("|     08      |      09      |       10       |      11      |     12     |      13      |     14     |");
        Console.WriteLine("|     15      |      16      |       17       |      18      |     19     |      20      |     21     |");
        Console.WriteLine("|     22      |      23      |       24       |      25      |     26     |      27      |     28     |");
        Console.WriteLine("|     29      |      30      |       31       |                                                       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar9(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             September 2022                                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                             |      01      |     02     |      03      |     04     |");
        Console.WriteLine("|     05      |      06      |        07      |      08      |     09     |      10      |     11     |");
        Console.WriteLine("|     12      |      13      |        14      |      15      |     16     |      17      |     18     |");
        Console.WriteLine("|     19      |      20      |        21      |      22      |     23     |      24      |     25     |");
        Console.WriteLine("|     26      |      27      |        28      |      29      |     30     |                           |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar10(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             October 2022                                              ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                                                         |      01      |     02     |");
        Console.WriteLine("|     03      |      04      |       05       |      06      |     07     |      08      |     09     |");
        Console.WriteLine("|     10      |      11      |       12       |      13      |     14     |      15      |     16     |");
        Console.WriteLine("|     17      |      18      |       19       |      20      |     21     |      22      |     23     |");
        Console.WriteLine("|     24      |      25      |       26       |      27      |     28     |      29      |     30     |");
        Console.WriteLine("|     31      |                                                                                       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar11(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             November 2022                                             ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                    01      |       02       |      03      |     04     |      05      |     06     |");
        Console.WriteLine("|     07      |      08      |       09       |      10      |     11     |      12      |     13     |");
        Console.WriteLine("|     14      |      15      |       16       |      17      |     18     |      19      |     20     |");
        Console.WriteLine("|     21      |      22      |       23       |      24      |     25     |      26      |     27     |");
        Console.WriteLine("|     28      |      29      |       30       |                                                       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
    public static void ShowInfoCalendar12(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             December 2022                                             ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                             |      01      |     02     |      03      |     04     |");
        Console.WriteLine("|     05      |      06      |        07      |      08      |     09     |      10      |     11     |");
        Console.WriteLine("|     12      |      13      |        14      |      15      |     16     |      17      |     18     |");
        Console.WriteLine("|     19      |      20      |        21      |      22      |     23     |      24      |     25     |");
        Console.WriteLine("|     26      |      27      |        28      |      29      |     30     |      31      |            |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar();
    }
}