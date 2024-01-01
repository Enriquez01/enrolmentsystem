using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace CP_FinalProject_EnrollmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string SignUporSignin;
            string username, password, username1, password1 = string.Empty;
            string studentnum;
            string searchstudentnum;
            string choices;
            string fname = string.Empty;
            string sname = string.Empty;
            string mname = string.Empty;
            string address = string.Empty;
            string gender = string.Empty;
            string mbday = string.Empty;
            string dbday = string.Empty;
            string ybday = string.Empty;
            string guardianname = string.Empty;
            string guardiannumber = string.Empty;
            string contactinfo = string.Empty;
            string course = string.Empty;
            string emailaddress = string.Empty;
            int amount;
            string coursechoice;
            string subjectplan = string.Empty;

            string year;
            string year1 = string.Empty;
            string subjects = string.Empty;
            string subjectchoices;
            int subjectprice;
            int numberofsubjects;
            int totalsubjectprice = 0;
            int tuition;
            int totalprice = 0;
            subjectprice = 1500;
            tuition = 4000;
            string edit;
            string editstud1;
            string amountyorn;



            Console.WriteLine("#       #  # # # # #  #           # # # # #  # # # # #  #       #  # # # # #\n#   #   #  #          #           #          #       #  # #   # #  #    \n#  # #  #  # # # #    #           #          #       #  #  # #  #  # # # # \n# #   # #  #          #           #          #       #  #   #   #  #   \n#       #  # # # # #  # # # # #   # # # # #  # # # # #  #       #  # # # # #\n ");
            Console.WriteLine("\n \n \npress any key to continue....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Create an account?\n press Y if yes\n press N if you already have an account");
            SignUporSignin = Convert.ToString(Console.ReadLine());

        login:
            switch (SignUporSignin)
            {
                case "Y":
                case "y":


                    Console.Clear();
                    Console.WriteLine("enter your username...");
                    username = Console.ReadLine();
                    Console.WriteLine("enter your password...");
                    password = Console.ReadLine();
                    using (StreamWriter sw = new StreamWriter(File.Create("admin.txt")))
                    {
                        sw.WriteLine(username);
                        sw.WriteLine(password);
                        sw.Close();
                    }
                    Console.Clear();
                    Console.WriteLine("account succesfully created\nPress any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    goto Login;


                case "N":
                case "n":
                    Console.WriteLine("Press any key to proceed to Login");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        Login:
            Console.WriteLine("enter your username...");
            username = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter your password...");
            password = Convert.ToString(Console.ReadLine());
            using (StreamReader sr = new StreamReader(File.Open("admin.txt", FileMode.Open)))
            {

                username1 = sr.ReadLine();
                password1 = sr.ReadLine();
                sr.Close();
            }

            if (username == username1 && password == password1)
            {
                Console.WriteLine("Login Succesful");
                Console.ReadLine();
                Console.Clear();

                Console.Clear();

            main:
                Console.WriteLine("MAIN MENU\nwhat would you like to do?\n{a}Add Student\n{b}Search Student\n{c}Contact us\n{d}Exit");
                choices = Convert.ToString(Console.ReadLine());
                Console.Clear();
            searchstudent:
                switch (choices)
                {
                    case "a":
                    case "A":
                        Console.WriteLine("Add student enter student number(1-2)\n type r to return to main menu");
                        studentnum = Console.ReadLine();
                        switch (studentnum)
                        {
                            case "1":
                                Console.WriteLine("STUDENT NUMBER 1\n input data");
                                Console.WriteLine("enter your surname here ");
                                sname = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your given name here  ");
                                fname = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your middle name here  ");
                                mname = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your gender here ");
                                gender = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your address here ");
                                address = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your birthdate here ");
                                Console.WriteLine("month ");
                                mbday = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("day ");
                                dbday = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("year ");
                                ybday = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your guardian's name here )");
                                guardianname = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your guardian's number here ");
                                guardiannumber = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your contact number here ");
                                contactinfo = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your Email Address here ");
                                emailaddress = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter the course you would like to take \n[a]Agriculture and Related Fields\n[b]Engineering\n[c]Science and Math\n[d]Information Technology\n");
                                coursechoice = Console.ReadLine();
                                Console.Clear();
                            course:
                                switch (coursechoice)
                                {
                                    case "a":
                                        course = "Agriculture and Related Fields";
                                        Console.WriteLine("what year are you taking?\n[1]1st Year\n[2]2nd Year\n[3]3rd Year\n[4]4th Year");
                                        year = Console.ReadLine();
                                        Console.Clear();
                                        switch (year)
                                        {
                                            case "1":
                                                year1 = "1st year";
                                                subjectprice = 1500;
                                                tuition = 4000;
                                            SABJEK:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK;


                                                }
                                                break;
                                            case "2":
                                                year1 = "2nd year";
                                            SABJEK2:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK2;
                                                }

                                                break;
                                            case "3":
                                                year1 = "3rd year";
                                            SABJEK3:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK3;
                                                }
                                                break;
                                            case "4":
                                                year1 = "4th year";
                                            SABJEK4:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK4;

                                                }
                                                break;
                                            default:
                                                goto course;
                                        }
                                        break;
                                    case "b":
                                        course = "Engineering";
                                        Console.WriteLine("what year are you taking?\n[1]1st Year\n[2]2nd Year\n[3]3rd Year\n[4]4th Year");
                                        year = Console.ReadLine();
                                        Console.Clear();
                                        switch (year)
                                        {
                                            case "1":
                                                year1 = "1st year";
                                                subjectprice = 1500;
                                                tuition = 4000;
                                            SABJEK:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK;


                                                }
                                                break;
                                            case "2":
                                                year1 = "2nd year";
                                            SABJEK2:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK2;
                                                }

                                                break;
                                            case "3":
                                                year1 = "3rd year";
                                            SABJEK3:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK3;
                                                }
                                                break;
                                            case "4":
                                                year1 = "4th year";
                                            SABJEK4:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK4;

                                                }
                                                break;
                                            default:
                                                goto course;
                                        }
                                        break;
                                    case "c":
                                        course = "Science and Math";
                                        Console.WriteLine("what year are you taking?\n[1]1st Year\n[2]2nd Year\n[3]3rd Year\n[4]4th Year");
                                        year = Console.ReadLine();
                                        Console.Clear();
                                        switch (year)
                                        {
                                            case "1":
                                                year1 = "1st year";
                                                subjectprice = 1500;
                                                tuition = 4000;
                                            SABJEK:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK;


                                                }
                                                break;
                                            case "2":
                                                year1 = "2nd year";
                                            SABJEK2:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK2;
                                                }

                                                break;
                                            case "3":
                                                year1 = "3rd year";
                                            SABJEK3:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK3;
                                                }
                                                break;
                                            case "4":
                                                year1 = "4th year";
                                            SABJEK4:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK4;

                                                }
                                                break;
                                            default:
                                                goto course;
                                        }
                                        break;
                                    case "d":
                                        course = "Information Technology";
                                        Console.WriteLine("what year are you taking?\n[1]1st Year\n[2]2nd Year\n[3]3rd Year\n[4]4th Year");
                                        year = Console.ReadLine();
                                        Console.Clear();
                                        switch (year)
                                        {
                                            case "1":
                                                year1 = "1st year";
                                                subjectprice = 1500;
                                                tuition = 4000;
                                            SABJEK:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK;


                                                }
                                                break;
                                            case "2":
                                                year1 = "2nd year";
                                            SABJEK2:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK2;
                                                }

                                                break;
                                            case "3":
                                                year1 = "3rd year";
                                            SABJEK3:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK3;
                                                }
                                                break;
                                            case "4":
                                                year1 = "4th year";
                                            SABJEK4:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK4;

                                                }
                                                break;
                                            default:
                                                goto course;
                                        }
                                        break;
                                    default:
                                        goto course;




                                }

                            amount:
                                Console.WriteLine("enter the amount paid ");
                                amount = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                if (amount >= 1000 && amount <= totalprice)
                                {

                                    Console.WriteLine("{0} pesos is this right? type Y if yes and type N if no", amount);
                                    amountyorn = Console.ReadLine();
                                    Console.Clear();
                                    switch (amountyorn)
                                    {

                                        case "y":
                                            Console.WriteLine("");
                                            Console.Clear();
                                            break;


                                        case "n":
                                            Console.Clear();
                                            goto amount;

                                        default:
                                            Console.WriteLine("invalid ");
                                            goto amount;
                                    }





                                    using (StreamWriter sw2 = new StreamWriter(File.Create("studentnumber1.txt")))
                                    {
                                        sw2.WriteLine(sname);
                                        sw2.WriteLine(fname);
                                        sw2.WriteLine(mname);
                                        sw2.WriteLine(mbday);
                                        sw2.WriteLine(dbday);
                                        sw2.WriteLine(ybday);
                                        sw2.WriteLine(gender);
                                        sw2.WriteLine(address);
                                        sw2.WriteLine(guardianname);
                                        sw2.WriteLine(guardiannumber);
                                        sw2.WriteLine(contactinfo);
                                        sw2.WriteLine(emailaddress);
                                        sw2.WriteLine(course);
                                        sw2.WriteLine(year1);
                                        sw2.WriteLine(subjects);
                                        sw2.WriteLine(totalsubjectprice);
                                        sw2.WriteLine(totalprice);
                                        sw2.WriteLine(amount);
                                        sw2.Close();

                                    }


                                    Console.Clear();
                                    Console.WriteLine("press any key to return to main menu");
                                    Console.ReadKey();
                                    goto main;
                                }
                                else
                                {
                                    Console.WriteLine("invalid amount of money\n its either insufficient or it exceed the amount needed");
                                    Console.Clear();
                                    goto amount;

                                }
                            case "2":
                                Console.WriteLine("STUDENT NUMBER 2\n input data");
                                Console.WriteLine("enter your surname here ");
                                sname = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your given name here  ");
                                fname = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your middle name here  ");
                                mname = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your gender here ");
                                gender = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your address here ");
                                address = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your birthdate here ");
                                Console.WriteLine("month ");
                                mbday = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("day ");
                                dbday = Convert.ToString(Console.ReadLine());
                                Console.WriteLine("year ");
                                ybday = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your guardian's name here )");
                                guardianname = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your guardian's number here ");
                                guardiannumber = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your contact number here ");
                                contactinfo = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter your Email Address here ");
                                emailaddress = Convert.ToString(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("enter the course you would like to take \n[a]Agriculture and Related Fields\n[b]Engineering\n[c]Science and Math\n[d]Information Technology\n");
                                coursechoice = Console.ReadLine();
                                Console.Clear();
                            course1:
                                switch (coursechoice)
                                {
                                    case "a":
                                        course = "Agriculture and Related Fields";
                                        Console.WriteLine("what year are you taking?\n[1]1st Year\n[2]2nd Year\n[3]3rd Year\n[4]4th Year");
                                        year = Console.ReadLine();
                                        Console.Clear();
                                        switch (year)
                                        {
                                            case "1":
                                                year1 = "1st year";
                                                subjectprice = 1500;
                                                tuition = 4000;
                                            SABJEK:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK;


                                                }
                                                break;
                                            case "2":
                                                year1 = "2nd year";
                                            SABJEK2:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK2;
                                                }

                                                break;
                                            case "3":
                                                year1 = "3rd year";
                                            SABJEK3:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK3;
                                                }
                                                break;
                                            case "4":
                                                year1 = "4th year";
                                            SABJEK4:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK4;

                                                }
                                                break;
                                            default:
                                                goto course1;
                                        }
                                        break;
                                    case "b":
                                        course = "Engineering";
                                        Console.WriteLine("what year are you taking?\n[1]1st Year\n[2]2nd Year\n[3]3rd Year\n[4]4th Year");
                                        year = Console.ReadLine();
                                        Console.Clear();
                                        switch (year)
                                        {
                                            case "1":
                                                year1 = "1st year";
                                                subjectprice = 1500;
                                                tuition = 4000;
                                            SABJEK:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK;


                                                }
                                                break;
                                            case "2":
                                                year1 = "2nd year";
                                            SABJEK2:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK2;
                                                }

                                                break;
                                            case "3":
                                                year1 = "3rd year";
                                            SABJEK3:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK3;
                                                }
                                                break;
                                            case "4":
                                                year1 = "4th year";
                                            SABJEK4:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK4;

                                                }
                                                break;
                                            default:
                                                goto course1;
                                        }
                                        break;
                                    case "c":
                                        course = "Science and Math";
                                        Console.WriteLine("what year are you taking?\n[1]1st Year\n[2]2nd Year\n[3]3rd Year\n[4]4th Year");
                                        year = Console.ReadLine();
                                        Console.Clear();
                                        switch (year)
                                        {
                                            case "1":
                                                year1 = "1st year";
                                                subjectprice = 1500;
                                                tuition = 4000;
                                            SABJEK:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK;


                                                }
                                                break;
                                            case "2":
                                                year1 = "2nd year";
                                            SABJEK2:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK2;
                                                }

                                                break;
                                            case "3":
                                                year1 = "3rd year";
                                            SABJEK3:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK3;
                                                }
                                                break;
                                            case "4":
                                                year1 = "4th year";
                                            SABJEK4:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK4;

                                                }
                                                break;
                                            default:
                                                goto course1;
                                        }
                                        break;
                                    case "d":
                                        course = "Information Technology";
                                        Console.WriteLine("what year are you taking?\n[1]1st Year\n[2]2nd Year\n[3]3rd Year\n[4]4th Year");
                                        year = Console.ReadLine();
                                        Console.Clear();
                                        switch (year)
                                        {
                                            case "1":
                                                year1 = "1st year";
                                                subjectprice = 1500;
                                                tuition = 4000;
                                            SABJEK:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK;


                                                }
                                                break;
                                            case "2":
                                                year1 = "2nd year";
                                            SABJEK2:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK2;
                                                }

                                                break;
                                            case "3":
                                                year1 = "3rd year";
                                            SABJEK3:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK3;
                                                }
                                                break;
                                            case "4":
                                                year1 = "4th year";
                                            SABJEK4:
                                                Console.WriteLine("{0}, 1500 per subject per year plus 4000 tuition fee\npick the subjects\n[a]Math\n[b]English\n[c]Filipino\n[d]Science", year1);
                                                subjectchoices = Console.ReadLine();
                                                switch (subjectchoices)
                                                {
                                                    case "a":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "b":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "c":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "d":
                                                        numberofsubjects = 1;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ab":
                                                    case "ba":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ac":
                                                    case "ca":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "ad":
                                                    case "da":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bc":
                                                    case "cb":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "bd":
                                                    case "db":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English and Science";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cd":
                                                    case "dc":
                                                        numberofsubjects = 2;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abc":
                                                    case "cba":
                                                    case "bca":
                                                    case "bac":
                                                    case "acb":
                                                    case "cab":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "cbd":
                                                    case "cdb":
                                                    case "bcd":
                                                    case "bdc":
                                                    case "dcb":
                                                    case "dbc":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "acd":
                                                    case "adc":
                                                    case "dca":
                                                    case "dac":
                                                    case "cda":
                                                    case "cad":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "abd":
                                                    case "adb":
                                                    case "bda":
                                                    case "bad":
                                                    case "dab":
                                                    case "dba":
                                                        numberofsubjects = 3;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, Science and English";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case "dabc":
                                                    case "dcba":
                                                    case "dbca":
                                                    case "dbac":
                                                    case "dacb":
                                                    case "dcab":
                                                    case "cabd":
                                                    case "cadb":
                                                    case "cbda":
                                                    case "cbad":
                                                    case "cdab":
                                                    case "cdba":
                                                    case "acbd":
                                                    case "acdb":
                                                    case "abcd":
                                                    case "abdc":
                                                    case "adcb":
                                                    case "adbc":
                                                    case "bacd":
                                                    case "badc":
                                                    case "bdca":
                                                    case "bdac":
                                                    case "bcda":
                                                    case "bcad":
                                                        numberofsubjects = 4;
                                                        totalsubjectprice = numberofsubjects * subjectprice;
                                                        totalprice = totalsubjectprice + tuition;
                                                        subjects = "Math, English, Science and Filipino";
                                                        Console.WriteLine("{2},total subject price{0}, total price{1}", totalsubjectprice, totalprice, subjects);
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        Console.WriteLine("invalid Choice");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        goto SABJEK4;

                                                }
                                                break;
                                            default:
                                                goto course1;
                                        }
                                        break;
                                    default:
                                        goto course1;



                                }

                            amount1:
                                Console.WriteLine("enter the amount paid ");
                                amount = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                if (amount >= 1000 && amount <= totalprice)
                                {

                                    Console.WriteLine("{0} pesos is this right? type Y if yes and type N if no", amount);
                                    amountyorn = Console.ReadLine();
                                    Console.Clear();
                                    switch (amountyorn)
                                    {

                                        case "y":
                                            Console.WriteLine("");
                                            Console.Clear();
                                            break;


                                        case "n":
                                            Console.Clear();
                                            goto amount;

                                        default:
                                            Console.WriteLine("invalid ");
                                            goto amount1;
                                    }





                                    using (StreamWriter sw2 = new StreamWriter(File.Create("studentnumber2.txt")))
                                    {
                                        sw2.WriteLine(sname);
                                        sw2.WriteLine(fname);
                                        sw2.WriteLine(mname);
                                        sw2.WriteLine(mbday);
                                        sw2.WriteLine(dbday);
                                        sw2.WriteLine(ybday);
                                        sw2.WriteLine(gender);
                                        sw2.WriteLine(address);
                                        sw2.WriteLine(guardianname);
                                        sw2.WriteLine(guardiannumber);
                                        sw2.WriteLine(contactinfo);
                                        sw2.WriteLine(emailaddress);
                                        sw2.WriteLine(course);
                                        sw2.WriteLine(year1);
                                        sw2.WriteLine(subjects);
                                        sw2.WriteLine(totalsubjectprice);
                                        sw2.WriteLine(totalprice);
                                        sw2.WriteLine(amount);
                                        sw2.Close();

                                    }


                                    Console.Clear();
                                    Console.WriteLine("press any key to return to main menu");
                                    Console.ReadKey();
                                    goto main;
                                }
                                else
                                {
                                    Console.WriteLine("invalid amount of money\n its either insufficient or it exceed the amount needed");
                                    Console.Clear();
                                    goto amount1;

                                }
                                
                            case "r":
                                Console.WriteLine("press any key to return");
                                Console.ReadKey();
                                goto main;

                            default:
                                Console.WriteLine("invalid number");
                                goto searchstudent;

                        }

                        
                    case "b":
                    case "B":
                        Console.WriteLine("Search student enter student number(1-2)");
                        searchstudentnum = Console.ReadLine();

                    studinfo:
                        switch (searchstudentnum)
                        {
                            case "1":
                                Console.WriteLine("student number 1 info:");
                                using (StreamReader sr1 = new StreamReader(File.Open("studentnumber1.txt", FileMode.Open)))
                                {

                                    sname = sr1.ReadLine();
                                    fname = sr1.ReadLine();
                                    mname = sr1.ReadLine();
                                    mbday = sr1.ReadLine();
                                    ybday = sr1.ReadLine();
                                    dbday = sr1.ReadLine();
                                    gender = sr1.ReadLine();
                                    address = sr1.ReadLine();
                                    guardianname = sr1.ReadLine();
                                    guardiannumber = sr1.ReadLine();
                                    contactinfo = sr1.ReadLine();
                                    emailaddress = sr1.ReadLine();
                                    course = sr1.ReadLine();
                                    year1 = sr1.ReadLine();
                                    subjects = sr1.ReadLine();
                                    totalsubjectprice = Convert.ToInt32(sr1.ReadLine());
                                    totalprice = Convert.ToInt32(sr1.ReadLine());
                                    amount = Convert.ToInt32(sr1.ReadLine());

                                    sr1.Close();
                                    Console.WriteLine("Name:{0} {1},{2}", sname, fname, mname);
                                    Console.WriteLine("Gender:{0}", gender);
                                    Console.WriteLine("Address:{0}", address);
                                    Console.WriteLine("Birthday:{0},{1},{2}", mbday, dbday, ybday);
                                    Console.WriteLine("Guardian's Name:{0}", guardianname);
                                    Console.WriteLine("Guardian's Number:{0}", guardiannumber);
                                    Console.WriteLine("Contact Info:{0}", contactinfo);
                                    Console.WriteLine("Email Address:{0}", emailaddress);
                                    Console.WriteLine("Course:{0}", course);
                                    Console.WriteLine("year:{0}", year1);
                                    Console.WriteLine("Subjects:{0}", subjects);
                                    Console.WriteLine("total subjects price{0}+tuition{1}=Total Price{2}", totalsubjectprice, tuition, totalprice);
                                    Console.WriteLine("Paid amount:{0}", amount);
                                    Console.WriteLine("Press (e) if you want to edit the info and press (r) to return to main menu");
                                    edit = Console.ReadLine();

                                    Console.Clear();
                                editorreturn:
                                    switch (edit)
                                    {
                                        case "e":
                                            Console.WriteLine("what would you like to change\n{a}name\n{b}gender\n{c}address\n{d}birthday\n{e}Guardian's name\n{f]Guardian's number\n{g}contact info\n{h}email address\n{r}return");
                                            editstud1 = Console.ReadLine();
                                            Console.Clear();
                                            switch (editstud1)
                                            {
                                                case "a":

                                                    Console.WriteLine("enter your surname here ");
                                                    sname = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    Console.WriteLine("enter your given name here  ");
                                                    fname = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    Console.WriteLine("enter your middle name here  ");
                                                    mname = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "b":
                                                    Console.WriteLine("enter your gender here ");
                                                    gender = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "c":
                                                    Console.WriteLine("enter your address here ");
                                                    address = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "d":
                                                    Console.WriteLine("enter your birthdate here ");
                                                    Console.WriteLine("month ");
                                                    mbday = Convert.ToString(Console.ReadLine());
                                                    Console.WriteLine("day ");
                                                    dbday = Convert.ToString(Console.ReadLine());
                                                    Console.WriteLine("year ");
                                                    ybday = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "e":
                                                    Console.WriteLine("enter your guardian's name here )");
                                                    guardianname = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "f":
                                                    Console.WriteLine("enter your guardian's number here ");
                                                    guardiannumber = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "g":
                                                    Console.WriteLine("enter your contact number here ");
                                                    contactinfo = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "h":
                                                    Console.WriteLine("enter your Email Address here ");
                                                    emailaddress = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;


                                                case "r":
                                                    goto studinfo;
                                                default:
                                                    goto editorreturn;

                                            }
                                            using (StreamWriter sw2 = new StreamWriter(File.Create("studentnumber1.txt")))
                                            {
                                                sw2.WriteLine(sname);
                                                sw2.WriteLine(fname);
                                                sw2.WriteLine(mname);
                                                sw2.WriteLine(mbday);
                                                sw2.WriteLine(dbday);
                                                sw2.WriteLine(ybday);
                                                sw2.WriteLine(gender);
                                                sw2.WriteLine(address);
                                                sw2.WriteLine(guardianname);
                                                sw2.WriteLine(guardiannumber);
                                                sw2.WriteLine(contactinfo);
                                                sw2.WriteLine(emailaddress);
                                                sw2.WriteLine(subjects);
                                                sw2.WriteLine(totalprice);
                                                sw2.WriteLine(amount);
                                                sw2.Close();

                                            }
                                            goto editorreturn;


                                        case "r":
                                            goto main;
                                        default:
                                            Console.WriteLine("invalid key");
                                            Console.ReadKey();
                                            Console.Clear();
                                            goto editorreturn;

                                    }
                                }
                            case "2":
                                Console.WriteLine("student number 2 info:");
                                using (StreamReader sr1 = new StreamReader(File.Open("studentnumber2.txt", FileMode.Open)))
                                {

                                    sname = sr1.ReadLine();
                                    fname = sr1.ReadLine();
                                    mname = sr1.ReadLine();
                                    mbday = sr1.ReadLine();
                                    ybday = sr1.ReadLine();
                                    dbday = sr1.ReadLine();
                                    gender = sr1.ReadLine();
                                    address = sr1.ReadLine();
                                    guardianname = sr1.ReadLine();
                                    guardiannumber = sr1.ReadLine();
                                    contactinfo = sr1.ReadLine();
                                    emailaddress = sr1.ReadLine();
                                    course = sr1.ReadLine();
                                    year1 = sr1.ReadLine();
                                    subjects = sr1.ReadLine();
                                    totalsubjectprice = Convert.ToInt32(sr1.ReadLine());
                                    totalprice = Convert.ToInt32(sr1.ReadLine());
                                    amount = Convert.ToInt32(sr1.ReadLine());

                                    sr1.Close();
                                    Console.WriteLine("Name:{0} {1},{2}", sname, fname, mname);
                                    Console.WriteLine("Gender:{0}", gender);
                                    Console.WriteLine("Address:{0}", address);
                                    Console.WriteLine("Birthday:{0},{1},{2}", mbday, dbday, ybday);
                                    Console.WriteLine("Guardian's Name:{0}", guardianname);
                                    Console.WriteLine("Guardian's Number:{0}", guardiannumber);
                                    Console.WriteLine("Contact Info:{0}", contactinfo);
                                    Console.WriteLine("Email Address:{0}", emailaddress);
                                    Console.WriteLine("Course:{0}", course);
                                    Console.WriteLine("year:{0}", year1);
                                    Console.WriteLine("Subjects:{0}", subjects);
                                    Console.WriteLine("total subjects price{0}+tuition{1}=Total Price{2}", totalsubjectprice, tuition, totalprice);
                                    Console.WriteLine("Paid amount:{0}", amount);
                                    Console.WriteLine("Press (e) if you want to edit the info and press (r) to return to main menu");
                                    edit = Console.ReadLine();

                                    Console.Clear();
                                editorreturn:
                                    switch (edit)
                                    {
                                        case "e":
                                            Console.WriteLine("what would you like to change\n{a}name\n{b}gender\n{c}address\n{d}birthday\n{e}Guardian's name\n{f]Guardian's number\n{g}contact info\n{h}email address\n{r}return");
                                            editstud1 = Console.ReadLine();
                                            Console.Clear();
                                            switch (editstud1)
                                            {
                                                case "a":

                                                    Console.WriteLine("enter your surname here ");
                                                    sname = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    Console.WriteLine("enter your given name here  ");
                                                    fname = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    Console.WriteLine("enter your middle name here  ");
                                                    mname = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "b":
                                                    Console.WriteLine("enter your gender here ");
                                                    gender = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "c":
                                                    Console.WriteLine("enter your address here ");
                                                    address = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "d":
                                                    Console.WriteLine("enter your birthdate here ");
                                                    Console.WriteLine("month ");
                                                    mbday = Convert.ToString(Console.ReadLine());
                                                    Console.WriteLine("day ");
                                                    dbday = Convert.ToString(Console.ReadLine());
                                                    Console.WriteLine("year ");
                                                    ybday = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "e":
                                                    Console.WriteLine("enter your guardian's name here )");
                                                    guardianname = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "f":
                                                    Console.WriteLine("enter your guardian's number here ");
                                                    guardiannumber = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "g":
                                                    Console.WriteLine("enter your contact number here ");
                                                    contactinfo = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;
                                                case "h":
                                                    Console.WriteLine("enter your Email Address here ");
                                                    emailaddress = Convert.ToString(Console.ReadLine());
                                                    Console.Clear();
                                                    break;


                                                case "r":
                                                    goto studinfo;
                                                default:
                                                    goto editorreturn;

                                            }
                                            using (StreamWriter sw2 = new StreamWriter(File.Create("studentnumber1.txt")))
                                            {
                                                sw2.WriteLine(sname);
                                                sw2.WriteLine(fname);
                                                sw2.WriteLine(mname);
                                                sw2.WriteLine(mbday);
                                                sw2.WriteLine(dbday);
                                                sw2.WriteLine(ybday);
                                                sw2.WriteLine(gender);
                                                sw2.WriteLine(address);
                                                sw2.WriteLine(guardianname);
                                                sw2.WriteLine(guardiannumber);
                                                sw2.WriteLine(contactinfo);
                                                sw2.WriteLine(emailaddress);
                                                sw2.WriteLine(subjects);
                                                sw2.WriteLine(totalprice);
                                                sw2.WriteLine(amount);
                                                sw2.Close();

                                            }
                                            goto editorreturn;


                                        case "r":
                                            goto main;
                                        default:
                                            Console.WriteLine("invalid key");
                                            Console.ReadKey();
                                            Console.Clear();
                                            goto editorreturn;

                                    }
                                }


                            case "r":
                                goto main;


                        }

                        break;
                    case "c":
                    case "C":
                        Console.WriteLine("If you need help, please contact us.\n 09xxxxxxxxx\n example@sample.com");
                        goto main;
                    case "d":
                    case "D":
                        Console.WriteLine("please come again");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("invalid key");
                        Console.ReadKey();
                        Console.Clear();
                        goto main;



                }
            }
            else
            {
                Console.WriteLine("Login Failed");
                Console.ReadKey();
                goto login;
                //thankyou//
                
            }

        }
    }
}


