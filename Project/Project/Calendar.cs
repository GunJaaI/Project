using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Calendar 
{
    public static void InfoCalendar() {
        Console.Clear();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                                Calendar                                               ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(" (1) <<- Calendar Year 2022");
        Console.WriteLine(" (2) <<- Calendar Year 2023");
        Console.WriteLine(" (3) <<- Back.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Choose number (1-3) : ");
        Calendarnum calendarnum = (Calendarnum)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (calendarnum) {
            case Calendarnum.Calendar2022:
                InfoCalendar2022();
                break;
            case Calendarnum.Calendar2023:
                InfoCalendar2023();
                break;
            case Calendarnum.PreviousPage:
                BackToPrintListMenuWhenLogin();
                break;
        default:
            break;
        }
    }

    public static void InfoCalendarForGuest() {
        Console.Clear();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                                Calendar                                               ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(" (1) <<- Calendar Year 2022");
        Console.WriteLine(" (2) <<- Calendar Year 2023");
        Console.WriteLine(" (3) <<- Back.");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.Write("Choose number (1-3) : ");
        Calendarnumforguest calendarnumforguest = (Calendarnumforguest)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (calendarnumforguest) {
            case Calendarnumforguest.Calendar2022:
                InfoCalendar2022ForGuest();
                break;
            case Calendarnumforguest.Calendar2023:
                InfoCalendar2023ForGuest();
                break;
            case Calendarnumforguest.PreviousPage:
                BackToPrintListMenuWhenGuestLogin();
                break;
        default:
            break;
        }
    }

    public static void InfoCalendar2022() {
        Console.Clear();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                              Calendar 2022                                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|      01 January         |       02 February       |      03 March          |      04 April          |");
        Console.WriteLine("|      05 May             |       06 June           |      07 July           |      08 August         |");
        Console.WriteLine("|      09 September       |       10 October        |      11 November       |      12 December       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(" (13) <<- Back.");
        Console.Write("Choose number (1-13) : ");
        Calendarnum2022 calendarnum2022 = (Calendarnum2022)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (calendarnum2022) {
            case Calendarnum2022.January:
                ShowInfoCalendar1_2022();
                break;
            case Calendarnum2022.February:
                ShowInfoCalendar2_2022();
                break;
            case Calendarnum2022.March:
                ShowInfoCalendar3_2022();
                break;
            case Calendarnum2022.April:
                ShowInfoCalendar4_2022();
                break;
            case Calendarnum2022.May:
                ShowInfoCalendar5_2022();
                break;
            case Calendarnum2022.June:
                ShowInfoCalendar6_2022();
                break;
            case Calendarnum2022.July:
                ShowInfoCalendar7_2022();
                break;
            case Calendarnum2022.August:
                ShowInfoCalendar8_2022();
                break;
            case Calendarnum2022.September:
                ShowInfoCalendar9_2022();
                break;
            case Calendarnum2022.October:
                ShowInfoCalendar10_2022();
                break;
            case Calendarnum2022.November:
                ShowInfoCalendar11_2022();
                break;
            case Calendarnum2022.December:
                ShowInfoCalendar12_2022();
                break;
            case Calendarnum2022.PreviousPage:
                BackToInfoCalendar();
                break;
        default:
            break;
        }
    }

    public static void InfoCalendar2023() {
        Console.Clear();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                              Calendar 2023                                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|      01 January         |       02 February       |      03 March          |      04 April          |");
        Console.WriteLine("|      05 May             |       06 June           |      07 July           |      08 August         |");
        Console.WriteLine("|      09 September       |       10 October        |      11 November       |      12 December       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(" (13) <<- Back.");
        Console.Write("Choose number (1-13) : ");
        Calendarnum2023 calendarnum2023 = (Calendarnum2023)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (calendarnum2023) {
            case Calendarnum2023.January:
                ShowInfoCalendar1_2023();
                break;
            case Calendarnum2023.February:
                ShowInfoCalendar2_2023();
                break;
            case Calendarnum2023.March:
                ShowInfoCalendar3_2023();
                break;
            case Calendarnum2023.April:
                ShowInfoCalendar4_2023();
                break;
            case Calendarnum2023.May:
                ShowInfoCalendar5_2023();
                break;
            case Calendarnum2023.June:
                ShowInfoCalendar6_2023();
                break;
            case Calendarnum2023.July:
                ShowInfoCalendar7_2023();
                break;
            case Calendarnum2023.August:
                ShowInfoCalendar8_2023();
                break;
            case Calendarnum2023.September:
                ShowInfoCalendar9_2023();
                break;
            case Calendarnum2023.October:
                ShowInfoCalendar10_2023();
                break;
            case Calendarnum2023.November:
                ShowInfoCalendar11_2023();
                break;
            case Calendarnum2023.December:
                ShowInfoCalendar12_2023();
                break;
            case Calendarnum2023.PreviousPage:
                BackToInfoCalendar();
                break;
        default:
            break;
        }
    }

    public static void InfoCalendar2022ForGuest() {
        Console.Clear();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                              Calendar 2022                                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|      01 January         |       02 February       |      03 March          |      04 April          |");
        Console.WriteLine("|      05 May             |       06 June           |      07 July           |      08 August         |");
        Console.WriteLine("|      09 September       |       10 October        |      11 November       |      12 December       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(" (13) <<- Back.");
        Console.Write("Choose number (1-13) : ");
        Calendarnum2022 calendarnum2022 = (Calendarnum2022)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (calendarnum2022) {
            case Calendarnum2022.January:
                ShowInfoCalendar1_2022();
                break;
            case Calendarnum2022.February:
                ShowInfoCalendar2_2022();
                break;
            case Calendarnum2022.March:
                ShowInfoCalendar3_2022();
                break;
            case Calendarnum2022.April:
                ShowInfoCalendar4_2022();
                break;
            case Calendarnum2022.May:
                ShowInfoCalendar5_2022();
                break;
            case Calendarnum2022.June:
                ShowInfoCalendar6_2022();
                break;
            case Calendarnum2022.July:
                ShowInfoCalendar7_2022();
                break;
            case Calendarnum2022.August:
                ShowInfoCalendar8_2022();
                break;
            case Calendarnum2022.September:
                ShowInfoCalendar9_2022();
                break;
            case Calendarnum2022.October:
                ShowInfoCalendar10_2022();
                break;
            case Calendarnum2022.November:
                ShowInfoCalendar11_2022();
                break;
            case Calendarnum2022.December:
                ShowInfoCalendar12_2022();
                break;
            case Calendarnum2022.PreviousPage:
                BackToInfoCalendarForGuest();
                break;
        default:
            break;
        }
    }

    public static void InfoCalendar2023ForGuest() {
        Console.Clear();
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                              Calendar 2023                                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|      01 January         |       02 February       |      03 March          |      04 April          |");
        Console.WriteLine("|      05 May             |       06 June           |      07 July           |      08 August         |");
        Console.WriteLine("|      09 September       |       10 October        |      11 November       |      12 December       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine(" (13) <<- Back.");
        Console.Write("Choose number (1-13) : ");
        Calendarnum2023 calendarnum2023 = (Calendarnum2023)int.Parse(Console.ReadLine());
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        switch (calendarnum2023) {
            case Calendarnum2023.January:
                ShowInfoCalendar1_2023();
                break;
            case Calendarnum2023.February:
                ShowInfoCalendar2_2023();
                break;
            case Calendarnum2023.March:
                ShowInfoCalendar3_2023();
                break;
            case Calendarnum2023.April:
                ShowInfoCalendar4_2023();
                break;
            case Calendarnum2023.May:
                ShowInfoCalendar5_2023();
                break;
            case Calendarnum2023.June:
                ShowInfoCalendar6_2023();
                break;
            case Calendarnum2023.July:
                ShowInfoCalendar7_2023();
                break;
            case Calendarnum2023.August:
                ShowInfoCalendar8_2023();
                break;
            case Calendarnum2023.September:
                ShowInfoCalendar9_2023();
                break;
            case Calendarnum2023.October:
                ShowInfoCalendar10_2023();
                break;
            case Calendarnum2023.November:
                ShowInfoCalendar11_2023();
                break;
            case Calendarnum2023.December:
                ShowInfoCalendar12_2023();
                break;
            case Calendarnum2023.PreviousPage:
                BackToInfoCalendarForGuest();
                break;
        default:
            break;
        }
    }

    static void BackToPrintListMenuWhenLogin() {
        Console.Clear();
        Program.PrintListMenuWhenLogin();
    }

    static void BackToPrintListMenuWhenGuestLogin() {
        Console.Clear();
        Program.PrintListMenuWhenGuestLogin();
    }

    static void BackToInfoCalendar() {
        Console.Clear();
        InfoCalendar();
    }

    static void BackToInfoCalendarForGuest() {
        Console.Clear();
        InfoCalendarForGuest();
    }

    static void BackToInfoCalendar2022() {
        Console.Clear();
        InfoCalendar2022();
    }

    static void BackToInfoCalendar2023() {
        Console.Clear();
        InfoCalendar2023();
    }

    public static void ShowInfoCalendar1_2022() {
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
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar2_2022() {
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
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar3_2022(){
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
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar4_2022(){
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
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar5_2022(){
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
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar6_2022(){
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
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar7_2022(){
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
        Console.WriteLine("                          Important activities before the start of semester 1                          ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     06      | - The first day of submitting an intention to maintain student status Semester 1 ");
        Console.WriteLine("|             |   through the New ACIS system.");
        Console.WriteLine("|   18 - 22   | - Day to meet with an advisor to give advice in registration and Allow registration ");
        Console.WriteLine("|             |   through the New ACIS system.");
        Console.WriteLine("|             | - For students with normal conditions and probationary conditions.");
        Console.WriteLine("|             | - Date of registration for the course of the 1st semester of the student Currently ");
        Console.WriteLine("|             |   through the New ACIS system.");
        Console.WriteLine("|             | - Date of registration to maintain student status Semester 1 ");
        Console.WriteLine("|             |   through the New ACIS system.");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar8_2022(){
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
        Console.WriteLine("                               Semester 1 (8 August - 12 December 2022)                                ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     01      | - Last day for payment of the 1st semester registration fee.");
        Console.WriteLine("|     08      | - Start date for students of all levels/courses.");
        Console.WriteLine("|   08 - 15   | - Late registration date via New ACIS system ");
        Console.WriteLine("|             |   (must pay a fine of 50 baht/day since 8 August 2022).");
        Console.WriteLine("|             | - The registration date for maintaining student status is delayed ");
        Console.WriteLine("|             |   (You have to pay a fine of 50 baht/day since 8 August 2022, including holidays).");
        Console.WriteLine("|   08 - 22   | - Additional registration date - change group classes through the New ACIS system.");
        Console.WriteLine("|             | - Date of notifying the intention of taking the exam for a course with overlapping hours ");
        Console.WriteLine("|             |   (for undergraduate students final year).");
        Console.WriteLine("|08/08 - 23/09| - Date of registration for the reduction of courses through the New ACIS system.");
        Console.WriteLine("|16/08 - 06/09| - Late registration date approved by the head of department ");
        Console.WriteLine("|             |   (must pay a fine of 50 baht/day since 8 August 2022, including holidays).");
        Console.WriteLine("|     18      | - Wai Kru Day (only for bachelor's degree - no teaching).");
        Console.WriteLine("|     23      | - Last day for submission Request for transfer of courses/credits For semester 1/2022.");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar9_2022(){
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
        Console.WriteLine("|     19      | - The start date for the pre-teaching assessment of the teachers and the academic ");
        Console.WriteLine("|             |   advisors are assessed by the students. Semester 1 (see courses that can assess ");
        Console.WriteLine("|             |   teaching in advance in the teaching assessment system).");
        Console.WriteLine("|     21      | - Last day for approval of student leave and student registration with the approval of ");
        Console.WriteLine("|             |   the Dean. For students who don't register for classes (must pay a fine of 50 baht/day ");
        Console.WriteLine("|             |   since 8 August 2022, including holidays).");
        Console.WriteLine("|     22      | - Date of termination of student status. In the event that a student does not register ");
        Console.WriteLine("|             |   for studies and does not take a leave of absence.");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar10_2022(){
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
        Console.WriteLine("|05/10 - 11/11| - Registration date for withdrawal of courses through the New ACIS system.");
        Console.WriteLine("|             |   advisors are assessed by the students. Semester 1 (see courses that can assess ");
        Console.WriteLine("|             |   teaching in advance in the teaching assessment system).");
        Console.WriteLine("|   13 - 21   | - Date of notification of intention to graduate, semester 1/2022.");
        Console.WriteLine("|             |   via website https://pre-grad.kmutt.ac.th/");
        Console.WriteLine("|17/10 - 18/11| - Week of teacher teaching assessment and academic advisor assessment by students ");
        Console.WriteLine("|             |   Passed the teaching assessment system for the 1st semester 2019.");
        Console.WriteLine("|     31      | - Last day of submission Request a refund of education fees and/or registration fees ");
        Console.WriteLine("|             |   for courses for the 1st semester.");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar11_2022(){
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
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar12_2022(){
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
        Console.WriteLine("                       Important activities after semester 1 and before semester 2                     ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     13      | - Last day of Semester 1.");
        Console.WriteLine("|             | - The first day of submitting a request to maintain student status In the semester 2");
        Console.WriteLine("|             |   (in the case of study leave) through the New ACIS system.");
        Console.WriteLine("|     28      | - Last day for submitting the results of the theory exam Project and thesis practical ");
        Console.WriteLine("|             |   subject to the Student Registration Office.");
        Console.WriteLine("|     30      | - Date of announcement of regular examination results Semester 1/2022.");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2022();
    }
    public static void ShowInfoCalendar1_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             January 2023                                              ");
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
        Console.WriteLine("                                 Semester 2 (16 January - 26 May 2023)                                 ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     03      | - Date of announcement of teaching evaluation results of teachers and academic advisors ");
        Console.WriteLine("|             |   by students Semester 1/2022 (Teachers and academic advisors can access the assessment ");
        Console.WriteLine("|             |   results in the university's internet system). ");
        Console.WriteLine("|   03 - 10   | - Meeting with the advisor to give advice To register and allow registration through ");
        Console.WriteLine("|             |   the New ACIS system for normal and probate students.");
        Console.WriteLine("|             | - Date of registration for courses in the semester 2 through the New ACIS system.");
        Console.WriteLine("|             | - Date of registration to maintain student status Semester 2/2022 through ");
        Console.WriteLine("|             |   the New ACIS system.");
        Console.WriteLine("|     11      | - Last day of payment of registration fee for semester 2/2022.");
        Console.WriteLine("|     16      | - Start date for Semester 2/2022.");
        Console.WriteLine("|   16 - 20   | - Late registration date via New ACIS system.");
        Console.WriteLine("|             |   (must pay a fine of 50 baht/day since 16 January 2023).");
        Console.WriteLine("|             | - The registration date for maintaining student status is delayed.");
        Console.WriteLine("|             |   (You have to pay a fine of 50 baht/day since 16 January 2023, including holidays).");
        Console.WriteLine("|   16 - 27   | - Additional registration dates - change of study groups via New ACIS system.");
        Console.WriteLine("|             | - Date of notifying the intention of taking the exam for a course with overlapping hours."); 
        Console.WriteLine("|             |   (for undergraduate students final year). ");
        Console.WriteLine("|16/01 - 03/03| - Registration date for reducing courses through the New ACIS system.");
        Console.WriteLine("|23/01 - 14/02| - Late registration date approved by the head of department/subject chair/course chair.");
        Console.WriteLine("|             |   (You have to pay a fine of 50 baht/day since 16 January 2023, including holidays).");
        Console.WriteLine("|     27      | - Last day to submit a request for transfer of courses/credits Semester 2.");
        Console.WriteLine("|             | - Last day for submitting the revision of the results of the 1st semester examination.");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar2_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             February 2023                                             ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                            |       01       |      02      |     03     |      04      |     05     |");
        Console.WriteLine("|     06      |      07      |       08       |      09      |     10     |      11      |     12     |");
        Console.WriteLine("|     13      |      14      |       15       |      16      |     17     |      18      |     19     |");
        Console.WriteLine("|     20      |      21      |       22       |      23      |     24     |      25      |     26     |");
        Console.WriteLine("|     27      |      28      |                                                                        |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   13 - 24   | - Date of notifying the intention to open a course for a special academic semester 2023.");
        Console.WriteLine("|     20      | - The start date of the teacher's pre-teaching assessment and the academic advisor ");
        Console.WriteLine("|             |   assessment by the 2nd semester students. (see courses that can assess teaching in advance ");
        Console.WriteLine("|             |   advance in the teaching assessment system).");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar3_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             March 2023                                                ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                            |       01       |      02      |     03     |      04      |     05     |");
        Console.WriteLine("|     06      |      07      |       08       |      09      |     10     |      11      |     12     |");
        Console.WriteLine("|     13      |      14      |       15       |      16      |     17     |      18      |     19     |");
        Console.WriteLine("|     20      |      21      |       22       |      23      |     24     |      25      |     26     |");
        Console.WriteLine("|     27      |      28      |       29       |      30      |     31     |                           |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     01      | - Last day for approval of student leave and student registration with the approval ");
        Console.WriteLine("|             |   of the Dean. For students who are not enrolled.");
        Console.WriteLine("|             |   (You have to pay a fine of 50 baht/day since 16 January 2023, including holidays).");
        Console.WriteLine("|     02      | - Date of termination of student status In the event that a student does not register ");
        Console.WriteLine("|             |   for studies and does not take a leave of absence.");
        Console.WriteLine("|15/03 - 01/05| - Date of registration and withdrawal of courses through the New ACIS system.");
        Console.WriteLine("|   20 - 31   | - Date of notification of intention to graduate, semester 2/2023.");
        Console.WriteLine("|             |   via website https://pre-grad.kmutt.ac.th/ ");
        Console.WriteLine("|27/03 - 05/05| - Week of teacher teaching assessment and academic advisor assessment by students ");
        Console.WriteLine("|             |   through the teaching assessment system for the 2nd semester.");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar4_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             April 2023                                                ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                                                         |      01      |     02     |");
        Console.WriteLine("|     03      |      04      |       05       |      06      |     07     |      08      |     09     |");
        Console.WriteLine("|     10      |      11      |       12       |      13      |     14     |      15      |     16     |");
        Console.WriteLine("|     17      |      18      |       19       |      20      |     21     |      22      |     23     |");
        Console.WriteLine("|     24      |      25      |       26       |      27      |     28     |      29      |     30     |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   10 - 15   | - Holidays, no teaching");
        Console.WriteLine("|     17      | - Last day of submission Request a refund of education fees and/or registration fees ");
        Console.WriteLine("|             |   for regular courses Semester 2/2022. ");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar5_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             May 2023                                                  ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     01      |      02      |       03       |      04      |     05     |      06      |     07     |");
        Console.WriteLine("|     08      |      09      |       10       |      11      |     12     |      13      |     14     |");
        Console.WriteLine("|     15      |      16      |       17       |      18      |     19     |      20      |     21     |");
        Console.WriteLine("|     22      |      23      |       24       |      25      |     26     |      27      |     28     |");
        Console.WriteLine("|     29      |      30      |       31       |                                                       |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("               Important activities after the semester 2 and before the special semester               ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     26      | - Last day of semester 2 ");
        Console.WriteLine("|29/05 - 02/06| - A day to meet with an advisor to advise on course registration Special semester 2022.");
        Console.WriteLine("|             | - Registration date for special semester courses through the New ACIS system.");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar6_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             June 2023                                                 ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                             |      01      |     02     |      03      |     04     |");
        Console.WriteLine("|     05      |      06      |        07      |      08      |     09     |      10      |     11     |");
        Console.WriteLine("|     12      |      13      |        14      |      15      |     16     |      17      |     18     |");
        Console.WriteLine("|     19      |      20      |        21      |      22      |     23     |      24      |     25     |");
        Console.WriteLine("|     26      |      27      |        28      |      29      |     30     |                           |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                          Special Education Semester (12 June - 4 August 2023)                         ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     06      | - Last day of payment for special semester/2022.");
        Console.WriteLine("|     15      | - Last day for submitting the results of the theory exam Practical subjects,");
        Console.WriteLine("|             |   Project and Thesis subjects to the Student Registration Office.");
        Console.WriteLine("|     17      | - Date of announcement of regular examination results Semester 2/2022.");
        Console.WriteLine("|     19      | - Announcement of teaching assessment results of teachers and academic advisors by ");
        Console.WriteLine("|             |   students of the 2nd semester of the year. (Teachers and academic advisors can view ");
        Console.WriteLine("|             |   the assessment results in the university's intranet system)");
        Console.WriteLine("|01/06 - 04/08| - Special semester internship day (The internship period is at least 16 working days) ");
        Console.WriteLine("|   12 - 16   | - The start date of the special semester.");
        Console.WriteLine("|             | - Late registration date via New ACIS system.");
        Console.WriteLine("|             |   (must pay a fine of 50 baht/day since 12 June 2023).");
        Console.WriteLine("|   12 - 23   | - Add - reduce - change-group registration date through New ACIS system.");
        Console.WriteLine("|     23      | - Last day for submitting revisions of the 2nd semester exam results.");
        Console.WriteLine("|   26 - 30   | - Date of notification of intention to graduate in the special semester 2022.");
        Console.WriteLine("|             |   via website https://pre-grad.kmutt.ac.th/");
        Console.WriteLine("|26/06 - 07/07| - Week of teacher teaching assessment and academic advisor assessment by students ");
        Console.WriteLine("|             |   through the teaching evaluation system for the special education semester 2022.");
        Console.WriteLine("|             | - Date of registration and withdrawal of courses through the New ACIS system.");
        Console.WriteLine("|     30      | - Last day of submission Request a refund of tuition fees and/or course registration ");
        Console.WriteLine("|             |   fees Special semester 2022. ");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar7_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             July 2023                                                 ");
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
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar8_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             August 2023                                               ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                    01      |       02       |      03      |     04     |      05      |     06     |");
        Console.WriteLine("|     07      |      08      |       09       |      10      |     11     |      12      |     13     |");
        Console.WriteLine("|     14      |      15      |       16       |      17      |     18     |      19      |     20     |");
        Console.WriteLine("|     21      |      22      |       23       |      24      |     25     |      26      |     27     |");
        Console.WriteLine("|     28      |      29      |       30       |      31      |                                        |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                        Important activities after the special education sector                        ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     04      | - Last day of the special semester.");
        Console.WriteLine("|     16      | - Last day for submitting the results of the theory exam Practical subjects,");
        Console.WriteLine("|             |   Project subjects and Thesis subjects to the Student Registration Office.");
        Console.WriteLine("|     18      | - Date of announcement of regular examination results special semester");
        Console.WriteLine("|     21      | - Announcing the results of teaching assessment results of teachers and assessment of ");
        Console.WriteLine("|             |   academic advisors by students special semester. (Teachers and advisors can access the ");
        Console.WriteLine("|             |   assessment results in the university intranet).");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar9_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             September 2023                                            ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|   Monday    |   Tuesday    |    Wednesday   |   Thursday   |   Friday   |   Saturday   |   Sunday   |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|                                                            |     01     |      02      |     03     |");
        Console.WriteLine("|     04      |      05      |        06      |      07      |     08     |      09      |     10     |");
        Console.WriteLine("|     11      |      12      |        13      |      14      |     15     |      16      |     17     |");
        Console.WriteLine("|     18      |      19      |        20      |      21      |     22     |      23      |     24     |");
        Console.WriteLine("|     25      |      26      |        27      |      28      |     29     |      30      |            |");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     01      | - Last day for submitting revised results of special semester exams.");
        Console.WriteLine("|             | - Last day for submitting internship exam results. ");
        Console.Write("Press enter to continue. : ");
        Console.ReadLine();
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar10_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             October 2023                                              ");
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
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar11_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             November 2023                                             ");
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
        BackToInfoCalendar2023();
    }
    public static void ShowInfoCalendar12_2023(){
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                                             December 2023                                             ");
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
        BackToInfoCalendar2023();
    }
}