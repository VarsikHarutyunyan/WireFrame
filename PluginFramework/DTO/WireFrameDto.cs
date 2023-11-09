namespace PluginFramework.DTO
{
    public class WireFrameDto
    {
        public int IFromFile { get; set; }
        public string name { get; set; }
        public ImageSizeDto Size { get; set; }
        public double Radius { get; set; }
        public List<int> Effects { get; set; }
    }
}
