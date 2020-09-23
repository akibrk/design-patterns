namespace Design_Patterns.Creational.Builder
{
    class Screen
    {
        public double ScreenSize { get; set; }
        public ScreenType ScreenPanel { get; set; }
        public enum ScreenType { HD, FullHD, FourK, FiveK, SixK, EightK };

        public Screen(double screenSize, ScreenType screenType)
        {
            ScreenSize = screenSize;
            ScreenPanel = screenType;
        }

        public void SetPanelType(ScreenType type)
        {
            ScreenPanel = type;
        }

        new public string ToString()
        {
            return $"Screen Size: {ScreenSize} - {ScreenPanel} ";
        }
    }
}
