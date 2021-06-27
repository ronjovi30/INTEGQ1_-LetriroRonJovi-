using System;
using System.Collections.Generic;
using System.Text;

namespace SVRMS.BL
{
    public class addViolationFunction
    {
        // addViolationFunction
        public void addviolation (List<string> course,
                                  List<string> bsa1S1,
                                  List<string> bsa2S1,
                                  List<string> bsa3S1,
                                  List<string> bsa4S1,
                                  List<int> bsa1S1N,
                                  List<int> bsa2S1N,
                                  List<int> bsa3S1N,
                                  List<int> bsa4S1N,
                                  List<string> bsse1S1,
                                  List<string> bsse2S1,
                                  List<string> bsse3S1,
                                  List<string> bsse4S1,
                                  List<int> bsse1S1N,
                                  List<int> bsse2S1N,
                                  List<int> bsse3S1N,
                                  List<int> bsse4S1N,
                                  List<string> bsie1S1,
                                  List<string> bsie2S1,
                                  List<string> bsie3S1,
                                  List<string> bsie4S1,
                                  List<int> bsie1S1N,
                                  List<int> bsie2S1N,
                                  List<int> bsie3S1N,
                                  List<int> bsie4S1N,
                                  List<string> bsce1S1,
                                  List<string> bsce2S1,
                                  List<string> bsce3S1,
                                  List<string> bsce4S1,
                                  List<int> bsce1S1N,
                                  List<int> bsce2S1N,
                                  List<int> bsce3S1N,
                                  List<int> bsce4S1N,
                                  List<string> bsit1S1,
                                  List<string> bsit2S1,
                                  List<string> bsit3S1,
                                  List<string> bsit4S1,
                                  List<int> bsit1S1N,
                                  List<int> bsit2S1N,
                                  List<int> bsit3S1N,
                                  List<int> bsit4S1N)
        {
            
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |");
            Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |\n\n\n");

            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Clear();
            //BSA
            if (bsa1S1.Contains(name))
            {

                addingViolation(bsa1S1[bsa1S1.IndexOf(name)], course[1], bsa1S1N[bsa1S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsa2S1.Contains(name))
            {

                addingViolation(bsa2S1[bsa2S1.IndexOf(name)], course[1], bsa2S1N[bsa2S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
               
            }
            else if (bsa3S1.Contains(name))
            {

                addingViolation(bsa3S1[bsa3S1.IndexOf(name)], course[1], bsa3S1N[bsa3S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsa4S1.Contains(name))
            {

                addingViolation(bsa4S1[bsa4S1.IndexOf(name)], course[1], bsa4S1N[bsa4S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();

            }
            // BSSE
            else if (bsse1S1.Contains(name))
            {

                addingViolation(bsse1S1[bsse1S1.IndexOf(name)], course[2], bsse1S1N[bsse1S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsse2S1.Contains(name))
            {

                addingViolation(bsse2S1[bsse2S1.IndexOf(name)], course[2], bsse2S1N[bsse2S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsse3S1.Contains(name))
            {

                addingViolation(bsse3S1[bsse3S1.IndexOf(name)], course[2], bsse3S1N[bsse3S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsse4S1.Contains(name))
            {

                addingViolation(bsse4S1[bsse4S1.IndexOf(name)], course[2], bsse4S1N[bsse4S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            // BSIE
            else if (bsie1S1.Contains(name))
            {

                addingViolation(bsie1S1[bsie1S1.IndexOf(name)], course[3], bsie1S1N[bsie1S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsie2S1.Contains(name))
            {

                addingViolation(bsie2S1[bsie2S1.IndexOf(name)], course[3], bsie2S1N[bsie2S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsie3S1.Contains(name))
            {

                addingViolation(bsie3S1[bsie3S1.IndexOf(name)], course[3], bsie3S1N[bsie3S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsie4S1.Contains(name))
            {

                addingViolation(bsie4S1[bsie4S1.IndexOf(name)], course[3], bsie4S1N[bsie4S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            //BSCE
            else if (bsce1S1.Contains(name))
            {

                addingViolation(bsce1S1[bsce1S1.IndexOf(name)], course[4], bsce1S1N[bsce1S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsce2S1.Contains(name))
            {

                addingViolation(bsce2S1[bsce2S1.IndexOf(name)], course[4], bsce2S1N[bsce2S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsce3S1.Contains(name))
            {

                addingViolation(bsce3S1[bsce3S1.IndexOf(name)], course[4], bsce3S1N[bsce3S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsce4S1.Contains(name))
            {

                addingViolation(bsce4S1[bsce4S1.IndexOf(name)], course[4], bsce4S1N[bsce4S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            //BSIT
            else if (bsit1S1.Contains(name))
            {

                addingViolation(bsit1S1[bsit1S1.IndexOf(name)], course[5], bsit1S1N[bsit1S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsit2S1.Contains(name))
            {

                addingViolation(bsit2S1[bsit2S1.IndexOf(name)], course[5], bsit2S1N[bsit2S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsit3S1.Contains(name))
            {

                addingViolation(bsit3S1[bsit3S1.IndexOf(name)], course[5], bsit3S1N[bsit3S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else if (bsit4S1.Contains(name))
            {

                addingViolation(bsit4S1[bsit4S1.IndexOf(name)], course[5], bsit4S1N[bsit4S1.IndexOf(name)]);
                Console.ReadKey();
                Console.Clear();
                
            }
            else
            {
                Console.WriteLine("Name is no found");
                Console.ReadKey();
                Console.Clear();
                
            }
        }

       

        private void addingViolation(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public void addingViolation(string studentName, string studentCourse, int numberViolation)
        {
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |");
            Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |\n\n\n");

            Console.Write("\nPosible Violation\n1. no ID\n2. improper dressing\n3. engaging in any unlawful Activity\n\n\nnote: type only the number correspoding to the violation.\n\n");
            Console.Write("Violation: ");
            String violation = Console.ReadLine();

            Console.WriteLine("\n\n\nVoilation has been added\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |");
            Console.WriteLine("| | STUDENT VIOlATION RECORD MANAGEMENT | |");
            Console.WriteLine("| |_____________________________________| |");
            Console.WriteLine("| |                                     | |\n\n\n");

            Console.WriteLine("Name:" + studentName);
            Console.WriteLine("Course:" + studentCourse);

            // condition

            if (violation == "1" && numberViolation == 0)
            {
                int number = 1;
                numberViolation = number + number - number;
                Console.WriteLine("Violation: No ID");
                Console.WriteLine("Number of violation: " + numberViolation);

            }

            else if (violation == "1" && numberViolation == 1)
            {
                int number = 1;
                numberViolation = number + number;
                Console.WriteLine("Violation: No ID");
                Console.WriteLine("Number of violation: " + numberViolation);
            }
            else if (violation == "1" && numberViolation == 2)
            {
                int number = 1;
                numberViolation = number + number + number;
                Console.WriteLine("Violation: No ID");
                Console.WriteLine("Number of violation: " + numberViolation);
            }
            else if (violation == "2" && numberViolation == 0)
            {
                int number = 1;
                numberViolation = number + number - number;
                Console.WriteLine("Violation: Improper Dressing ");
                Console.WriteLine("Number of violation: " + numberViolation);

            }
            else if (violation == "2" && numberViolation == 1)
            {
                int number = 1;
                numberViolation = number + number;
                Console.WriteLine("Violation: Improper Dressing ");
                Console.WriteLine("Number of violation: " + numberViolation);

            }
            else if (violation == "2" && numberViolation == 2)
            {
                int number = 1;
                numberViolation = number + number + number;
                Console.WriteLine("Violation: Improper Dressing ");
                Console.WriteLine("Number of violation: " + numberViolation);

            }
            else if (violation == "3" && numberViolation == 0)
            {
                int number = 1;
                numberViolation = number + number - number;
                Console.WriteLine("Violation: Engaging in any unlawful Activity ");
                Console.WriteLine("Number of violation: " + numberViolation);

            }
            else if (violation == "3" && numberViolation == 1)
            {
                int number = 1;
                numberViolation = number + number;
                Console.WriteLine("Violation: Engaging in any unlawful Activity ");
                Console.WriteLine("Number of violation: " + numberViolation);

            }
            else if (violation == "3" && numberViolation == 2)
            {
                int number = 1;
                numberViolation = number + number + number;
                Console.WriteLine("Violation: Engaging in any unlawful Activity ");
                Console.WriteLine("Number of violation: " + numberViolation);

            }
            else
            {
                Console.WriteLine("invalid input");
            }
            Console.ReadKey();
            

        }


    }
}