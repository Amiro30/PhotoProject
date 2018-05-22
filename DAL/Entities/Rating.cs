using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int UserRate { get; set; }

        public int? UserId { get; set; }
        public virtual User User { get; set; }

        public int PhotoId { get; set; }
        public virtual Photo Photo { get; set; }
    }
}
