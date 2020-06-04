namespace Commander.Models
{
    public class Command 
    {
name
        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public string HowTo { get; set; }
        [BindProperty]
        public string Line { get; set; }
        [BindProperty]
        public string Platform { get; set; }
    }
}