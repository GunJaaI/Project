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

    static void BackToPrintListMenuWhenLogin() {
        Console.Clear();
        Program.PrintListMenuWhenLogin();
    }

    static void BackToInfoCalendar() {
        Console.Clear();
        InfoCalendar();
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
        Console.WriteLine("|             |   (must pay a fine of 50 baht/day from 8 August 2022).");
        Console.WriteLine("|             | - The registration date for maintaining student status is delayed ");
        Console.WriteLine("|             |   (You have to pay a fine of 50 baht/day from August 8 2022, including holidays).");
        Console.WriteLine("|   08 - 22   | - Additional registration date - change group classes through the New ACIS system.");
        Console.WriteLine("|             | - Date of notifying the intention of taking the exam for a course with overlapping hours ");
        Console.WriteLine("|             |   (for undergraduate students final year).");
        Console.WriteLine("|08/08 - 23/09| - Date of registration for the reduction of courses through the New ACIS system.");
        Console.WriteLine("|16/08 - 06/09| - Late registration date approved by the head of department ");
        Console.WriteLine("|             |   (must pay a fine of 50 baht/day from 8 August 2022, including holidays).");
        Console.WriteLine("|     18      | - Wai Kru Day (only for bachelor's degree - no teaching).");
        Console.WriteLine("|     23      | - Last day for submission Request for transfer of courses/credits For semester 1/2565.");
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
        Console.WriteLine("|             |   from 8 August 2022, including holidays).");
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
        Console.WriteLine("|   13 - 21   | - Date of notification of intention to graduate, semester 1/2565.");
        Console.WriteLine("|             |   via website https://pre-grad.kmutt.ac.th/");
        Console.WriteLine("|17/10 - 18/11| - Week of teacher teaching assessment and academic advisor assessment by students ");
        Console.WriteLine("|             |   Passed the teaching assessment system for the 1st semester/2019.");
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
        Console.WriteLine("|             | - The first day of submitting a request to maintain student status In the second semester ");
        Console.WriteLine("|             |   (in the case of study leave) through the New ACIS system.");
        Console.WriteLine("|     28      | - Last day for submitting the results of the theory exam Project and thesis practical ");
        Console.WriteLine("|             |   subject to the Student Registration Office.");
        Console.WriteLine("|     30      | - Date of announcement of regular examination results Semester 1/2565.");
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
        Console.WriteLine("|     03      | - Announcement of the results of the teaching assessment of teachers and advisors ");
        Console.WriteLine("|             |   Academic by students Semester 1/2022");
        Console.WriteLine("|             |   (Instructors and Academic advisors can access the assessment results in the system. University intranet) ");
        Console.WriteLine("|   03 - 10   | - Meet with your advisor to give advice on how to register. and allow registration through the New ACIS system. ");
        Console.WriteLine("|             |   (For students, normal conditions and correctional science conditions.) ");
        Console.WriteLine("|             | - Registration date for semester 2 through New ACIS ");
        Console.WriteLine("|             | - Student Registration Date 2/2022 Via New ACIS ");
        Console.WriteLine("|     11      | - The last day of grocery Registration fee for semester 2/2022 ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                               Semester 2 (16 January - 26 May 2023)                                   ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     16      | - Start date for Semester 2/2022 ");
        Console.WriteLine("|   16 - 20   | - Late registration date via New ACIS system ");
        Console.WriteLine("|             |   (rescheduled required Daily fines 50 Baht from Monday, January 16, 2023) ");
        Console.WriteLine("|             | - Student registration dates are delayed ");
        Console.WriteLine("|             |   (rescheduled required. Fine 50 baht per day From Monday, January 16, 2023, including holidays) ");
        Console.WriteLine("|   16 - 27   | - Additional registration dates - change of study groups via New ACIS system ");
        Console.WriteLine("|             | - Notification date for requesting a course exam with double exam hours ");  
        Console.WriteLine("|             |   (For undergraduates, final year) ");
        Console.WriteLine("|16/01 - 03/03| - Reduced course registration dates via New ACIS system ");
        Console.WriteLine("|23/01 - 14/02| - Late registration date approved by department head/subject chair/Course Chair ");
        Console.WriteLine("|             |   (Grocery required. Fine 50 baht per day from Monday, January 16, 2023 (including holidays) ");
        Console.WriteLine("|     27      | - Final filing date Request for transfer of course/credits for semester 2 ");
        Console.WriteLine("|             | - Last day of submission of revised examination results for semester 1/2022 ");
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
        Console.WriteLine("|   13 - 24   | - Special Education Semester/2023 ");
        Console.WriteLine("|     20      | - Start a teacher's pre-teaching assessment and evaluate it. Academic advisors by students ");
        Console.WriteLine("|             |   Semester 2 See courses that can be evaluated in advance. Teaching Assessment System) ");
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
        Console.WriteLine("|     01      | - The last day of application for approval of leave of absence and registration. ");
        Console.WriteLine("|             |   Maintain student status with the approval of the dean. forNon-enrolled students ");
        Console.WriteLine("|             |   (rescheduled) Fine 50 baht per day From Monday, January 16, 2023, including holidays) ");
        Console.WriteLine("|     02      | - Student Lapse Date In case the student does not enroll.");
        Console.WriteLine("|             |   And I'm not taking a leave of absence from education. ");
        Console.WriteLine("|15/03 - 01/05| - Registration date for withdrawal of courses through the New ACIS system ");
        Console.WriteLine("|   20 - 31   | - Notification date for the second semester of education 2/2023 ");
        Console.WriteLine("|             |   Via the https://pre-grad.kmutt.ac.th/ website ");
        Console.WriteLine("|27/03 - 05/05| - Week of teacher teaching assessments and assessments Academic Advisors ");
        Console.WriteLine("|             |   Students are treated through a teaching assessment system. emester 2/2022");
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
        Console.WriteLine("|   10 - 15   | - Teaching breaks ");
        Console.WriteLine("|     17      | - The last day of filing Request a refund of education pension ");
        Console.WriteLine("|             |   and registration fee for regular courses for semester 2/2022. ");
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
        Console.WriteLine("|     26      | - Last day of semester 2 ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                          Key activities after semester 2 and before special education                 ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|29/05 - 02/06| - Day met with a counselor to advise on the enrollment of the subject. ");
        Console.WriteLine("|             |   Special Education Semester/2022 ");
        Console.WriteLine("|     26      | - Registration date for special education classes via New ACIS system ");
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
        Console.WriteLine("|     06      | - The last day of grocery Special Education Period/2022 ");
        Console.WriteLine("|     15      | - The last day of submission of the results of the theory exam. Practical subjects ");
        Console.WriteLine("|             |   Project and Thesis subjects to the Student Registry Office ");
        Console.WriteLine("|     17      | - Announcement date for the results of the regular exam for semester 2/2022 ");
        Console.WriteLine("|     19      | - Announcement of the results of the teaching assessment of teachers and advisors ");
        Console.WriteLine("|             |   Academic by students for semester 2/2022 ");
        Console.WriteLine("|             |   (Instructors Academic advisors can view the results of the assessment in University intranet system) ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                          Special Education Semester (12 June - 4 August 2023)                         ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|01/06 - 04/08| - Special Education Internship Day ");
        Console.WriteLine("|   12 - 16   | - Special Education Start Dates ");
        Console.WriteLine("|             | - Late registration date via New ACIS system ");
        Console.WriteLine("|             |   (rescheduled required Fines 50 Baht per day from Monday, June 12, 2023) ");
        Console.WriteLine("|   12 - 23   | - Registration dates increase and decrease and change groups via New ACIS system ");
        Console.WriteLine("|     23      | - Last day of submission of revised results for semester 2/2022 ");
        Console.WriteLine("|   26 - 30   | - Special Education Semester/2022 Through the https://pre-grad.kmutt.ac.th website ");
        Console.WriteLine("|26/06 - 07/07| - Week of teacher teaching assessments and assessments Academic advisors ");
        Console.WriteLine("|             |   by students through the teaching assessment system Special Education Semester/2022");
        Console.WriteLine("|             | - Registration date for withdrawal of courses through the New ACIS system ");
        Console.WriteLine("|     30      | - The last day of filing Request a refund of education pension ");
        Console.WriteLine("|             |   and course registration fees for special education semester/2022. ");
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
        Console.WriteLine("|     04      | - Last day of the special education semester ");
         Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                          Important activities after the special education sector                       ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("|     16      | - The last day of submission of the results of the theory exam. Practical subjects. ");
        Console.WriteLine("|             |   Project and Thesis subjects to the Student Registration Office. ");
        Console.WriteLine("|     18      | - Announcement of the results of the regular exams for the special education sector. ");
        Console.WriteLine("|     21      | - Announcement of the results of the teacher's teaching assessment and assessment ");
        Console.WriteLine("|             |   Academic Advisors by Students Special Education Semester ");
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
        Console.WriteLine("|     01      | - The last day of submission of the revised results of the special education exam. ");
        Console.WriteLine("|             | - The last day of submitting the results of the internship exam. ");
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