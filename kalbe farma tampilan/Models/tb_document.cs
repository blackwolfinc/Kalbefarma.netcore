using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kalbe_farma_tampilan.Models
{
    public class tb_document
    {
        public int no_doc { get; set; }
        public string main_proccess { get; set; }
        public string core_proccess { get; set; }
        public string proccess { get; set; }
        public string lob { get; set; }

        public List <tb_document>ListDocuments{get; set;}
    }
}
