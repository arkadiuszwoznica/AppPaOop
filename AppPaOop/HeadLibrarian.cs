using System;
using AppPaOop.Items;

namespace AppPaOop
{
	public class HeadLibrarian
	{
        public List<Record> records = new List<Record>();

        public HeadLibrarian()
        {
        }

        public Record? GetRecord(ItemBase item)
        {
            foreach (Record record in this.records)
            {
                if (record.ItemId == item.Id)
                {
                    return record;
                }
            }
            return null;
        }     
    }
}