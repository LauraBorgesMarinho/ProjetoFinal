using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1LAURA26.Code.DTO
{
    class DadosDto
    {
        private int _id;
        private string _lbm;
        private string _l5;
        private string _m3;

        public int Id { get => _id; set => _id = value; }
        public string Lbm { get => _lbm; set => _lbm = value; }
        public string L5 { get => _l5; set => _l5 = value; }
        public string M3 { get => _m3; set => _m3 = value; }
    }
}
