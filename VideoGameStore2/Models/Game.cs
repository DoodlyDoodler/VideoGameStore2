using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameStore2.Models
{
    public class Game
    {
        public virtual int Id { get; set; } //primary key

        
        public virtual String Name { get; set; }
        public virtual String Description { get; set; }
        public virtual String MinimumRequirements { get; set; }
        public virtual Decimal Price { get; set; }

        public virtual int DeveloperId { get; set; } //foreign key
        public virtual Developer Dev { get; set; } //navigational property ?

        public virtual int GenreId { get; set; } //foreign key
        public virtual Genre GameGenre { get; set; }
    }
}
