/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Repository.Hierarchy;
using PaperlessRestAPI.logging;

namespace TourPlanner_4_SWENII.Utils.Validating
{
    public class ValidateUserInput
    {
        public static bool IfInputIsTooLong(string input)
        {
            var Logger = LoggerFactory.GetLogger();

            if (input.Length > 100)
            {
                Logger.Info_Notice(" Hey, User your Input is tooo long.");

                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool IsInputEmpty(string input)
        {

            var Logger = LoggerFactory.GetLogger();

            if (input.Trim().Length == 0)
            {
                Logger.Info_Notice(" Sorry, this is not a valid input. Please type something.");
                return true;
            }

            return false;

        }
    }
}*/
