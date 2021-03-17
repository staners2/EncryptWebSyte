using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EncryptWebSyte.DataBase
{
    public class Encrypt
    {
        [Key]
        public int Id { get; set; }
        public string InputText { get; set; }
        public string EncryptKey { get; set; }
        public string DescryptKey { get; set; }
        public string ResultText { get; set; }
        public DateTime DateTime { get; set; }

        public Encrypt(string InputText, string EncryptKey, string DescryptKey, string ResultText)
        {
            this.InputText = InputText;
            this.EncryptKey = EncryptKey;
            this.DescryptKey = DescryptKey;
            this.ResultText = ResultText;
            this.DateTime = DateTime.Now;
        }
    }
}
