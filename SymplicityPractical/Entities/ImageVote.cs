using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SymplicityPractical.Entities
{
    public class ImageVote
    {
        public int ID { get; set; }
        public string Session { get; set; }
        public int ImageIndex { get; set; }
        public bool VoteUp { get; set; }

    }
}