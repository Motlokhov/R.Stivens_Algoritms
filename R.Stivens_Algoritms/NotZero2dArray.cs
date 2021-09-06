using System;

namespace R.Stivens_Algoritms
{
    public class NotZero2dArray
    {
        private readonly TableMinBorders _borders;
        private readonly int[,] _data;

        public NotZero2dArray(TableMinBorders borders, TableRange range)
        {
            _borders = borders;
            _data = new int[range.YearRange, range.PersonIdRange];
        }

        public int this[int year, int person]
        {
            get => _data[year - _borders.MinYear, person - _borders.MinPersonId];
            set => _data[year - _borders.MinYear, person - _borders.MinPersonId] = value;
        }
    }

    public struct TableRange
    {
        public int YearRange { get; }
        public int PersonIdRange { get; }

        public TableRange(int yearRange, int personRange)
        {
            if(yearRange < 1 || personRange < 1)
                throw new ArgumentException("");

            YearRange = yearRange;
            PersonIdRange = personRange;
        }
    }

    public struct TableMinBorders
    {
        public int MinYear { get; }
        public int MinPersonId { get; }

        public TableMinBorders(int minYear, int minPersonId)
        {
            if(minYear < 0 || minPersonId < 0)
                throw new ArgumentException("");

            MinYear = minYear;
            MinPersonId = minPersonId;
        }
    }
}
