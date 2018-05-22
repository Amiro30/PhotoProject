using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DataTransferObjects
{
   public class PhotoDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] PhotoFile { get; set; }
        public int TotalRate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
    }
}
