using System.Collections.Generic;

namespace Decred2Mysql.Models
{
    public class ScriptPubKey
    {
        public string asm { get; set; }
        public string hex { get; set; }
        public int reqSigs { get; set; }
        public string type { get; set; }
        public List<string> addresses { get; set; }
        public double? commitamt { get; set; }
    }
}