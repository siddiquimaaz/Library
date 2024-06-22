using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class SessionInfo
    {
        public static int CurrentStudentId { get; set; }
        public static string CurrentStudentEmail { get; set; }
        public static int CurrentAdminId { get; set; }
        public static string CurrentAdminEmail { get; set; }
    }
}
