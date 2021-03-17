using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptWebSyte.DataBase
{
    public class Descrypt
    {
        [Key]
        public int Id { get; set; }
        public string InputText { get; set; }
        public string DescryptKey { get; set; }
        public string EncryptKey { get; set; }
        public string ResultText { get; set; }
        public DateTime DateTime { get; set; }

        public Descrypt(string InputText, string DescryptKey, string EncryptKey, string ResultText)
        {
            this.InputText = InputText;
            this.DescryptKey = DescryptKey;
            this.EncryptKey = EncryptKey;
            this.ResultText = ResultText;
            this.DateTime = DateTime.Now;
        }
    }
}
