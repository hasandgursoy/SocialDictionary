using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialDictionary.Domain.Models
{
    public class Entry : BaseEntity
    {
        // Virtual yapılar oluşturmamızın sebebi ilişkiler kurulurken 
        // Include ettiğimiz zaman hatalar alıcaz, virtual tanımlayınca
        // kullanmadığımız zamanlarda da hata almadan çalışabileceğiz.

        public string Subject { get; set; }
        public string Content { get; set; }
        public Guid CreatedById { get; set; } // Entry'i oluşturan kim
        public virtual User UserCreatedBy { get; set; }
        public virtual ICollection<EntryComment> EntryComments { get; set; }
        public virtual ICollection<EntryVote> EntryVotes { get; set; }
        public virtual ICollection<EntryFavorite> EntryFavorites { get; set; }



    }
}
