using SocialDictionary.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialDictionary.Domain.Models
{
    public class EntryVote : BaseEntity
    {
        public Guid EntryId { get; set; }
        public virtual Entry Entry { get; set; }
        public VoteType voteType { get; set; }
        public Guid CreatedById { get; set; }
        





    
    }
}
