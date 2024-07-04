using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbNgonNgu
    {
        private int ngon_ngu_id;
        private string ngon_ngu_name;

        public tbNgonNgu(int ngon_ngu_id, string ngon_ngu_name)
        {
            this.ngon_ngu_id = ngon_ngu_id;
            this.ngon_ngu_name = ngon_ngu_name;
        }

        public int Ngon_ngu_id { get => ngon_ngu_id; set => ngon_ngu_id = value; }
        public string Ngon_ngu_name { get => ngon_ngu_name; set => ngon_ngu_name = value; }
    }
}
