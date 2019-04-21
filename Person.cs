namespace CSharpSandbox {
    public struct Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Person {{ Name = {Name}, Age = {Age} }}";
        }
    }
}