using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CENG_LUDO
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu_option = 0, game_control = 0, control_p_1 = 0, control_p_2 = 0, control_p_3 = 0, control_p_4 = 0;
            char temp = '.';
            int dice, round, pname2, pname3, pname4, turn_number, pawn_number = 0, board_number = 0; ;
            pname2 = 0; pname3 = 0; pname4 = 0; menu_option = 0; round = 1; turn_number = 0; dice = 0;
            Random random = new Random();
            pname2 = random.Next(1, 5);
            pname3 = random.Next(1, 5);
            pname4 = random.Next(1, 5);
            int pawn_location = 0;
            int previous_location = 0;
            string player1, player2, player3, player4, notice_box, dice_command, player_name;
            player1 = "";
            player2 = "";
            player3 = "";
            player4 = "";
            notice_box = "";
            dice_command = "";
            player_name = player1;
            char[] board = new char[56];
            switch (pname2)
            {
                case 1:
                    player2 = "ZUCKERBERG";
                    break;
                case 2:
                    player2 = "PAGE";
                    break;
                case 3:
                    player2 = "AHMET";
                    break;
                case 4:
                    player2 = "DORSEY";
                    break;
            }


            switch (pname3)

            {
                case 1:
                    player3 = "HANS";
                    break;
                case 2:
                    player3 = "ONUR";
                    break;
                case 3:
                    player3 = "BOOLE";
                    break;
                case 4:
                    player3 = "TURING";
                    break;
            }

            switch (pname4)
            {
                case 1:
                    player4 = "ATA";
                    break;
                case 2:
                    player4 = "RITCHIE";
                    break;
                case 3:
                    player4 = "STROUSTRUP";
                    break;
                case 4:
                    player4 = "HEJLSBERG";
                    break;
            }


            for (int i = 0; i < 56; i++)
                board[i] = ('.');


            char[] target_f = new char[16];


            for (int i = 0; i < 16; i++)
                target_f[i] = ('o');

            char[] home_f = new char[16] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P' };

            char[] penalty1 = new char[3] { '(', '(', '(' };

            char[] penalty2 = new char[2] { '<', '<' };

            char[] penalty3 = new char[1] { 'X' };

            char[] reward1 = new char[3] { ')', ')', ')' };

            char[] reward2 = new char[2] { '>', '>' };
            while (menu_option != 1)
            {
                Console.Clear();
                Console.WriteLine("         --- CENG LUDO ---");
                Console.WriteLine("");
                Console.WriteLine("   Welcome to Ceng Ludo!");
                Console.WriteLine("");
                Console.WriteLine(" Please choose an option to continue:");
                Console.WriteLine("");
                Console.WriteLine("1- Start Game");
                Console.WriteLine("2- Rules");
                Console.WriteLine("3- Creators");
                Console.SetCursorPosition(38, 4);
                menu_option = Convert.ToInt16(Console.ReadLine());
                switch (menu_option)
                {
                    case 1:

                        {
                            game_control = 1;
                            menu_option = 1;
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("      * Rules *");
                            Console.WriteLine("");
                            Console.WriteLine(" -To start the game, the player must roll a six.");
                            Console.WriteLine(" -After moving a pawn to the board, the player rolls again to move.");
                            Console.WriteLine(" -Two pawns of the same player can't be located at the same point.");
                            Console.WriteLine(" -If a player rolls a six, the player can choose to place another pawn out of a home field or move a pawn inside the game path.");
                            Console.WriteLine(" -The player continues to play as long as he/she rolls a six.");
                            Console.WriteLine(" -You can capture an opponent's pawn anytime you land on top of one of their pawns.");
                            Console.WriteLine(" -To land in the target field, player has to roll the exact number.");
                            Console.WriteLine(" -The first player whose targeted field is full with pawns wins the game.");
                            Console.WriteLine("");
                            Console.Write("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Welcome to Ceng Ludo!");
                            Console.WriteLine("Made by:");
                            Console.WriteLine("Ahmet Fevzi Balaban");
                            Console.WriteLine("Ata Buğra Pişkin");
                            Console.WriteLine("Onur Kantar");
                            Console.WriteLine("");
                            Console.Write("Press any key to continue");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.SetCursorPosition(38, 4); Console.Write(" Wrong command, enter 1, 2 or 3");
                            Console.ReadKey();
                            break;
                        }
                }

            }
            Console.Clear();
            Console.SetCursorPosition(8, 5);
            Console.Write("Please write your username !!");
            Console.SetCursorPosition(8, 6);
            player1 = Convert.ToString(Console.ReadLine());
            player_name = player1;
            while (game_control == 1)
            {

                dice = random.Next(1, 7);
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("{0}                      {1}                        Round:{2}", player1, player2, round);
                Console.WriteLine("A B C D      + - - - +      E F G H           Turn:{0}", player_name);
                Console.WriteLine("+ - - +      | {0} {1} {2} |      + - - +           Dice: " + dice, board[12], board[13], board[14]);
                Console.WriteLine("| {0} {1} |      | {2} {3} {4} |      | {5} {6} |           Enter Pawn:", home_f[0], home_f[1], board[11], target_f[4], board[15], home_f[4], home_f[5]);
                Console.WriteLine("| {0} {1} |      | {2} {3} {4} |      | {5} {6} | ", home_f[2], home_f[3], board[10], target_f[5], board[16], home_f[6], home_f[7]);
                Console.WriteLine("+ - - +      | {0} {1} {2} |      + - - + ", board[9], target_f[6], board[17]);
                Console.WriteLine("             | {0} {1} {2} |              ", board[8], target_f[7], board[18]);
                Console.WriteLine(" + - - - - - + {0} # {1} + - - - - - +  ", board[7], board[19]);
                Console.Write(" | {0} {1} {2} {3} {4} {5} {6} #", board[0], board[1], board[2], board[3], board[4], board[5], board[6]);
                Console.WriteLine(" {0} {1} {2} {3} {4} {5} {6} |", board[20], board[21], board[22], board[23], board[24], board[25], board[26]);
                Console.WriteLine(" | {0} {1} {2} {3} {4} # # # # # {5} {6} {7} {8} {9} |", board[55], target_f[0], target_f[1], target_f[2], target_f[3], target_f[11], target_f[10], target_f[9], target_f[8], board[27]);
                Console.Write(" | {0} {1} {2} {3} {4} {5} {6} #", board[54], board[53], board[52], board[51], board[50], board[49], board[48]);
                Console.WriteLine(" {0} {1} {2} {3} {4} {5} {6} |", board[34], board[33], board[32], board[31], board[30], board[29], board[28]);
                Console.WriteLine(" + - - - - - + {0} # {1} + - - - - - +", board[47], board[35]);
                Console.WriteLine("             | {0} {1} {2} |            ", board[46], target_f[15], board[36]);
                Console.WriteLine("+ - - +      | {0} {1} {2} |      + - - + ", board[45], target_f[14], board[37]);
                Console.WriteLine("| {0} {1} |      | {2} {3} {4} |      | {5} {6} |", home_f[12], home_f[13], board[44], target_f[13], board[38], home_f[8], home_f[9]);
                Console.WriteLine("| {0} {1} |      | {2} {3} {4} |      | {5} {6} |", home_f[14], home_f[15], board[43], target_f[12], board[39], home_f[10], home_f[11]);
                Console.WriteLine("+ - - +      | {0} {1} {2} |      + - - +", board[42], board[41], board[40]);
                Console.WriteLine("M N O P      + - - - +      I J K L");
                Console.WriteLine("{0}                      {1}", player4, player3);



                //if (dice == 6)
                //{
                //    control_p_1 = Convert.ToInt16(Console.ReadLine());
                //    switch (turn_number)
                //    {
                //        case 1:

                //            if (control_p_1 == 1)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[0];
                //                home_f[0] = temp;

                //            }
                //            else if (control_p_1 == 2)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[1];
                //                home_f[1] = temp;
                //            }
                //            else if (control_p_1 == 3)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[2];
                //                home_f[2] = temp;

                //            }
                //            else if (control_p_1 == 4)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[3];
                //                home_f[3] = temp;

                //            }
                //            if (control_p_1 > 4)
                //            {
                //                notice_box = "Wrong command !!Your Turn Has Passed !!";
                //                break;
                //            }
                //            break;

                //        case 2:
                //            control_p_2 = random.Next(1, 5);
                //            if (control_p_2 == 1)
                //            {

                //                board[0] = home_f[4];
                //                home_f[4] = temp;
                //                if (board[0] != '.')
                //                    control_p_2 = random.Next(1, 5);
                //            }
                //            else if (control_p_2 == 2)
                //            {
                //                board[0] = home_f[5];
                //                home_f[5] = temp;
                //                if (board[0] != '.')
                //                    control_p_2 = random.Next(1, 5);
                //            }
                //            else if (control_p_2 == 3)
                //            {
                //                board[0] = home_f[6];
                //                home_f[6] = temp;
                //                if (board[0] != '.')
                //                    control_p_2 = random.Next(1, 5);
                //            }
                //            else if (control_p_2 == 4)
                //            {
                //                board[0] = home_f[7];
                //                home_f[7] = temp;
                //                if (board[0] != '.')
                //                    control_p_2 = random.Next(1, 5);
                //            }

                //            break;

                //        case 3:
                //            control_p_3 = random.Next(1, 5);
                //            if (control_p_3 == 1)
                //            {
                //                board[0] = home_f[8];
                //                home_f[8] = temp;
                //                if (board[0] != '.')
                //                    control_p_2 = random.Next(1, 5);
                //            }
                //            else if (control_p_3 == 2)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[9];
                //                home_f[9] = temp;
                //            }
                //            else if (control_p_3 == 3)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[10];
                //                home_f[10] = temp;

                //            }
                //            else if (control_p_3 == 4)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[11];
                //                home_f[11] = temp;

                //            }
                //            if (control_p_3 > 4)
                //            {
                //                notice_box = "Wrong command !!Your Turn Has Passed !!";
                //                break;
                //            }
                //            break;

                //        case 4:
                //            control_p_4 = random.Next(1, 5);
                //            if (control_p_4 == 1)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[12];
                //                home_f[12] = temp;

                //            }
                //            else if (control_p_4 == 2)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[13];
                //                home_f[13] = temp;
                //            }
                //            else if (control_p_4 == 3)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[14];
                //                home_f[14] = temp;

                //            }
                //            else if (control_p_4 == 4)
                //            {
                //                if (board[0] != '.')
                //                    break;
                //                board[0] = home_f[15];
                //                home_f[15] = temp;

                //            }
                //            if (control_p_4 > 4)
                //            {
                //                notice_box = "Wrong command !!Your Turn Has Passed !!";
                //                break;
                //            }
                ///////////////////////////////////////////////////////////////////////////////////////burada piyon çıkarma yapay zekası
                //if (turn_number == 1 && dice == 6)
                //{
                //    Console.SetCursorPosition(57, 5);
                //    control_p_1 = Convert.ToInt16(Console.ReadLine());
                //    board[0] = home_f[(control_p_1) - 1];
                //    home_f[(control_p_1) - 1] = '.';
                //    turn_number--;
                //}
                //else if (turn_number == 1 && dice != 6 && home_f[0] == '.')
                //{
                //    Console.SetCursorPosition(57, 5);
                //    control_p_1 = Convert.ToInt16(Console.ReadLine());
                //    pawn_location += dice;
                //    board[pawn_location] = board[previous_location];
                //    board[previous_location] = '.';
                //}
                //else if (turn_number == 1 && dice != 6)
                //{

                //}
                //else if (turn_number == 2 && dice == 6 && board[14] == '.')
                //{
                //    if (home_f[4] != '.')
                //    {
                //        board[14] = home_f[4];
                //        home_f[4] = '.';
                //        turn_number--;
                //    }
                //    else if  (home_f[5] != '.')
                //    {
                //        board[14] = home_f[5];
                //        home_f[5] = '.';
                //        turn_number--;
                //    }
                //    else if (home_f[6] != '.')
                //    {
                //        board[14] = home_f[6];
                //        home_f[6] = '.';
                //        turn_number--;
                //    }
                //    else if (home_f[7] != '.')
                //    {
                //        board[14] = home_f[7];
                //        home_f[7] = '.';
                //        turn_number--;
                //    }
                //}
                //else if (turn_number == 2 && dice != 6 && home_f[4] == '.')
                //{
                //    //movement plz
                //}
                //else if (turn_number == 2 && dice != 6)
                //{
                    
                //}
                //else if (turn_number == 3 && dice == 6 && board[28] == '.')
                //{
                //    if (home_f[8] != '.')
                //    {
                //        board[28] = home_f[8];
                //        home_f[8] = '.';
                //        turn_number--;
                //    }
                //    else if (home_f[9] != '.')
                //    {
                //        board[14] = home_f[9];
                //        home_f[9] = '.';
                //        turn_number--;
                //    }
                //    else if (home_f[10] != '.')
                //    {
                //        board[14] = home_f[10];
                //        home_f[10] = '.';
                //        turn_number--;
                //    }
                //    else if (home_f[11] != '.')
                //    {
                //        board[14] = home_f[11];
                //        home_f[11] = '.';
                //        turn_number--;
                //    }
                //}
                //else if (turn_number == 3 && dice != 6 && home_f[8] == '.')
                //{
                //    //movement plz
                //}
                //else if (turn_number == 3 && dice != 6)
                //{
                    
                //}
                //else if (turn_number == 4 && dice == 6 && board[42] == '.')
                //{
                //    if (home_f[12] != '.')
                //    {
                //        board[42] = home_f[12];
                //        home_f[12] = '.';
                //        turn_number--;
                //    }
                //    else if (home_f[13] != '.')
                //    {
                //        board[14] = home_f[13];
                //        home_f[13] = '.';
                //        turn_number--;
                //    }
                //    else if (home_f[14] != '.')
                //    {
                //        board[14] = home_f[14];
                //        home_f[14] = '.';
                //        turn_number--;
                //    }
                //    else if (home_f[15] != '.')
                //    {
                //        board[14] = home_f[15];
                //        home_f[15] = '.';
                //        turn_number--;
                //    }
                //}
                //else if (turn_number == 4 && dice != 6 && home_f[12] == '.')
                //{
                //    //movement plz
                //}
                //else if (turn_number == 4 && dice != 6)
                //{
                    
                //}
                if (dice == 6)
                {
                    if (turn_number > 0)
                    {

                        control_p_2 = random.Next(0, 4);
                        control_p_3 = random.Next(0, 4);
                        control_p_4 = random.Next(0, 4);

                        while (true)
                        {
                            if (turn_number == 1)
                            {
                                if (home_f[control_p_2] == '.')
                                    control_p_2 = random.Next(0, 3);
                                break;
                            }

                            else if (turn_number == 2)
                            {
                                if (home_f[control_p_3] == '.')
                                    control_p_3 = random.Next(0, 3);
                                break;
                            }

                            else if (turn_number == 3)
                            {
                                if (home_f[control_p_4] == '.')
                                    control_p_4 = random.Next(0, 3);
                                break;

                            }
                        }
                    }
                    if (turn_number == 0)
                    {
                        Console.SetCursorPosition(57, 5);
                        control_p_1 = Convert.ToInt16(Console.ReadLine());
                        pawn_number = control_p_1;
                    }
                    if (turn_number == 1)
                        pawn_number = control_p_2*4;
                    else if (turn_number == 2)
                        pawn_number = control_p_3*4;
                    else if (turn_number == 3)
                        pawn_number = control_p_4*4;

                    if (turn_number == 0)
                        board_number = 0;
                    else if (turn_number == 1)
                        board_number = 15;
                    else if (turn_number == 2)
                        board_number = 29;
                    else if (turn_number == 3)
                        board_number = 43;

                    board[board_number] = home_f[(pawn_number) - 1];
                    home_f[(pawn_number) - 1] = '.';
                    turn_number--;

                }////// burada kaldın
                if (round == 2 && board[0] != '.')
                {
                    pawn_location += dice;
                    board[pawn_location] = board[previous_location];
                    board[previous_location] = '.';


                }


                turn_number += 1;
                turn_number = turn_number % 4;
                if (turn_number == 0)
                    player_name = player1;
                else if (turn_number == 1)
                    player_name = player2;
                else if (turn_number == 2)
                    player_name = player3;
                else if (turn_number == 3)
                    player_name = player4;


                round++;
                Console.ReadKey();
                Console.Clear();

            }
        }



    }
}

