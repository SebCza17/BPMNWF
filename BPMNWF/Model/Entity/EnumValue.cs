namespace BPMNWF.Model.Entity
{
    public class EnumValue
    {
        public string Id;
        public string Name;

        public override string ToString()
        {
            return Name ?? "Unknown";   
        }
    }
}