﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONVUNI_RESTFULL_DOTNET_CLICON.Controllers;
using Newtonsoft.Json.Linq;

namespace CONVUNI_RESTFULL_DOTNET_CLICON.Views
{
    public class ConvView
    {
        private ConvController _convController;

        public ConvView()
        {
            _convController = new ConvController();
        }

        public async Task Start() {
            int left = (Console.WindowWidth - 20) / 2;
            int top = (Console.WindowHeight) - 8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("    *#######################(       ########################   ############################  ###########################\r\n    *#  ,,,,,,,,,,,,,,,,,,, ,#.   .#, .,,,,,,,,,,,,,,,,,, .#   #  ,...................., /#  ##  ....................  #\r\n    *#  ####################  ## ##  #################### .#   #  ###################### /#  ## ,####################  #\r\n    *#  #####################(  #. /##################### .#   #  ###################### /#  ## ,####################  #\r\n    *#     (###################   ###################,    .#   #       ############      /#  ##     ,############      #\r\n    *####  ###########################################  ####   ######  ############  ######  ###### ,############  #####\r\n       #( *##############(.    .*,     (##############, ##         ##  ############  #*          ## ,############  #.   \r\n      /#  ##########.       &@@@@@@@@       .##########  #.        ##  ############  #*          ## ,############  #.   \r\n      #( *#######.          @@@@@@@@@.         *#######, ##        ##  ############  #*          ## .############  #.   \r\n     /#  ###########/       /@@@@@@@/       (###########  #        ##  ############  #*          ## ,############  #.   \r\n     ## *#################(.        .*##################* ##       ##  ############  #*          ## ,############  #.   \r\n######  ############## ################### ##############  #####   ##  ############  /############. ,############  #.   \r\n/#  .../#############,  ,###############.  ,#############/,,,  #   ##  ##############/............/##############  #.   \r\n/#  #################  #  ############/  #  #################  #    ##,  #####################################*  (#/    \r\n/#  ################( (##/  #########  ###/ (################  #       ##  ,################################  .##       \r\n*#                    ## (#          /#* /#                    #         /#(                                ##.         \r\n*######################.   ###########    ######################            ###############################(    ");
                Console.WriteLine(" ");
                DrawSmallBox();
                Console.SetCursorPosition(left - 4, top);
                Console.WriteLine("1. Convertir");
                Console.WriteLine(" ");
                Console.SetCursorPosition(left - 4, top + 2);
                Console.WriteLine("2. Salir");
                Console.WriteLine(" ");
                Console.SetCursorPosition(left - 4, top + 4);
                Console.Write("Seleccione una opción: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        await Convert();
                        break;
                    case "2":
                        return;
                    default:
                        Console.SetCursorPosition(5, 9);
                        Console.WriteLine("La opción ingresada no es válida");
                        await Task.Delay(2000);
                        break;
                }
            }
        }

        public async Task Convert()
        {
            double valueD = 0.0;
            string fromUnit = "", toUnit = "";

            Console.Clear();
            DrawBox();

            while (true)
            {
                Console.SetCursorPosition(6, 2);
                Console.WriteLine("Valor: ");
                Console.SetCursorPosition(6, 4);
                var value = Console.ReadLine();
                if (!double.TryParse(value, out valueD))
                {
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("El valor ingresado no es válido");
                    await Task.Delay(2000);
                    return;
                }
                else {
                    break;
                }
            }
            var units = new[] { "PA", "ATM", "BAR", "PSI", "mmHg" };
            while (true) {
                Console.SetCursorPosition(26, 2);
                Console.WriteLine("Seleccione la Unidad de Origen:");
                DisplayOptions(units, 4, 26);

                Console.SetCursorPosition(26, 10);
                var option1 = Console.ReadLine();
                if (int.TryParse(option1, out int fromIndex) && fromIndex >= 1 && fromIndex <= units.Length)
                {
                    fromUnit = units[fromIndex - 1];
                    break;
                }
                else
                {
                    Console.SetCursorPosition(26, 11);
                    Console.WriteLine("Opción no válida.");
                    await Task.Delay(2000);
                    return;
                }
            }
            

            while(true)
            {
                Console.SetCursorPosition(46, 2);
                Console.WriteLine("Seleccione la Unidad de Destino:");
                DisplayOptions(units, 4, 46);

                Console.SetCursorPosition(46, 10);
                var option2 = Console.ReadLine();
                if (int.TryParse(option2, out int toIndex) && toIndex >= 1 && toIndex <= units.Length)
                {
                    toUnit = units[toIndex - 1];
                    break;
                }
                else
                {
                    Console.SetCursorPosition(46, 11);
                    Console.WriteLine("Opción no válida.");
                    await Task.Delay(2000);
                    return;
                }
            }

            var result = await _convController.Convertir(new Models.ConversionRequest
            {
                Value = valueD,
                FromUnit = fromUnit,
                ToUnit = toUnit
            });

            Console.SetCursorPosition(10, 12);
            Console.WriteLine(result);
            Console.SetCursorPosition(10, 13);
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

        private void DisplayOptions(string[] options, int startRow, int startColumn)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.SetCursorPosition(startColumn, startRow + i);
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
        }

        static void DrawBox()
        {
            int boxWidth = Console.WindowWidth - 10;
            int boxHeight = Console.WindowHeight - 13;
            int left = 5;
            int top = 0;

            Console.SetCursorPosition(left, top);
            Console.Write("+" + new string('-', boxWidth - 2) + "+");

            for (int i = 1; i < boxHeight - 1; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("|" + new string(' ', boxWidth - 2) + "|");
            }

            Console.SetCursorPosition(left, top + boxHeight - 1);
            Console.Write("+" + new string('-', boxWidth - 2) + "+");

            Console.SetCursorPosition(left + 10, top + 1);
            Console.WriteLine("CONVERSOR DE UNIDADES - Grupo 5");

            Console.SetCursorPosition(left, top + boxHeight);
            Console.WriteLine(".  #%%%@   &@%%%%%%%%%%%%%@.   @%%&     @%%,,......%%/     /&%%%*(%%&   .         \r\n        .  %%..*%%%................%%%%..*%@   @%%%........%%%# %%%%........%%@  .        \r\n        .  @%...........(%%%%%...........%%,     *%(......%% @%%%........%%(.%%&  .       \r\n            @%.......*%%#     @%%.......#%*  .   *%(.......%%/..........(%/#@%%@  .       \r\n           #%%......%%@         @%.......%@  .   *%(..............%%&@@%%%                \r\n        .  @%.......%&          *%(......%%  .   *%(.............%%@     @*  ....         \r\n           @%,......%%          @%*......%@  .   *%(...............#%%%%%%/   .&          \r\n            %%.......%%%       @%#......#%&      *%(......%%&%#.........%%@%%%%&          \r\n         .  .%%........%%%%&%%%(.......#%@  ,    (%(......%%  @%%............%%           \r\n              @%%..................../%%,  .   @%%........./%@  (%%#........%%*  .        \r\n            .    @%%%%/........,#%%%%@       .   &%%%%%%%%%%#      /@%%%%%%@/             \r\n               .        *&@@@%.       .                       .   .          . ");
        }

        static void DrawSmallBox()
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

            Console.SetCursorPosition(left + 10, top + 1);
            Console.WriteLine("CONVERSOR DE UNIDADES");
        }
    }
}
