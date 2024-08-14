using Serilog;

namespace School.DTO
{
    public class Logging
    {
        public static void AddReqResLog(string reqrestype, string methodname, string content, string type)
        {
            string log = "<" + methodname + ">" + content;
            if (type == "info")
                Log.Logger.ForContext("Origin", "TMS-Microservice").ForContext("Type", reqrestype).Information(log);
            else if (type == "exc" || type == "error")
                Log.Logger.ForContext("Origin", "TMS-Microservice").ForContext("Type", reqrestype).Error(log);
        }

    }
}
