using SSAProject_A20335721.InputProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSAProject_A20335721
{
    class MainGasPump
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("************************Welcome to Gas Station!!*************************");
                Console.WriteLine("\t1. Gas Pump 1\n\n\t2. Gas Pump 2\n\n\t3. Gas Pump 3\n\n\t4. Exit");
                Console.Write("\tEnter type of gas pump(1 or 2 or 3) : ");
                int gasPumpNumber = (Int32.Parse(Console.ReadLine()));
                bool flag = false;
                switch (gasPumpNumber)
                {
                    case 1:
                        GasPump1 gaspump = new GasPump1();
                        Console.WriteLine("\tGas Pump 1 selected");
                        flag = true;
                        while (flag)
                        {
                            Console.WriteLine("\t\t1. Activate\n\t\t2. Start\n\t\t3. Pay Credit\n\t\t4. Reject\n\t\t5. Cancel\n\t\t6. Approved\n\t\t7. Pay Cash\n\t\t8. Start Pump\n\t\t9. Pump Gallon\n\t\t10 Stop Pump\n\t\t11. Exit");
                            Console.Write("\t\tPlease select an option :");
                            
                            int gaspump1Option = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(gaspump1Option);
                            

                            switch (gaspump1Option)
                            {

                                case 1:
                                    Console.Write("\t\tPlease enter price to activate gas pump:");
                                    
                                    int a = Int32.Parse(Console.ReadLine());
                                    gaspump.Activate(a);
                                    break;
                                case 2:
                                    gaspump.Start();
                                    break;
                                case 3:
                                    gaspump.PayCredit();
                                    break;
                                case 4:
                                    gaspump.Reject();
                                    break;
                                case 5: gaspump.Cancel();
                                    break;
                                case 6: gaspump.Approved();
                                    break;
                                case 7: Console.Write("\t\tPlease enter cash amount:");
                                        int c = Int32.Parse(Console.ReadLine());
                                       
                                        gaspump.PayCash(c);
                                    break;
                                case 8:
                                    gaspump.StartPump();
                                    break;
                                case 9:
                                    gaspump.PumpGallon();
                                    break;
                                case 10:
                                    gaspump.StopPump();
                                    break;
                                case 11: flag = false;
                                    break;
                                default:
                                    break;


                            }
                        }
                        break;
                    case 2:
                        GasPump2 gasPump2 = new GasPump2();
                        Console.WriteLine("\tGas Pump 2 selected");
                        flag = true;
                        while (flag)
                        {
                        
                        Console.WriteLine("\t\t1. Activate\n\t\t2. Start\n\t\t3. Pay Credit\n\t\t4. Reject\n\t\t5. Cancel\n\t\t6. Approved\n\t\t7. Super\n\t\t8. Regular\n\t\t9. Start Pump\n\t\t10. Pump Gallon\n\t\t11 Stop Pump\n\t\t12 Exit");
                        Console.Write("\t\tPlease select an option :");
                        int gaspump2Option = Int32.Parse(Console.ReadLine());

                        
                        
                            switch (gaspump2Option)
                            {
                                case 1: Console.Write("\t\tPlease enter price of regular gas:");
                                    float a = float.Parse(Console.ReadLine());
                                    Console.Write("\n\t\tPlease enter price of super gas: ");
                                    float b = float.Parse(Console.ReadLine());
                                    gasPump2.Activate(a, b);
                                    break;
                                case 2: gasPump2.Start();

                                    break;
                                case 3: gasPump2.PayCredit();
                                    break;
                                case 4: gasPump2.Reject();
                                    break;
                                case 5: gasPump2.Cancel();
                                    break;
                                case 6: gasPump2.Approved();
                                    break;
                                case 7: gasPump2.Super();
                                    break;
                                case 8: gasPump2.Regular();
                                    break;
                                case 9: gasPump2.StartPump();
                                    break;
                                case 10: gasPump2.PumpGallon();
                                    break;
                                case 11: gasPump2.StopPump();
                                    break;
                                case 12: flag = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 3:
                        GasPump3 gasPump3 = new GasPump3();
                        Console.WriteLine("\tGas Pump 3 Selected!!!");
                        flag = true;
                        while (flag)
                        {
                        Console.WriteLine("\t\t1. Activate\n\t\t2. Start\n\t\t3. Pay Cash\n\t\t4. Cancel\n\t\t5. Premium\n\t\t6. Regular\n\t\t7. Start Pump\n\t\t8. Pump Liter\n\t\t9. Stop Pump\n\t\t10. Receipt\n\t\t11 No Receipt");
                        Console.Write("\t\tPlease select an option :");
                        int gaspump3Option = Int32.Parse(Console.ReadLine());
                        
                            switch (gaspump3Option)
                            {
                                case 1: Console.Write("\t\tPlease enter price of regular gas:");
                                    float a = float.Parse(Console.ReadLine());
                                    Console.Write("\n\t\tPlease enter price of premium gas: ");
                                    float b = float.Parse(Console.ReadLine());
                                    gasPump3.Activate(a,b);
                                    break;
                                case 2: gasPump3.Start();
                                    break;
                                case 3: Console.Write("\t\tPlease enter cash amount:");
                                    float c = float.Parse(Console.ReadLine());
                                    gasPump3.PayCash(c);
                                    break;
                                case 4: gasPump3.Cancel();
                                    break;
                                case 5: gasPump3.Premium();
                                    break;
                                case 6: gasPump3.Regular();
                                    break;
                                case 7: gasPump3.StartPump();
                                    break;
                                case 8: gasPump3.PumpLiter();
                                    break;
                                case 9: gasPump3.StopPump();
                                    break;
                                case 10: gasPump3.Receipt();
                                    break;
                                case 11: gasPump3.NoReceipt();
                                    break;
                                case 12:
                                    flag = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 4:
                        System.Environment.Exit(1);
                        break;
                    default:
                        break;

                }
                //Console.ReadLine();
            }
        }
    }
}
