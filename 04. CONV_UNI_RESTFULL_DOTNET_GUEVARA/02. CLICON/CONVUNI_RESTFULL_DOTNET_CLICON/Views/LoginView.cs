using CONVUNI_RESTFULL_DOTNET_CLICON.Controllers;
using System;
using System.Text;
using System.Threading.Tasks;

namespace CONVUNI_RESTFULL_DOTNET_CLICON.Views
{
    public class LoginView
    {
        private LoginController _loginController;

        public LoginView()
        {
            _loginController = new LoginController();
        }

        public async Task Start()
        {
            Console.WriteLine("    *#######################(       ########################   ############################  ###########################\r\n    *#  ,,,,,,,,,,,,,,,,,,, ,#.   .#, .,,,,,,,,,,,,,,,,,, .#   #  ,...................., /#  ##  ....................  #\r\n    *#  ####################  ## ##  #################### .#   #  ###################### /#  ## ,####################  #\r\n    *#  #####################(  #. /##################### .#   #  ###################### /#  ## ,####################  #\r\n    *#     (###################   ###################,    .#   #       ############      /#  ##     ,############      #\r\n    *####  ###########################################  ####   ######  ############  ######  ###### ,############  #####\r\n       #( *##############(.    .*,     (##############, ##         ##  ############  #*          ## ,############  #.   \r\n      /#  ##########.       &@@@@@@@@       .##########  #.        ##  ############  #*          ## ,############  #.   \r\n      #( *#######.          @@@@@@@@@.         *#######, ##        ##  ############  #*          ## .############  #.   \r\n     /#  ###########/       /@@@@@@@/       (###########  #        ##  ############  #*          ## ,############  #.   \r\n     ## *#################(.        .*##################* ##       ##  ############  #*          ## ,############  #.   \r\n######  ############## ################### ##############  #####   ##  ############  /############. ,############  #.   \r\n/#  .../#############,  ,###############.  ,#############/,,,  #   ##  ##############/............/##############  #.   \r\n/#  #################  #  ############/  #  #################  #    ##,  #####################################*  (#/    \r\n/#  ################( (##/  #########  ###/ (################  #       ##  ,################################  .##       \r\n*#                    ## (#          /#* /#                    #         /#(                                ##.         \r\n*######################.   ###########    ######################            ###############################(    ");
            Console.WriteLine(" ");
            Console.WriteLine("                                     Bienvenido al sistema de Conversiones Restfull - Grupo 5");
            while (true)
            {
                DrawBox();
                int left = (Console.WindowWidth - 20) / 2;
                int top = (Console.WindowHeight) - 8;

                Console.SetCursorPosition(left -4, top);
                Console.Write("Ingrese su usuario: ");
                string username = Console.ReadLine();

                Console.SetCursorPosition(left - 4, top + 2);
                Console.Write("Ingrese su contraseña: ");
                string password = ReadPassword(left - 4 + "Ingrese su contraseña: ".Length, top + 2);

                var result = _loginController.Login(new Models.LoginModel
                {
                    username = username,
                    password = password
                });

                if (await result)
                {
                    DrawBox();
                    Console.SetCursorPosition(left - 6, top);
                    Console.WriteLine($"Bienvenido {username} al sistema de");
                    Console.SetCursorPosition(left - 6, top + 1);
                    Console.WriteLine("Conversiones Restfull - Grupo 5");
                    break;
                }
                else
                {
                    DrawBox();
                    Console.SetCursorPosition(left - 6, top);
                    Console.WriteLine("Usuario o contraseña incorrectos");
                    await Task.Delay(2000);
                }
            }
        }

        private string ReadPassword(int startX, int startY)
        {
            StringBuilder password = new StringBuilder();
            ConsoleKeyInfo key;

            while (true)
            {
                Console.SetCursorPosition(startX + password.Length, startY);
                key = Console.ReadKey(intercept: true);

                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password.Length--;
                    Console.SetCursorPosition(startX + password.Length, startY);
                    Console.Write(' ');
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    password.Append(key.KeyChar);
                    Console.Write('*');
                }
            }
            Console.WriteLine();
            return password.ToString();
        }

        static void DrawBox()
        {
            int boxWidth = 40;
            int boxHeight = 10;
            int left = (Console.WindowWidth - boxWidth) / 2;
            int top = (Console.WindowHeight - boxHeight) - 1;

            Console.SetCursorPosition(left, top);
            Console.Write("+" + new string('-', boxWidth - 2) + "+");

            for (int i = 1; i < boxHeight - 1; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("|" + new string(' ', boxWidth - 2) + "|");
            }

            Console.SetCursorPosition(left, top + boxHeight - 1);
            Console.Write("+" + new string('-', boxWidth - 2) + "+");
        }
    }
}
