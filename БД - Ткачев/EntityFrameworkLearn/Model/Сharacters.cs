using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkLearn.Model
{
    public class Сharacters
    {
        public int ID { get; set; }
        public string Nickname { get; set; }
        public int Level { get; set; }


        [ForeignKey("id_player")]
        public int ID_player { get; set; }

    }
}
