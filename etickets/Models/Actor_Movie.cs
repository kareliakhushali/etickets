using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace etickets.Models
{
    public class Actor_Movie
    {
        //we made a single class for actor and movie as 
        //actor can have multiple movies and movies can have multiple actors 
        //they have many to many relationships

        public int MovieId { get; set; }
        //using Movie from class movie same for actor
        public Movie Movie { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
                public List<Actor_Movie> Actor_Movies { get; set; }


    }
}
