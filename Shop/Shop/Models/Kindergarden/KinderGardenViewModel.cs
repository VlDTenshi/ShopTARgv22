namespace Shop.Models.Kindergarden
{
    public class KinderGardenViewModel
    {
        public Guid? Id { get; set; }
        public string GroupName { get; set; }
        public int ChildrenCount { get; set; }
        public string KindergardenName { get; set; }

        public string Teacher { get; set; }
    }
}
