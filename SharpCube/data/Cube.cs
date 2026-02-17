namespace SharpCube.data;

public class Cube{
        public List<List<string>> Back;
        public List<List<string>> Up;
        public List<List<string>> Front;
        public List<List<string>> Left;
        public List<List<string>> Right;
        public List<List<string>> Down;

        public Cube(
            List<List<string>> back, 
            List<List<string>> up,
            List<List<string>> front,
            List<List<string>> left,
            List<List<string>> right,
            List<List<string>> down
        )
        {
            this.Back = back;
            this.Up = up;
            this.Front = front;
            this.Left = left;
            this.Right = right;
            this.Down = down;
        }

}
