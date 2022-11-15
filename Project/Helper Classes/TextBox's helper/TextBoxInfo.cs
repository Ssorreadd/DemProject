namespace Project
{
    internal class TextBoxInfo
    {
        internal TextBoxInfo(string name, string defaultValue)
        {
            Name = name;
            DefaultValue = defaultValue;
        }

        internal string Name { get; private set; }
        internal string DefaultValue { get; private set; }
    }
}
