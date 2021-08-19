using System.Collections.Generic;

namespace AT_CRUD.Models
{
    public class AniversarianteViewModel
    {
        public IEnumerable<Models.Amigo> Aniversariantes { get; set; }

        public IEnumerable<Models.Amigo> ProximosAniversariantes { get; set; }
    }
}
