using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tbtheLoai
    {
        private int the_loai_id;
        private string the_loai_name;

        public tbtheLoai(int the_loai_id, string the_loai_name)
        {
            this.the_loai_id = the_loai_id;
            this.the_loai_name = the_loai_name;
        }

        public int The_loai_id { get => the_loai_id; set => the_loai_id = value; }
        public string The_loai_name { get => the_loai_name; set => the_loai_name = value; }
    }
}
