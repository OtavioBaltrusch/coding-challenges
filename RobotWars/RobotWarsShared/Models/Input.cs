namespace RobotWarsShared.Models
{
    public class Input
    {
        public Input(IEnumerable<Enums.Action> actions)
        {
            Actions = actions.ToList();
        }

        public List<Enums.Action> Actions { get; set; }
    }
}
