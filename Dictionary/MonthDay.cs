namespace Dictionary
{
	public class MonthDay
	{
		public int Month { get; private set; }
		public int Day { get; private set; }

		public MonthDay(int month, int day)
		{
			this.Month = month;
			this.Day = day;
		}

		// compare MonthDay objects
		public override bool Equals(object? obj)
		{
			var other = obj as MonthDay;
			if (other == null)
				throw new ArgumentException();
			return this.Day == other.Day && this.Month == other.Month;
		}

        // hash generator
        public override int GetHashCode()
        {
					return Month.GetHashCode() * 31 + Day.GetHashCode();
        }
    }
}