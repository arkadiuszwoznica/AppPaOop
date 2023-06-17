using System;
namespace AppPaOop.Items
{
	public class CD : ItemBase
    {
        public CD(string name, int numberOfTracks)
        {
            ObjectsCounter++;
            Id = ObjectsCounter;
            Name = name;
            Length = numberOfTracks;
        }
    }
}